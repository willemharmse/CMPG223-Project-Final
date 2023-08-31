﻿using System;
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

        public string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\harms\OneDrive\Desktop\CMPG223\CMPG223_Final\CMPG223_Final\CMPG223_Final\Data.mdf;Integrated Security=True";

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
                                                MessageBox.Show("Please provide a Gender !", "Gender Error", MessageBoxButtons.OK);
                                            }
                                        }
                                        else
                                        {
                                            //err message
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please provide a Cellphone Number !", "Cellphone Number Error", MessageBoxButtons.OK);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please provide an Email Address !", "Email Address Error", MessageBoxButtons.OK);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please provide a Surname !", "Surname Error", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please provide a Surname !", "Surname Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide a Name !", "Name Error", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a Username !", "Username Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("The following errors occured : " + exe.Message);
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
                    MessageBox.Show("This username has not been found or you have entered the wrong ");
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("The following error has occured: \n" + ex.Message);
            }
        }

        private string showError(string err)
        {
            return "Error has occured:\n" + err;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                login(txtUsername.Text, txtPassword.Text);
            }
            else
            {
                MessageBox.Show("Please ensure that you have entered a username and a password into the fields.");
            }   
        }
    }
}
