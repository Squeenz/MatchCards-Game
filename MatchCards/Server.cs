﻿using System;
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
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MatchCards_Server
{
    public partial class Server : LostForm
    {
        private SQLiteConnection conn;

        public Server()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=MatchCards.db;Version=3;");
        }

        private SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(serverIPText.Text + ":" + serverPortText.Text);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
        }

        void ClientConnected(object sender, SuperSimpleTcp.ConnectionEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}] client connected.... { Environment.NewLine}";
            userList.Items.Add(e.IpPort);
        }

        void ClientDisconnected(object sender, SuperSimpleTcp.ConnectionEventArgs e)
        {
            serverLogTextBox.Text += $"[{e.IpPort}] client disconnected: {e.Reason}{Environment.NewLine}";
            userList.Items.Remove(e.IpPort);
        }

        void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
            var cmdSyntax = data.Substring(0, 2);

            if (cmdSyntax == "!!")
            {
                serverLogTextBox.Text += $"[{e.IpPort}]: {data}{Environment.NewLine}";
            }
            else if (cmdSyntax == "--")
            {
                for (int i = 0; i < userList.Items.Count; i++)
                {
                    string port = userList.Items[i].ToString();
                    server.Send(port, $"[{e.IpPort}] {data.Substring(2)}");
                }
            }

            int userLength = int.Parse(data.Substring(4, 1));
            string username = data.Substring(7, userLength);
            string password = data.Substring(7 + userLength + 3);

            MessageBox.Show(cmdSyntax);

            if (cmdSyntax == "!C")
            {
                CreateNewUser(username, password);
            }
            else if (cmdSyntax == "!L")
            {
                CheckLoginInformation(e.IpPort, username, password);
            }
            else if (cmdSyntax == "!O") 
            {
                UpdateLoginStatus(e.IpPort, username, false);
                serverLogTextBox.Text += $"sent !O {username} {Environment.NewLine}";
            }
        }

        private void CreateNewUser(string username, string password)
        {
            conn.Open();
            string sql = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.ExecuteNonQuery();
            conn.Close();

            serverLogTextBox.Text += $"A new user {username} created{Environment.NewLine}";
        }

        private void UpdateLoginStatus(string ipPort, string username, bool status) 
        {
            if (status == true)
            {
                conn.Open();
                string sql = "UPDATE Users SET Online = 1 WHERE Username = @Username";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
                conn.Close();

                server.Send(ipPort, $"!O {username}");

                //for (int i = 0; i < userList.Items.Count; i++)
                //{
                //    string port = userList.Items[i].ToString();
                //    serverLogTextBox.Text += $"sent !O {username} {Environment.NewLine}";
                //    server.Send(ipPort, $"!O {username}");
                //}
            }
            else 
            {
                conn.Open();
                string sql = "UPDATE Users SET Online = 0 WHERE Username = @Username";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void CheckLoginInformation(string ipPort, string username, string password)
        {
            conn.Open();

            string sql = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            if (count > 0)
            {
                server.Send(ipPort, $"[{username.Count()}] : {username} : VALID");
            }
            else
            {
                server.Send(ipPort, $"[{username.Count()}] : {username} : INVALID");
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
