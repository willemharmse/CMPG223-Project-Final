using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Final
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblSingUpLink_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
            pnlSignUp.Visible = true;
            this.Size = new Size(589, 880);
        }

        private void lblLoginlbl_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlSignUp.Visible = false;
            this.Size = new Size(589, 626);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Size = new Size(589, 626);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlSignUp.Visible = false;
            this.Size = new Size(589, 626);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmDashboard d = new frmDashboard();
            d.Show();
            this.Hide();
        }
    }
}
