namespace WindowsFormsApp1
{
    partial class Form2
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
            this.display_Btn = new System.Windows.Forms.Button();
            this.add_Btn = new System.Windows.Forms.Button();
            this.edit_Btn = new System.Windows.Forms.Button();
            this.logout_Btn = new System.Windows.Forms.Button();
            this.delete_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display_Btn
            // 
            this.display_Btn.BackColor = System.Drawing.Color.SandyBrown;
            this.display_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display_Btn.Location = new System.Drawing.Point(292, 67);
            this.display_Btn.Name = "display_Btn";
            this.display_Btn.Size = new System.Drawing.Size(75, 23);
            this.display_Btn.TabIndex = 0;
            this.display_Btn.Text = "Display";
            this.display_Btn.UseVisualStyleBackColor = false;
            this.display_Btn.Click += new System.EventHandler(this.display_Btn_Click);
            // 
            // add_Btn
            // 
            this.add_Btn.BackColor = System.Drawing.Color.SandyBrown;
            this.add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_Btn.Location = new System.Drawing.Point(430, 67);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(75, 23);
            this.add_Btn.TabIndex = 1;
            this.add_Btn.Text = "Add";
            this.add_Btn.UseVisualStyleBackColor = false;
            // 
            // edit_Btn
            // 
            this.edit_Btn.BackColor = System.Drawing.Color.SandyBrown;
            this.edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_Btn.Location = new System.Drawing.Point(430, 181);
            this.edit_Btn.Name = "edit_Btn";
            this.edit_Btn.Size = new System.Drawing.Size(75, 23);
            this.edit_Btn.TabIndex = 2;
            this.edit_Btn.Text = "Edit";
            this.edit_Btn.UseVisualStyleBackColor = false;
            // 
            // logout_Btn
            // 
            this.logout_Btn.BackColor = System.Drawing.Color.SandyBrown;
            this.logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_Btn.Location = new System.Drawing.Point(363, 255);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(75, 23);
            this.logout_Btn.TabIndex = 3;
            this.logout_Btn.Text = "Logout";
            this.logout_Btn.UseVisualStyleBackColor = false;
            // 
            // delete_Btn
            // 
            this.delete_Btn.BackColor = System.Drawing.Color.SandyBrown;
            this.delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Btn.Location = new System.Drawing.Point(291, 181);
            this.delete_Btn.Name = "delete_Btn";
            this.delete_Btn.Size = new System.Drawing.Size(75, 23);
            this.delete_Btn.TabIndex = 4;
            this.delete_Btn.Text = "Delete";
            this.delete_Btn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_Btn);
            this.Controls.Add(this.logout_Btn);
            this.Controls.Add(this.edit_Btn);
            this.Controls.Add(this.add_Btn);
            this.Controls.Add(this.display_Btn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button display_Btn;
        private System.Windows.Forms.Button add_Btn;
        private System.Windows.Forms.Button edit_Btn;
        private System.Windows.Forms.Button logout_Btn;
        private System.Windows.Forms.Button delete_Btn;
    }
}