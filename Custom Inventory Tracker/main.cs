using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //For using Sql Databases


namespace Custom_Inventory_Tracker
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created By Kodey!");   //Pop-up message box for "About"
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }

        private void newInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {            
            string databasePath = AppDomain.CurrentDomain.BaseDirectory; //Get file path of directory that program is running in           
            string dbPath = "AttachDbFilename=" + databasePath + "Database.mdf;"; //String for Database file location
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + dbPath + "Integrated Security=True;" + "Connect Timeout=30"); //Create Connection to Database            

            try
            {
                sqlConnection.Open(); //Open Database Connection
                sqlConnection.Close();    //Close Database Connection
            }
            catch (SqlException ex) //Exception checking for Sql Connection
            {
                MessageBox.Show($"Can not open connection ! ErrorCode: {ex.ErrorCode} Error: {ex.Message}");    //Display error code and a error message in message box
            }
            catch (Exception ex)    //Exception checking 
            {
                MessageBox.Show($"Can not open connection ! Error: {ex.Message}");  //Display Message box showing the message  
            }
            MessageBox.Show("Success!");
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory i2 = new inventory(); //Creates new "Inventory" form
            i2.Show();  //Shows "Inventory" form
        }

        private void addMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addMaterialForm f2 = new addMaterialForm(); //Creates new "Add Material Type" form
            f2.Show();  //Shows "Add Material Type" form
        }
    }

    //Class for Global Vars
    public static class Globals
    {
        public const string xmlFilePath = @"C:\Users\Kodey\Desktop\dat new\invMenus.xml";   //File path for xmls that can't be changed unless while program is running,
        //public const string xmlFilePath = "invMenus.xml";   //File path for xmls that can't be changed unless while program is running,
                
    }

    
}
