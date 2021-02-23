namespace restaurant_management_system
{
    partial class submit_todays_sell
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
            this.todays_sell_user_ID = new System.Windows.Forms.Label();
            this.todays_sell_sell = new System.Windows.Forms.Label();
            this.userid_sell = new System.Windows.Forms.TextBox();
            this.userid_Sell_sell = new System.Windows.Forms.TextBox();
            this.btn_check_sell = new System.Windows.Forms.Button();
            this.check_todays_sell_panel = new System.Windows.Forms.Panel();
            this.userID_check_pannel = new System.Windows.Forms.Panel();
            this.btn_submit_sell = new System.Windows.Forms.Button();
            this.check_todays_sell_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // todays_sell_user_ID
            // 
            this.todays_sell_user_ID.AutoSize = true;
            this.todays_sell_user_ID.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todays_sell_user_ID.Location = new System.Drawing.Point(38, 59);
            this.todays_sell_user_ID.Name = "todays_sell_user_ID";
            this.todays_sell_user_ID.Size = new System.Drawing.Size(71, 19);
            this.todays_sell_user_ID.TabIndex = 0;
            this.todays_sell_user_ID.Text = "User ID: ";
            // 
            // todays_sell_sell
            // 
            this.todays_sell_sell.AutoSize = true;
            this.todays_sell_sell.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todays_sell_sell.Location = new System.Drawing.Point(38, 203);
            this.todays_sell_sell.Name = "todays_sell_sell";
            this.todays_sell_sell.Size = new System.Drawing.Size(127, 19);
            this.todays_sell_sell.TabIndex = 0;
            this.todays_sell_sell.Text = "Enter Todays Sell";
            // 
            // userid_sell
            // 
            this.userid_sell.Location = new System.Drawing.Point(192, 59);
            this.userid_sell.Multiline = true;
            this.userid_sell.Name = "userid_sell";
            this.userid_sell.Size = new System.Drawing.Size(235, 36);
            this.userid_sell.TabIndex = 1;
            // 
            // userid_Sell_sell
            // 
            this.userid_Sell_sell.Location = new System.Drawing.Point(192, 201);
            this.userid_Sell_sell.Multiline = true;
            this.userid_Sell_sell.Name = "userid_Sell_sell";
            this.userid_Sell_sell.Size = new System.Drawing.Size(235, 36);
            this.userid_Sell_sell.TabIndex = 1;
            // 
            // btn_check_sell
            // 
            this.btn_check_sell.Location = new System.Drawing.Point(233, 113);
            this.btn_check_sell.Name = "btn_check_sell";
            this.btn_check_sell.Size = new System.Drawing.Size(129, 34);
            this.btn_check_sell.TabIndex = 4;
            this.btn_check_sell.Text = "Check";
            this.btn_check_sell.UseVisualStyleBackColor = true;
            this.btn_check_sell.Click += new System.EventHandler(this.btn_check_sell_Click);
            // 
            // check_todays_sell_panel
            // 
            this.check_todays_sell_panel.Controls.Add(this.btn_submit_sell);
            this.check_todays_sell_panel.Location = new System.Drawing.Point(27, 186);
            this.check_todays_sell_panel.Name = "check_todays_sell_panel";
            this.check_todays_sell_panel.Size = new System.Drawing.Size(419, 142);
            this.check_todays_sell_panel.TabIndex = 5;
            this.check_todays_sell_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.check_todays_sell_panel_Paint);
            // 
            // userID_check_pannel
            // 
            this.userID_check_pannel.Location = new System.Drawing.Point(27, 13);
            this.userID_check_pannel.Name = "userID_check_pannel";
            this.userID_check_pannel.Size = new System.Drawing.Size(419, 147);
            this.userID_check_pannel.TabIndex = 6;
            this.userID_check_pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_submit_sell
            // 
            this.btn_submit_sell.BackColor = System.Drawing.Color.White;
            this.btn_submit_sell.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_sell.ForeColor = System.Drawing.Color.Black;
            this.btn_submit_sell.Location = new System.Drawing.Point(206, 70);
            this.btn_submit_sell.Name = "btn_submit_sell";
            this.btn_submit_sell.Size = new System.Drawing.Size(129, 35);
            this.btn_submit_sell.TabIndex = 2;
            this.btn_submit_sell.Text = "Submit";
            this.btn_submit_sell.UseVisualStyleBackColor = false;
            this.btn_submit_sell.Click += new System.EventHandler(this.btn_submit_sell_Click);
            // 
            // submit_todays_sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_check_sell);
            this.Controls.Add(this.userid_Sell_sell);
            this.Controls.Add(this.userid_sell);
            this.Controls.Add(this.todays_sell_sell);
            this.Controls.Add(this.todays_sell_user_ID);
            this.Controls.Add(this.userID_check_pannel);
            this.Controls.Add(this.check_todays_sell_panel);
            this.Name = "submit_todays_sell";
            this.Size = new System.Drawing.Size(463, 342);
            this.Load += new System.EventHandler(this.submit_todays_sell_Load);
            this.check_todays_sell_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todays_sell_user_ID;
        private System.Windows.Forms.Label todays_sell_sell;
        private System.Windows.Forms.TextBox userid_sell;
        private System.Windows.Forms.TextBox userid_Sell_sell;
        private System.Windows.Forms.Button btn_check_sell;
        private System.Windows.Forms.Panel check_todays_sell_panel;
        private System.Windows.Forms.Panel userID_check_pannel;
        private System.Windows.Forms.Button btn_submit_sell;
    }
}
