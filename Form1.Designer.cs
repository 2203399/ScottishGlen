namespace WindowsFormsApp1
{
    partial class Form1
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
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.username_Textbox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.username_Label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // password_Textbox
            // 
            this.password_Textbox.Location = new System.Drawing.Point(366, 222);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(100, 20);
            this.password_Textbox.TabIndex = 0;
            // 
            // username_Textbox
            // 
            this.username_Textbox.Location = new System.Drawing.Point(366, 144);
            this.username_Textbox.Name = "username_Textbox";
            this.username_Textbox.Size = new System.Drawing.Size(100, 20);
            this.username_Textbox.TabIndex = 1;
            // 
            // login_Button
            // 
            this.login_Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.login_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Button.Location = new System.Drawing.Point(366, 305);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(75, 23);
            this.login_Button.TabIndex = 2;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = false;
            // 
            // username_Label
            // 
            this.username_Label.AutoSize = true;
            this.username_Label.Location = new System.Drawing.Point(262, 144);
            this.username_Label.Name = "username_Label";
            this.username_Label.Size = new System.Drawing.Size(55, 13);
            this.username_Label.TabIndex = 3;
            this.username_Label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(264, 222);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_Label);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.username_Textbox);
            this.Controls.Add(this.password_Textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.TextBox username_Textbox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Label username_Label;
        private System.Windows.Forms.Label password_label;
    }
}

