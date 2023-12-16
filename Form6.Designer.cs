namespace WindowsFormsApp1
{
    partial class Form6
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
            this.HS_ComboBox = new System.Windows.Forms.ComboBox();
            this.software_ComboBox = new System.Windows.Forms.ComboBox();
            this.hardware_ComboBox = new System.Windows.Forms.ComboBox();
            this.delete_Label = new System.Windows.Forms.Label();
            this.delete_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.Button();
            this.deleteAsset_Label = new System.Windows.Forms.Label();
            this.printItem_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HS_ComboBox
            // 
            this.HS_ComboBox.FormattingEnabled = true;
            this.HS_ComboBox.Items.AddRange(new object[] {
            "Hardware",
            "Software"});
            this.HS_ComboBox.Location = new System.Drawing.Point(287, 80);
            this.HS_ComboBox.Name = "HS_ComboBox";
            this.HS_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.HS_ComboBox.TabIndex = 0;
            this.HS_ComboBox.SelectedIndexChanged += new System.EventHandler(this.HS_ComboBox_SelectedIndexChanged);
            // 
            // software_ComboBox
            // 
            this.software_ComboBox.FormattingEnabled = true;
            this.software_ComboBox.Location = new System.Drawing.Point(290, 196);
            this.software_ComboBox.Name = "software_ComboBox";
            this.software_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.software_ComboBox.TabIndex = 1;
            this.software_ComboBox.Visible = false;
            this.software_ComboBox.SelectedIndexChanged += new System.EventHandler(this.software_ComboBox_SelectedIndexChanged);
            // 
            // hardware_ComboBox
            // 
            this.hardware_ComboBox.FormattingEnabled = true;
            this.hardware_ComboBox.Location = new System.Drawing.Point(287, 196);
            this.hardware_ComboBox.Name = "hardware_ComboBox";
            this.hardware_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.hardware_ComboBox.TabIndex = 2;
            this.hardware_ComboBox.Visible = false;
            this.hardware_ComboBox.SelectedIndexChanged += new System.EventHandler(this.hardware_ComboBox_SelectedIndexChanged);
            // 
            // delete_Label
            // 
            this.delete_Label.AutoSize = true;
            this.delete_Label.Location = new System.Drawing.Point(284, 45);
            this.delete_Label.Name = "delete_Label";
            this.delete_Label.Size = new System.Drawing.Size(155, 13);
            this.delete_Label.TabIndex = 3;
            this.delete_Label.Text = "Select asset you want to delete";
            // 
            // delete_Button
            // 
            this.delete_Button.BackColor = System.Drawing.Color.SandyBrown;
            this.delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Button.Location = new System.Drawing.Point(287, 363);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(75, 23);
            this.delete_Button.TabIndex = 4;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.Color.SandyBrown;
            this.back_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_Button.Location = new System.Drawing.Point(23, 45);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(75, 23);
            this.back_Button.TabIndex = 5;
            this.back_Button.Text = "Back";
            this.back_Button.UseVisualStyleBackColor = false;
            // 
            // deleteAsset_Label
            // 
            this.deleteAsset_Label.AutoSize = true;
            this.deleteAsset_Label.Location = new System.Drawing.Point(284, 158);
            this.deleteAsset_Label.Name = "deleteAsset_Label";
            this.deleteAsset_Label.Size = new System.Drawing.Size(221, 13);
            this.deleteAsset_Label.TabIndex = 6;
            this.deleteAsset_Label.Text = "Select item you want to delete from list below ";
            // 
            // printItem_Label
            // 
            this.printItem_Label.AutoSize = true;
            this.printItem_Label.Location = new System.Drawing.Point(287, 232);
            this.printItem_Label.Name = "printItem_Label";
            this.printItem_Label.Size = new System.Drawing.Size(0, 13);
            this.printItem_Label.TabIndex = 7;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printItem_Label);
            this.Controls.Add(this.deleteAsset_Label);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.delete_Label);
            this.Controls.Add(this.hardware_ComboBox);
            this.Controls.Add(this.software_ComboBox);
            this.Controls.Add(this.HS_ComboBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HS_ComboBox;
        private System.Windows.Forms.ComboBox software_ComboBox;
        private System.Windows.Forms.ComboBox hardware_ComboBox;
        private System.Windows.Forms.Label delete_Label;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Label deleteAsset_Label;
        private System.Windows.Forms.Label printItem_Label;
    }
}