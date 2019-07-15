using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;    //For handling Input and Output
using System.Xml;   //For Handling Xml Files
using System.Xml.Linq;  //For Handling/Editing/Parsing Xml Files
using System.Data.SqlClient;    //For using Sql Databases

namespace Custom_Inventory_Tracker
{
    public partial class addItemForm : Form
    {
        public addItemForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes Form
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //For final Build
            //string databasePath = AppDomain.CurrentDomain.BaseDirectory; //Get file path of directory that program is running in           
            //string dbPath = "AttachDbFilename=" + databasePath + "Database.mdf;"; //String for Database file location
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + dbPath + "Integrated Security=True;" + "Connect Timeout=30"); //Create Connection to Database            

            //For testing/Debugging                
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kodey\Documents\Inentorytrackertest.mdf;Integrated Security=True;Connect Timeout=30"); //Create Connection to Database            

            try
            {                
                string cmdStr = "INSERT INTO invItem (Sku, Name, Color, Qty, Price, Material, Material_Required, Cost) VALUES (@Sku, @Name, @Color, @Qty, @Price, @Material, @Material_Required, @Cost)";

                using (SqlCommand command = new SqlCommand(cmdStr, sqlConnection))  //Loops a SqlCommand using the sqlConnection connection
                {
                    //Adds values to database table using parameters to avoid sql Injections
                    command.Parameters.AddWithValue("@Sku", this.skuTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Name", this.nameTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Color", this.colorTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Qty", qtyTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Price", priceTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Material", matTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Material_Required", matReqTextBox.Text.ToString());
                    command.Parameters.AddWithValue("@Cost", costTextBox.Text.ToString());

                    sqlConnection.Open(); //Opens Connection to database
                    command.ExecuteNonQuery(); //Execute Command
                    sqlConnection.Close();  //Closes connection to database
                }

                this.Close();   //Closes Form
                MessageBox.Show("Success!");       //Message box to let user know items were successfully added to database
            }
            catch (SqlException ex) //Exception checking for Sql Connection
            {
                MessageBox.Show($"Can not open connection ! ErrorCode: {ex.ErrorCode} Error: {ex.Message}");    //Display error code and a error message in message box
            }
            catch (Exception ex)    //Exception checking 
            {
                MessageBox.Show($"Can not open connection ! Error: {ex.Message}");  //Display Message box showing the message  
            }
        }
    }
}
