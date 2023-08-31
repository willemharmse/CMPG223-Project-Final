using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Final
{
    public partial class frmLogin : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harms\OneDrive\Desktop\CMPG223\CMPG223_Final\CMPG223_Final\CMPG223_Final\projData.mdf;Integrated Security=True";

        public frmLogin()
        {
            InitializeComponent();
        }

        public void connectDB()
        {
            con = new SqlConnection(conString);
            con.Open();
            con.Close();
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
            
        }
    }
}
