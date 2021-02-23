namespace restaurant_management_system
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnCheckSell = new System.Windows.Forms.Button();
            this.btnManageSec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnaccoes = new System.Windows.Forms.Button();
            this.uc_accessories_manage1 = new restaurant_management_system.uc_accessories_manage();
            this.uc_check_sell1 = new restaurant_management_system.uc_check_sell();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnaccoes);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnCheckSell);
            this.panel1.Controls.Add(this.btnManageSec);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 541);
            this.panel1.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(197)))), ((int)(((byte)(210)))));
            this.btnlogout.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.Location = new System.Drawing.Point(0, 505);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(315, 33);
            this.btnlogout.TabIndex = 2;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnCheckSell
            // 
            this.btnCheckSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheckSell.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSell.Location = new System.Drawing.Point(54, 213);
            this.btnCheckSell.Name = "btnCheckSell";
            this.btnCheckSell.Size = new System.Drawing.Size(204, 46);
            this.btnCheckSell.TabIndex = 0;
            this.btnCheckSell.Text = "Check Sell";
            this.btnCheckSell.UseVisualStyleBackColor = false;
            this.btnCheckSell.Click += new System.EventHandler(this.btnCheckSell_Click);
            // 
            // btnManageSec
            // 
            this.btnManageSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnManageSec.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSec.Location = new System.Drawing.Point(54, 140);
            this.btnManageSec.Name = "btnManageSec";
            this.btnManageSec.Size = new System.Drawing.Size(204, 50);
            this.btnManageSec.TabIndex = 0;
            this.btnManageSec.Text = " Employee Section";
            this.btnManageSec.UseVisualStyleBackColor = false;
            this.btnManageSec.Click += new System.EventHandler(this.btnManageEmp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 547);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uc_accessories_manage1);
            this.panel2.Controls.Add(this.uc_check_sell1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(308, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 538);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(776, 547);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnaccoes
            // 
            this.btnaccoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnaccoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccoes.Location = new System.Drawing.Point(54, 279);
            this.btnaccoes.Name = "btnaccoes";
            this.btnaccoes.Size = new System.Drawing.Size(204, 53);
            this.btnaccoes.TabIndex = 3;
            this.btnaccoes.Text = "Accessories Management";
            this.btnaccoes.UseVisualStyleBackColor = false;
            this.btnaccoes.Click += new System.EventHandler(this.btnaccoes_Click);
            // 
            // uc_accessories_manage1
            // 
            this.uc_accessories_manage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uc_accessories_manage1.Location = new System.Drawing.Point(3, -3);
            this.uc_accessories_manage1.Name = "uc_accessories_manage1";
            this.uc_accessories_manage1.Size = new System.Drawing.Size(776, 547);
            this.uc_accessories_manage1.TabIndex = 2;
            // 
            // uc_check_sell1
            // 
            this.uc_check_sell1.Location = new System.Drawing.Point(3, -3);
            this.uc_check_sell1.Name = "uc_check_sell1";
            this.uc_check_sell1.Size = new System.Drawing.Size(776, 547);
            this.uc_check_sell1.TabIndex = 1;
            this.uc_check_sell1.Load += new System.EventHandler(this.uc_check_sell1_Load);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCheckSell;
        private System.Windows.Forms.Button btnManageSec;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private uc_check_sell uc_check_sell1;
        private System.Windows.Forms.Button btnaccoes;
        private uc_accessories_manage uc_accessories_manage1;
    }
}