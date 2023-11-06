using System.Windows.Forms;

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
            this.login_Btn = new System.Windows.Forms.Button();
            this.username_Lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_TxtBox = new System.Windows.Forms.TextBox();
            this.password_TxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.Color.SandyBrown;
            this.login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Btn.Location = new System.Drawing.Point(342, 248);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(95, 29);
            this.login_Btn.TabIndex = 0;
            this.login_Btn.Text = "Login";
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // username_Lbl
            // 
            this.username_Lbl.AutoSize = true;
            this.username_Lbl.Location = new System.Drawing.Point(281, 101);
            this.username_Lbl.Name = "username_Lbl";
            this.username_Lbl.Size = new System.Drawing.Size(55, 13);
            this.username_Lbl.TabIndex = 1;
            this.username_Lbl.Text = "Username";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Location = new System.Drawing.Point(281, 180);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(53, 13);
            this.password_lbl.TabIndex = 2;
            this.password_lbl.Text = "Password";
            // 
            // username_TxtBox
            // 
            this.username_TxtBox.Location = new System.Drawing.Point(342, 101);
            this.username_TxtBox.Name = "username_TxtBox";
            this.username_TxtBox.Size = new System.Drawing.Size(100, 20);
            this.username_TxtBox.TabIndex = 3;
            // 
            // password_TxtBox
            // 
            this.password_TxtBox.Location = new System.Drawing.Point(342, 180);
            this.password_TxtBox.Name = "password_TxtBox";
            this.password_TxtBox.Size = new System.Drawing.Size(100, 20);
            this.password_TxtBox.TabIndex = 4;
            this.password_TxtBox.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(776, 418);
            this.Controls.Add(this.password_TxtBox);
            this.Controls.Add(this.username_TxtBox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_Lbl);
            this.Controls.Add(this.login_Btn);
            this.Name = "Form1";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

      
        private Button login_Btn;
        private Label username_Lbl;
        private Label password_lbl;
        private TextBox username_TxtBox;
        private TextBox password_TxtBox;
    }
}

