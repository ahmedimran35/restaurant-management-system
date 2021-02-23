using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;

namespace restaurant_management_system
{
    public partial class uc_add_employee : UserControl
    {
        public uc_add_employee()
        {
            InitializeComponent();
        }
        public int EmployeeID;

        private void uc_addemployee_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_lbl_postion_Click(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_lbl_salary_Click(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_salary_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void uc_addemployee_btn_ADD_Click(object sender, EventArgs e)
        {
            if(checkvalid()){
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");

                SqlCommand cmd = new SqlCommand(@" INSERT INTO [dbo].[employee_sell]
           ([id]
           ,[name]
           ,[postion]
           ,[salary]
           ,[password]
           ,[number])
     VALUES
           ('" + uc_addemployee_id.Text + "','" + uc_addemployee_name.Text + "','" + cmbpostion.SelectedItem.ToString() + "','" + uc_addemployee_salary.Text + "','" + uc_addemployee_pass.Text + "','" + uc_addemployee_num.Text + "')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                display_grade_view_data();
                MessageBox.Show("Sucessfully add");
                resetmethod();
            }
        }

        public bool checkvalid()
        {
            if (uc_addemployee_name.Text == string.Empty && cmbpostion.Text==string.Empty)
            {
                MessageBox.Show("Insert Value");
                return false;
            
            }
            return true;
        
        
        }

        public void display_grade_view_data()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from employee_sell;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            add_employee_gradeview.DataSource = dt;
            con.Close();


        }

        private void uc_add_employee_Load(object sender, EventArgs e)
        {
            display_grade_view_data();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uc_addemployee_btn_reset_Click(object sender, EventArgs e)
        {
            resetmethod();
        }
        public void resetmethod()
        {
             EmployeeID = 0;
            //uc_addemployee_id.Clear();
            uc_addemployee_name.Clear();
            uc_addemployee_salary.Clear();
            uc_addemployee_num.Clear();
            uc_addemployee_pass.Clear();
            cmbpostion.ResetText();
            uc_addemployee_name.Focus();
        }

        private void add_employee_gradeview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmployeeID = Convert.ToInt32(add_employee_gradeview.SelectedRows[0].Cells[0].Value);
            uc_addemployee_name.Text = add_employee_gradeview.SelectedRows[0].Cells[1].Value.ToString();
            cmbpostion.Text= add_employee_gradeview.SelectedRows[0].Cells[2].Value.ToString();
            uc_addemployee_salary.Text = add_employee_gradeview.SelectedRows[0].Cells[3].Value.ToString();
            uc_addemployee_num.Text = add_employee_gradeview.SelectedRows[0].Cells[6].Value.ToString();
            uc_addemployee_pass.Text = add_employee_gradeview.SelectedRows[0].Cells[5].Value.ToString();
            
            


        }

        private void uc_addemployee_btn_update_Click(object sender, EventArgs e)
            
        {
            if (EmployeeID > 0)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("Update employee_sell SET name=@name,postion=@postion,salary=@salary,password=@password,number=@number where id=@ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@name", uc_addemployee_name.Text);
                cmd.Parameters.AddWithValue("@postion", cmbpostion.Text);
                cmd.Parameters.AddWithValue("@salary", uc_addemployee_salary.Text);
             
                cmd.Parameters.AddWithValue("@password", uc_addemployee_pass.Text);
                cmd.Parameters.AddWithValue("@number", uc_addemployee_num.Text);
                cmd.Parameters.AddWithValue("@ID", this.EmployeeID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucessfully Updated");
                resetmethod();
               display_grade_view_data();
            }
            else 
            {
                MessageBox.Show("Please select a Row.");
            
            }


        }

        private void uc_addemployee_btn_DELETE_Click(object sender, EventArgs e)
        {

            if (EmployeeID > 0)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("DELETE from employee_sell where  id=@ID", con);
                cmd.CommandType = CommandType.Text;
                
                cmd.Parameters.AddWithValue("@ID", this.EmployeeID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sucessfully Deleated from database");
                resetmethod();
                display_grade_view_data();
            }
            else
            {
                MessageBox.Show("Please select a Row.");

            }


        }


    }
    }