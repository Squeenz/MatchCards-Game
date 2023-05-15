using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using SuperSimpleTcp;

namespace MatchCards_Client
{
    public partial class Lobby : LostForm
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private async void Game_Load(object sender, EventArgs e)
        {
            clientChatBox.Text += $"Connected To Server... {Environment.NewLine}";
            TcpClientSingleton.Client.Events.DataReceived += DataReceived;

            usernameLabel.Text = User.Username;

            await Task.Delay(500);

            TcpClientSingleton.Client.Send($"GP {User.Username}");

            await Task.Delay(500);

            TcpClientSingleton.Client.Send("RO");
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            if (TcpClientSingleton.Client.IsConnected)
            {
                if (!string.IsNullOrEmpty(lobbyTextBox.Text))
                {
                    TcpClientSingleton.Client.Send($"-- [{User.Username}]: " + lobbyTextBox.Text);
                    lobbyTextBox.Text = string.Empty;
                }
            }
        }

        private void GetOnlinePlayers(string usernameList)
        {
            if (onlineUserList.Items.Count >= 1)
            {
                onlineUserList.Items.Clear();
            }

            string[] OnlinePlayerNames = usernameList.Split(',');
            List<string> OnlinePlayers = new List<string>(OnlinePlayerNames);

            for (int i = 0; i < OnlinePlayers.Count(); i++)
            {
                onlineUserList.Items.Add(OnlinePlayers.ElementAt(i).Trim());
            }
        }


        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = $"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count).Substring(e.IpPort.Length + 5)}{Environment.NewLine}";
            string cmdSyntax = data.Substring(0, 2);
            string usernameList = data.Substring(3);

            switch (cmdSyntax) 
            {
                case "SP":
                    User.Points = data.Substring(2);
                    pointsLabel.Text = User.Points;
                    break;

                case "!O":
                case "!R":
                case "!F":
                    GetOnlinePlayers(usernameList);
                    break;

                case "UG":
                    User.TypeOfGame = "Unranked";
                    SetOpponentData(data);
                    GameChange();
                    break;

                case "RG":
                    User.TypeOfGame = "Ranked";
                    SetOpponentData(data);
                    GameChange();
                    break;

                default:
                    clientChatBox.Text += data;
                    break;
            }
        }

        private void SetOpponentData(string data)
        {
            int userLength = int.Parse(data.Substring(4, 1));
            string username = data.Substring(8, userLength);
            string ipPort = data.Substring(8 + userLength + 1);

            User.OpponentIpPort = ipPort;
            User.OpponentUserName = username;
        }

        private void GameChange()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(GameChange));
                return;
            }

            var game = new Game();
            game.Show();
            this.Hide();
        }


        private async void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            lostAcceptButton1.Text = "ALREADY IN THE QUEUE";
            lostAcceptButton1.Enabled = false;
            lostAcceptButton2.Enabled = false;

            if (TcpClientSingleton.Client.IsConnected)
            {
                TcpClientSingleton.Client.Send($"RQ {User.Username}");
                clientChatBox.Text += $"You are in the ranked queue, waiting for people {Environment.NewLine}";
                clientChatBox.Text += $"+50 Poins for a win {Environment.NewLine}";
                clientChatBox.Text += $"-50 Poins for a loss {Environment.NewLine}";
                await Task.Delay(1000);
                TcpClientSingleton.Client.Send($"-- {User.Username} is in the Ranked queue");
            }
            else
            {
                MessageBox.Show("No connection to server");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            try
            {
                TcpClientSingleton.Client.Send($"UF {User.Username}");
                await Task.Delay(1000);
                TcpClientSingleton.Client.Send($"-- {User.Username} has logged out!");
            }
            finally
            {
                TcpClientSingleton.Client.Disconnect();
            }

            await Task.Delay(1000);
            Application.Exit();
        }

        private async void lostAcceptButton2_Click(object sender, EventArgs e)
        {
            lostAcceptButton1.Enabled = false;
            lostAcceptButton2.Text = "ALREADY IN THE QUEUE";
            lostAcceptButton2.Enabled = false;

            if (TcpClientSingleton.Client.IsConnected)
            {
                TcpClientSingleton.Client.Send($"UQ {User.Username}");
                clientChatBox.Text += $"You are in the unranked queue, waiting for people {Environment.NewLine}";
                clientChatBox.Text += $"No points will be gained from an unranked match {Environment.NewLine}";
                await Task.Delay(1000);
                TcpClientSingleton.Client.Send($"-- {User.Username} is in the unranked queue");
            }
            else
            {
                MessageBox.Show("No connection to server");
            }
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
