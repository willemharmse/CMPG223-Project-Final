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
    public partial class frmDelete : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlCommand cmd;

        public string table;

        public int id { get; set; }
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (cbxID.Text != "")
            {
                id = int.Parse(cbxID.Text);

                this.Close();
            }
            else
            {
                MessageBox.Show("Please ensure the value is not 0");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            id = -1;

            this.Close();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            id = -1;

            frmLogin login = new frmLogin();
            connectDB(login.conString);

            fillCombo(table);
        }

        private void fillCombo(string table)
        {
            switch (table)
            {
                case "Clients":
                    fillClientID();
                    break;

                case "Admin":
                    fillAdminID();
                    break;

                case "Vehicle":
                    fillVehicleID();
                    break;

                case "CarModel":
                    fillModelID();
                    break;

                case "CarMake":
                    fillMakeID();
                    break;

                case "CarColour":
                    fillColourID();
                    break;

                case "Mechanic":
                    fillMechanicID();
                    break;

                case "Service":
                    fillServiceID();
                    break;

                case "Service_on_Vehicle":
                    fillServiceNumber(); 
                    break;

                default:
                    break;
            }
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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "VehicleID";
                cbxID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillServiceNumber()
        {
            try
            {
                string sql = $"SELECT ServiceNumber FROM {table}";

                con.Open();

                DataSet ds = new DataSet();

                cmd = new SqlCommand(sql, con);
                adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                adapter.Fill(ds, "Services");

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "ServiceNumber";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "ClientID";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "ModelID";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "ColourID";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "MakeID";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "ServiceID";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "MechanicID";
                cbxID.SelectedIndex = -1;

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

                cbxID.DataSource = ds.Tables[0];
                cbxID.DisplayMember = "AdminID";
                cbxID.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }
    }
}
