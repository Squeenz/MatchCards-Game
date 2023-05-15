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
        private List<string> UsernamesList { get; } = new List<string>();

        private void CrownLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void ClientRegister_Load(object sender, EventArgs e)
        {
            TcpClientSingleton.Client.Events.DataReceived += DataReceived;
        }


        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = $"{Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count).Substring(e.IpPort.Length + 5)}{Environment.NewLine}";
            string cmdSyntax = data.Substring(0, 2);

            switch (cmdSyntax)
            {
                case "UN":
                    string usernameList = data.Substring(2);

                    // Split the username list by comma, trim each username, and convert to array
                    string[] usernames = usernameList.Split(',').Select(u => u.Trim()).ToArray();

                    // Clear the existing usernames in the list and add the new ones
                    UsernamesList.Clear();
                    UsernamesList.AddRange(usernames);

                    break;
            }
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

        private bool LoopThroughAllNames(List<string> names, string currentName)
        {
            bool state = false;

            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == currentName)
                {
                    state = true;
                    break; // Exit the loop if a match is found
                }
            }

            return state;
        }

        private async void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            TcpClientSingleton.Client.Send("DN");
            await Task.Delay(100);
            bool usernameValid = LoopThroughAllNames(UsernamesList, usernameBox.Text);


            //Add a check to see if the username already exists in the database
            if (!string.IsNullOrEmpty(usernameBox.Text) && usernameValid == false)
            {
                username = usernameBox.Text;

                MessageBox.Show(LoopThroughAllNames(UsernamesList, usernameBox.Text).ToString());
            }
            else 
            {
                userErrorLabel.Visible = true;
            }

            if (passwordOneBox.Text != passwordTwoBox.Text || passwordTwoBox.Text != passwordOneBox.Text)
            {
                passwordLabel1.Visible = true;
            }
            else
            {
                password = passwordOneBox.Text;
            }

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && usernameValid == false)
            {
                if (TcpClientSingleton.Client.IsConnected)
                {
                    byte[] passwordHash = CalculateSHA256(password);
                    string hashedPassword = BitConverter.ToString(passwordHash).Replace("-", "").ToLower();

                    TcpClientSingleton.Client.Send($"!C [{username.Length}] {username} : {hashedPassword}");

                    LoginChange();
                }
                else
                {
                    MessageBox.Show("No connection to server");
                }
            }
        }

        private void LoginChange()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoginChange));
                return;
            }
            var login = new ClientLogin();
            login.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
