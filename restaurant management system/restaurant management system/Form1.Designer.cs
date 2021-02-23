namespace restaurant_management_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_choose_user = new System.Windows.Forms.Label();
            this.choose_user = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblsusername = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.lbl_choose_user);
            this.panel1.Controls.Add(this.choose_user);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblpassword);
            this.panel1.Controls.Add(this.lblsusername);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 717);
            this.panel1.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(71, 524);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(391, 48);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_choose_user
            // 
            this.lbl_choose_user.AutoSize = true;
            this.lbl_choose_user.BackColor = System.Drawing.Color.Black;
            this.lbl_choose_user.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choose_user.ForeColor = System.Drawing.Color.White;
            this.lbl_choose_user.Location = new System.Drawing.Point(183, 167);
            this.lbl_choose_user.Name = "lbl_choose_user";
            this.lbl_choose_user.Size = new System.Drawing.Size(152, 24);
            this.lbl_choose_user.TabIndex = 7;
            this.lbl_choose_user.Text = "Choose User Role";
            this.lbl_choose_user.Click += new System.EventHandler(this.lbl_choose_user_Click);
            // 
            // choose_user
            // 
            this.choose_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_user.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_user.FormattingEnabled = true;
            this.choose_user.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.choose_user.Location = new System.Drawing.Point(134, 194);
            this.choose_user.Name = "choose_user";
            this.choose_user.Size = new System.Drawing.Size(254, 32);
            this.choose_user.TabIndex = 6;
            this.choose_user.SelectedIndexChanged += new System.EventHandler(this.choose_user_SelectedIndexChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(71, 456);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(391, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.White;
            this.lblpassword.Location = new System.Drawing.Point(79, 349);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(85, 24);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // lblsusername
            // 
            this.lblsusername.AutoSize = true;
            this.lblsusername.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsusername.ForeColor = System.Drawing.Color.White;
            this.lblsusername.Location = new System.Drawing.Point(79, 253);
            this.lblsusername.Name = "lblsusername";
            this.lblsusername.Size = new System.Drawing.Size(90, 24);
            this.lblsusername.TabIndex = 1;
            this.lblsusername.Text = "Username";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(71, 376);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(391, 35);
            this.txtpass.TabIndex = 0;
            this.txtpass.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtusername.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(71, 280);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(391, 35);
            this.txtusername.TabIndex = 0;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(548, 733);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 722);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblsusername;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_choose_user;
        private System.Windows.Forms.ComboBox choose_user;
    }
}

