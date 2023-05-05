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

        SimpleTcpClient client;

        private void CrownLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            client.Disconnect();
            var register = new ClientRegister();
            register.Show();
            this.Hide();
        }

        private void ClientLogin_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1:8910");
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

        private void DataReceived(object sender, DataReceivedEventArgs e)
        {
            var data = Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count);

            if (data == "VALID")
            {
                var lobby = new Lobby();
                lobby.Show();
                this.Hide();
            }
            else if (data == "INVALID")
            {
                MessageBox.Show("Incorrect login information");
            }
        }

        private void startServerButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            client.Send($"!L [{username.Count()}] {username} : {password}");
        }
    }
}
