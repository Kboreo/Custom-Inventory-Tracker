using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Inventory_Tracker
{
    public partial class addMaterialForm : Form
    {
        public addMaterialForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addMaterialTypeForm f2 = new addMaterialTypeForm(); //Creates new "Add Material" form
            f2.Show();  //Shows "Add Material" form
            this.Close();   //Closes Current Material Type Form
        }

        private void addMaterialForm_Load(object sender, EventArgs e)
        {

        }

        
    }
}
