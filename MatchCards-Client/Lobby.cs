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
                    TcpClientSingleton.Client.Send("--" + lobbyTextBox.Text);
                    lobbyTextBox.Text = string.Empty;
                }
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            clientChatBox.Text += $"Server: {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}{Environment.NewLine}";
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
    }
}
