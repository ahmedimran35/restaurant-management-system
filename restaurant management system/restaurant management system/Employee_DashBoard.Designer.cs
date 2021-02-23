namespace restaurant_management_system
{
    partial class Employee_DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.empl_dash_btn_profile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.empl_dash_btn_mail = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.emp_logout = new System.Windows.Forms.Button();
            this.uc_Update_em_profile1 = new restaurant_management_system.uc_Update_em_profile();
            this.uc_Sending_email1 = new restaurant_management_system.uc_Sending_email();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 538);
            this.panel1.TabIndex = 0;
            // 
            // empl_dash_btn_profile
            // 
            this.empl_dash_btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empl_dash_btn_profile.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empl_dash_btn_profile.ForeColor = System.Drawing.Color.White;
            this.empl_dash_btn_profile.Location = new System.Drawing.Point(244, 14);
            this.empl_dash_btn_profile.Margin = new System.Windows.Forms.Padding(0);
            this.empl_dash_btn_profile.Name = "empl_dash_btn_profile";
            this.empl_dash_btn_profile.Size = new System.Drawing.Size(165, 40);
            this.empl_dash_btn_profile.TabIndex = 0;
            this.empl_dash_btn_profile.Text = "Profile";
            this.empl_dash_btn_profile.UseVisualStyleBackColor = false;
            this.empl_dash_btn_profile.Click += new System.EventHandler(this.empl_dash_btn_profile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 23);
            this.panel3.TabIndex = 2;
            // 
            // empl_dash_btn_mail
            // 
            this.empl_dash_btn_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empl_dash_btn_mail.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empl_dash_btn_mail.ForeColor = System.Drawing.Color.White;
            this.empl_dash_btn_mail.Location = new System.Drawing.Point(645, 13);
            this.empl_dash_btn_mail.Name = "empl_dash_btn_mail";
            this.empl_dash_btn_mail.Size = new System.Drawing.Size(144, 39);
            this.empl_dash_btn_mail.TabIndex = 3;
            this.empl_dash_btn_mail.Text = "Send Email";
            this.empl_dash_btn_mail.UseVisualStyleBackColor = false;
            this.empl_dash_btn_mail.Click += new System.EventHandler(this.empl_dash_btn_mail_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.uc_Update_em_profile1);
            this.panel4.Controls.Add(this.uc_Sending_email1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(12, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1054, 471);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(279, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(390, 360);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(1044, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 61);
            this.panel5.TabIndex = 5;
            // 
            // emp_logout
            // 
            this.emp_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.emp_logout.Location = new System.Drawing.Point(935, 17);
            this.emp_logout.Name = "emp_logout";
            this.emp_logout.Size = new System.Drawing.Size(103, 34);
            this.emp_logout.TabIndex = 6;
            this.emp_logout.Text = "Log Out";
            this.emp_logout.UseVisualStyleBackColor = false;
            this.emp_logout.Click += new System.EventHandler(this.emp_logout_Click);
            // 
            // uc_Update_em_profile1
            // 
            this.uc_Update_em_profile1.Location = new System.Drawing.Point(-9, 3);
            this.uc_Update_em_profile1.Name = "uc_Update_em_profile1";
            this.uc_Update_em_profile1.Size = new System.Drawing.Size(1054, 456);
            this.uc_Update_em_profile1.TabIndex = 1;
            this.uc_Update_em_profile1.Load += new System.EventHandler(this.uc_Update_em_profile1_Load_1);
            // 
            // uc_Sending_email1
            // 
            this.uc_Sending_email1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.uc_Sending_email1.Location = new System.Drawing.Point(-9, 3);
            this.uc_Sending_email1.Name = "uc_Sending_email1";
            this.uc_Sending_email1.Size = new System.Drawing.Size(1051, 462);
            this.uc_Sending_email1.TabIndex = 0;
            // 
            // Employee_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 535);
            this.Controls.Add(this.emp_logout);
            this.Controls.Add(this.empl_dash_btn_mail);
            this.Controls.Add(this.empl_dash_btn_profile);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Name = "Employee_DashBoard";
            this.Text = "Employee_DashBoard";
            this.Load += new System.EventHandler(this.Employee_DashBoard_Load);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button empl_dash_btn_profile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button empl_dash_btn_mail;
        private System.Windows.Forms.Panel panel4;
        private uc_Sending_email uc_Sending_email1;
        private System.Windows.Forms.Panel panel5;
        private uc_Update_em_profile uc_Update_em_profile1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button emp_logout;
    }
}