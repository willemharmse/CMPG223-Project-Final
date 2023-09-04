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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace CMPG223_Final
{
    public partial class Insert : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlCommand cmd;

        public string table;

        public Insert()
        {
            InitializeComponent();
        }

        public void connectDB(string conString)
        {
            con = new SqlConnection(conString);
            con.Open();
            con.Close();
        }

        public void showError(string err)
        {
            MessageBox.Show("Error has occured:\n" + err);
        }

        private bool validateService(string newItem)
        {
            bool result = false;
            int counter = 0;

            try
            {
                con.Open();

                string sql = $"SELECT Service FROM Service WHERE Service = '{newItem}'";
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    counter++;
                }

                con.Close();

                if (counter != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            return result;
        }

        private bool validateValues(string newItem, string table)
        {
            bool result = false;
            int counter = 0;

            try
            {
                con.Open();

                string sql = $"SELECT {table} FROM Car{table} WHERE {table} = '{newItem}'";
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    counter++;
                }

                con.Close();

                if (counter != 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            return result;
        }

        private void pnlAddVehicle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceName = txtServiceName.Text;
                decimal servicePrice = nudPriceService.Value;

                if (txtServiceName.Text != "")
                {
                    if (!validateService(serviceName))
                    {
                        if (servicePrice != 0)
                        {
                            con.Open();

                            String sql = $"INSERT INTO Service(Service, Cost) VALUES('{serviceName}',{servicePrice}) ";
                            cmd = new SqlCommand(sql, con);
                            adapter = new SqlDataAdapter();
                            adapter.InsertCommand = cmd;
                            adapter.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("The record has been added to the database table");

                            con.Close();

                            this.Close();
                        } else {
                            showError("Please enter a valid price for the service");
                        }
                    } else {
                        showError("Service Type already exists");
                    }
                } else {
                    showError("Please type a name for the service");
                }
            } catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnAddMake_Click(object sender, EventArgs e)
        {
            try {
                String carMake = txtAddMake.Text;
                if (txtAddMake.Text != "")
                {
                    if (!validateValues(carMake, "Make"))
                    {
                        con.Open();

                        String sql = $"INSERT INTO CarMake(Make) VALUES('{carMake}') ";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been added to the database table");

                        con.Close();

                        this.Close();
                    } else {
                        showError("Car Make already in table");
                    }
                } else {
                    showError("Please type a name for the Car Make");
                }
            } catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            try {
                String carModel = txtAddModel.Text;
                if (txtAddModel.Text != "")
                {
                    if (!validateValues(carModel, "Model"))
                    {
                        con.Open();

                        String sql = $"INSERT INTO CarModel(Model) VALUES('{carModel}') ";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been added to the database table");

                        con.Close();

                        this.Close();
                    } else {
                        showError("Car Model already in table");
                    }
                } else {
                    showError("Please type a name for the Car Model");
                }
            } catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnAddColour_Click(object sender, EventArgs e)
        {
            try
            {
                String carColour = txtAddColour.Text;
                if (txtAddColour.Text != "")
                {
                    if (!validateValues(carColour, "Colour"))
                    {
                        con.Open();

                        String sql = $"INSERT INTO CarColour(Colour) VALUES('{carColour}') ";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been added to the database table");

                        con.Close();

                        this.Close();
                    }
                    else
                    {
                        showError("Car Colour already in table");
                    }
                }
                else
                {
                    showError("Please type a name for the Car Colour");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
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

        private bool usernameAvail(string username, string user)
        {
            bool result = false;

            try
            {
                con.Open();

                string sql = $"SELECT Username FROM {user} WHERE Username = '{username}'";
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

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (txtUsernameAdmin.Text != "")
            {
                if (txtUsernameAdmin.Text[0].ToString() == "_")
                {
                    if (usernameAvail(txtUsernameAdmin.Text, "Admin"))
                    {
                        if (txtNameAdmin.Text != "")
                        {
                            if (txtSurnameAdmin.Text != "")
                            {
                                if (txtPasswordAdmin.Text != "")
                                {
                                    if (txtEmailAdmin.Text != "")
                                    {
                                        if (validEmail(txtEmailAdmin.Text))
                                        {

                                            if (txtCellAdmin.Text != "")
                                            {
                                                string cell_number = txtCellAdmin.Text;

                                                if (cell_number.Length == 10)
                                                {
                                                    if (int.TryParse(txtCellAdmin.Text, out int num))
                                                    {
                                                        if (cbxGenderAdmin.Text != "")
                                                        {
                                                            if (nudAgeAdmin.Value >= 18)
                                                            {
                                                                addAdmin();
                                                            }
                                                            else
                                                            {
                                                                showError("Age should be at least 18");
                                                            }
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
                    showError("The username for an admin user should start with a _");
                }
            }
            else
            {
                showError("No Username was provided");
            }
        }

        private void addAdmin()
        {
            try
            {
                con.Open();

                string sql = $"INSERT INTO Admin(Name, Surname, Age, Gender, Phone_Number, Email, Username, Password) " +
                             $"VALUES('{txtNameAdmin.Text}', '{txtSurnameAdmin.Text}', " +
                             $"{(int)nudAgeAdmin.Value}, '{cbxGenderAdmin.Text}', '{txtCellAdmin.Text}'," +
                             $" '{txtEmailAdmin.Text}', '{txtUsernameAdmin.Text}', '{txtPasswordAdmin.Text}')";
                
                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("The record has been added to the database table.");

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            { 
                showError(ex.Message); 
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (txtAddUsernameClient.Text != "")
            {
                if (usernameAvail(txtAddUsernameClient.Text, "Clients"))
                {
                    if (txtNameClient.Text != "")
                    {
                        if (txtSurnameClient.Text != "")
                        {
                            if (txtPasswordClient.Text != "")
                            {
                                if (txtEmailClient.Text != "")
                                {
                                    if (validEmail(txtEmailClient.Text))
                                    {
                                        if (txtNumberClient.Text != "")
                                        {
                                            string cell_number = txtNumberClient.Text;

                                            if (cell_number.Length == 10)
                                            {
                                                if (int.TryParse(txtNumberClient.Text, out int num))
                                                {
                                                    if (cmbGenderClient.Text != "")
                                                    {
                                                        if (nudAgeClient.Value >= 18)
                                                        {
                                                            addClient();
                                                        }
                                                        else
                                                        {
                                                            showError("Age should be at least 18");
                                                        }
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

        private void addClient()
        {
            try
            {
                con.Open();

                string sql = $"INSERT INTO Client(Name, Surname, Age, Gender, Phone_Number, Email, Username, Password) " +
                             $"VALUES('{txtNameClient.Text}', '{txtSurnameClient.Text}', " +
                             $"{(int)nudAgeClient.Value}, '{cmbGenderClient.Text}', '{txtNumberClient.Text}'," +
                             $" '{txtEmailClient.Text}', '{txtAddUsernameClient.Text}', '{txtPasswordClient.Text}')";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("The record has been added to the database table.");

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {
            if (txtNameMech.Text != "")
            {
                if (txtSurnameMech.Text != "")
                {
                    if (txtEmailMech.Text != "")
                    {
                        if (validEmail(txtEmailMech.Text))
                        {
                            if (txtNumberMech.Text != "")
                            {
                                string cell_number = txtNumberMech.Text;

                                if (cell_number.Length == 10)
                                {
                                    if (int.TryParse(txtNumberMech.Text, out int num))
                                    {
                                        if (cmbGenderMech.Text != "")
                                        {
                                            if (nudAgeMech.Value >= 18)
                                            {
                                                if (nudSallaryMech.Value > 0)
                                                {
                                                    addMech();
                                                }
                                                else
                                                {
                                                    showError("The salary cannot be R0");
                                                }
                                            }
                                            else
                                            {
                                                showError("Age should be at least 18");
                                            }
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
                    showError("No Surname was provided");
                }
            }
            else
            {
                showError("No Name was provided");
            }
        }

        private void addMech()
        {
            try
            {
                con.Open();

                string sql = $"INSERT INTO Mechanic(Name, Surname, Age, Gender, Phone_Number, Email, Salary) " +
                             $"VALUES('{txtNameMech.Text}', '{txtSurnameMech.Text}', " +
                             $"{(int)nudAgeMech.Value}, '{cmbGenderMech.Text}', '{txtNumberMech.Text}'," +
                             $" '{txtEmailMech.Text}', {nudSallaryMech.Value})";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("The record has been added to the database table.");

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            connectDB(login.conString);

            pnlAddAdmin.Hide();
            pnlAddClient.Visible = false;
            pnlAddColour.Hide();
            pnlAddMake.Hide();
            pnlAddMechanic.Hide();
            pnlAddModel.Hide();
            pnlAddService.Hide();
            pnlAddVehicle.Hide();

            showPanel(table);

            fillColours();
            fillModels();
            fillClients();
            fillMakes();
        }

        private void showPanel(string table)
        {
            switch (table)
            {
                case "Clients":
                    pnlAddClient.Visible = true;
                    break;

                case "Admin":
                    pnlAddAdmin.Show();
                    break;

                case "Vehicle":
                    pnlAddVehicle.Show();
                    break;

                case "CarModel":
                    pnlAddModel.Show();
                    break;

                case "CarMake":
                    pnlAddMake.Show();
                    break;

                case "CarColour":
                    pnlAddColour.Show();
                    break;

                case "Mechanic":
                    pnlAddMechanic.Show();
                    break;

                case "Service":
                    pnlAddService.Show();
                    break;

                default:
                    break;
            }
        }

        private void fillColours()
        {
            try
            {
                con.Open();

                DataSet ds = new DataSet();

                string sql = $"SELECT Colour FROM CarColour";
                cmd = new SqlCommand(sql, con);

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ColourCar");

                cmbColour.DataSource = ds.Tables[0];
                cmbColour.DisplayMember = "Colour";
                cmbColour.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillClients()
        {
            try
            {
                con.Open();

                DataSet ds = new DataSet();

                string sql = $"SELECT ClientID FROM Clients";
                cmd = new SqlCommand(sql, con);

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Clients");

                cmbClientIDVehicle.DataSource = ds.Tables[0];
                cmbClientIDVehicle.DisplayMember = "ClientID";
                cmbClientIDVehicle.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillModels()
        {
            try
            {
                con.Open();

                DataSet ds = new DataSet();

                string sql = $"SELECT Model FROM CarModel";
                cmd = new SqlCommand(sql, con);

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ModelCar");

                cmbModelVehicle.DataSource = ds.Tables[0];
                cmbModelVehicle.DisplayMember = "Model";
                cmbModelVehicle.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillMakes()
        {
            try
            {
                con.Open();

                DataSet ds = new DataSet();

                string sql = $"SELECT Make FROM CarMake";
                cmd = new SqlCommand(sql, con);

                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "MakeCar");

                cmbMakeVehicle.DataSource = ds.Tables[0];
                cmbMakeVehicle.DisplayMember = "Make";
                cmbMakeVehicle.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientIDVehicle.Text != "")
                {
                    if (cmbColour.Text != "")
                    {
                        if (cmbModelVehicle.Text != "")
                        {
                            if (cmbMakeVehicle.Text != "")
                            {
                                String sql = $"INSERT INTO Vehicle(ClientID, ColourID, ModelID, MakeID) VALUES({cmbClientIDVehicle.Text}, " +
                                             $"{getColourID(cmbColour.Text)}, {getModelID(cmbModelVehicle.Text)}, {getMakeID(cmbMakeVehicle.Text)}) ";

                                con.Open();

                                cmd = new SqlCommand(sql, con);
                                adapter = new SqlDataAdapter();
                                adapter.InsertCommand = cmd;
                                adapter.InsertCommand.ExecuteNonQuery();

                                MessageBox.Show("The record has been added to the database table.");

                                con.Close();

                                this.Close();
                            }
                            else
                            {
                                showError("Please select a make for the vehicle");
                            }
                        }
                        else
                        {
                            showError("Please select a model for the vehicle");
                        }
                    }
                    else
                    {
                        showError("Please select a colour for the vehicle");
                    }
                }
                else
                {
                    showError("Please select a valid ID for the user");
                }
            }   
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private int getColourID(string colour)
        {
            int id = 0;

            try
            {
                con.Open();
                string sql = $"SELECT ColourID FROM CarColour WHERE Colour = '{colour}'";

                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        private int getModelID(string model)
        {
            int id = 0;

            try
            {
                con.Open();
                string sql = $"SELECT ModelID FROM CarModel WHERE Model = '{model}'";

                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        private int getMakeID(string make)
        {
            int id = 0;

            try
            {
                con.Open();
                string sql = $"SELECT MakeID FROM CarMake WHERE Make = '{make}'";

                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
        }
    }
}
