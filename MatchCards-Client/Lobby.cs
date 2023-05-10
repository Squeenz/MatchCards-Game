using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void Game_Load(object sender, EventArgs e)
        {
            clientChatBox.Text += $"Connected To Server... {Environment.NewLine}";
            usernameLabel.Text = User.Username;

            TcpClientSingleton.Client.Events.DataReceived += DataReceived;
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

            if (cmdSyntax == "!O")
            {
                GetOnlinePlayers(usernameList);
            }
            else if (cmdSyntax == "!F") 
            {
                GetOnlinePlayers(usernameList);
            }
            else
            {
                clientChatBox.Text += data;
            }
        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            if (TcpClientSingleton.Client.IsConnected) 
            {
                clientChatBox.Text += $"You are in the ranked queue, waiting for people {Environment.NewLine}";
                TcpClientSingleton.Client.Send($"-- {User.Username} is in the ranked queue");
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

        private void lostAcceptButton2_Click(object sender, EventArgs e)
        {
            var game = new Game();
            this.Hide();
            game.Show();

            //if (TcpClientSingleton.Client.IsConnected)
            //{
            //    clientChatBox.Text += $"You are in the unranked queue, waiting for people {Environment.NewLine}";
            //    clientChatBox.Text += $"No points will be gained from an unranked match {Environment.NewLine}";
            //    TcpClientSingleton.Client.Send($"-- {User.Username} is in the unranked queue");
            //}
            //else
            //{
            //    MessageBox.Show("No connection to server");
            //}
        }
    }
}
