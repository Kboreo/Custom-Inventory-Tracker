﻿using System;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(sizeTextBox.Text))
            {
                MessageBox.Show("Sorry, there was an error.  Please try again!");
            }
            else
            {
                //For final Build
                //string databasePath = AppDomain.CurrentDomain.BaseDirectory; //Get file path of directory that program is running in           
                //string dbPath = "AttachDbFilename=" + databasePath + "Database.mdf;"; //String for Database file location
                //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;" + dbPath + "Integrated Security=True;" + "Connect Timeout=30"); //Create Connection to Database            

                //For testing/Debugging                
                SqlConnection sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kodey\Documents\Inentorytrackertest.mdf;Integrated Security=True;Connect Timeout=30"); //Create Connection to Database            
                
                try
                {
                    decimal size = Convert.ToDecimal(sizeTextBox.Text); //Converts value in size textbox to decimal type and sets size equal to that value
                    //sqlConnection.Open(); //Open Database Connection
                    string cmdStr = "INSERT INTO invMaterial (Filament_Type, Color, Vendor, Size) VALUES (@Filament_Type, @Color, @Vendor, @Size)";

                    using (SqlCommand command = new SqlCommand(cmdStr, sqlConnection))  //Loops a SqlCommand using the sqlConnection connection
                    {
                        //Adds values to database table using parameters to avoid sql Injections
                        command.Parameters.AddWithValue("@Filament_Type", this.filamentTypeComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Color", this.colorTypeComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Vendor", this.vendorTypeComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Size", size);

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
}
