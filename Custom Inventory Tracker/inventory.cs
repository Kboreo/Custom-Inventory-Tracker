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

namespace Custom_Inventory_Tracker
{
    public partial class inventory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + "AttachDbFilename=" + AppDomain.CurrentDomain.BaseDirectory + "Database.mdf;" + "Integrated Security=True;" + "Connect Timeout=30"); //Create Connection to Database
        public inventory()
        {
            InitializeComponent();

        }        
        
        private void inventory_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        //Fuction that will display all data in the current database to the dataGridView1 datagrid
        public void disp_data()
        {
            con.Open(); //Open Connection con
            SqlCommand cmd = con.CreateCommand();   //Create SqlCommand for the 'con' Connection
            cmd.CommandType = CommandType.Text; //CommandType for cmd is set to text
            cmd.CommandText = "select * from invMaterial";   //selects all data in the table1 database
            cmd.ExecuteNonQuery();  //Execute command
            DataTable dt = new DataTable(); //Creates new datatable dt
            SqlDataAdapter da = new SqlDataAdapter(cmd);    //Creates new data adapter da
            da.Fill(dt);    //Fills data table dt with data from the database 
            dataGridView1.DataSource = dt;  //Sets the datasource in dataGridView1 equal to the data in dt
            con.Close();
        }
    }
}
