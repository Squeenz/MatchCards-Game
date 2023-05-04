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

        SimpleTcpClient client;

        private void Game_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1:8910");
            client.Events.Connected += Connected;
            client.Events.Disconnected += Disconnected;
            client.Events.DataReceived += DataReceived;

            try 
            {
                client.Connect();
            }
            catch
            {
                MessageBox.Show("No Connection to server");
            }
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
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(lobbyTextBox.Text.Substring(2)))
                {
                    client.Send(lobbyTextBox.Text);
                    lobbyTextBox.Text = string.Empty;
                }
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            clientChatBox.Text += $"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}{Environment.NewLine}";
        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            if (client.IsConnected) 
            {
                MessageBox.Show("You are in the queue, waiting for people");
                client.Send($"!!is in the queue");
            }
        }
    }
}
