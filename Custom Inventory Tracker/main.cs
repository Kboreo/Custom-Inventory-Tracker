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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + dbPath + "Integrated Security=True;" + "Connect Timeout=30"); //Create Connection to Database
            con.Open(); //Open Database Connection
            con.Close();    //Close Database Connection
            MessageBox.Show("Success!");
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory i2 = new inventory(); //Creates new "Inventory" form
            i2.Show();  //Shows "Inventory" form
        }
    }
}
