using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Sonele Sodo 43912338
 Cally Makhubele 43679714 
 */

namespace ProjectAssigment_1
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        frmStart fo = new frmStart();
        private void Form2_Load(object sender, EventArgs e)
        {
            lstOutput.Visible = false;    
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            frmStart.mdiobj.welcomeToolStripMenuItem.Visible = true;// enables the customer tab
            btnStaff.Enabled = false;   //once user clicks on customer Staff data cannot be accessed

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            lstOutput.Visible = true;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStart.mdiobj.stToolStripMenuItem.Visible = true; // enables the staff tab
        }
    }
}
