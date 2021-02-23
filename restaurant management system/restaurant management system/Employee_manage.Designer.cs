namespace restaurant_management_system
{
    partial class Employee_manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_manage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_total_Back = new System.Windows.Forms.Button();
            this.btn_Add_Manage_employee = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelx = new System.Windows.Forms.Panel();
            this.pic_fisher = new System.Windows.Forms.PictureBox();
            this.uc_add_employee1 = new restaurant_management_system.uc_add_employee();
            this.panel1.SuspendLayout();
            this.panelx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fisher)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_total_Back);
            this.panel1.Controls.Add(this.btn_Add_Manage_employee);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 10);
            this.panel4.TabIndex = 2;
            // 
            // btn_total_Back
            // 
            this.btn_total_Back.BackColor = System.Drawing.Color.Teal;
            this.btn_total_Back.ForeColor = System.Drawing.Color.Black;
            this.btn_total_Back.Location = new System.Drawing.Point(25, 544);
            this.btn_total_Back.Name = "btn_total_Back";
            this.btn_total_Back.Size = new System.Drawing.Size(217, 34);
            this.btn_total_Back.TabIndex = 0;
            this.btn_total_Back.Text = " 🡰   Back ";
            this.btn_total_Back.UseVisualStyleBackColor = false;
            this.btn_total_Back.Click += new System.EventHandler(this.btn_total_Back_Click);
            // 
            // btn_Add_Manage_employee
            // 
            this.btn_Add_Manage_employee.BackColor = System.Drawing.Color.White;
            this.btn_Add_Manage_employee.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Manage_employee.Location = new System.Drawing.Point(25, 163);
            this.btn_Add_Manage_employee.Name = "btn_Add_Manage_employee";
            this.btn_Add_Manage_employee.Size = new System.Drawing.Size(208, 40);
            this.btn_Add_Manage_employee.TabIndex = 0;
            this.btn_Add_Manage_employee.Text = "Manage Employee";
            this.btn_Add_Manage_employee.UseVisualStyleBackColor = false;
            this.btn_Add_Manage_employee.Click += new System.EventHandler(this.btn_Add_employee_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(264, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 578);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 578);
            this.panel2.TabIndex = 1;
            // 
            // panelx
            // 
            this.panelx.Controls.Add(this.uc_add_employee1);
            this.panelx.Controls.Add(this.pic_fisher);
            this.panelx.Location = new System.Drawing.Point(275, 1);
            this.panelx.Name = "panelx";
            this.panelx.Size = new System.Drawing.Size(942, 581);
            this.panelx.TabIndex = 1;
            this.panelx.Paint += new System.Windows.Forms.PaintEventHandler(this.panelx_Paint);
            // 
            // pic_fisher
            // 
            this.pic_fisher.Image = ((System.Drawing.Image)(resources.GetObject("pic_fisher.Image")));
            this.pic_fisher.Location = new System.Drawing.Point(0, 0);
            this.pic_fisher.Name = "pic_fisher";
            this.pic_fisher.Size = new System.Drawing.Size(942, 581);
            this.pic_fisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fisher.TabIndex = 1;
            this.pic_fisher.TabStop = false;
            // 
            // uc_add_employee1
            // 
            this.uc_add_employee1.BackColor = System.Drawing.Color.Silver;
            this.uc_add_employee1.Location = new System.Drawing.Point(0, 0);
            this.uc_add_employee1.Name = "uc_add_employee1";
            this.uc_add_employee1.Size = new System.Drawing.Size(946, 582);
            this.uc_add_employee1.TabIndex = 2;
            this.uc_add_employee1.Load += new System.EventHandler(this.uc_add_employee1_Load_1);
            // 
            // Employee_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 579);
            this.Controls.Add(this.panelx);
            this.Controls.Add(this.panel1);
            this.Name = "Employee_manage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_manage";
            this.panel1.ResumeLayout(false);
            this.panelx.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_fisher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Add_Manage_employee;
        private System.Windows.Forms.Button btn_total_Back;
        private System.Windows.Forms.Panel panelx;
        private System.Windows.Forms.PictureBox pic_fisher;
        private uc_add_employee uc_add_employee1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}