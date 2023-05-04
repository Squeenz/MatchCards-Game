using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReaLTaiizor.Forms;

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
    }
}
