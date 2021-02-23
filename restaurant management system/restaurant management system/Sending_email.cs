using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace restaurant_management_system
{
    public partial class uc_Sending_email : UserControl
    {
        public uc_Sending_email()
        {
            InitializeComponent();
        }

        private void ES_txt_your_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void ES_lbl_your_pass_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ES_lbl_receiver_email_Click(object sender, EventArgs e)
        {

        }

        private void uc_Sending_email_Load(object sender, EventArgs e)
        {

        }

        private void btn_email_send_Click(object sender, EventArgs e)
        {
            //sending Email
            MailMessage mail = new MailMessage();
            SmtpClient smtpserver = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(ES_txt_your_mail.Text);
            mail.To.Add(ES_txt_receiver_email.Text);
            mail.Subject = ES_txt_your_sub.Text;
            mail.Body = ES_txt_your_message.Text;

            smtpserver.Port = 587;
            smtpserver.Credentials = new System.Net.NetworkCredential(ES_txt_your_mail.Text, ES_txt_your_pass.Text);
            smtpserver.EnableSsl = true;
            //smtpserver.UseDefaultCredentials = false;
            smtpserver.Send(mail);
            MessageBox.Show("Sucessfully Send");

            // empty box agter button click
            ES_txt_your_mail.Text = " ";
            ES_txt_receiver_email.Text = " ";
            ES_txt_your_sub.Text = " ";
            ES_txt_your_message.Text = " ";
            ES_txt_your_pass.Text = " ";





        }

        private void ES_txt_receiver_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
