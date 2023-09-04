using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPG223_Final
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            if (User.getAdmin())
            {
                try
                {
                    StreamReader reader = new StreamReader("AdminHelp.txt");

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        lstAssistance.Items.Add(line);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error has occured: " + ex.Message);
                }
            }
            else if (!User.getAdmin())
            {
                try
                {
                    StreamReader reader = new StreamReader("ClientHelp.txt");

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        lstAssistance.Items.Add(line);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The following error has occured: " + ex.Message);
                }
            }
        }

        private void pnlHelp_Paint(object sender, PaintEventArgs e)
        {
  
        }
    }
}
