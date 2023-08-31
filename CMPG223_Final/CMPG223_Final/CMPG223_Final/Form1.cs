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
            connectDB();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlSignUp.Visible = false;
            this.Size = new Size(589, 626);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                string sql = "";
                Boolean userFound = false;

                if (txtUsername.Text[0].ToString() == "_")
                {
                    sql = "SELECT id, username, password FROM Admin";

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read() && userFound != true)
                    {
                        if (reader.GetValue(1).ToString() == txtUsername.Text)
                        {
                            if (reader.GetValue(2).ToString() == txtPassword.Text)
                            {
                                User.setUsername(reader.GetValue(1).ToString());
                                User.setPassword(reader.GetValue(2).ToString());
                                User.setID((int)reader.GetValue(0));
                                User.setAdmin(true);

                                userFound = true;
                            }
                        }
                    }
                }
                else
                {
                    sql = "SELECT id, username, password FROM User";

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read() && userFound != true)
                    {
                        if (reader.GetValue(1).ToString() == txtUsername.Text)
                        {
                            if (reader.GetValue(2).ToString() == txtPassword.Text)
                            {
                                User.setUsername(reader.GetValue(1).ToString());
                                User.setPassword(reader.GetValue(2).ToString());
                                User.setID((int)reader.GetValue(0));
                                User.setAdmin(false);

                                userFound = true;
                            }
                        }
                    }
                }

                if (userFound)
                {
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("This username has not been found or you have entered the wrong ");
                }
            }
            else
            {
                MessageBox.Show("Please ensure that you have entered a username and a password into the fields.");
            }
        }
    }
}
