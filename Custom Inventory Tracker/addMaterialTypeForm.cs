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
using System.IO;

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
                XDocument doc = XDocument.Load(Globals.xmlFilePath);     //Creates new Xdoc
                XElement edit = doc.Root;   //New element equal to the root of the XML File
                edit.Element("addMaterialForm").Element("filamentType").Add(new XElement("FilType", addTextBox.Text)); // Add a new <Type> Element with a value taken from a text box            
                doc.Save(Globals.xmlFilePath);   //Save XML file
                var matForm = new addMaterialForm();    //Creates New "matForm" Type                
                this.Hide();    //Hides Current Form
                matForm.Show(); //Shows matForm Form
            }
            else if (comboValue == "Color")
            {
                XDocument doc = XDocument.Load(Globals.xmlFilePath);     //Creates new Xdoc
                XElement edit = doc.Root;   //New element equal to the root of the XML File
                edit.Element("addMaterialForm").Element("Color").Add(new XElement("ColorType", addTextBox.Text)); // Add a new <Type> Element with a value taken from a text box            
                doc.Save(Globals.xmlFilePath);   //Save XML file
                var matForm = new addMaterialForm();    //Creates New "matForm" Type
                this.Hide();    //Hides Current Form
                matForm.Show(); //Shows matForm Form
            }
            else if (comboValue == "Vendor")
            {
                XDocument doc = XDocument.Load(Globals.xmlFilePath);     //Creates new Xdoc
                XElement edit = doc.Root;   //New element equal to the root of the XML File
                edit.Element("addMaterialForm").Element("Vendor").Add(new XElement("VendorType", addTextBox.Text)); // Add a new <Type> Element with a value taken from a text box            
                doc.Save(Globals.xmlFilePath);   //Save XML file
                var matForm = new addMaterialForm();    //Creates New "matForm" Type
                this.Hide();    //Hides Current Form
                matForm.Show(); //Shows matForm Form
            }           
            else
            {
                MessageBox.Show("Sorry something went wrong, please try again!");
            }
            
        }

        private void addMaterialTypeForm_Load(object sender, EventArgs e)
        {
            checkForFile();
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
    }
}
