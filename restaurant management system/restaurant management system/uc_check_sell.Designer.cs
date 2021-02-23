namespace restaurant_management_system
{
    partial class uc_check_sell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_check_sell));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.uc_txt_search_empl = new System.Windows.Forms.TextBox();
            this.uc_lbl_search = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uc_txt_search_empl
            // 
            this.uc_txt_search_empl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uc_txt_search_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_txt_search_empl.Location = new System.Drawing.Point(172, 198);
            this.uc_txt_search_empl.Name = "uc_txt_search_empl";
            this.uc_txt_search_empl.Size = new System.Drawing.Size(407, 41);
            this.uc_txt_search_empl.TabIndex = 0;
            this.uc_txt_search_empl.TextChanged += new System.EventHandler(this.uc_txt_search_empl_TextChanged);
            // 
            // uc_lbl_search
            // 
            this.uc_lbl_search.AutoSize = true;
            this.uc_lbl_search.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uc_lbl_search.Location = new System.Drawing.Point(265, 162);
            this.uc_lbl_search.Name = "uc_lbl_search";
            this.uc_lbl_search.Size = new System.Drawing.Size(222, 33);
            this.uc_lbl_search.TabIndex = 2;
            this.uc_lbl_search.Text = "Enter Id to search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.password,
            this.name,
            this.postion,
            this.salary,
            this.number,
            this.total_sell});
            this.dataGridView1.Location = new System.Drawing.Point(0, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 228);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Employee ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            this.password.Width = 125;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.HeaderText = "Employee Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // postion
            // 
            this.postion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.postion.DataPropertyName = "postion";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postion.DefaultCellStyle = dataGridViewCellStyle3;
            this.postion.HeaderText = "Postion";
            this.postion.MinimumWidth = 6;
            this.postion.Name = "postion";
            this.postion.ReadOnly = true;
            // 
            // salary
            // 
            this.salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salary.DataPropertyName = "salary";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.salary.DefaultCellStyle = dataGridViewCellStyle4;
            this.salary.HeaderText = "Salary";
            this.salary.MinimumWidth = 6;
            this.salary.Name = "salary";
            this.salary.ReadOnly = true;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Contact Number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // total_sell
            // 
            this.total_sell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_sell.DataPropertyName = "total_sell";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Silver;
            this.total_sell.DefaultCellStyle = dataGridViewCellStyle5;
            this.total_sell.HeaderText = "Total Sell";
            this.total_sell.MinimumWidth = 6;
            this.total_sell.Name = "total_sell";
            this.total_sell.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // uc_check_sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uc_lbl_search);
            this.Controls.Add(this.uc_txt_search_empl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "uc_check_sell";
            this.Size = new System.Drawing.Size(776, 547);
            this.Load += new System.EventHandler(this.uc_check_sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TextBox uc_txt_search_empl;
        private System.Windows.Forms.Label uc_lbl_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn postion;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_sell;
    }
}
