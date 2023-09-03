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

        public string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Auto.mdf;Integrated Security=True;User Instance=True";

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
                    if (usernameAvail(txtUsernameSU.Text))
                    {
                        if (txtName.Text != "")
                        {
                            if (txtSurname.Text != "")
                            {
                                if (txtPasswordSU.Text != "")
                                {
                                    if (txtEmail.Text != "")
                                    {
                                        if (validEmail(txtEmail.Text))
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
                                                            signup();
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
                                            showError("The email address provided is not valid it should have the format example@provider.com");
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
                        showError("This username has already been taken, please choose another username");
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

        private bool validEmail(string email)
        {
            bool result = false;

            try
            {
                if (email.IndexOf("@") != -1)
                {
                    if (email.IndexOf(".com") != -1)
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            return result;
        }

        private bool usernameAvail(string username)
        {
            bool result = false;

            try
            {
                con.Open();

                string sql = $"SELECT Username FROM Clients WHERE Username = '{username}'";
                cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                int counter = 0;

                while (reader.Read())
                {
                    counter++;
                }

                if (counter == 0)
                {
                    result = true;
                }

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            return result;
        }

        private void signup()
        {
            try
            {
                string username, firstName, lastName, password, email, cellNumber, gender;
                int age;

                username = txtUsernameSU.Text;
                firstName = txtName.Text;
                lastName = txtSurname.Text;
                password = txtPasswordSU.Text;
                email = txtEmail.Text;
                cellNumber = txtCell.Text;
                gender = comboBox1.Text;
                age = (int)numericUpDown1.Value;

                con.Open();

                adapter = new SqlDataAdapter();

                string sql = $"INSERT INTO Clients(Name, Surname, Age, Gender, Phone_Number, Email, Username, Password) " +
                             $"VALUES('{firstName}', '{lastName}', {age}, '{gender}', '{cellNumber}', '{email}', '{username}', '{password}')";

                cmd = new SqlCommand(sql, con);

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                con.Close();

                MessageBox.Show($"User: {firstName} {lastName}\nUsername: {username}\nHas been successfully added to the system.");

                clearSignUp();
            }
            catch(Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void clearSignUp()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtUsernameSU.Clear();
            numericUpDown1.Value = 0;
            comboBox1.SelectedIndex = -1;
            txtPasswordSU.Clear();
            txtCell.Clear();
            txtEmail.Clear();

            lblLoginlbl_Click(new object(), new EventArgs());
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
                    sql = "SELECT AdminID, Username, Password FROM Admin";

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
                    sql = "SELECT ClientID, Username, Password, Email FROM Clients";

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
                                User.setEmail(reader.GetValue(3).ToString());

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
                    showError("This username has not been found or you have entered the wrong password");
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                showError(ex.Message);
            }
        }

        public void showError(string err)
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
