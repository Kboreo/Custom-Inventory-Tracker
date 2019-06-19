using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Custom_Inventory_Tracker
{
    public partial class addMaterialTypeForm : Form
    {
        public addMaterialTypeForm()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            addItem();            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes Form
        }

        private void addItem()
        {

            string addValue = ""; //Value to add to the Combo Box of choice
            string comboValue = ""; //Type that the user wants to add an option too

            comboValue = catComBox.Text;    //Gets Value from combo box of the data type user wants to change
            addValue = addTextBox.Text;   //Sets value of comboValue to the value of the text box            

            if (comboValue == "Filament Type")
            {
                var matForm = new addMaterialForm();    //Creates New "matForm" Type
                matForm.filTypeComboBox.Items.Add(addValue);  //Adds Value to comboBox
                this.Hide();    //Hides Current Form
                matForm.Show(); //Shows matForm Form
            }
            else if (comboValue == "Color")
            {
                var matForm = new addMaterialForm();    //Creates New "matForm" Type
                matForm.colorTypeComBox.Items.Add(addValue);  //Adds Value to comboBox
                this.Hide();    //Hides Current Form
                matForm.Show(); //Shows matForm Form
            }
            else if (comboValue == "Vendor")
            {
                var matForm = new addMaterialForm();    //Creates New "matForm" Type
                matForm.venTypeComBox.Items.Add(addValue);  //Adds Value to comboBox
                this.Hide();    //Hides Current Form
                matForm.Show(); //Shows matForm Form
            }           
            else
            {

            }
            
        }
    }
}
