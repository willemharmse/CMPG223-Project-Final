using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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

        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\harms\OneDrive\Desktop\New folder\CMPG223_Final\CMPG223_Final\CMPG223_Final\Data.mdf"";Integrated Security=True";

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
            try
            {
                // nested if to check if the user provided input for all the fields
                
                if (txtUsernameSU.Text != "")
                {
                    if (txtName.Text != "")
                    {
                        if (txtSurname.Text != "")
                        {
                            if (txtPasswordSU.Text != "")
                            {
                                if (txtEmail.Text != "")
                                {
                                    if (txtCell.Text != "")
                                    {
                                        string cell_number = txtCell.Text;

                                        if (cell_number.Length == 10)
                                        {
                                            if (int.TryParse(txtCell.Text, out int num))
                                            {
                                                if (comboBox1.Text != "")
                                                {
                                                    pnlLogin.Visible = true;
                                                    pnlSignUp.Visible = false;
                                                    this.Size = new Size(589, 626);
                                                }
                                                else
                                                {
                                                    showError("No Gender was provided");
                                                }
                                            }
                                            else
                                            {
                                                showError("The Cellphone Number must only contain digits");
                                            }
                                        }
                                        else
                                        {
                                            showError("Cellphone number must not be loner than 10 digits");
                                        }
                                    }
                                    else
                                    {
                                        showError("No Cellphone Number was provided");
                                    }
                                }
                                else
                                {
                                    showError("No Email Address was provided");
                                }
                            }
                            else
                            {
                                showError("No Password was provided");
                            }
                        }
                        else
                        {
                            showError("No Surname was provided");
                        }
                    }
                    else
                    {
                        showError("No Name was provided");
                    }
                }
                else
                {
                    showError("No Username was provided");
                }
            }
            catch (Exception exe)
            {
                showError(exe.Message);
            }
        }

        private void login(string name, string password)
        {
            try
            {
                con.Open();
                string sql = "";
                Boolean userFound = false;

                if (txtUsername.Text[0].ToString() == "_")
                {
                    sql = "SELECT admin_id, username, password FROM Admin";

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
                    sql = "SELECT * FROM [User]";

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
                    showError("This username has not been found or you have entered the wrong ");
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                showError(ex.Message);
            }
        }

        private void showError(string err)
        {
            MessageBox.Show("Error has occured:\n" + err);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                login(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                showError("Please ensure that you have entered a username and a password into the fields.");
            }   
        }
    }
}
