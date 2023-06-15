using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BloodBankManagementSystem
{
    public partial class AdminLoginPage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage l = new LoginPage();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtadminpassword.Text) == true)
            {
                errorProvider1.SetError(this.txtadminpassword, "Please Enter Password !");
                txtadminpassword.Focus();

            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from AdminTbl where password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@pass", txtadminpassword.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows==true)
                {
                    MessageBox.Show("Login Successful", "Login Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    AdminUserAddPage a = new AdminUserAddPage();
                    a.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login Faild", "Login Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtadminpassword.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked==false)
            {
                txtadminpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtadminpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtadminpassword.Text)==true)
            {
                errorProvider1.SetError(this.txtadminpassword, "Please Enter Password !");
                txtadminpassword.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
