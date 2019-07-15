namespace Custom_Inventory_Tracker
{
    partial class addMaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filamentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMaterialToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.vendorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filament Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size (Kg):";
            // 
            // filamentTypeComboBox
            // 
            this.filamentTypeComboBox.FormattingEnabled = true;
            this.filamentTypeComboBox.Items.AddRange(new object[] {
            "N/A",
            "ABS",
            "PETG",
            "PLA",
            "PLA+"});
            this.filamentTypeComboBox.Location = new System.Drawing.Point(12, 53);
            this.filamentTypeComboBox.Name = "filamentTypeComboBox";
            this.filamentTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.filamentTypeComboBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMaterialToolStripItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // AddMaterialToolStripItem
            // 
            this.AddMaterialToolStripItem.Name = "AddMaterialToolStripItem";
            this.AddMaterialToolStripItem.Size = new System.Drawing.Size(170, 22);
            this.AddMaterialToolStripItem.Text = "Add Material Type";
            this.AddMaterialToolStripItem.Click += new System.EventHandler(this.addItemToolStripMenuItem2_Click);
            // 
            // colorTypeComboBox
            // 
            this.colorTypeComboBox.FormattingEnabled = true;
            this.colorTypeComboBox.Location = new System.Drawing.Point(150, 53);
            this.colorTypeComboBox.Name = "colorTypeComboBox";
            this.colorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorTypeComboBox.TabIndex = 9;
            // 
            // vendorTypeComboBox
            // 
            this.vendorTypeComboBox.FormattingEnabled = true;
            this.vendorTypeComboBox.Location = new System.Drawing.Point(289, 53);
            this.vendorTypeComboBox.Name = "vendorTypeComboBox";
            this.vendorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.vendorTypeComboBox.TabIndex = 10;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(435, 53);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(49, 20);
            this.sizeTextBox.TabIndex = 12;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(120, 90);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(240, 90);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 126);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.vendorTypeComboBox);
            this.Controls.Add(this.colorTypeComboBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.filamentTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Material";
            this.Load += new System.EventHandler(this.addMaterialForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMaterialToolStripItem;
        public System.Windows.Forms.ComboBox filamentTypeComboBox;
        public System.Windows.Forms.ComboBox colorTypeComboBox;
        public System.Windows.Forms.ComboBox vendorTypeComboBox;
        private System.Windows.Forms.TextBox sizeTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
    }
}