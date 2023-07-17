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
using System.Security.Cryptography;

namespace BloodBankManagementSystem
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        //HashCode hc = new HashCode();
        string hash = "f0xle@rn";

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
            else if (CheckBox1.Checked == false)
            {

                errorProvider4.SetError(CheckBox1, "Please Check Terms and Condition..!");
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



                byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                        string name = txtusername.Text;
                        //string password = txtpassword.Text;

                        SqlConnection con = new SqlConnection(cs);
                        con.Open();
                        //SqlCommand cmd = new SqlCommand("exec LoginPageUserSelect '"+name+"','"+ hc.PassHash(password)+"'", con);
                        SqlCommand cmd = new SqlCommand("exec LoginPageUserSelect '" + name + "','" + UserPassword + "'", con);
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


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                errorProvider4.SetError(CheckBox1, "Please Check Terms and Condition..!");
            }
            else if (CheckBox1.Checked == true)
            {

                errorProvider4.Clear();
            }
        }



        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmdUserRole_Leave_1(object sender, EventArgs e)
        {
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

        private void txtusername_Leave(object sender, EventArgs e)
        {
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

        private void txtpassword_Leave(object sender, EventArgs e)
        {
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

        private void cmdUserRole_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void exitlink_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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
    }
}
