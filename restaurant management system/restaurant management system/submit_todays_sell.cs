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
    public partial class submit_todays_sell : UserControl
    {
        public submit_todays_sell()
        {
            InitializeComponent();
        }

        private void btn_submit_sell_Click(object sender, EventArgs e)
        {
            if (userid_sell.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("update employee_sell set total_sell='" + userid_Sell_sell.Text + "' where id='" + userid_sell.Text + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Submitted");
            }
            else
            {
                MessageBox.Show("Enter your Id And CLick Check Button  ");
            
            }
        }

        private void btn_check_sell_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employee_sell where id='" + userid_sell.Text + "';", con);
            SqlDataReader de = cmd.ExecuteReader();
            if (de.Read())
            {

                MessageBox.Show("sucess");
                check_todays_sell_panel.Visible = true;

            }
            else
            {
                MessageBox.Show("Not matched ");
            }
            de.Close();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //check_todays_sell_panel.Visible = false;
        }

        private void submit_todays_sell_Load(object sender, EventArgs e)
        {
           
        }

        private void check_todays_sell_panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Submit_submit_Click(object sender, EventArgs e)
        {
           
        }
    }
}
