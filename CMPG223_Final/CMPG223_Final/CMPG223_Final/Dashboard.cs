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
        DataSet ds;
        SqlCommand cmd;

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
        }
    }
}
