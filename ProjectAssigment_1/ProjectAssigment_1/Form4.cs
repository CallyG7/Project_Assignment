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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        //Classes to work with data in the database
        SqlDataAdapter dataAdapter;
        SqlDataReader dataReader;
        SqlCommand command;
        SqlConnection conn;

        //Global connection string
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
      
        private void PopulateCmbItem_ID() //method to Populate combobox with Item_IDs
        {
            try
            {


                conn = new SqlConnection(connectionString);
                conn.Open();

                string sql = "SELECT DISTINCT Item_ID FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Filling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Populates the ComboBox
                cmbItem_ID.DataSource = ds.Tables["FoodAndDrinks"];
                cmbItem_ID.DisplayMember = "Item_ID";
                cmbItem_ID.ValueMember = "Item_ID";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message); //Display error message
            }
        }

        private void PopulateCmbItem() //method to Populate combobox with Item
        {
            try
            {


             
                conn.Open();

                string sql = "SELECT DISTINCT Item FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Fiiling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Populates the ComboBox
                cmbItem.DataSource = ds.Tables["FoodAndDrinks"];
                cmbItem.DisplayMember = "Item";
                cmbItem.ValueMember = "Item";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void DisplayDB() //Method to display database in datagrid
        {
            try
            {
                
                conn.Open();

                string sql = "SELECT * FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Fiiling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Populates the dataGrid
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "FoodAndDrinks";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Dgv1Display() //Method to display database in datagrid
        {
            try
            {
               
                conn.Open();

                string sql = "SELECT * FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Fiiling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Populates the dataGrid
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "FoodAndDrinks";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void DsiplayDBwithDataReader() //Method to display database in listbox
        {
            /* Displaying data in a listbox*/
            try
            {
                conn.Open();

                string sql = "SELECT * FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataReader = command.ExecuteReader();

                string output = "";

                lstReports.Items.Add("Item_ID\t\t Item\t\t\t\t Price\t\t\t\tItem Sold ");
                lstReports.Items.Add("======================================================================================================================");
                while (dataReader.Read()) //To loop through the database
                {
                    output = dataReader.GetValue(0).ToString() + "\t\t\t" + dataReader.GetValue(1) + "\t\t\t" + dataReader.GetValue(2) + "\t\t\t" + dataReader.GetValue(3);
                    lstReports.Items.Add(output); // Adding Data to the listBox
                }

                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            //PopulateCmbPrice();
            PopulateCmbItem_ID();
            PopulateCmbItem();
            DisplayDB();
            Dgv1Display();
            DsiplayDBwithDataReader();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Hide tabs until staff logs in
            tabControl1.TabPages.Remove(tbpReports);
            tabControl1.TabPages.Remove(tbpUpdate);
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                /*Filter the database based on the price of the items*/
                conn.Open();

                string sql = "SELECT DISTINCT Price FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Fiiling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Filteres database 
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "FoodAndDrinks";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Update the price of an item by the staff*/
            double price = 0;

            if (double.TryParse(txtUpdate.Text, out price))
            {
                if (txtUpdate.Text != "")
                {
                    try
                    {


                        conn.Open();

                        string sql = "UPDATE FoodAndDrinks SET Price = @Price WHERE Item = @Item";
                        command = new SqlCommand(sql, conn);
                        command.Parameters.AddWithValue("@Price", price); //field being updated specified
                        command.Parameters.AddWithValue("@Item", cmbItem.Text); // condition of field being updated
                        command.ExecuteNonQuery();

                        MessageBox.Show("Price Updated");
                        conn.Close();


                    }
                    catch (SqlException ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Specify amount");
                }
            }
            else
            {
                errorProvider2.SetError(txtUpdate, "Please enter price of item");
            }

           
            //Refresh
            PopulateCmbItem();
            DisplayDB();
            Dgv1Display();
            DsiplayDBwithDataReader();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*Delete item of the staff's choice from the database*/
            try
            {
                conn.Open();

                string delete_query = "DELETE FROM FoodAndDrinks WHERE Item_ID = '" + cmbItem_ID.Text+"'";
                command = new SqlCommand(delete_query, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.DeleteCommand = command; // execute delete statement
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }

            MessageBox.Show("Item "+cmbItem_ID.Text+"  deleted from the database");

            //Clear the data in the listbox 
            lstReports.Items.Clear();
            //Refreshes the combobox
            PopulateCmbItem_ID();

            //Refresh database
            DisplayDB();

            //Refresh listbox
            DsiplayDBwithDataReader();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            /* Authorizing acces to BeetleCaf data , if you not a staff then no access*/
            int password = 0;

            if (int.TryParse(txtPassword.Text, out password))
            {

                if (txtUsername.Text == "Thomas458" && password.ToString() == "1234")
                {
                    if (txtUsername.Text != "" && txtPassword.Text != "")
                    {
                        //Show the tabs the data of BeetleCafe
                        tabControl1.TabPages.Insert(1, tbpReports);
                        tabControl1.TabPages.Insert(2, tbpUpdate);
                        MessageBox.Show("Logged in successully");
                        tbpReports.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Fill in credentials for access"); // Exception for nothing being filled in
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Credentials");// Exception for incorrect credentiasl
                }
            }
            else
            {
                errorProvider1.SetError(txtPassword, "Please enter a valid password");// error message
            }
            


        }

        private void lblFilter_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            /*Filter the data as you type*/
            try
            {
                //Open the connection
                conn.Open();

                string sql = "SELECT * FROM FoodAndDrinks WHERE Item_ID LIKE '%" + txtFilter.Text + "%' OR Item LIKE '%" + txtFilter.Text + "%' OR Price LIKE '%" + txtFilter.Text + "%' OR Items_Sold LIKE '%" + txtFilter.Text + "%'";
                command = new SqlCommand(sql, conn); // Sets the command, sql as well as the connection
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command; // Execute the command

                //Filling the DataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Populates the DataGridview
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "FoodAndDrinks";

                //Close the connection 
                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbp_Enter(object sender, EventArgs e)
        {
            /*Food and drinks data display*/
            try
            {
                 conn = new SqlConnection(connectionString);
                conn.Open();

                string sql = "SELECT * FROM FoodAndDrinks";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Fiiling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "FoodAndDrinks");

                //Populates the dataGrid
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "FoodAndDrinks";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }



            /*Customer orders data display*/
            try
            {
               
                conn.Open();

                string sql = "SELECT * FROM CustomerOrders";
                command = new SqlCommand(sql, conn);
                dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;

                //Fiiling the dataSet
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "CustomerOrders");

                //Populates the dataGrid
                dataGridView4.DataSource = ds;
                dataGridView4.DataMember = "CustomerOrders";

                conn.Close();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


            /*Generate report on most items sold and profit made*/
            try
            {
                conn.Open();

                string sql = "SELECT * FROM FoodAndDrinks";// sql statement to be executed
                command = new SqlCommand(sql, conn); //instantiating sqlcommand obkect
                dataReader = command.ExecuteReader(); //executing command

                //declaring variables 
                string output = "";
                double total = 0;

                lstData.Items.Add("Item \t\t Total generated from each item ");
                lstData.Items.Add("======================================================================================================================");

                while (dataReader.Read()) //To loop through the database
                {
                    decimal price =(decimal)dataReader.GetValue(2); // price of item stored in variable
                    int items_sold =(int) dataReader.GetValue(3); //items sold of item stored in variable
                    decimal generated = price * items_sold;  //calculation of how much each item sold generated in total

                     total+= (double)generated; // add up the total money generated of each item
                    output = dataReader.GetValue(1).ToString() + "\t\tR" + generated.ToString("n0")+ "\n";
                    lstData.Items.Add(output); // Adding Data to the listBox
                }

                lstData.Items.Add("");
                lstData.Items.Add("Total profits : R" +total); // display total

                conn.Close();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
