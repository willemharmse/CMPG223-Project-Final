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
    public partial class Update : Form
    {
        public string table;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        public Update()
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

        private void Update_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            connectDB(login.conString);

            pnlUpdateAdmin.Hide();
            pnlUpdateClient.Hide();
            pnlUpdateColour.Hide();
            pnlUpdateMake.Hide();
            pnlUpdateMechanic.Hide();
            pnlUpdateModel.Hide();
            pnlUpdateService.Hide();
            pnlUpdateVehicle.Hide();

            showPanel(table);

            fillVehicleID();
            fillClientID();
            fillModelID();
            fillColourID();
            fillMakeID();
            fillServiceID();
            fillMechanicID();
            fillAdminID();
        }

        private void showPanel(string table)
        {
            switch (table)
            {
                case "Clients":
                    pnlUpdateClient.Show();
                    break;

                case "Admin":
                    pnlUpdateAdmin.Show();
                    break;

                case "Vehicle":
                    pnlUpdateVehicle.Show();
                    break;

                case "CarModel":
                    pnlUpdateModel.Show();
                    break;

                case "CarMake":
                    pnlUpdateMake.Show();
                    break;

                case "CarColour":
                    pnlUpdateColour.Show();
                    break;

                case "Mechanic":
                    pnlUpdateMechanic.Show();
                    break;

                case "Service":
                    pnlUpdateService.Show();
                    break;

                default:
                    break;
            }
        }

        private void fillVehicleID()
        {
            try
            {
                string sql = "SELECT VehicleID FROM Vehicle";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Cars");

                cmbVehicleID.DataSource = ds.Tables[0];
                cmbVehicleID.DisplayMember = "VehicleID";
                cmbVehicleID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillClientID()
        {
            try
            {
                string sql = "SELECT ClientID FROM Clients";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "People");

                cmbClientID.DataSource = ds.Tables[0];
                cmbClientID.DisplayMember = "ClientID";
                cmbClientID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillModelID()
        {
            try
            {
                string sql = "SELECT ModelID FROM CarModel";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Models");

                cmbModelID.DataSource = ds.Tables[0];
                cmbModelID.DisplayMember = "ModelID";
                cmbModelID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillColourID()
        {
            try
            {
                string sql = "SELECT ColourID FROM CarColour";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Colours");

                cmbColourID.DataSource = ds.Tables[0];
                cmbColourID.DisplayMember = "ColourID";
                cmbColourID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillMakeID()
        {
            try
            {
                string sql = "SELECT MakeID FROM CarMake";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Makes");

                cmbMakeID.DataSource = ds.Tables[0];
                cmbMakeID.DisplayMember = "MakeID";
                cmbMakeID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillServiceID()
        {
            try
            {
                string sql = "SELECT ServiceID FROM Service";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Services");

                cmbServiceID.DataSource = ds.Tables[0];
                cmbServiceID.DisplayMember = "ServiceID";
                cmbServiceID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillMechanicID()
        {
            try
            {
                string sql = "SELECT MechanicID FROM Mechanic";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Mechs");

                cmbMechID.DataSource = ds.Tables[0];
                cmbMechID.DisplayMember = "MechanicID";
                cmbMechID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillAdminID()
        {
            try
            {
                string sql = "SELECT AdminID FROM Admin";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Ads");

                cmbAdminID.DataSource = ds.Tables[0];
                cmbAdminID.DisplayMember = "AdminID";
                cmbAdminID.SelectedIndex = -1;

                con.Close();
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

        private void btnUpdateClient_Click(object sender, EventArgs e)
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
                                                            updateClient();
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

        private void updateClient()
        {
            try
            {
                con.Open();

                string sql = $"UPDATE Clients " +
                             $"SET Name = '{txtNameClient.Text}', Surname = '{txtSurnameClient.Text}', " +
                             $"Age = {(int)nudAgeClient.Value}, Gender = '{cmbGenderClient.Text}', Phone_Number = '{txtNumberClient.Text}'," +
                             $" Email = '{txtEmailClient.Text}', Username = '{txtAddUsernameClient.Text}', Password = '{txtPasswordClient.Text}' " +
                             $"WHERE ClientID = {cmbClientID.Text}";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();

                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("The record has been updated in the database table.");

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceName = txtServiceName.Text;
                decimal servicePrice = nudPriceService.Value;

                if (txtServiceName.Text != "")
                {
                    if (validateService(serviceName))
                    {
                        if (servicePrice != 0)
                        {
                            con.Open();

                            String sql = $"UPDATE Service SET Service = '{serviceName}', Cost = {servicePrice} WHERE ServiceID = {cmbServiceID.Text}";
                            cmd = new SqlCommand(sql, con);
                            adapter = new SqlDataAdapter();
                            adapter.InsertCommand = cmd;
                            adapter.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("The record has been updated in the database table.");

                            con.Close();

                            this.Close();
                        }
                        else
                        {
                            showError("Please enter a valid price for the service");
                        }
                    }
                    else
                    {
                        showError("Service Type already exists");
                    }
                }
                else
                {
                    showError("Please type a name for the service");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
                con.Close();
            }
        }

        private void btnChooseService_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbServiceID.Text != "")
                {
                    string sql = $"SELECT * FROM Service WHERE ServiceID = {cmbServiceID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtServiceName.Text = reader.GetString(1);
                        nudPriceService.Value = reader.GetDecimal(2);
                    }

                    con.Close();

                    txtServiceName.Enabled = true;
                    nudPriceService.Enabled = true;
                    btnUpdateService.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnChooseVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVehicleID.Text != "")
                {
                    string sql = $"SELECT * FROM Vehicle WHERE VehicleID = {cmbVehicleID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                    }

                    con.Close();

                    txtServiceName.Enabled = true;
                    nudPriceService.Enabled = true;
                    btnUpdateService.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {

        }

        private void btnChooseAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAdminID.Text != "")
                {
                    string sql = $"SELECT * FROM Admin WHERE AdminID = {cmbAdminID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtUsernameAdmin.Text = reader.GetValue(7).ToString();
                        txtPasswordAdmin.Text = reader.GetValue(8).ToString();
                        txtCellAdmin.Text = reader.GetValue(5).ToString();
                        txtEmailAdmin.Text = reader.GetValue(6).ToString();
                        txtNameAdmin.Text = reader.GetValue(1).ToString();
                        txtSurnameAdmin.Text = reader.GetValue(2).ToString();
                        nudAgeAdmin.Value = reader.GetInt32(3);

                        if (reader.GetValue(4).ToString() == "Female")
                            cbxGenderAdmin.SelectedIndex = 1;
                        else
                            cbxGenderAdmin.SelectedIndex = 0;
                    }

                    con.Close();

                    txtUsernameAdmin.Enabled = true;
                    txtPasswordAdmin.Enabled = true;
                    txtCellAdmin.Enabled = true;
                    txtEmailAdmin.Enabled = true;
                    txtNameAdmin.Enabled = true;
                    txtSurnameAdmin.Enabled = true;
                    nudAgeAdmin.Enabled = true;
                    cbxGenderAdmin.Enabled = true;
                    btnUpdateAdmin.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
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
                                                                updateAdmin();
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

        private void updateAdmin()
        {
            try
            {
                con.Open();

                string sql = $"UPDATE Admin SET " +
                             $"Name = '{txtNameAdmin.Text}', Surname = '{txtSurnameAdmin.Text}', " +
                             $"Age = {(int)nudAgeAdmin.Value}, Gender = '{cbxGenderAdmin.Text}', Phone_Number = '{txtCellAdmin.Text}'," +
                             $" Email = '{txtEmailAdmin.Text}', Username = '{txtUsernameAdmin.Text}', Password = '{txtPasswordAdmin.Text}' " +
                             $"WHERE AdminID = {cmbAdminID.Text}";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("The record has been updated in the database table.");

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnChooseMake_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMakeID.Text != "")
                {
                    string sql = $"SELECT * FROM CarMake WHERE MakeID = {cmbMakeID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtAddMake.Text = reader.GetString(1);
                    }

                    con.Close();

                    txtAddMake.Enabled = true;
                    btnUpdateMake.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateMake_Click(object sender, EventArgs e)
        {
            try
            {
                String carMake = txtAddMake.Text;
                if (txtAddMake.Text != "")
                {
                    if (validateValues(carMake, "Make"))
                    {
                        con.Open();

                        String sql = $"UPDATE CarMake SET Make = '{carMake}' WHERE MakeID = {cmbMakeID.Text}";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been updated in the database table.");

                        con.Close();

                        this.Close();
                    }
                    else
                    {
                        showError("Car Make already in table");
                    }
                }
                else
                {
                    showError("Please type a name for the Car Make");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnChooseModel_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbModelID.Text != "")
                {
                    string sql = $"SELECT * FROM CarModel WHERE ModelID = {cmbModelID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtAddModel.Text = reader.GetString(1);
                    }

                    con.Close();

                    txtAddModel.Enabled = true;
                    btnUpdateModel.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateModel_Click(object sender, EventArgs e)
        {
            try
            {
                String carModel = txtAddModel.Text;
                if (txtAddMake.Text != "")
                {
                    if (validateValues(carModel, "Model"))
                    {
                        con.Open();

                        String sql = $"UPDATE CarModel SET Model = '{carModel}' WHERE ModelID = {cmbModelID.Text}";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been updated in the database table.");

                        con.Close();

                        this.Close();
                    }
                    else
                    {
                        showError("Car Model already in table");
                    }
                }
                else
                {
                    showError("Please type a name for the Car Model");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateColour_Click(object sender, EventArgs e)
        {
            try
            {
                String carColour = txtAddModel.Text;
                if (txtAddMake.Text != "")
                {
                    if (validateValues(carColour, "Colour"))
                    {
                        con.Open();

                        String sql = $"UPDATE CarColour SET Colour = '{carColour}' WHERE ColourID = {cmbColourID.Text}";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been updated in the database table.");

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

        private void btnChooseColour_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbColourID.Text != "")
                {
                    string sql = $"SELECT * FROM CarColour WHERE ColourID = {cmbColourID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtAddColour.Text = reader.GetString(1);
                    }

                    con.Close();

                    txtAddColour.Enabled = true;
                    btnUpdateColour.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnChooseMech_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMechID.Text != "")
                {
                    string sql = $"SELECT * FROM Mechanic WHERE MechanicID = {cmbMechID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtNumberMech.Text = reader.GetValue(5).ToString();
                        txtEmailMech.Text = reader.GetValue(6).ToString();
                        txtNameMech.Text = reader.GetValue(1).ToString();
                        txtSurnameMech.Text = reader.GetValue(2).ToString();
                        nudAgeMech.Value = reader.GetInt32(3);
                        nudSallaryMech.Value = reader.GetDecimal(7);

                        if (reader.GetValue(4).ToString() == "Female")
                            cmbGenderMech.SelectedIndex = 1;
                        else
                            cmbGenderMech.SelectedIndex = 0;
                    }

                    con.Close();

                    txtNumberMech.Enabled = true;
                    txtEmailMech.Enabled = true;
                    txtNameMech.Enabled = true;
                    txtSurnameMech.Enabled = true;
                    nudAgeMech.Enabled = true;
                    nudSallaryMech.Enabled = true;
                    cmbGenderMech.Enabled = true;
                    btnUpdateMechanic.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnUpdateMechanic_Click(object sender, EventArgs e)
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
                                                    updateMech();
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

        private void updateMech()
        {
            try
            {
                con.Open();

                string sql = $"UPDATE Mechanic SET " +
                             $"Name = '{txtNameMech.Text}', Surname = '{txtSurnameMech.Text}', " +
                             $"Age = {(int)nudAgeMech.Value}, Gender = '{cmbGenderMech.Text}', Phone_Number = '{txtNumberMech.Text}'," +
                             $" Email = '{txtEmailMech.Text}', Salary = {nudSallaryMech.Value} WHERE MechanicID = {cmbMechID.Text}";

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("The record has been updated in the database table.");

                con.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
                con.Close();
            }
        }

        private void btnChooseClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbClientID.Text != "")
                {
                    string sql = $"SELECT * FROM Clients WHERE ClientID = {cmbClientID.Text}";

                    con.Open();

                    cmd = new SqlCommand(sql, con);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtAddUsernameClient.Text = reader.GetValue(7).ToString();
                        txtPasswordClient.Text = reader.GetValue(8).ToString();
                        txtNumberClient.Text = reader.GetValue(5).ToString();
                        txtEmailClient.Text = reader.GetValue(6).ToString();
                        txtNameClient.Text = reader.GetValue(1).ToString();
                        txtSurnameClient.Text = reader.GetValue(2).ToString();
                        nudAgeClient.Value = reader.GetInt32(3);

                        if (reader.GetValue(4).ToString() == "Female")
                            cmbGenderClient.SelectedIndex = 1;
                        else
                            cmbGenderClient.SelectedIndex = 0;
                    }

                    con.Close();

                    txtAddUsernameClient.Enabled = true;
                    txtPasswordClient.Enabled = true;
                    txtNumberClient.Enabled = true;
                    txtEmailClient.Enabled = true;
                    txtNameClient.Enabled = true;
                    txtSurnameClient.Enabled = true;
                    nudAgeClient.Enabled = true;
                    cmbGenderClient.Enabled = true;
                    btnUpdateClient.Enabled = true;
                }
                else
                {
                    showError("Please select a value for the ID");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }
    }
}
