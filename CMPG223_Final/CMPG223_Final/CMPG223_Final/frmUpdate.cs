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
    }
}
