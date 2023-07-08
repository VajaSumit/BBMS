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
using System.Threading;
using BloodBankManagementSystem.ClassFiles;

namespace BloodBankManagementSystem
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        HashCode hc = new HashCode();

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        } 



        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (cmdUserRole.SelectedItem == null)
            {
                cmdUserRole.Focus();
                errorProvider1.SetError(cmdUserRole, "Please select User-Role !!");
            }
            else if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider2.SetError(txtusername, "Please Enter The UserName !!");
            }
            else if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider3.SetError(txtpassword, "Please Enter The Password !!");
            }
            else if (checkBox1.Checked == false)
            {

                errorProvider4.SetError(checkBox1, "Please Check Terms and Condition..!");
            }

            else
            {
                // By Using Query

                //SqlConnection con = new SqlConnection(cs);
                //string query = "select *from Login_Master where UserName=@user and Password=@pass";
                //SqlCommand cmd = new SqlCommand(query, con);
                //con.Open();
                //cmd.Parameters.AddWithValue("@user", txtusername.Text);
                //cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.HasRows == true)
                //{
                //    MessageBox.Show("Login Successful..", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    txtusername.Clear();
                //    txtpassword.Clear();
                //    MasterPage m = new MasterPage();
                //    m.Show();
                //    this.Hide();

                //}
                //else
                //{
                //    MessageBox.Show("Login Faild ", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}

                //con.Close();

                //By Using Procedure 

                string name = txtusername.Text;
                string password = txtpassword.Text;

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("exec LoginPageUserSelect '"+name+"','"+ hc.PassHash(password)+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful..", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtusername.Clear();
                    txtpassword.Clear();
                    cmdUserRole.SelectedItem = null;
                    MasterPage m = new MasterPage();
                    m.Show();
                    this.Hide();
                   

                }
                else
                {
                    MessageBox.Show("Login Faild ", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                con.Close();

            }
        }

        private void cmdUserRole_Leave(object sender, EventArgs e)
        {
            cmdUserRole.BackColor = Color.White;
            cmdUserRole.ForeColor = Color.Black;

            if (cmdUserRole.SelectedItem == null)
            {
                cmdUserRole.Focus();
                errorProvider1.SetError(cmdUserRole, "Please select User-Role !!");
            }
            else
            {
                errorProvider1.Clear();
                txtusername.Focus();
            }
        }

        private void txtusername_Leave_1(object sender, EventArgs e)
        {
            txtusername.BackColor = Color.White;
            txtusername.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(txtusername.Text) == true)
            {
                txtusername.Focus();
                errorProvider2.SetError(this.txtusername, "Please Enter The UserName !!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtpassword_Leave_1(object sender, EventArgs e)
        {
            txtpassword.BackColor = Color.White;
            txtpassword.ForeColor = Color.Black;
            if (string.IsNullOrEmpty(txtpassword.Text) == true)
            {
                txtpassword.Focus();
                errorProvider3.SetError(this.txtpassword, "Please Enter The Password !!");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else if (chkshowpassword.Checked == false)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                errorProvider4.SetError(checkBox1, "Please Check Terms and Condition..!");
            }
            else if (checkBox1.Checked == true)
            {

                errorProvider4.Clear();
            }
        }

        private void cmdUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdUserRole.SelectedItem == null)
            {
                errorProvider1.SetError(this.cmdUserRole, "Select Gender !");
            }
            else
            {
                errorProvider1.Clear();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string title = lblMarquee.Text;
            // r:    // goto statment lable 

            //for (int i = 0; i <= 20; i++)
            //{
            //    lblMarquee.Text = title.PadLeft(i);
            //    Thread.Sleep(4);
            //}

            //for (int j = 20 ; j >= 1; j--)
            //{
            //    lblMarquee.Text = title.PadLeft(j);
            //    Thread.Sleep(4);
            //}
            //goto r;

            //string title = this.Text;
            //  r:    // goto statment lable 

            //for (int i = 0; i <= 273; i++)
            //{
            //    this.Text = title.PadLeft(i);
            //    Thread.Sleep(40);
            //}

            //for (int j = 273; j >= 1; j--)
            //{
            //    this.Text = title.PadLeft(j);
            //    Thread.Sleep(40);
            //}
            //goto r;


        }

        private void cmdUserRole_Enter(object sender, EventArgs e)
        {
            //cmdUserRole.BackColor = Color.FromArgb(192, 255, 255);
            //cmdUserRole.BackColor = Color.FromArgb(0, 64, 0);
            //cmdUserRole.BackColor = Color.OldLace;
            cmdUserRole.ForeColor = Color.Black;
            //cmdUserRole.BackColor = Color.DodgerBlue;
            cmdUserRole.BackColor = Color.LightCyan;
            //cmdUserRole.ForeColor = Color.White;
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            //txtusername.BackColor = Color.FromArgb(192, 255, 255);
            //txtusername.BackColor = Color.FromArgb(0, 64, 0);
            //txtusername.BackColor = Color.OldLace;
            txtusername.ForeColor = Color.Black;
            //txtusername.ForeColor = Color.White;
            //txtusername.BackColor = Color.DodgerBlue;
            txtusername.BackColor = Color.LightCyan;

        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            //txtpassword.BackColor = Color.FromArgb(192, 255, 255);
            //txtpassword.BackColor = Color.FromArgb(0, 64, 0);
            //txtpassword.BackColor = Color.OldLace;
            txtpassword.ForeColor = Color.Black;
            //txtpassword.ForeColor = Color.White;
            //txtpassword.BackColor = Color.DodgerBlue;
            txtpassword.BackColor = Color.LightCyan;

        }

        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
           

        }

        private void btnlogin_MouseHover(object sender, EventArgs e)
        {

        }

        private void exitlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
