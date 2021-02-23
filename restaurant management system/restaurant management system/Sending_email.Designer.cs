namespace restaurant_management_system
{
    partial class uc_Sending_email
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
            this.ES_lbl_your_mail = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ES_txt_your_mail = new System.Windows.Forms.TextBox();
            this.ES_lbl_your_pass = new System.Windows.Forms.Label();
            this.ES_txt_your_pass = new System.Windows.Forms.TextBox();
            this.ES_txt_your_message = new System.Windows.Forms.TextBox();
            this.ES_lbl_receiver_email = new System.Windows.Forms.Label();
            this.ES_txt_receiver_email = new System.Windows.Forms.TextBox();
            this.ES_lbl_your_sub = new System.Windows.Forms.Label();
            this.ES_txt_your_sub = new System.Windows.Forms.TextBox();
            this.btn_email_send = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ES_lbl_your_mail
            // 
            this.ES_lbl_your_mail.AutoSize = true;
            this.ES_lbl_your_mail.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES_lbl_your_mail.Location = new System.Drawing.Point(136, 29);
            this.ES_lbl_your_mail.Name = "ES_lbl_your_mail";
            this.ES_lbl_your_mail.Size = new System.Drawing.Size(160, 26);
            this.ES_lbl_your_mail.TabIndex = 0;
            this.ES_lbl_your_mail.Text = "Enter Your Email";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1070, 11);
            this.panel4.TabIndex = 2;
            // 
            // ES_txt_your_mail
            // 
            this.ES_txt_your_mail.BackColor = System.Drawing.Color.White;
            this.ES_txt_your_mail.Location = new System.Drawing.Point(141, 59);
            this.ES_txt_your_mail.Multiline = true;
            this.ES_txt_your_mail.Name = "ES_txt_your_mail";
            this.ES_txt_your_mail.Size = new System.Drawing.Size(242, 32);
            this.ES_txt_your_mail.TabIndex = 4;
            // 
            // ES_lbl_your_pass
            // 
            this.ES_lbl_your_pass.AutoSize = true;
            this.ES_lbl_your_pass.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES_lbl_your_pass.Location = new System.Drawing.Point(136, 106);
            this.ES_lbl_your_pass.Name = "ES_lbl_your_pass";
            this.ES_lbl_your_pass.Size = new System.Drawing.Size(196, 26);
            this.ES_lbl_your_pass.TabIndex = 0;
            this.ES_lbl_your_pass.Text = "Enter Your Password";
            this.ES_lbl_your_pass.Click += new System.EventHandler(this.ES_lbl_your_pass_Click);
            // 
            // ES_txt_your_pass
            // 
            this.ES_txt_your_pass.Location = new System.Drawing.Point(141, 135);
            this.ES_txt_your_pass.Multiline = true;
            this.ES_txt_your_pass.Name = "ES_txt_your_pass";
            this.ES_txt_your_pass.PasswordChar = '*';
            this.ES_txt_your_pass.Size = new System.Drawing.Size(242, 32);
            this.ES_txt_your_pass.TabIndex = 4;
            this.ES_txt_your_pass.TextChanged += new System.EventHandler(this.ES_txt_your_pass_TextChanged);
            // 
            // ES_txt_your_message
            // 
            this.ES_txt_your_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ES_txt_your_message.Location = new System.Drawing.Point(141, 190);
            this.ES_txt_your_message.Multiline = true;
            this.ES_txt_your_message.Name = "ES_txt_your_message";
            this.ES_txt_your_message.Size = new System.Drawing.Size(727, 226);
            this.ES_txt_your_message.TabIndex = 5;
            // 
            // ES_lbl_receiver_email
            // 
            this.ES_lbl_receiver_email.AutoSize = true;
            this.ES_lbl_receiver_email.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES_lbl_receiver_email.Location = new System.Drawing.Point(444, 29);
            this.ES_lbl_receiver_email.Name = "ES_lbl_receiver_email";
            this.ES_lbl_receiver_email.Size = new System.Drawing.Size(193, 26);
            this.ES_lbl_receiver_email.TabIndex = 0;
            this.ES_lbl_receiver_email.Text = "Enter Receiver Email";
            this.ES_lbl_receiver_email.Click += new System.EventHandler(this.ES_lbl_receiver_email_Click);
            // 
            // ES_txt_receiver_email
            // 
            this.ES_txt_receiver_email.Location = new System.Drawing.Point(440, 58);
            this.ES_txt_receiver_email.Multiline = true;
            this.ES_txt_receiver_email.Name = "ES_txt_receiver_email";
            this.ES_txt_receiver_email.Size = new System.Drawing.Size(431, 32);
            this.ES_txt_receiver_email.TabIndex = 4;
            this.ES_txt_receiver_email.TextChanged += new System.EventHandler(this.ES_txt_receiver_email_TextChanged);
            // 
            // ES_lbl_your_sub
            // 
            this.ES_lbl_your_sub.AutoSize = true;
            this.ES_lbl_your_sub.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ES_lbl_your_sub.Location = new System.Drawing.Point(444, 106);
            this.ES_lbl_your_sub.Name = "ES_lbl_your_sub";
            this.ES_lbl_your_sub.Size = new System.Drawing.Size(82, 26);
            this.ES_lbl_your_sub.TabIndex = 0;
            this.ES_lbl_your_sub.Text = "Subject";
            this.ES_lbl_your_sub.Click += new System.EventHandler(this.ES_lbl_your_pass_Click);
            // 
            // ES_txt_your_sub
            // 
            this.ES_txt_your_sub.Location = new System.Drawing.Point(439, 135);
            this.ES_txt_your_sub.Multiline = true;
            this.ES_txt_your_sub.Name = "ES_txt_your_sub";
            this.ES_txt_your_sub.Size = new System.Drawing.Size(429, 32);
            this.ES_txt_your_sub.TabIndex = 4;
            // 
            // btn_email_send
            // 
            this.btn_email_send.BackColor = System.Drawing.Color.White;
            this.btn_email_send.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email_send.ForeColor = System.Drawing.Color.Black;
            this.btn_email_send.Location = new System.Drawing.Point(874, 376);
            this.btn_email_send.Name = "btn_email_send";
            this.btn_email_send.Size = new System.Drawing.Size(121, 40);
            this.btn_email_send.TabIndex = 6;
            this.btn_email_send.Text = "Send";
            this.btn_email_send.UseVisualStyleBackColor = false;
            this.btn_email_send.Click += new System.EventHandler(this.btn_email_send_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(1041, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 465);
            this.panel3.TabIndex = 7;
            // 
            // uc_Sending_email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Controls.Add(this.btn_email_send);
            this.Controls.Add(this.ES_txt_your_message);
            this.Controls.Add(this.ES_txt_your_pass);
            this.Controls.Add(this.ES_txt_your_sub);
            this.Controls.Add(this.ES_txt_receiver_email);
            this.Controls.Add(this.ES_txt_your_mail);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ES_lbl_your_sub);
            this.Controls.Add(this.ES_lbl_your_pass);
            this.Controls.Add(this.ES_lbl_receiver_email);
            this.Controls.Add(this.ES_lbl_your_mail);
            this.Controls.Add(this.panel3);
            this.Name = "uc_Sending_email";
            this.Size = new System.Drawing.Size(1054, 465);
            this.Load += new System.EventHandler(this.uc_Sending_email_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ES_lbl_your_mail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ES_txt_your_mail;
        private System.Windows.Forms.Label ES_lbl_your_pass;
        private System.Windows.Forms.TextBox ES_txt_your_pass;
        private System.Windows.Forms.TextBox ES_txt_your_message;
        private System.Windows.Forms.Label ES_lbl_receiver_email;
        private System.Windows.Forms.TextBox ES_txt_receiver_email;
        private System.Windows.Forms.Label ES_lbl_your_sub;
        private System.Windows.Forms.TextBox ES_txt_your_sub;
        private System.Windows.Forms.Button btn_email_send;
        private System.Windows.Forms.Panel panel3;
    }
}
