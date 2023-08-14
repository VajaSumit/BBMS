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
using System.IO;

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
        public static string username;
        public static string password;
        public static DateTime dateofbrith;
        public static string emailId;
        public static string userrole;
        public static Image userImage;
        public static string mobileno;
        public static string address;


        private void LoginPage_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            cmdUserRole.SelectedItem = "Select UserRole";
            cmdUserRole.ForeColor = Color.Silver;
            
        }



        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
          
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
        }


        private void cmdUserRole_Leave_1(object sender, EventArgs e)
        {
            cmdUserRole.ForeColor = Color.FromArgb(68, 88, 112);
            if (cmdUserRole.SelectedItem.ToString() == "Select UserRole")
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

  

        private void exitlink_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }


        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.CheckState == CheckState.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else if (chkshowpassword.CheckState == CheckState.Unchecked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmdUserRole_Enter(object sender, EventArgs e)
        {
            cmdUserRole.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
          
        }
        

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (cmdUserRole.SelectedItem.ToString() == "Select UserRole")
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



                //    byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
                //    using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                //    {
                //        byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                //        using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                //        {
                //            ICryptoTransform transform = tripDes.CreateEncryptor();
                //            byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                //            string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                //            string name = txtusername.Text;
                //            //string password = txtpassword.Text;

                //            SqlConnection con = new SqlConnection(cs);
                //            con.Open();
                //            //SqlCommand cmd = new SqlCommand("exec LoginPageUserSelect '"+name+"','"+ hc.PassHash(password)+"'", con);
                //            SqlCommand cmd = new SqlCommand("exec LoginPageUserSelect '" + name + "','" + UserPassword + "'", con);
                //            SqlDataReader dr = cmd.ExecuteReader();

                //            if (dr.HasRows)
                //            {
                //                LoginDialogbox1.Show();
                //                txtusername.Clear();
                //                txtpassword.Clear();
                //                cmdUserRole.SelectedItem = null;

                //                while (dr.Read())
                //                {
                //                    int x = dr.GetInt32(6);
                //                    MessageBox.Show(" " + x);
                //                }

                //                MasterPage m = new MasterPage();
                //                m.Show();
                //                this.Hide();


                //            }
                //            else
                //            {
                //                LoginDialog2.Show();
                //            }

                //            con.Close();
                //        }
                //    }



               
                userrole = cmdUserRole.SelectedItem.ToString();
               
                if (cmdUserRole.SelectedItem.ToString() == "Admin")
                {
                    IfAdminHasLogin();
                }
                else if (cmdUserRole.SelectedItem.ToString() == "Manager")
                {
                    IfManagerHasLogin();
                }
                else if (cmdUserRole.SelectedItem.ToString() == "Doctor")
                {
                    IfDoctorHasLogin();
                }
                else if (cmdUserRole.SelectedItem.ToString() == "Staff")
                {
                    IfStaffHasLogin();
                }

               

            }
        }

        private void btnClose_Click_3(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmdUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

      

        public void IfAdminHasLogin()
        {
            
                byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                        int role = 0;

                        SqlConnection con = new SqlConnection(cs);
                        string query = "select *from Login_Master where UserName=@user and Password=@pass and UserRole=@role";
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@user", txtusername.Text);
                        cmd.Parameters.AddWithValue("@pass", UserPassword);
                        cmd.Parameters.AddWithValue("@role", role);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            LoginDialogbox1.Show();



                        while (dr.Read())
                        {
                            username = dr.GetString(2);
                            password = dr.GetString(3);
                            dateofbrith = dr.GetDateTime(4);
                            emailId = dr.GetString(5);

                            MemoryStream ms = new MemoryStream((byte[])dr.GetValue(8));
                            userImage = Image.FromStream(ms);

                            mobileno = dr.GetString(9);
                            address = dr.GetString(10);
                           
                        }

                        MasterPage m = new MasterPage();
                            m.Show();
                            this.Hide();

                        }
                        else
                        {
                            LoginDialog2.Show();
                        }

                        con.Close();

                    }
                }
            
        }


        public void IfManagerHasLogin()
        {

            byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                    int role = 1;

                    SqlConnection con = new SqlConnection(cs);
                    string query = "select *from Login_Master where UserName=@user and Password=@pass and UserRole=@role";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@user", txtusername.Text);
                    cmd.Parameters.AddWithValue("@pass", UserPassword);
                    cmd.Parameters.AddWithValue("@role", role);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        LoginDialogbox1.Show();



                        while (dr.Read())
                        {
                            username = dr.GetString(2);
                            password = dr.GetString(3);
                            dateofbrith = dr.GetDateTime(4);
                            emailId = dr.GetString(5);

                            MemoryStream ms = new MemoryStream((byte[])dr.GetValue(8));
                            userImage = Image.FromStream(ms);

                            mobileno = dr.GetString(9);
                            address = dr.GetString(10);

                        }

                        MasterPage m = new MasterPage();
                        m.Show();
                        this.Hide();

                        m.btnUserMenu.Enabled = false;
                        m.btnStaffMenu.Enabled = false;
                        



                    }
                    else
                    {
                        LoginDialog2.Show();
                    }

                    con.Close();

                }
            }

        }


        public void IfDoctorHasLogin()
        {

            byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                    int role = 2;

                    SqlConnection con = new SqlConnection(cs);
                    string query = "select *from Login_Master where UserName=@user and Password=@pass and UserRole=@role";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@user", txtusername.Text);
                    cmd.Parameters.AddWithValue("@pass", UserPassword);
                    cmd.Parameters.AddWithValue("@role", role);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        LoginDialogbox1.Show();



                        while (dr.Read())
                        {
                            username = dr.GetString(2);
                            password = dr.GetString(3);
                            dateofbrith = dr.GetDateTime(4);
                            emailId = dr.GetString(5);

                            MemoryStream ms = new MemoryStream((byte[])dr.GetValue(8));
                            userImage = Image.FromStream(ms);

                            mobileno = dr.GetString(9);
                            address = dr.GetString(10);

                        }

                        MasterPage m = new MasterPage();
                        m.Show();
                        this.Hide();

                        m.btnDonorsRegistration.Enabled = false;
                        m.btnEditDonors.Enabled = false;
                       
                        m.btnAddBloodDonation.Enabled = false;

                        m.btnPatientsRegistration.Enabled = false;
                        m.btnEditPatients.Enabled = false;

                        m.btnAddBloodTransfer.Enabled = false;

                        m.btnBloodDiscardMenu.Enabled = false;

                        m.btnHospitalRegistration.Enabled = false;

                        m.btnAddDoctorMenu.Enabled = false;

                        m.btnUserMenu.Enabled = false;

                        m.btnAddStaffMenu.Enabled = false;

                        m.btnReportsMenu.Enabled = false;


                    }
                    else
                    {
                        LoginDialog2.Show();
                    }

                    con.Close();

                }
            }

        }


        public void IfStaffHasLogin()
        {

            byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                    int role = 3;

                    SqlConnection con = new SqlConnection(cs);
                    string query = "select *from Login_Master where UserName=@user and Password=@pass and UserRole=@role";
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@user", txtusername.Text);
                    cmd.Parameters.AddWithValue("@pass", UserPassword);
                    cmd.Parameters.AddWithValue("@role", role);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        LoginDialogbox1.Show();



                        while (dr.Read())
                        {
                            username = dr.GetString(2);
                            password = dr.GetString(3);
                            dateofbrith = dr.GetDateTime(4);
                            emailId = dr.GetString(5);

                            MemoryStream ms = new MemoryStream((byte[])dr.GetValue(8));
                            userImage = Image.FromStream(ms);

                            mobileno = dr.GetString(9);
                            address = dr.GetString(10);

                        }

                        MasterPage m = new MasterPage();
                        m.Show();
                        this.Hide();

                        m.btnHomeMenu.Enabled = false;
                        m.btnDonorMenu.Enabled = false;
                        m.btnBloodDonationMenu.Enabled = false;
                        m.btnPatientMenu.Enabled = false;
                        m.btnBloodTransferMenu.Enabled = false;
                        m.btnBloodDiscardMenu.Enabled = false;
                        m.btnHospitalMenu.Enabled = false;
                        m.btnDoctorMenu.Enabled = false;
                        m.btnUserMenu.Enabled = false;
                        m.btnAddStaffMenu.Enabled = false;
                        m.btnReportsMenu.Enabled = false;

                    }
                    else
                    {
                        LoginDialog2.Show();
                    }

                    con.Close();

                }
            }

        }


    }
}
