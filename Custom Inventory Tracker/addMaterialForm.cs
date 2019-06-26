using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Custom_Inventory_Tracker
{
    public partial class addMaterialForm : Form
    {
        public addMaterialForm()
        {
            InitializeComponent();
        }        

        private void addItemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addMaterialTypeForm f2 = new addMaterialTypeForm(); //Creates new "Add Material" form
            f2.Show();  //Shows "Add Material" form
            this.Close();   //Closes Current Material Type Form
        }

        private void addMaterialForm_Load(object sender, EventArgs e)
        {
            checkForFile(); //Check for Xml file
            loadFilamentComboBox();
            
        }

        //Function for checking if Xml file exists
        private void checkForFile()
        {
            if (!File.Exists(Custom_Inventory_Tracker.Globals.xmlFilePath))  //Check if Xml file has not been created, and if it hasn't create it!
            {
                XmlTextWriter xWriter = new XmlTextWriter(Globals.xmlFilePath, Encoding.UTF8); //Create xml File
                xWriter.Formatting = Formatting.Indented;   //Format Output Indenting
                xWriter.WriteStartElement("menus");    //"root" <menus>
                xWriter.WriteStartElement("addMaterialForm");    //<addMaterialForm>
                xWriter.WriteStartElement("filamentType");    //<filamentType>
                xWriter.WriteStartElement("Type");    //<Type>
                xWriter.WriteString("PLA");
                xWriter.WriteEndElement(); //</Type>
                xWriter.WriteEndElement(); //</filamentType>
                xWriter.WriteEndElement(); //</addMaterialForm>
                xWriter.WriteEndElement(); //</menus>
                xWriter.Close();
            }
            else //File already exists
            {

            }
        }

        //Function that loads the Filament Combo box with data from the Xml file
        private void loadFilamentComboBox()
        {
            checkForFile(); // Check if Xml file exists
        }
    }
}
