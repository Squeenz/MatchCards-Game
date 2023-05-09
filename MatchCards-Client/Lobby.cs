using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = $"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count).Substring(e.IpPort.Length + 5)}{Environment.NewLine}";
            string cmdSyntax = data.Substring(0, 2);
            string usernameList = data.Substring(3);

            if (cmdSyntax == "!O")
            {
                if (onlineUserList.Items.Count > 1) 
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
            else if (cmdSyntax == "!F") 
            {
                //onlineUserList.Items.Remove(username);
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
                MessageBox.Show("You are in the queue, waiting for people");
                TcpClientSingleton.Client.Send($"!!is in the queue");
            }
            else 
            {
                MessageBox.Show("No connection to server");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
