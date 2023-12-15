namespace WindowsFormsApp1
{
    partial class Form5
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
            this.softwareAsset_ComboBox = new System.Windows.Forms.ComboBox();
            this.editSoftwarePanel = new System.Windows.Forms.Panel();
            this.softwareAddNotes_TextBox = new System.Windows.Forms.TextBox();
            this.softwarePurchaseDate_TextBox = new System.Windows.Forms.TextBox();
            this.editHardwarePanel = new System.Windows.Forms.Panel();
            this.hardwareAddNotes_TextBox = new System.Windows.Forms.TextBox();
            this.hardwarePurchaseDate_TextBox = new System.Windows.Forms.TextBox();
            this.hardwareIpAddress_TextBox = new System.Windows.Forms.TextBox();
            this.hardwareType_TextBox = new System.Windows.Forms.TextBox();
            this.hardwareManufacturer_TextBox = new System.Windows.Forms.TextBox();
            this.hardwareModel_TextBox = new System.Windows.Forms.TextBox();
            this.hardwareName_TextBox = new System.Windows.Forms.TextBox();
            this.hardwareAddNotes_Label = new System.Windows.Forms.Label();
            this.hardwarePurchaseDate_Label = new System.Windows.Forms.Label();
            this.hardwareIpAddress_Label = new System.Windows.Forms.Label();
            this.hardwareType_Label = new System.Windows.Forms.Label();
            this.hardwareManufacturer_Label = new System.Windows.Forms.Label();
            this.hardwareModel_Label = new System.Windows.Forms.Label();
            this.hardwareName_Label = new System.Windows.Forms.Label();
            this.softwareLicenseInfo_TextBox = new System.Windows.Forms.TextBox();
            this.softwareVersion_TextBox = new System.Windows.Forms.TextBox();
            this.softwareName_TextBox = new System.Windows.Forms.TextBox();
            this.softwareAddNotes_Label = new System.Windows.Forms.Label();
            this.softwarePurchaseDate_Label = new System.Windows.Forms.Label();
            this.softwareLicenseInfo_Label = new System.Windows.Forms.Label();
            this.softwareVersion_Label = new System.Windows.Forms.Label();
            this.softwareName_Label = new System.Windows.Forms.Label();
            this.edit_Button = new System.Windows.Forms.Button();
            this.hsAsset_ComboBox = new System.Windows.Forms.ComboBox();
            this.assetEdit_Lbl = new System.Windows.Forms.Label();
            this.hardwareAsset_ComboBox = new System.Windows.Forms.ComboBox();
            this.softwareCalendar = new System.Windows.Forms.MonthCalendar();
            this.hardwareCalendar = new System.Windows.Forms.MonthCalendar();
            this.editSoftwarePanel.SuspendLayout();
            this.editHardwarePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // softwareAsset_ComboBox
            // 
            this.softwareAsset_ComboBox.FormattingEnabled = true;
            this.softwareAsset_ComboBox.Location = new System.Drawing.Point(15, 99);
            this.softwareAsset_ComboBox.Name = "softwareAsset_ComboBox";
            this.softwareAsset_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.softwareAsset_ComboBox.TabIndex = 0;
            this.softwareAsset_ComboBox.Visible = false;
            this.softwareAsset_ComboBox.SelectedIndexChanged += new System.EventHandler(this.softwareAsset_ComboBox_SelectedIndexChanged);
            // 
            // editSoftwarePanel
            // 
            this.editSoftwarePanel.Controls.Add(this.softwareAddNotes_TextBox);
            this.editSoftwarePanel.Controls.Add(this.softwarePurchaseDate_TextBox);
            this.editSoftwarePanel.Controls.Add(this.editHardwarePanel);
            this.editSoftwarePanel.Controls.Add(this.softwareLicenseInfo_TextBox);
            this.editSoftwarePanel.Controls.Add(this.softwareVersion_TextBox);
            this.editSoftwarePanel.Controls.Add(this.softwareName_TextBox);
            this.editSoftwarePanel.Controls.Add(this.softwareAddNotes_Label);
            this.editSoftwarePanel.Controls.Add(this.softwarePurchaseDate_Label);
            this.editSoftwarePanel.Controls.Add(this.softwareLicenseInfo_Label);
            this.editSoftwarePanel.Controls.Add(this.softwareVersion_Label);
            this.editSoftwarePanel.Controls.Add(this.softwareName_Label);
            this.editSoftwarePanel.Location = new System.Drawing.Point(254, 46);
            this.editSoftwarePanel.Name = "editSoftwarePanel";
            this.editSoftwarePanel.Size = new System.Drawing.Size(248, 341);
            this.editSoftwarePanel.TabIndex = 1;
            this.editSoftwarePanel.Visible = false;
            // 
            // softwareAddNotes_TextBox
            // 
            this.softwareAddNotes_TextBox.Location = new System.Drawing.Point(118, 259);
            this.softwareAddNotes_TextBox.Name = "softwareAddNotes_TextBox";
            this.softwareAddNotes_TextBox.Size = new System.Drawing.Size(100, 20);
            this.softwareAddNotes_TextBox.TabIndex = 11;
            // 
            // softwarePurchaseDate_TextBox
            // 
            this.softwarePurchaseDate_TextBox.Location = new System.Drawing.Point(118, 198);
            this.softwarePurchaseDate_TextBox.Name = "softwarePurchaseDate_TextBox";
            this.softwarePurchaseDate_TextBox.ReadOnly = true;
            this.softwarePurchaseDate_TextBox.Size = new System.Drawing.Size(100, 20);
            this.softwarePurchaseDate_TextBox.TabIndex = 10;
            this.softwarePurchaseDate_TextBox.Tag = "";
            // 
            // editHardwarePanel
            // 
            this.editHardwarePanel.Controls.Add(this.hardwareAddNotes_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwarePurchaseDate_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwareIpAddress_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwareType_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwareManufacturer_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwareModel_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwareName_TextBox);
            this.editHardwarePanel.Controls.Add(this.hardwareAddNotes_Label);
            this.editHardwarePanel.Controls.Add(this.hardwarePurchaseDate_Label);
            this.editHardwarePanel.Controls.Add(this.hardwareIpAddress_Label);
            this.editHardwarePanel.Controls.Add(this.hardwareType_Label);
            this.editHardwarePanel.Controls.Add(this.hardwareManufacturer_Label);
            this.editHardwarePanel.Controls.Add(this.hardwareModel_Label);
            this.editHardwarePanel.Controls.Add(this.hardwareName_Label);
            this.editHardwarePanel.Location = new System.Drawing.Point(0, 0);
            this.editHardwarePanel.Name = "editHardwarePanel";
            this.editHardwarePanel.Size = new System.Drawing.Size(242, 341);
            this.editHardwarePanel.TabIndex = 6;
            this.editHardwarePanel.Visible = false;
            // 
            // hardwareAddNotes_TextBox
            // 
            this.hardwareAddNotes_TextBox.Location = new System.Drawing.Point(121, 274);
            this.hardwareAddNotes_TextBox.Name = "hardwareAddNotes_TextBox";
            this.hardwareAddNotes_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareAddNotes_TextBox.TabIndex = 13;
            // 
            // hardwarePurchaseDate_TextBox
            // 
            this.hardwarePurchaseDate_TextBox.Location = new System.Drawing.Point(121, 231);
            this.hardwarePurchaseDate_TextBox.Name = "hardwarePurchaseDate_TextBox";
            this.hardwarePurchaseDate_TextBox.ReadOnly = true;
            this.hardwarePurchaseDate_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwarePurchaseDate_TextBox.TabIndex = 12;
            // 
            // hardwareIpAddress_TextBox
            // 
            this.hardwareIpAddress_TextBox.Location = new System.Drawing.Point(121, 187);
            this.hardwareIpAddress_TextBox.Name = "hardwareIpAddress_TextBox";
            this.hardwareIpAddress_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareIpAddress_TextBox.TabIndex = 11;
            // 
            // hardwareType_TextBox
            // 
            this.hardwareType_TextBox.Location = new System.Drawing.Point(121, 141);
            this.hardwareType_TextBox.Name = "hardwareType_TextBox";
            this.hardwareType_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareType_TextBox.TabIndex = 10;
            // 
            // hardwareManufacturer_TextBox
            // 
            this.hardwareManufacturer_TextBox.Location = new System.Drawing.Point(121, 95);
            this.hardwareManufacturer_TextBox.Name = "hardwareManufacturer_TextBox";
            this.hardwareManufacturer_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareManufacturer_TextBox.TabIndex = 9;
            // 
            // hardwareModel_TextBox
            // 
            this.hardwareModel_TextBox.Location = new System.Drawing.Point(121, 55);
            this.hardwareModel_TextBox.Name = "hardwareModel_TextBox";
            this.hardwareModel_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareModel_TextBox.TabIndex = 8;
            // 
            // hardwareName_TextBox
            // 
            this.hardwareName_TextBox.Location = new System.Drawing.Point(121, 16);
            this.hardwareName_TextBox.Name = "hardwareName_TextBox";
            this.hardwareName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.hardwareName_TextBox.TabIndex = 7;
            // 
            // hardwareAddNotes_Label
            // 
            this.hardwareAddNotes_Label.AutoSize = true;
            this.hardwareAddNotes_Label.Location = new System.Drawing.Point(31, 277);
            this.hardwareAddNotes_Label.Name = "hardwareAddNotes_Label";
            this.hardwareAddNotes_Label.Size = new System.Drawing.Size(84, 13);
            this.hardwareAddNotes_Label.TabIndex = 6;
            this.hardwareAddNotes_Label.Text = "Additional Notes";
            // 
            // hardwarePurchaseDate_Label
            // 
            this.hardwarePurchaseDate_Label.AutoSize = true;
            this.hardwarePurchaseDate_Label.Location = new System.Drawing.Point(31, 234);
            this.hardwarePurchaseDate_Label.Name = "hardwarePurchaseDate_Label";
            this.hardwarePurchaseDate_Label.Size = new System.Drawing.Size(76, 13);
            this.hardwarePurchaseDate_Label.TabIndex = 5;
            this.hardwarePurchaseDate_Label.Text = "Purchase date";
            // 
            // hardwareIpAddress_Label
            // 
            this.hardwareIpAddress_Label.AutoSize = true;
            this.hardwareIpAddress_Label.Location = new System.Drawing.Point(31, 187);
            this.hardwareIpAddress_Label.Name = "hardwareIpAddress_Label";
            this.hardwareIpAddress_Label.Size = new System.Drawing.Size(58, 13);
            this.hardwareIpAddress_Label.TabIndex = 4;
            this.hardwareIpAddress_Label.Text = "IP Address";
            // 
            // hardwareType_Label
            // 
            this.hardwareType_Label.AutoSize = true;
            this.hardwareType_Label.Location = new System.Drawing.Point(31, 148);
            this.hardwareType_Label.Name = "hardwareType_Label";
            this.hardwareType_Label.Size = new System.Drawing.Size(31, 13);
            this.hardwareType_Label.TabIndex = 3;
            this.hardwareType_Label.Text = "Type";
            // 
            // hardwareManufacturer_Label
            // 
            this.hardwareManufacturer_Label.AutoSize = true;
            this.hardwareManufacturer_Label.Location = new System.Drawing.Point(31, 98);
            this.hardwareManufacturer_Label.Name = "hardwareManufacturer_Label";
            this.hardwareManufacturer_Label.Size = new System.Drawing.Size(70, 13);
            this.hardwareManufacturer_Label.TabIndex = 2;
            this.hardwareManufacturer_Label.Text = "Manufacturer";
            // 
            // hardwareModel_Label
            // 
            this.hardwareModel_Label.AutoSize = true;
            this.hardwareModel_Label.Location = new System.Drawing.Point(31, 55);
            this.hardwareModel_Label.Name = "hardwareModel_Label";
            this.hardwareModel_Label.Size = new System.Drawing.Size(36, 13);
            this.hardwareModel_Label.TabIndex = 1;
            this.hardwareModel_Label.Text = "Model";
            // 
            // hardwareName_Label
            // 
            this.hardwareName_Label.AutoSize = true;
            this.hardwareName_Label.Location = new System.Drawing.Point(31, 16);
            this.hardwareName_Label.Name = "hardwareName_Label";
            this.hardwareName_Label.Size = new System.Drawing.Size(35, 13);
            this.hardwareName_Label.TabIndex = 0;
            this.hardwareName_Label.Text = "Name";
            // 
            // softwareLicenseInfo_TextBox
            // 
            this.softwareLicenseInfo_TextBox.Location = new System.Drawing.Point(118, 137);
            this.softwareLicenseInfo_TextBox.Name = "softwareLicenseInfo_TextBox";
            this.softwareLicenseInfo_TextBox.Size = new System.Drawing.Size(100, 20);
            this.softwareLicenseInfo_TextBox.TabIndex = 9;
            // 
            // softwareVersion_TextBox
            // 
            this.softwareVersion_TextBox.Location = new System.Drawing.Point(118, 80);
            this.softwareVersion_TextBox.Name = "softwareVersion_TextBox";
            this.softwareVersion_TextBox.Size = new System.Drawing.Size(100, 20);
            this.softwareVersion_TextBox.TabIndex = 8;
            // 
            // softwareName_TextBox
            // 
            this.softwareName_TextBox.Location = new System.Drawing.Point(118, 20);
            this.softwareName_TextBox.Name = "softwareName_TextBox";
            this.softwareName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.softwareName_TextBox.TabIndex = 7;
            // 
            // softwareAddNotes_Label
            // 
            this.softwareAddNotes_Label.AutoSize = true;
            this.softwareAddNotes_Label.Location = new System.Drawing.Point(28, 259);
            this.softwareAddNotes_Label.Name = "softwareAddNotes_Label";
            this.softwareAddNotes_Label.Size = new System.Drawing.Size(84, 13);
            this.softwareAddNotes_Label.TabIndex = 6;
            this.softwareAddNotes_Label.Text = "Additional Notes";
            // 
            // softwarePurchaseDate_Label
            // 
            this.softwarePurchaseDate_Label.AutoSize = true;
            this.softwarePurchaseDate_Label.Location = new System.Drawing.Point(28, 200);
            this.softwarePurchaseDate_Label.Name = "softwarePurchaseDate_Label";
            this.softwarePurchaseDate_Label.Size = new System.Drawing.Size(76, 13);
            this.softwarePurchaseDate_Label.TabIndex = 5;
            this.softwarePurchaseDate_Label.Text = "Purchase date";
            // 
            // softwareLicenseInfo_Label
            // 
            this.softwareLicenseInfo_Label.AutoSize = true;
            this.softwareLicenseInfo_Label.Location = new System.Drawing.Point(28, 137);
            this.softwareLicenseInfo_Label.Name = "softwareLicenseInfo_Label";
            this.softwareLicenseInfo_Label.Size = new System.Drawing.Size(69, 13);
            this.softwareLicenseInfo_Label.TabIndex = 4;
            this.softwareLicenseInfo_Label.Text = "Licesnse info";
            // 
            // softwareVersion_Label
            // 
            this.softwareVersion_Label.AutoSize = true;
            this.softwareVersion_Label.Location = new System.Drawing.Point(28, 80);
            this.softwareVersion_Label.Name = "softwareVersion_Label";
            this.softwareVersion_Label.Size = new System.Drawing.Size(42, 13);
            this.softwareVersion_Label.TabIndex = 2;
            this.softwareVersion_Label.Text = "Version";
            // 
            // softwareName_Label
            // 
            this.softwareName_Label.AutoSize = true;
            this.softwareName_Label.Location = new System.Drawing.Point(28, 23);
            this.softwareName_Label.Name = "softwareName_Label";
            this.softwareName_Label.Size = new System.Drawing.Size(35, 13);
            this.softwareName_Label.TabIndex = 0;
            this.softwareName_Label.Text = "Name";
            // 
            // edit_Button
            // 
            this.edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_Button.Location = new System.Drawing.Point(15, 364);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(75, 23);
            this.edit_Button.TabIndex = 2;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = true;
            // 
            // hsAsset_ComboBox
            // 
            this.hsAsset_ComboBox.FormattingEnabled = true;
            this.hsAsset_ComboBox.Items.AddRange(new object[] {
            "Hardware",
            "Software"});
            this.hsAsset_ComboBox.Location = new System.Drawing.Point(15, 99);
            this.hsAsset_ComboBox.Name = "hsAsset_ComboBox";
            this.hsAsset_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.hsAsset_ComboBox.TabIndex = 3;
            this.hsAsset_ComboBox.SelectedIndexChanged += new System.EventHandler(this.hsAsset_ComboBox_SelectedIndexChanged);
            // 
            // assetEdit_Lbl
            // 
            this.assetEdit_Lbl.AutoSize = true;
            this.assetEdit_Lbl.Location = new System.Drawing.Point(12, 46);
            this.assetEdit_Lbl.Name = "assetEdit_Lbl";
            this.assetEdit_Lbl.Size = new System.Drawing.Size(174, 13);
            this.assetEdit_Lbl.TabIndex = 4;
            this.assetEdit_Lbl.Text = "Select which asset you want to edit";
            // 
            // hardwareAsset_ComboBox
            // 
            this.hardwareAsset_ComboBox.FormattingEnabled = true;
            this.hardwareAsset_ComboBox.Location = new System.Drawing.Point(15, 99);
            this.hardwareAsset_ComboBox.Name = "hardwareAsset_ComboBox";
            this.hardwareAsset_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.hardwareAsset_ComboBox.TabIndex = 5;
            this.hardwareAsset_ComboBox.Visible = false;
            this.hardwareAsset_ComboBox.SelectedIndexChanged += new System.EventHandler(this.hardwareAsset_ComboBox_SelectedIndexChanged);
            // 
            // softwareCalendar
            // 
            this.softwareCalendar.Location = new System.Drawing.Point(15, 181);
            this.softwareCalendar.Name = "softwareCalendar";
            this.softwareCalendar.TabIndex = 7;
            this.softwareCalendar.Visible = false;
            this.softwareCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.softwareCalendar_DateSelected);
            // 
            // hardwareCalendar
            // 
            this.hardwareCalendar.Location = new System.Drawing.Point(15, 181);
            this.hardwareCalendar.Name = "hardwareCalendar";
            this.hardwareCalendar.TabIndex = 8;
            this.hardwareCalendar.Visible = false;
            this.hardwareCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.hardwareCalendar_DateSelected);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hardwareCalendar);
            this.Controls.Add(this.softwareCalendar);
            this.Controls.Add(this.hardwareAsset_ComboBox);
            this.Controls.Add(this.softwareAsset_ComboBox);
            this.Controls.Add(this.assetEdit_Lbl);
            this.Controls.Add(this.editSoftwarePanel);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.hsAsset_ComboBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.editSoftwarePanel.ResumeLayout(false);
            this.editSoftwarePanel.PerformLayout();
            this.editHardwarePanel.ResumeLayout(false);
            this.editHardwarePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox softwareAsset_ComboBox;
        private System.Windows.Forms.Panel editSoftwarePanel;
        private System.Windows.Forms.TextBox softwareAddNotes_TextBox;
        private System.Windows.Forms.TextBox softwarePurchaseDate_TextBox;
        private System.Windows.Forms.TextBox softwareLicenseInfo_TextBox;
        private System.Windows.Forms.TextBox softwareVersion_TextBox;
        private System.Windows.Forms.TextBox softwareName_TextBox;
        private System.Windows.Forms.Label softwareAddNotes_Label;
        private System.Windows.Forms.Label softwarePurchaseDate_Label;
        private System.Windows.Forms.Label softwareLicenseInfo_Label;
        private System.Windows.Forms.Label softwareVersion_Label;
        private System.Windows.Forms.Label softwareName_Label;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.ComboBox hsAsset_ComboBox;
        private System.Windows.Forms.Label assetEdit_Lbl;
        private System.Windows.Forms.ComboBox hardwareAsset_ComboBox;
        private System.Windows.Forms.Panel editHardwarePanel;
        private System.Windows.Forms.MonthCalendar softwareCalendar;
        private System.Windows.Forms.MonthCalendar hardwareCalendar;
        private System.Windows.Forms.TextBox hardwareAddNotes_TextBox;
        private System.Windows.Forms.TextBox hardwarePurchaseDate_TextBox;
        private System.Windows.Forms.TextBox hardwareIpAddress_TextBox;
        private System.Windows.Forms.TextBox hardwareType_TextBox;
        private System.Windows.Forms.TextBox hardwareManufacturer_TextBox;
        private System.Windows.Forms.TextBox hardwareModel_TextBox;
        private System.Windows.Forms.TextBox hardwareName_TextBox;
        private System.Windows.Forms.Label hardwareAddNotes_Label;
        private System.Windows.Forms.Label hardwarePurchaseDate_Label;
        private System.Windows.Forms.Label hardwareIpAddress_Label;
        private System.Windows.Forms.Label hardwareType_Label;
        private System.Windows.Forms.Label hardwareManufacturer_Label;
        private System.Windows.Forms.Label hardwareModel_Label;
        private System.Windows.Forms.Label hardwareName_Label;
    }
}