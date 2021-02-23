using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace restaurant_management_system
{
    public partial class Form1 : Form
    {
        public bool checkvalid()
        {
            if (txtusername.Text == string.Empty && txtpass.Text == string.Empty && choose_user.Text==null)
            {
                MessageBox.Show("Insert Value");
                return false;

            }
            return true;


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // string query = "select * from userlogin where userid = '" + this.txtusername.Text + "' and password = '" + this.txtpass.Text + "';";
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-Q8D5FNB;Initial Catalog=resturent;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from userlogin where userid = '" + this.txtusername.Text + "' and password = '" + this.txtpass.Text + "';", sqlcon);
            //sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
           // SqlCommand sqlcom = new SqlCommand(query, sqlcon);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            {
                string itm = choose_user.SelectedItem.ToString();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        if (dt.Rows[i]["usertype"].ToString() == itm)
                        {
                            MessageBox.Show("Your Arelog in as " + dt.Rows[i][1]);
                            if (choose_user.SelectedIndex == 0)
                            {

                                DashBoard dss = new DashBoard();
                                dss.Show();
                                this.Hide();


                            }
                            else
                            {
                                Employee_DashBoard emd = new Employee_DashBoard();
                                emd.Show();
                                this.Hide();

                            }
                        }
                    }


                }


                else
                {
                    MessageBox.Show("Login Invalid");
                    sqlcon.Close();
                }


            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_choose_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void choose_user_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
