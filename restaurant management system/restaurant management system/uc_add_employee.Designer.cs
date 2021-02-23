namespace restaurant_management_system
{
    partial class uc_add_employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uc_addemployee_id = new System.Windows.Forms.TextBox();
            this.uc_addemployee_name = new System.Windows.Forms.TextBox();
            this.cmbpostion = new System.Windows.Forms.ComboBox();
            this.uc_addemployee_salary = new System.Windows.Forms.TextBox();
            this.uc_addemployee_lbl_id = new System.Windows.Forms.Label();
            this.uc_addemployee_lbl_name = new System.Windows.Forms.Label();
            this.uc_addemployee_lbl_postion = new System.Windows.Forms.Label();
            this.uc_addemployee_lbl_salary = new System.Windows.Forms.Label();
            this.uc_addemployee_btn_SAVE = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uc_addemployee_pass = new System.Windows.Forms.TextBox();
            this.uc_addemployee_lbl_pass = new System.Windows.Forms.Label();
            this.uc_addemployee_lbl_num = new System.Windows.Forms.Label();
            this.uc_addemployee_num = new System.Windows.Forms.TextBox();
            this.add_employee_gradeview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uc_addemployee_btn_update = new System.Windows.Forms.Button();
            this.uc_addemployee_btn_reset = new System.Windows.Forms.Button();
            this.uc_addemployee_btn_DELETE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.add_employee_gradeview)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_addemployee_id
            // 
            this.uc_addemployee_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_addemployee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_id.Location = new System.Drawing.Point(25, 69);
            this.uc_addemployee_id.Name = "uc_addemployee_id";
            this.uc_addemployee_id.Size = new System.Drawing.Size(326, 34);
            this.uc_addemployee_id.TabIndex = 0;
            this.uc_addemployee_id.TextChanged += new System.EventHandler(this.uc_addemployee_id_TextChanged);
            // 
            // uc_addemployee_name
            // 
            this.uc_addemployee_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_addemployee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_name.Location = new System.Drawing.Point(25, 158);
            this.uc_addemployee_name.Name = "uc_addemployee_name";
            this.uc_addemployee_name.Size = new System.Drawing.Size(326, 34);
            this.uc_addemployee_name.TabIndex = 0;
            this.uc_addemployee_name.TextChanged += new System.EventHandler(this.uc_addemployee_name_TextChanged);
            // 
            // cmbpostion
            // 
            this.cmbpostion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbpostion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpostion.FormattingEnabled = true;
            this.cmbpostion.Items.AddRange(new object[] {
            "Chef",
            "Cleaner",
            "Dishwasher",
            "Main Chef",
            "Waiter "});
            this.cmbpostion.Location = new System.Drawing.Point(25, 251);
            this.cmbpostion.Name = "cmbpostion";
            this.cmbpostion.Size = new System.Drawing.Size(326, 37);
            this.cmbpostion.Sorted = true;
            this.cmbpostion.TabIndex = 1;
            this.cmbpostion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uc_addemployee_salary
            // 
            this.uc_addemployee_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_addemployee_salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_salary.Location = new System.Drawing.Point(448, 251);
            this.uc_addemployee_salary.Name = "uc_addemployee_salary";
            this.uc_addemployee_salary.Size = new System.Drawing.Size(315, 34);
            this.uc_addemployee_salary.TabIndex = 2;
            this.uc_addemployee_salary.TextChanged += new System.EventHandler(this.uc_addemployee_salary_TextChanged);
            // 
            // uc_addemployee_lbl_id
            // 
            this.uc_addemployee_lbl_id.AutoSize = true;
            this.uc_addemployee_lbl_id.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_lbl_id.Location = new System.Drawing.Point(33, 42);
            this.uc_addemployee_lbl_id.Name = "uc_addemployee_lbl_id";
            this.uc_addemployee_lbl_id.Size = new System.Drawing.Size(113, 24);
            this.uc_addemployee_lbl_id.TabIndex = 3;
            this.uc_addemployee_lbl_id.Text = "Employee ID";
            this.uc_addemployee_lbl_id.Click += new System.EventHandler(this.uc_addemployee_lbl_id_Click);
            // 
            // uc_addemployee_lbl_name
            // 
            this.uc_addemployee_lbl_name.AutoSize = true;
            this.uc_addemployee_lbl_name.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_lbl_name.Location = new System.Drawing.Point(33, 131);
            this.uc_addemployee_lbl_name.Name = "uc_addemployee_lbl_name";
            this.uc_addemployee_lbl_name.Size = new System.Drawing.Size(133, 24);
            this.uc_addemployee_lbl_name.TabIndex = 3;
            this.uc_addemployee_lbl_name.Text = "Employee name";
            this.uc_addemployee_lbl_name.Click += new System.EventHandler(this.uc_addemployee_lbl_name_Click);
            // 
            // uc_addemployee_lbl_postion
            // 
            this.uc_addemployee_lbl_postion.AutoSize = true;
            this.uc_addemployee_lbl_postion.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_lbl_postion.Location = new System.Drawing.Point(21, 224);
            this.uc_addemployee_lbl_postion.Name = "uc_addemployee_lbl_postion";
            this.uc_addemployee_lbl_postion.Size = new System.Drawing.Size(150, 24);
            this.uc_addemployee_lbl_postion.TabIndex = 3;
            this.uc_addemployee_lbl_postion.Text = "Employee Postion";
            this.uc_addemployee_lbl_postion.Click += new System.EventHandler(this.uc_addemployee_lbl_postion_Click);
            // 
            // uc_addemployee_lbl_salary
            // 
            this.uc_addemployee_lbl_salary.AutoSize = true;
            this.uc_addemployee_lbl_salary.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_lbl_salary.Location = new System.Drawing.Point(444, 224);
            this.uc_addemployee_lbl_salary.Name = "uc_addemployee_lbl_salary";
            this.uc_addemployee_lbl_salary.Size = new System.Drawing.Size(144, 24);
            this.uc_addemployee_lbl_salary.TabIndex = 3;
            this.uc_addemployee_lbl_salary.Text = "Employee Salary";
            this.uc_addemployee_lbl_salary.Click += new System.EventHandler(this.uc_addemployee_lbl_salary_Click);
            // 
            // uc_addemployee_btn_SAVE
            // 
            this.uc_addemployee_btn_SAVE.BackColor = System.Drawing.Color.White;
            this.uc_addemployee_btn_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_btn_SAVE.ForeColor = System.Drawing.Color.Black;
            this.uc_addemployee_btn_SAVE.Location = new System.Drawing.Point(47, 327);
            this.uc_addemployee_btn_SAVE.Name = "uc_addemployee_btn_SAVE";
            this.uc_addemployee_btn_SAVE.Size = new System.Drawing.Size(189, 42);
            this.uc_addemployee_btn_SAVE.TabIndex = 4;
            this.uc_addemployee_btn_SAVE.Text = "SAVE";
            this.uc_addemployee_btn_SAVE.UseVisualStyleBackColor = false;
            this.uc_addemployee_btn_SAVE.Click += new System.EventHandler(this.uc_addemployee_btn_ADD_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(931, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 579);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 10);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(0, 570);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(944, 11);
            this.panel4.TabIndex = 7;
            // 
            // uc_addemployee_pass
            // 
            this.uc_addemployee_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_addemployee_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_pass.Location = new System.Drawing.Point(450, 69);
            this.uc_addemployee_pass.Name = "uc_addemployee_pass";
            this.uc_addemployee_pass.Size = new System.Drawing.Size(313, 34);
            this.uc_addemployee_pass.TabIndex = 0;
            this.uc_addemployee_pass.TextChanged += new System.EventHandler(this.uc_addemployee_id_TextChanged);
            // 
            // uc_addemployee_lbl_pass
            // 
            this.uc_addemployee_lbl_pass.AutoSize = true;
            this.uc_addemployee_lbl_pass.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_lbl_pass.Location = new System.Drawing.Point(446, 42);
            this.uc_addemployee_lbl_pass.Name = "uc_addemployee_lbl_pass";
            this.uc_addemployee_lbl_pass.Size = new System.Drawing.Size(175, 24);
            this.uc_addemployee_lbl_pass.TabIndex = 3;
            this.uc_addemployee_lbl_pass.Text = "Employee Passsword";
            this.uc_addemployee_lbl_pass.Click += new System.EventHandler(this.uc_addemployee_lbl_id_Click);
            // 
            // uc_addemployee_lbl_num
            // 
            this.uc_addemployee_lbl_num.AutoSize = true;
            this.uc_addemployee_lbl_num.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_lbl_num.Location = new System.Drawing.Point(446, 131);
            this.uc_addemployee_lbl_num.Name = "uc_addemployee_lbl_num";
            this.uc_addemployee_lbl_num.Size = new System.Drawing.Size(142, 24);
            this.uc_addemployee_lbl_num.TabIndex = 3;
            this.uc_addemployee_lbl_num.Text = "Contact Number";
            this.uc_addemployee_lbl_num.Click += new System.EventHandler(this.uc_addemployee_lbl_id_Click);
            // 
            // uc_addemployee_num
            // 
            this.uc_addemployee_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_addemployee_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_num.Location = new System.Drawing.Point(450, 158);
            this.uc_addemployee_num.Name = "uc_addemployee_num";
            this.uc_addemployee_num.Size = new System.Drawing.Size(313, 34);
            this.uc_addemployee_num.TabIndex = 0;
            this.uc_addemployee_num.TextChanged += new System.EventHandler(this.uc_addemployee_id_TextChanged);
            // 
            // add_employee_gradeview
            // 
            this.add_employee_gradeview.AllowUserToDeleteRows = false;
            this.add_employee_gradeview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.add_employee_gradeview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.add_employee_gradeview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.postion,
            this.salary,
            this.total_sell,
            this.password,
            this.number});
            this.add_employee_gradeview.Location = new System.Drawing.Point(25, 387);
            this.add_employee_gradeview.Name = "add_employee_gradeview";
            this.add_employee_gradeview.ReadOnly = true;
            this.add_employee_gradeview.RowHeadersWidth = 51;
            this.add_employee_gradeview.RowTemplate.Height = 24;
            this.add_employee_gradeview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.add_employee_gradeview.Size = new System.Drawing.Size(885, 177);
            this.add_employee_gradeview.TabIndex = 8;
            this.add_employee_gradeview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.add_employee_gradeview_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.id.DefaultCellStyle = dataGridViewCellStyle5;
            this.id.HeaderText = "Employee ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Employee Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // postion
            // 
            this.postion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postion.DataPropertyName = "postion";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.postion.DefaultCellStyle = dataGridViewCellStyle6;
            this.postion.HeaderText = "Employee Postion";
            this.postion.MinimumWidth = 6;
            this.postion.Name = "postion";
            this.postion.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            this.salary.HeaderText = "Employee Salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // total_sell
            // 
            this.total_sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_sell.DataPropertyName = "total_sell";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.total_sell.DefaultCellStyle = dataGridViewCellStyle7;
            this.total_sell.HeaderText = "Employee Sell";
            this.total_sell.MinimumWidth = 6;
            this.total_sell.Name = "total_sell";
            this.total_sell.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.DataPropertyName = "number";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.number.DefaultCellStyle = dataGridViewCellStyle8;
            this.number.HeaderText = "Contact Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // uc_addemployee_btn_update
            // 
            this.uc_addemployee_btn_update.BackColor = System.Drawing.Color.White;
            this.uc_addemployee_btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_btn_update.Location = new System.Drawing.Point(262, 327);
            this.uc_addemployee_btn_update.Name = "uc_addemployee_btn_update";
            this.uc_addemployee_btn_update.Size = new System.Drawing.Size(184, 42);
            this.uc_addemployee_btn_update.TabIndex = 9;
            this.uc_addemployee_btn_update.Text = "UPDATE";
            this.uc_addemployee_btn_update.UseVisualStyleBackColor = false;
            this.uc_addemployee_btn_update.Click += new System.EventHandler(this.uc_addemployee_btn_update_Click);
            // 
            // uc_addemployee_btn_reset
            // 
            this.uc_addemployee_btn_reset.BackColor = System.Drawing.Color.White;
            this.uc_addemployee_btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_btn_reset.Location = new System.Drawing.Point(685, 327);
            this.uc_addemployee_btn_reset.Name = "uc_addemployee_btn_reset";
            this.uc_addemployee_btn_reset.Size = new System.Drawing.Size(154, 42);
            this.uc_addemployee_btn_reset.TabIndex = 10;
            this.uc_addemployee_btn_reset.Text = "RESET";
            this.uc_addemployee_btn_reset.UseVisualStyleBackColor = false;
            this.uc_addemployee_btn_reset.Click += new System.EventHandler(this.uc_addemployee_btn_reset_Click);
            // 
            // uc_addemployee_btn_DELETE
            // 
            this.uc_addemployee_btn_DELETE.BackColor = System.Drawing.Color.White;
            this.uc_addemployee_btn_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_addemployee_btn_DELETE.Location = new System.Drawing.Point(485, 327);
            this.uc_addemployee_btn_DELETE.Name = "uc_addemployee_btn_DELETE";
            this.uc_addemployee_btn_DELETE.Size = new System.Drawing.Size(170, 42);
            this.uc_addemployee_btn_DELETE.TabIndex = 11;
            this.uc_addemployee_btn_DELETE.Text = "DELETE";
            this.uc_addemployee_btn_DELETE.UseVisualStyleBackColor = false;
            this.uc_addemployee_btn_DELETE.Click += new System.EventHandler(this.uc_addemployee_btn_DELETE_Click);
            // 
            // uc_add_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.uc_addemployee_btn_DELETE);
            this.Controls.Add(this.uc_addemployee_btn_reset);
            this.Controls.Add(this.uc_addemployee_btn_update);
            this.Controls.Add(this.add_employee_gradeview);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uc_addemployee_btn_SAVE);
            this.Controls.Add(this.uc_addemployee_lbl_name);
            this.Controls.Add(this.uc_addemployee_lbl_postion);
            this.Controls.Add(this.uc_addemployee_lbl_salary);
            this.Controls.Add(this.uc_addemployee_lbl_num);
            this.Controls.Add(this.uc_addemployee_lbl_pass);
            this.Controls.Add(this.uc_addemployee_lbl_id);
            this.Controls.Add(this.uc_addemployee_salary);
            this.Controls.Add(this.cmbpostion);
            this.Controls.Add(this.uc_addemployee_name);
            this.Controls.Add(this.uc_addemployee_num);
            this.Controls.Add(this.uc_addemployee_pass);
            this.Controls.Add(this.uc_addemployee_id);
            this.Name = "uc_add_employee";
            this.Size = new System.Drawing.Size(946, 582);
            this.Load += new System.EventHandler(this.uc_add_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_employee_gradeview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uc_addemployee_id;
        private System.Windows.Forms.TextBox uc_addemployee_name;
        private System.Windows.Forms.ComboBox cmbpostion;
        private System.Windows.Forms.TextBox uc_addemployee_salary;
        private System.Windows.Forms.Label uc_addemployee_lbl_id;
        private System.Windows.Forms.Label uc_addemployee_lbl_name;
        private System.Windows.Forms.Label uc_addemployee_lbl_postion;
        private System.Windows.Forms.Label uc_addemployee_lbl_salary;
        private System.Windows.Forms.Button uc_addemployee_btn_SAVE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox uc_addemployee_pass;
        private System.Windows.Forms.Label uc_addemployee_lbl_pass;
        private System.Windows.Forms.Label uc_addemployee_lbl_num;
        private System.Windows.Forms.TextBox uc_addemployee_num;
        private System.Windows.Forms.DataGridView add_employee_gradeview;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn postion;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.Button uc_addemployee_btn_update;
        private System.Windows.Forms.Button uc_addemployee_btn_reset;
        private System.Windows.Forms.Button uc_addemployee_btn_DELETE;
    }
}
