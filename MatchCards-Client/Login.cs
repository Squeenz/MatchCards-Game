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
            var username = data.Substring(6, userLenght);
            var isValid = data.Substring(6 + userLenght + 3);

            if (isValid == "VALID")
            {
                LobbyChange();
                User.Username = username;
            }
            else if (isValid == "INVALID")
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

            var lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }


        private void startServerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            TcpClientSingleton.Client.Send($"!L [{username.Count()}] {username} : {password}");
        }
    }
}
