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

namespace MatchCards_ClientLogin
{
    public partial class ClientRegister : LostForm
    {
        public ClientRegister()
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

        private void ClientRegister_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient("127.0.0.1:8910");

            try
            {
                client.Connect();
            }
            catch
            {
                MessageBox.Show("No Connection to server");
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

        private void lostAcceptButton1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (!string.IsNullOrEmpty(usernameBox.Text))
            {
                username = usernameBox.Text;
            }

            if (passwordOneBox.Text != passwordTwoBox.Text)
            {
                passwordLabel1.Visible = true;
            }
            else if (passwordTwoBox.Text != passwordOneBox.Text)
            {
                passwordLabel2.Visible = true;
            }
            else
            {
                password = passwordOneBox.Text;
            }

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                client.Send($"C [{username.Count()}] {username} : {password}");
                //client.Send($"!!L {username} : {password}");
                //client.Send($"!!U {username} ");
            }
        }
    }
}
