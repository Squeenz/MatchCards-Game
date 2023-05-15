using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            var login = new ClientLogin();
            login.Show();
            this.Hide();
        }

        private byte[] CalculateSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] hashValue;
            UTF8Encoding objUtf8 = new UTF8Encoding();
            hashValue = sha256.ComputeHash(objUtf8.GetBytes(str));

            return hashValue;
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
            else
            {
                password = passwordOneBox.Text;
            }

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                if (TcpClientSingleton.Client.IsConnected)
                {
                    byte[] passwordHash = CalculateSHA256(password);
                    string hashedPassword = BitConverter.ToString(passwordHash).Replace("-", "").ToLower();

                    TcpClientSingleton.Client.Send($"!C [{username.Length}] {username} : {hashedPassword}");
                }
                else
                {
                    MessageBox.Show("No connection to server");
                }
            }

            var login = new ClientLogin();
            login.Show();
            this.Hide();
        }
    }
}
