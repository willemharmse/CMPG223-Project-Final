using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Final
{
    public partial class frmDelete : Form
    {
        public int id { get; set; }
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (nudDeleteID.Value != 0)
            {
                id = (int)nudDeleteID.Value;

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
        }
    }
}
