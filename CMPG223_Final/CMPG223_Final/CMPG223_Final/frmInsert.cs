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
    public partial class frmInsert : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlCommand cmd;

        public frmInsert()
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
            fillColours();
            fillModels();
            fillClients();
            fillMakes();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                string serviceName = txtServiceName.Text;
                decimal servicePrice = nudPriceService.Value;

                if (txtServiceName.Text != "")
                {
                    if (validateService(serviceName))
                    {
                        if(servicePrice != 0)
                        {
                            con.Open();

                            String sql = $"INSERT INTO Service(Service, Cost) VALUES('{serviceName}',{servicePrice}) ";
                            cmd = new SqlCommand(sql, con);
                            adapter = new SqlDataAdapter();
                            adapter.InsertCommand = cmd;
                            adapter.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("The record has been added to the database table");

                            con.Close();
                        }else{
                            MessageBox.Show("An Error has occured:\nPlease enter a valid price for the service");
                        }
                    }else{
                        MessageBox.Show("An Error has occured:\nService Type already exists");
                    }
                }else{
                    MessageBox.Show("An Error has occured:\nPlease type a name for the service");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("An Error has occured:\n"+ex.Message);
            }
        }

        private void btnAddMake_Click(object sender, EventArgs e)
        {
            try{
                String carMake = txtAddMake.Text;
                if (txtAddMake.Text != "")
                {
                    if(validateValues(carMake, "Make"))
                    {
                        con.Open();

                        String sql = $"INSERT INTO CarMake(Make) VALUES('{carMake}') ";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been added to the database table");

                        con.Close();
                    }else{
                        MessageBox.Show("An Error has occured:\nCar Make already in table");
                    }
                }else{
                    MessageBox.Show("An Error has occured:\nPlease type a name for the Car Make");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("An Error has occured:\n"+ex.Message);
            }
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            try{
                String carModel = txtAddModel.Text;
                if (txtAddModel.Text != "")
                {
                    if(validateValues(carModel, "Model"))
                    {
                        con.Open();

                        String sql = $"INSERT INTO CarModel(Model) VALUES('{carModel}') ";
                        cmd = new SqlCommand(sql, con);
                        adapter = new SqlDataAdapter();
                        adapter.InsertCommand = cmd;
                        adapter.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("The record has been added to the database table");

                        con.Close();
                    }else{
                        MessageBox.Show("An Error has occured:\nCar Model already in table");
                    }
                }else{
                    MessageBox.Show("An Error has occured:\nPlease type a name for the Car Model");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("An Error has occured:\n"+ex.Message);
            }
        }

        private void btnAddColour_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMechanic_Click(object sender, EventArgs e)
        {

        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            connectDB(login.conString);
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
                                con.Open();

                                String sql = $"INSERT INTO Vehicle(ClientID, ColourID, ModelID, MakeID) VALUES({cmbClientIDVehicle.Text}, " +
                                             $"{getColourID(cmbColour.Text)}, {getModelID(cmbModelVehicle.Text)}, {getMakeID(cmbMakeVehicle.Text)}) ";

                                cmd = new SqlCommand(sql, con);
                                adapter = new SqlDataAdapter();
                                adapter.InsertCommand = cmd;
                                adapter.InsertCommand.ExecuteNonQuery();

                                MessageBox.Show("The record has been added to the database table.");

                                con.Close();
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
    }
}
