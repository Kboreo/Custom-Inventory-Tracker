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
            loadFilamentComboBox(); //Fills Filament Type ComboBox from Xml File
            loadColorComboBox();    //Fills Color ComboBox from Xml File
            loadVendorComboBox();   //Fills Vendor ComboBox from Xml File
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
                xWriter.WriteStartElement("FilType");    //<Type>
                xWriter.WriteString("PLA");
                xWriter.WriteEndElement(); //</Type>
                xWriter.WriteEndElement(); //</filamentType>
                xWriter.WriteStartElement("Color");    //<Color>
                xWriter.WriteStartElement("ColorType");    //<Type>
                xWriter.WriteString("Blue");
                xWriter.WriteEndElement(); //</Type>
                xWriter.WriteEndElement(); //</Color>
                xWriter.WriteStartElement("Vendor");    //<Vendor>
                xWriter.WriteStartElement("VendorType");    //<Type>
                xWriter.WriteString("Amazon");
                xWriter.WriteEndElement(); //</Type>
                xWriter.WriteEndElement(); //</Vendor>
                xWriter.WriteEndElement(); //</addMaterialForm>
                xWriter.WriteEndElement(); //</menus>
                xWriter.Close();
            }
            else //File already exists
            {

            }
        }

        //Function that loads the Filament Combobox with data from the Xml file
        private void loadFilamentComboBox()
        {
            checkForFile(); // Check if Xml file exists
            var document = XDocument.Load(Globals.xmlFilePath); //Add new XDocument
            var types = document.Descendants("FilType").Select(element => element.Value).ToList(); //Create new var list with all the values of the "Type" Element
            types.Sort();   //Sort List
            filamentTypeComboBox.DataSource = types; //Add list to ComboBox
        }

        //Function that loads the Color Combobox with data from the Xml file
        private void loadColorComboBox()
        {
            checkForFile(); // Check if Xml file exists
            var document = XDocument.Load(Globals.xmlFilePath); //Add new XDocument
            var types = document.Descendants("ColorType").Select(element => element.Value).ToList(); //Create new var list with all the values of the "Type" Element
            types.Sort();   //Sort List
            colorTypeComboBox.DataSource = types; //Add list to ComboBox
        }

        //Function that loads the Vendor Combobox with data from the Xml file
        private void loadVendorComboBox()
        {
            checkForFile(); // Check if Xml file exists
            var document = XDocument.Load(Globals.xmlFilePath); //Add new XDocument
            var types = document.Descendants("VendorType").Select(element => element.Value).ToList(); //Create new var list with all the values of the "Type" Element
            types.Sort();   //Sort List
            vendorTypeComboBox.DataSource = types; //Add list to ComboBox
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();   //Closes Form
        }
    }
}
