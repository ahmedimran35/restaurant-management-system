using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_management_system
{
    public partial class Employee_DashBoard : Form
    {
        public Employee_DashBoard()
        {
            InitializeComponent();
        }

        private void empl_dash_btn_profile_Click(object sender, EventArgs e)
        {

            uc_Sending_email1.Hide();
            uc_Update_em_profile1.Show();
            
                
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            uc_Update_em_profile1.Hide();
            uc_Sending_email1.Hide();
           
        }

        private void uc_Update_em_profile1_Load(object sender, EventArgs e)
        {
           

        }

        private void empl_dash_btn_mail_Click(object sender, EventArgs e)
        {
            uc_Update_em_profile1.Hide();
            uc_Sending_email1.Show();
        }

        private void emp_logout_Click(object sender, EventArgs e)
        {
            Form1 n1 = new Form1();
            this.Hide();
            n1.Show();
        }

        private void uc_Update_em_profile1_Load_1(object sender, EventArgs e)
        {
            
        }

        private void Employee_DashBoard_Load(object sender, EventArgs e)
        {
           
        }
    }
}
