using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace restaurant_management_system
{
    public partial class uc_check_sell : UserControl
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
       // SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt;
        public uc_check_sell()
        {
            InitializeComponent();
            displayvalue();


        }
       

        public void displayvalue()
        {
            sqlcon.Open();
            adpt = new SqlDataAdapter(" SELECT * FROM employee_sell;", sqlcon);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;


            sqlcon.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void uc_check_sell_Load(object sender, EventArgs e)
        {
           

           


           // sqlcon.Close();

            

        }

        private void uc_txt_search_empl_TextChanged(object sender, EventArgs e)
        {
            searchdata(uc_txt_search_empl.Text);
        }
        public void searchdata(string search)
        {
            string quary = "SELECT * FROM employee_sell where id like '%" + search + "%'"; // like search 
            adpt = new SqlDataAdapter(quary, sqlcon);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
