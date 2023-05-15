using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MatchCards_Client;
using ReaLTaiizor.Forms;
using SuperSimpleTcp;

namespace MatchCards_ClientLogin
{
    public partial class ClientLogin : LostForm
    {
        public ClientLogin()
        {
            InitializeComponent();
        }

        private void CrownLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            var register = new ClientRegister();
            register.Show();
            this.Hide();
        }

        private void ClientLogin_Load(object sender, EventArgs e)
        {
            if (TcpClientSingleton.Client == null)
            {
                TcpClientSingleton.Client = new SimpleTcpClient("127.0.0.1:8910");
                TcpClientSingleton.Client.Events.DataReceived += DataReceived;

                try
                {
                    TcpClientSingleton.Client.Connect();
                }
                catch
                {
                    MessageBox.Show("No Connection to server");
                }
            }
            else if (!TcpClientSingleton.Client.IsConnected)
            {
                try
                {
                    TcpClientSingleton.Client.Connect();
                }
                catch
                {
                    MessageBox.Show("No Connection to server");
                }
            }
        }

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);
            int userLenght = int.Parse(data.Substring(1, 1));   
            string username = data.Substring(6, userLenght);
            string isValid = data.Substring(6 + userLenght + 3, 5);
            string isOnline = data.Substring(6 + userLenght + 10).Trim();

            if (isValid == "VALID" && isOnline == "0")
            {
                User.Username = username;
                LobbyChange();
            }
            else if (isValid == "VALID" && isOnline == "1")
            {
                MessageBox.Show("User already online");
            }
            else
            {
                MessageBox.Show("Incorrect login information");
            }
        }

        private void LobbyChange()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LobbyChange));
                return;
            }

            TcpClientSingleton.Client.Events.DataReceived -= DataReceived;
            var lobby = new Lobby();
            lobby.Show();
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

        private void startServerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            byte[] passwordHash = CalculateSHA256(password);
            string hashedPassword = BitConverter.ToString(passwordHash).Replace("-", "").ToLower();

            TcpClientSingleton.Client.Send($"!L [{username.Count()}] {username} : {hashedPassword}");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
