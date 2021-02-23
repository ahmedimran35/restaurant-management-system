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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            this.Hide(); // current from hide 
            Employee_manage fm = new Employee_manage();
            fm.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckSell_Click(object sender, EventArgs e)
        {
           uc_check_sell1.Show();
            uc_accessories_manage1.Hide();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            uc_check_sell1.Hide();
            uc_accessories_manage1.Hide();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           uc_check_sell1.Hide();
            uc_accessories_manage1.Hide();
        }

        private void uc_check_sell1_Load(object sender, EventArgs e)
        {

        }

        private void btnaccoes_Click(object sender, EventArgs e)
        {
           // uc_check_sell1.Hide();
           uc_accessories_manage1.Show();

        }
    }
}
