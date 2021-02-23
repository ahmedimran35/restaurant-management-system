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
    public partial class Employee_manage : Form
    {
        public Employee_manage()
        {
            InitializeComponent();
        }

        private void btn_Add_employee_Click(object sender, EventArgs e)
        {
            uc_add_employee1.Show();
            pic_fisher.Hide();
        }

        private void btn_total_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard ds1 = new DashBoard();
            ds1.Show();
        }

        private void panelx_Paint(object sender, PaintEventArgs e)
        {
            uc_add_employee1.Hide();
            pic_fisher.Show();
        }

        private void uc_add_employee1_Load(object sender, EventArgs e)
        {

        }

        private void uc_add_employee1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
