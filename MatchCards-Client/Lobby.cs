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
            TcpClientSingleton.Client.Events.Connected += Connected;
            TcpClientSingleton.Client.Events.Disconnected += Disconnected;
            TcpClientSingleton.Client.Events.DataReceived += DataReceived;
        }

        private void Connected(object sender, ConnectionEventArgs e)
        {
            clientChatBox.Text += $"Server: {e.IpPort} connected {Environment.NewLine}";
        }

        private void Disconnected(object sender, ConnectionEventArgs e)
        {
            clientChatBox.Text += $"Server: {e.IpPort} disconnected {Environment.NewLine}";
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
            string username = data.Substring(3);

            if (cmdSyntax == "!0")
            {
                onlineUserList.Items.Add(username);
                lobbyTextBox.Text += $"Syntax: {cmdSyntax}{Environment.NewLine}";
                lobbyTextBox.Text += $"Username: {username}{Environment.NewLine}";
            }
            else if (cmdSyntax == "!F")
            {
                onlineUserList.Items.Remove(username);
            }

            clientChatBox.Text += data;
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
