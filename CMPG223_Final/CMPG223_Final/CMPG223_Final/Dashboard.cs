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
    public partial class frmDashboard : Form
    {
        SqlConnection con;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;
        SqlCommand cmd;

        private string[] services = new string[100];
        private int[] serviceIDs = new int[100];
        private int counter = 0;

        public frmDashboard()
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

        private void fillCarMakes()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sql = "SELECT Make FROM CarMake";

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                cmd = new SqlCommand(sql, con);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "CarMakes");

                cmbCarMakes.DataSource = ds.Tables[0];
                cmbCarMakes.DisplayMember = "Make";
                cmbCarMakes.ValueMember = "Make";
                cmbCarMakes.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillCarModels()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sql = "SELECT Model FROM CarModel";

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                cmd = new SqlCommand(sql, con);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "CarModel");

                cmbCarModel.DataSource = ds.Tables[0];
                cmbCarModel.DisplayMember = "Model";
                cmbCarModel.ValueMember = "Model";
                cmbCarModel.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void fillCarColours()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sql = "SELECT Colour FROM CarColour";

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                cmd = new SqlCommand(sql, con);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "CarColour");

                cmbCarColour.DataSource = ds.Tables[0];
                cmbCarColour.DisplayMember = "Colour";
                cmbCarColour.ValueMember = "Colour";
                cmbCarColour.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }


        private void fillServiceTypes()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sql = "SELECT Service FROM Service";

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                cmd = new SqlCommand(sql, con);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Services");

                cbxServiceType.DataSource = ds.Tables[0];
                cbxServiceType.DisplayMember = "Service";
                cbxServiceType.ValueMember = "Service";
                cbxServiceType.SelectedIndex = -1;

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void ResetAll()
        {
            lblQuotes.BackColor = Color.Transparent;
            lblPayments.BackColor = Color.Transparent;
            lblReports.BackColor = Color.Transparent;
            lblMaintain.BackColor = Color.Transparent;
            pnlQuotes.Visible = false;
            pnlPayments.Visible = false;
            pnlReports.Visible = false;
            pnlMaintain.Visible = false;
        }
        private void lblQuotes_Click(object sender, EventArgs e)
        {
            ResetAll();
            lblQuotes.BackColor = Color.FromArgb(35,35,35);
            pnlQuotes.Visible = true;
        }

        private void lblPayments_Click(object sender, EventArgs e)
        {
            ResetAll();
            lblPayments.BackColor = Color.FromArgb(45, 45, 45);
            pnlPayments.Visible = true;
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            ResetAll();
            lblReports.BackColor = Color.FromArgb(50, 50, 50);
            pnlReports.Visible = true;
        }

        private void lblMaintain_Click(object sender, EventArgs e)
        {
            ResetAll();
            lblMaintain.BackColor = Color.FromArgb(45, 45, 45);
            pnlMaintain.Visible = true;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            connectDB(login.conString);

            if (!User.getAdmin())
            {
                lblPayments.Enabled = false;
                lblPayments.Visible = false;

                lblReports.Enabled = false;
                lblReports.Visible = false;

                lblMaintain.Enabled = false;
                lblMaintain.Visible = false;

                lblQuotes_Click(new object(), new EventArgs());
            }

            fillCarMakes();
            fillCarModels();
            fillCarColours();
            fillServiceTypes();
        }

        private void btnAddServiceType_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxServiceType.SelectedIndex != -1)
                {
                    if (!serviceChosenAlready(cbxServiceType.Text))
                    {
                        if (MessageBox.Show("This item will be added to the list of services to the vehicle.\nAre you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            lstListServiceTypes.Items.Add(cbxServiceType.Text);
                            services[counter++] = cbxServiceType.Text;
                        }
                        else
                        {
                            MessageBox.Show("The service was not added to the list");
                        }
                    }
                    else
                    {
                        showError("This service type has already been chosen. Please select a different type of service");
                    }
                }
                else
                {
                    showError("Please select a valid service type to add");
                    cbxServiceType.Focus();
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private bool serviceChosenAlready(string service)
        {
            bool result = false;

            for (int i = 0; i < counter; i++)
            {
                if (services[i] == service)
                {
                    result = true;
                }
            }

            return result;
        }

        private int determineIndex(string service)
        {
            int result = -1;

            for (int i = 0; i < counter; i++)
            {
                if (services[i] == service)
                {
                    result = i;
                }
            }

            return result;
        }

        private void removeServiceType(int index)
        {
            for (int i = index; i < counter - 1; i++)
            {
                services[i] = services[i + 1];
            }

            services[counter - 1] = null;
            counter--;

            lstListServiceTypes.Items.Clear();

            for (int i = 0; i < counter; i++)
            {
                lstListServiceTypes.Items.Add(services[i]);
            }
        }

        private void btnRemoveServiceType_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxServiceType.SelectedIndex != -1)
                {
                    if (serviceChosenAlready(cbxServiceType.Text))
                    {
                        if (MessageBox.Show("This item will be removed from the list of services to the vehicle.\nAre you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int index = determineIndex(cbxServiceType.Text);
                            removeServiceType(index);
                        }
                        else
                        {
                            MessageBox.Show("The service was not removed from the list");
                        }
                    }
                    else
                    {
                        showError("This service type has not been chosen. Please select a different type of service that has been chosen to remove form the list");
                    }
                }
                else
                {
                    showError("Please select a valid service type to remove");
                    cbxServiceType.Focus();
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("If you want to proceed with this action your car details will be captured and saved", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    lstQuote.Items.Clear();

                    decimal totalcost = determineTotalCost();

                    lstQuote.Items.Add("PRO TECH AUTO");
                    lstQuote.Items.Add("QUOTE FOR SERVICE");
                    lstQuote.Items.Add("__________________________________________________");

                    for (int i = 0; i < counter; i++)
                    {
                        lstQuote.Items.Add(services[i] + " R" + getServiceCost(serviceIDs[i]));
                    }
                }
                else
                {
                    MessageBox.Show("No data was captured");
                }
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }
        }

        private decimal getServiceCost(int serviceid)
        {
            decimal cost = 0.0m;

            try
            {
                con.Open();

                string sql = $"SELECT Cost FROM Service WHERE ServiceID = {serviceid}";

                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cost = (decimal)reader.GetValue(0);
                }

                reader.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            return cost;
        }

        private decimal determineTotalCost()
        {
            decimal cost = 0.0m;

            try
            {
                con.Open();

                string sql = $"SELECT * FROM Service";

                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                int innerCounter = 0;

                while (reader.Read())
                {
                    for (int i = 0; i < counter; i++)
                    {
                        if (reader.GetValue(1).ToString() == services[i])
                        {
                            cost += (decimal)reader.GetValue(2);
                            serviceIDs[innerCounter++] = (int)reader.GetInt32(0);
                        }
                    }
                }

                reader.Close();

                con.Close();
            }
            catch (Exception ex)
            {
                showError(ex.Message);
            }

            return cost;
        }
    }
}
