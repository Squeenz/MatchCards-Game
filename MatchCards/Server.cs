using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ReaLTaiizor.Forms;
using SuperSimpleTcp;

namespace MatchCards_Server
{
    public partial class Server : LostForm
    {
        public Server()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(serverIPText.Text + ":" + serverPortText.Text);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
        }

        void ClientConnected(object sender, ConnectionEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}] client connected.... { Environment.NewLine}";
            userList.Items.Add(e.IpPort);
        }

        void ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}] client disconnected: {e.Reason}{Environment.NewLine}";
            userList.Items.Remove(e.IpPort);
        }

        void DataReceived(object sender, DataReceivedEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}]: {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}{Environment.NewLine}";

            for (int i = 0; i < userList.Items.Count; i++)
            {
                string port = userList.Items[i].ToString();
                server.Send(port, $"[{e.IpPort}]: {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}");
            }
        }

        private void ServerLabel_Click(object sender, EventArgs e)
        {

        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            server.Start();
            serverLogTextBox.Text += $"Starting.... {Environment.NewLine}";
            startServerButton.Enabled = false;
            stopServerButton.Enabled = true;
        }

        private void serverLogTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stopServerButton_Click(object sender, EventArgs e)
        {
            server.Stop();
            stopServerButton.Enabled = false;
            serverLogTextBox.Text += $"Stopping....{Environment.NewLine}";
        }

        private void userList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if (!string.IsNullOrEmpty(serverChatBox.Text) && userList.SelectedItem != null) 
                {
                    server.Send(userList.SelectedItem.ToString(), serverChatBox.Text);
                    serverLogTextBox.Text += $"Server: {serverChatBox.Text}{Environment.NewLine}";
                    serverChatBox.Text = string.Empty;
                }
            }
        }

        private void serverChatBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
