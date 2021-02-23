namespace restaurant_management_system
{
    partial class uc_accessories_manage
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
            this.Accessories_grade_view = new System.Windows.Forms.DataGridView();
            this.Acces_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uc_access_lbl_ec_bill = new System.Windows.Forms.Label();
            this.uc_access_txt_ec_bill = new System.Windows.Forms.TextBox();
            this.uc_access_lbl_gas_bill = new System.Windows.Forms.Label();
            this.uc_access_txt_gas_bill = new System.Windows.Forms.TextBox();
            this.uc_access_lbl_water_bill = new System.Windows.Forms.Label();
            this.uc_access_txt_water_bill = new System.Windows.Forms.TextBox();
            this.uc_access_lbl_equip_bill = new System.Windows.Forms.Label();
            this.uc_access_txt_equip_bill = new System.Windows.Forms.TextBox();
            this.uc_access_lbl_sec_bill = new System.Windows.Forms.Label();
            this.uc_access_txt_sec_bill = new System.Windows.Forms.TextBox();
            this.Acces_Total_Cost = new System.Windows.Forms.Button();
            this.electricitybill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterbill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.security = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Accessories_grade_view)).BeginInit();
            this.SuspendLayout();
            // 
            // Accessories_grade_view
            // 
            this.Accessories_grade_view.AllowUserToDeleteRows = false;
            this.Accessories_grade_view.BackgroundColor = System.Drawing.Color.Silver;
            this.Accessories_grade_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accessories_grade_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.electricitybill,
            this.gasbill,
            this.waterbill,
            this.equipment,
            this.security});
            this.Accessories_grade_view.Location = new System.Drawing.Point(14, 365);
            this.Accessories_grade_view.Name = "Accessories_grade_view";
            this.Accessories_grade_view.ReadOnly = true;
            this.Accessories_grade_view.RowHeadersWidth = 51;
            this.Accessories_grade_view.RowTemplate.Height = 24;
            this.Accessories_grade_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Accessories_grade_view.Size = new System.Drawing.Size(745, 186);
            this.Accessories_grade_view.TabIndex = 0;
            this.Accessories_grade_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Accessories_grade_view_CellContentClick);
            // 
            // Acces_save
            // 
            this.Acces_save.BackColor = System.Drawing.Color.White;
            this.Acces_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acces_save.Location = new System.Drawing.Point(49, 307);
            this.Acces_save.Name = "Acces_save";
            this.Acces_save.Size = new System.Drawing.Size(133, 39);
            this.Acces_save.TabIndex = 1;
            this.Acces_save.Text = "Save";
            this.Acces_save.UseVisualStyleBackColor = false;
            this.Acces_save.Click += new System.EventHandler(this.Acces_save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 550);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(760, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 550);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 14);
            this.panel3.TabIndex = 3;
            // 
            // uc_access_lbl_ec_bill
            // 
            this.uc_access_lbl_ec_bill.AutoSize = true;
            this.uc_access_lbl_ec_bill.BackColor = System.Drawing.Color.Black;
            this.uc_access_lbl_ec_bill.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_access_lbl_ec_bill.ForeColor = System.Drawing.Color.White;
            this.uc_access_lbl_ec_bill.Location = new System.Drawing.Point(16, 78);
            this.uc_access_lbl_ec_bill.Name = "uc_access_lbl_ec_bill";
            this.uc_access_lbl_ec_bill.Size = new System.Drawing.Size(108, 19);
            this.uc_access_lbl_ec_bill.TabIndex = 4;
            this.uc_access_lbl_ec_bill.Text = "Electricity Bill";
            // 
            // uc_access_txt_ec_bill
            // 
            this.uc_access_txt_ec_bill.Location = new System.Drawing.Point(19, 99);
            this.uc_access_txt_ec_bill.Multiline = true;
            this.uc_access_txt_ec_bill.Name = "uc_access_txt_ec_bill";
            this.uc_access_txt_ec_bill.Size = new System.Drawing.Size(195, 30);
            this.uc_access_txt_ec_bill.TabIndex = 5;
            // 
            // uc_access_lbl_gas_bill
            // 
            this.uc_access_lbl_gas_bill.AutoSize = true;
            this.uc_access_lbl_gas_bill.BackColor = System.Drawing.Color.Black;
            this.uc_access_lbl_gas_bill.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_access_lbl_gas_bill.ForeColor = System.Drawing.Color.White;
            this.uc_access_lbl_gas_bill.Location = new System.Drawing.Point(266, 78);
            this.uc_access_lbl_gas_bill.Name = "uc_access_lbl_gas_bill";
            this.uc_access_lbl_gas_bill.Size = new System.Drawing.Size(61, 19);
            this.uc_access_lbl_gas_bill.TabIndex = 4;
            this.uc_access_lbl_gas_bill.Text = "Gas Bill";
            // 
            // uc_access_txt_gas_bill
            // 
            this.uc_access_txt_gas_bill.Location = new System.Drawing.Point(269, 99);
            this.uc_access_txt_gas_bill.Multiline = true;
            this.uc_access_txt_gas_bill.Name = "uc_access_txt_gas_bill";
            this.uc_access_txt_gas_bill.Size = new System.Drawing.Size(195, 30);
            this.uc_access_txt_gas_bill.TabIndex = 5;
            // 
            // uc_access_lbl_water_bill
            // 
            this.uc_access_lbl_water_bill.AutoSize = true;
            this.uc_access_lbl_water_bill.BackColor = System.Drawing.Color.Black;
            this.uc_access_lbl_water_bill.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_access_lbl_water_bill.ForeColor = System.Drawing.Color.White;
            this.uc_access_lbl_water_bill.Location = new System.Drawing.Point(510, 78);
            this.uc_access_lbl_water_bill.Name = "uc_access_lbl_water_bill";
            this.uc_access_lbl_water_bill.Size = new System.Drawing.Size(81, 19);
            this.uc_access_lbl_water_bill.TabIndex = 4;
            this.uc_access_lbl_water_bill.Text = "Water Bill";
            // 
            // uc_access_txt_water_bill
            // 
            this.uc_access_txt_water_bill.Location = new System.Drawing.Point(513, 99);
            this.uc_access_txt_water_bill.Multiline = true;
            this.uc_access_txt_water_bill.Name = "uc_access_txt_water_bill";
            this.uc_access_txt_water_bill.Size = new System.Drawing.Size(195, 30);
            this.uc_access_txt_water_bill.TabIndex = 5;
            // 
            // uc_access_lbl_equip_bill
            // 
            this.uc_access_lbl_equip_bill.AutoSize = true;
            this.uc_access_lbl_equip_bill.BackColor = System.Drawing.Color.Black;
            this.uc_access_lbl_equip_bill.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_access_lbl_equip_bill.ForeColor = System.Drawing.Color.White;
            this.uc_access_lbl_equip_bill.Location = new System.Drawing.Point(19, 180);
            this.uc_access_lbl_equip_bill.Name = "uc_access_lbl_equip_bill";
            this.uc_access_lbl_equip_bill.Size = new System.Drawing.Size(103, 19);
            this.uc_access_lbl_equip_bill.TabIndex = 4;
            this.uc_access_lbl_equip_bill.Text = "Equipment Bill";
            // 
            // uc_access_txt_equip_bill
            // 
            this.uc_access_txt_equip_bill.Location = new System.Drawing.Point(22, 201);
            this.uc_access_txt_equip_bill.Multiline = true;
            this.uc_access_txt_equip_bill.Name = "uc_access_txt_equip_bill";
            this.uc_access_txt_equip_bill.Size = new System.Drawing.Size(195, 30);
            this.uc_access_txt_equip_bill.TabIndex = 5;
            // 
            // uc_access_lbl_sec_bill
            // 
            this.uc_access_lbl_sec_bill.AutoSize = true;
            this.uc_access_lbl_sec_bill.BackColor = System.Drawing.Color.Black;
            this.uc_access_lbl_sec_bill.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_access_lbl_sec_bill.ForeColor = System.Drawing.Color.White;
            this.uc_access_lbl_sec_bill.Location = new System.Drawing.Point(266, 180);
            this.uc_access_lbl_sec_bill.Name = "uc_access_lbl_sec_bill";
            this.uc_access_lbl_sec_bill.Size = new System.Drawing.Size(94, 19);
            this.uc_access_lbl_sec_bill.TabIndex = 4;
            this.uc_access_lbl_sec_bill.Text = "Security Bill";
            // 
            // uc_access_txt_sec_bill
            // 
            this.uc_access_txt_sec_bill.Location = new System.Drawing.Point(269, 201);
            this.uc_access_txt_sec_bill.Multiline = true;
            this.uc_access_txt_sec_bill.Name = "uc_access_txt_sec_bill";
            this.uc_access_txt_sec_bill.Size = new System.Drawing.Size(195, 30);
            this.uc_access_txt_sec_bill.TabIndex = 5;
            // 
            // Acces_Total_Cost
            // 
            this.Acces_Total_Cost.BackColor = System.Drawing.Color.White;
            this.Acces_Total_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acces_Total_Cost.Location = new System.Drawing.Point(230, 308);
            this.Acces_Total_Cost.Name = "Acces_Total_Cost";
            this.Acces_Total_Cost.Size = new System.Drawing.Size(130, 39);
            this.Acces_Total_Cost.TabIndex = 6;
            this.Acces_Total_Cost.Text = "Total Cost = ";
            this.Acces_Total_Cost.UseVisualStyleBackColor = false;
            this.Acces_Total_Cost.Click += new System.EventHandler(this.Acces_Total_Cost_Click);
            // 
            // electricitybill
            // 
            this.electricitybill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.electricitybill.DataPropertyName = "electricity bill";
            this.electricitybill.HeaderText = "Electricity Bill";
            this.electricitybill.MinimumWidth = 6;
            this.electricitybill.Name = "electricitybill";
            // 
            // gasbill
            // 
            this.gasbill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gasbill.DataPropertyName = "gas bill";
            this.gasbill.HeaderText = "Gas Bill";
            this.gasbill.MinimumWidth = 6;
            this.gasbill.Name = "gasbill";
            // 
            // waterbill
            // 
            this.waterbill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waterbill.DataPropertyName = "water bill";
            this.waterbill.HeaderText = "Water Bill";
            this.waterbill.MinimumWidth = 6;
            this.waterbill.Name = "waterbill";
            // 
            // equipment
            // 
            this.equipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.equipment.DataPropertyName = "equipment";
            this.equipment.HeaderText = "Equipment";
            this.equipment.MinimumWidth = 6;
            this.equipment.Name = "equipment";
            // 
            // security
            // 
            this.security.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.security.DataPropertyName = "security";
            this.security.HeaderText = "Security";
            this.security.MinimumWidth = 6;
            this.security.Name = "security";
            // 
            // uc_accessories_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Acces_Total_Cost);
            this.Controls.Add(this.uc_access_txt_sec_bill);
            this.Controls.Add(this.uc_access_txt_equip_bill);
            this.Controls.Add(this.uc_access_txt_water_bill);
            this.Controls.Add(this.uc_access_txt_gas_bill);
            this.Controls.Add(this.uc_access_txt_ec_bill);
            this.Controls.Add(this.uc_access_lbl_sec_bill);
            this.Controls.Add(this.uc_access_lbl_equip_bill);
            this.Controls.Add(this.uc_access_lbl_water_bill);
            this.Controls.Add(this.uc_access_lbl_gas_bill);
            this.Controls.Add(this.uc_access_lbl_ec_bill);
            this.Controls.Add(this.Acces_save);
            this.Controls.Add(this.Accessories_grade_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "uc_accessories_manage";
            this.Size = new System.Drawing.Size(776, 551);
            this.Load += new System.EventHandler(this.uc_accessories_manage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Accessories_grade_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Accessories_grade_view;
        private System.Windows.Forms.Button Acces_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label uc_access_lbl_ec_bill;
        private System.Windows.Forms.TextBox uc_access_txt_ec_bill;
        private System.Windows.Forms.Label uc_access_lbl_gas_bill;
        private System.Windows.Forms.TextBox uc_access_txt_gas_bill;
        private System.Windows.Forms.Label uc_access_lbl_water_bill;
        private System.Windows.Forms.TextBox uc_access_txt_water_bill;
        private System.Windows.Forms.Label uc_access_lbl_equip_bill;
        private System.Windows.Forms.TextBox uc_access_txt_equip_bill;
        private System.Windows.Forms.Label uc_access_lbl_sec_bill;
        private System.Windows.Forms.TextBox uc_access_txt_sec_bill;
        private System.Windows.Forms.Button Acces_Total_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricitybill;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterbill;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn security;
    }
}
