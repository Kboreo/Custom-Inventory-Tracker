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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filamentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addItemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addItemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorTypeComBox = new System.Windows.Forms.ComboBox();
            this.venTypeComBox = new System.Windows.Forms.ComboBox();
            this.sizeTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filament Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 58);
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
            this.filamentTypeComboBox.Location = new System.Drawing.Point(74, 75);
            this.filamentTypeComboBox.Name = "filamentTypeComboBox";
            this.filamentTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.filamentTypeComboBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 26);
            // 
            // addItemToolStripMenuItem
            // 
            this.addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            this.addItemToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addItemToolStripMenuItem.Text = "Add Item";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(124, 26);
            // 
            // addItemToolStripMenuItem1
            // 
            this.addItemToolStripMenuItem1.Name = "addItemToolStripMenuItem1";
            this.addItemToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.addItemToolStripMenuItem1.Text = "Add Item";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addItemToolStripMenuItem2
            // 
            this.addItemToolStripMenuItem2.Name = "addItemToolStripMenuItem2";
            this.addItemToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.addItemToolStripMenuItem2.Text = "Add Material Type";
            this.addItemToolStripMenuItem2.Click += new System.EventHandler(this.addItemToolStripMenuItem2_Click);
            // 
            // colorTypeComBox
            // 
            this.colorTypeComBox.FormattingEnabled = true;
            this.colorTypeComBox.Location = new System.Drawing.Point(224, 75);
            this.colorTypeComBox.Name = "colorTypeComBox";
            this.colorTypeComBox.Size = new System.Drawing.Size(121, 21);
            this.colorTypeComBox.TabIndex = 9;
            // 
            // venTypeComBox
            // 
            this.venTypeComBox.FormattingEnabled = true;
            this.venTypeComBox.Location = new System.Drawing.Point(394, 75);
            this.venTypeComBox.Name = "venTypeComBox";
            this.venTypeComBox.Size = new System.Drawing.Size(121, 21);
            this.venTypeComBox.TabIndex = 10;
            // 
            // sizeTextBox
            // 
            this.sizeTextBox.Location = new System.Drawing.Point(572, 75);
            this.sizeTextBox.Name = "sizeTextBox";
            this.sizeTextBox.Size = new System.Drawing.Size(49, 20);
            this.sizeTextBox.TabIndex = 12;
            // 
            // addMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 186);
            this.Controls.Add(this.sizeTextBox);
            this.Controls.Add(this.venTypeComBox);
            this.Controls.Add(this.colorTypeComBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.filamentTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "addMaterialForm";
            this.Text = "addMaterialForm";
            this.Load += new System.EventHandler(this.addMaterialForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addItemToolStripMenuItem2;
        public System.Windows.Forms.ComboBox filamentTypeComboBox;
        public System.Windows.Forms.ComboBox colorTypeComBox;
        public System.Windows.Forms.ComboBox venTypeComBox;
        private System.Windows.Forms.TextBox sizeTextBox;
    }
}