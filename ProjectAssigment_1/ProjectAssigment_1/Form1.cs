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
    public partial class frmStart : Form
    {

        public static frmStart mdiobj ;


        public frmStart()
        {
            InitializeComponent();
        }

        private void welcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //hide windows
            stToolStripMenuItem.Visible = false;
            welcomeToolStripMenuItem.Visible = false;

            //Display the welcome page when the project loads
            frmWelcome welcome = new frmWelcome();
            welcome.MdiParent = this;
            welcome.Show();
            mdiobj = this;

            

          
           
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void satffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show the staff form
            frmOrder customer = new frmOrder();
            customer.MdiParent = this;
            customer.Show();

          
            frmWelcome welcome = new frmWelcome();
            welcome.btnStaff.Enabled = true;
        }

        private void stToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Show the staff form
            frmStaff staff = new frmStaff();
            staff.MdiParent = this;
            staff.Show();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // exit program
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
