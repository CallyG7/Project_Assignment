using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*
 Sonele Sodo 43912338
 Cally Makhubele 43679714 
 */

namespace ProjectAssigment_1
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        //Classes to work with the data in the database
        SqlConnection conn;
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        SqlCommand command;

        //Global connection string
        public string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        //Field variables (attributes in the table)
        string food_Ordered = "";
        string drink_Ordered = "";
        double totalPrice = 0;
        int cust_ID = 3;


        private void clear() //Method to clear radiobuttons , listbox etc
        {
            lstReceipt.Items.Clear();
            rdoRooibosTea.Checked = false;
            rdoRockyRoadCups.Checked = false;
            rdoLemonMaringueTarts.Checked = false;
            rdoHamSandwich.Checked = false;
            rdoGrilledCheeseSandwich.Checked = false;
            rdoGreenTea.Checked = false;
            rdoChickenSandwich.Checked = false;
            rdoChamomileTea.Checked = false;
            rdoCappuccino.Checked = false;
            rdoCaffemocha.Checked = false;
            rdoAppricotDanish.Checked = false;
            rdoAmericano.Checked = false;
        }


        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            double drinkPrice = 0;
            double foodPrice = 0;
           
           

            // Assigning variables to the item chosen for drinks or food
            if(rdoAmericano.Checked)
            {
                drink_Ordered = "Americano";
                drinkPrice = 20;
            }
            else if (rdoCaffemocha.Checked)
            {
                drink_Ordered = "Caffe mocha";
                drinkPrice = 40;

            }
            else if (rdoCappuccino.Checked)
            {
                drink_Ordered = "Cappuccino";
                drinkPrice = 35;
            }
            else if (rdoChamomileTea.Checked)
            {
                drink_Ordered = "Chamomile tea";
                drinkPrice = 20;
            }
            else if (rdoGreenTea.Checked)
            {
                drink_Ordered = "Green tea";
                drinkPrice = 10;
            }
            else if (rdoRooibosTea.Checked)
            {
                drink_Ordered = "Rooibos tea";
                drinkPrice = 17;
            }
            else
            {
                MessageBox.Show("No drinks orderd");
            }

            if (rdoChickenSandwich.Checked)
            {
                food_Ordered = "Chicken sandwich";
                foodPrice = 15;
            }
            else if (rdoGrilledCheeseSandwich.Checked)
            {
                food_Ordered = "Grilled cheese sandwich";
                foodPrice = 20;
            }
            else if (rdoHamSandwich.Checked)
            {
                food_Ordered = "Ham sandwich";
                foodPrice = 15;
            }
            else if (rdoLemonMaringueTarts.Checked)
            {
                food_Ordered = "Lemon maringue tarts";
                foodPrice = 25;
            }
            else if (rdoRockyRoadCups.Checked)
            {
                food_Ordered = "Rocky road cups";
                foodPrice = 30;
            }
            else if (rdoAppricotDanish.Checked)
            {
                food_Ordered = "Appricot Danish";
                foodPrice = 25;
            }
            else
            {
                MessageBox.Show("No food orderd");
            }


            totalPrice = (foodPrice + drinkPrice);

          
            //Make sure item is selected or error message
            if(rdoAmericano.Checked || rdoAppricotDanish.Checked || rdoCaffemocha.Checked || rdoCappuccino.Checked || rdoChamomileTea.Checked || rdoChickenSandwich.Checked || rdoGreenTea.Checked || rdoGrilledCheeseSandwich.Checked || rdoHamSandwich.Checked || rdoLemonMaringueTarts.Checked || rdoRockyRoadCups.Checked || rdoRooibosTea.Checked)
            {
                
                try
                {
                    conn.Open();

                    string sql = $"INSERT INTO CustomerOrders(Food_Ordered , Drink_Ordered , Total_Price) VALUES ('{food_Ordered}', '{drink_Ordered}', {totalPrice})";
                    command = new SqlCommand(sql, conn);

                    dataAdapter = new SqlDataAdapter();

                    dataAdapter.InsertCommand = command;

                    dataAdapter.InsertCommand.ExecuteNonQuery();

                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

                // new customer added
                cust_ID++;

                //Review of order
                gbReview.Visible = true;
               
                lblFood.Text = "Food ordered: " + food_Ordered;
                lblDrink.Text = "Drink ordered: " + drink_Ordered;
            }
            else
            {
                MessageBox.Show("Please order first");
            }



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                //Connecting to the database
                conn = new SqlConnection(connStr);

                //Open the connection
                conn.Open();

                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


            gbReview.Visible = false;
           
        }
        

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Customer decides to cancel order , remove them from the database
            try
            {
                conn.Open();
                string delete_query = "DELETE FROM CustomerOrders WHERE Customer_ID = "+ cust_ID;
                command = new SqlCommand(delete_query, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.DeleteCommand = command;
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            MessageBox.Show("Order cancelled");
            //reduce customer orders because order has been deleted
            cust_ID--;

            gbReview.Visible = false;
            clear();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Display receipt to customer
            MessageBox.Show("Order succesfull");
            lstReceipt.Items.Add("Beetle Caf");
            lstReceipt.Items.Add("");
            lstReceipt.Items.Add("============================================");
            lstReceipt.Items.Add("Food ordered : " + food_Ordered);
            lstReceipt.Items.Add("Drink ordered : " + drink_Ordered);         
            lstReceipt.Items.Add("Total price : " + totalPrice.ToString("C"));

            gbReview.Visible = false;
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnNextOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
