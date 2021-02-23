using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace restaurant_management_system
{
    public partial class uc_chng_pass_button : UserControl
    {
        public uc_chng_pass_button()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_btn_cngpass_btn_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from userlogin where userid='"+ user_ID_txt_cngpass_btn.Text + "' and password='"+ old_pass_txt_cngpass_btn.Text + "';", con);
            SqlDataReader de = cmd.ExecuteReader();
            if (de.Read())
            {
               
                MessageBox.Show("sucess");
                panel_chng_pass.Visible = true;
            }
            else
            {
                MessageBox.Show("Not matched ");

            }
            de.Close();
            con.Close();

        }

        private void chng_f_button_txt_cngpass_btn_Click(object sender, EventArgs e)
        {

            if (new_pass_txt_cngpass_btn.Text == confirm_pass_txt_cngpass_btn.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update userlogin set password='" + new_pass_txt_cngpass_btn.Text + "' where userid='" + user_ID_txt_cngpass_btn.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Changed Succefully");
            }
            else
            {
                MessageBox.Show("Not Matched");
            }


        }

        private void uc_chng_pass_button_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel_chng_pass.Visible = false;
        }
    }
}
