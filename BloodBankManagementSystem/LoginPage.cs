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
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
     

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
          //  txtusername.BackColor = Color.DarkCyan;

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            // txtusername.BackColor = Color.White;
            if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider1.SetError(this.txtusername, "Please Enter The UserName !!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
          //  txtpassword.BackColor = Color.DarkCyan;
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            // txtpassword.BackColor = Color.White;
            if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider2.SetError(txtpassword, "Please Enter The Password !!");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked==true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else if (chkshowpassword.Checked==false)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider1.SetError(txtusername, "Please Enter The UserName !!");
            }
            else if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider2.SetError(txtpassword, "Please Enter The Password !!");
            }
            else if (checkBox1.Checked == false)
            {
               
                errorProvider3.SetError(this.checkBox1, "Please Check Terms and Condition..!");
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from UserTbl where username=@user and password=@pass";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.Parameters.AddWithValue("@user", txtusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows==true)
                {
                    MessageBox.Show("Login Successful..","Login Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtusername.Clear();
                    txtpassword.Clear();
                    MasterPage m = new MasterPage();
                    m.Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Login Faild ", "Login Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                con.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==false)
            {
                errorProvider3.SetError(checkBox1, "Please Check Terms and Condition..!");
            }
            else if (checkBox1.Checked==true)
            {
              
                errorProvider3.Clear();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminLoginPage l = new AdminLoginPage();
            l.Show();
            this.Hide();
        }
    }
}
