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
    public partial class uc_accessories_manage : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
        public uc_accessories_manage()
        {
            InitializeComponent();
        }

        private void Accessories_grade_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void acc_disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from accessories;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            Accessories_grade_view.DataSource = dt;
            con.Close();


        }

        private void uc_accessories_manage_Load(object sender, EventArgs e)
        {
            acc_disp_data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Acces_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into accessories values('"+ uc_access_txt_ec_bill.Text + "','"+ uc_access_txt_gas_bill.Text + "','"+ uc_access_txt_water_bill.Text + "','"+ uc_access_txt_equip_bill.Text + "','"+ uc_access_txt_sec_bill.Text + "')";
            cmd.ExecuteNonQuery();
            
            con.Close();
            acc_disp_data();
            MessageBox.Show("Data insert - DONE ");

        }

        private void Acces_Total_Cost_Click(object sender, EventArgs e)
        {
            int sum=0,sum2=0,sum3=0,sum4=0,sum5=0,t_sum=0;
            for (int i = 0; i < Accessories_grade_view.Rows.Count; i++)
            {
                sum += Convert.ToInt32(Accessories_grade_view.Rows[i].Cells[4].Value);
                sum2+= Convert.ToInt32(Accessories_grade_view.Rows[i].Cells[0].Value);
                sum3+= Convert.ToInt32(Accessories_grade_view.Rows[i].Cells[1].Value);
                sum4+= Convert.ToInt32(Accessories_grade_view.Rows[i].Cells[2].Value);
                sum5+= Convert.ToInt32(Accessories_grade_view.Rows[i].Cells[3].Value);
                t_sum = sum + sum2 + sum3 + sum4 + sum5;
            }
            //result_show_lbl.Text =sum.ToString();
            MessageBox.Show(t_sum.ToString());
        }

        private void ddlt_Click(object sender, EventArgs e)
        {
        }
       // public void delete_acceesrioes_value()
       // {
          //  con.Open();
          //  SqlCommand cmd = con.CreateCommand();
          //  cmd.CommandType = CommandType.Text;
           // cmd.CommandText = "delete from accessories where [electricity bill]='" + uc_access_txt_ec_bill.Text + "'";
          //  cmd.ExecuteNonQuery();

           // con.Close();
           // acc_disp_data();
           // MessageBox.Show("Data insert - DONE ");



        //}
    }
}
