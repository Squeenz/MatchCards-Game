﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatchCards_Client;
using ReaLTaiizor.Forms;
using SuperSimpleTcp;

namespace MatchCards_ClientLogin
{
    public partial class ClientRegister : LostForm
    {
        public ClientRegister()
        {
            InitializeComponent();
        }

        private void CrownLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void ClientRegister_Load(object sender, EventArgs e)
        {
        
        }

        private void tableLayoutPanel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void closeThisAndGoBack()
        {
            var login = new ClientLogin();
            login.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            closeThisAndGoBack();
        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            //Add a check to see if the username already exists in the database
            if (!string.IsNullOrEmpty(usernameBox.Text))
            {
                username = usernameBox.Text;
            }

            if (passwordOneBox.Text != passwordTwoBox.Text || passwordTwoBox.Text != passwordOneBox.Text)
            {
                passwordLabel1.Visible = true;
            }
            //Need to encrypt the password
            else
            {
                password = passwordOneBox.Text;
            }

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {

                if (TcpClientSingleton.Client.IsConnected)
                {
                    TcpClientSingleton.Client.Send($"!C [{username.Count()}] {username} : {password}");
                }
                else
                {
                    MessageBox.Show("No connection to server");
                }
               
                //client.Send($"!!L {username} : {password}");
            }

            closeThisAndGoBack();
        }
    }
}
