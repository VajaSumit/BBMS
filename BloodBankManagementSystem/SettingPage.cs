using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace BloodBankManagementSystem
{
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string hash = "f0xle@rn";

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEditSwitch.Checked == true)
            {
                txtName.Enabled = true;
                txtPassword.Enabled = true;
                dtpDateOfBrith.Enabled = true;
                txtEmailID.Enabled = true;
                txtMobileNo.Enabled = true;
                txtAddress.Enabled = true;
                btnBrowse.Enabled = true;
                btnupdate.Enabled = true;

            }
            else if (btnEditSwitch.Checked == false)
            {
                txtName.Enabled = false;
                txtPassword.Enabled = false;
                dtpDateOfBrith.Enabled = false;
                txtEmailID.Enabled = false;
                txtMobileNo.Enabled = false;
                txtAddress.Enabled = false;
                btnBrowse.Enabled = false;
                btnupdate.Enabled = false;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else if (ch == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider1.SetError(this.txtName, "Please Enter Only Alphabets ");

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider2.SetError(this.txtPassword, "Please Enter Password !");
                txtPassword.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtEmailID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider3.SetError(this.txtEmailID, "Please Enter The Email Id !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider3.SetError(this.txtEmailID, "Invalid Email");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
            {
                e.Handled = false;
            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Only Numeric Value");

            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider5.SetError(this.txtAddress, "Please Enter Address");
                txtAddress.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider2.SetError(this.txtPassword, "Please Enter Password !");
                txtPassword.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider3.SetError(this.txtEmailID, "Please Enter The Email Id !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider3.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider5.SetError(this.txtAddress, "Please Enter Address");
                txtAddress.Focus();
            }
            else
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(txtPassword.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        string UserPassword = Convert.ToBase64String(results, 0, results.Length);

                        SqlConnection con = new SqlConnection(cs);
                        string query = "update Login_Master set UserName=@name,Password=@password,Dob=@dob,Email=@email,Picture=@picture,Mobile=@mobile,Address=@address where UserName=@name";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@password", UserPassword);
                        cmd.Parameters.AddWithValue("@dob", dtpDateOfBrith.Value);
                        cmd.Parameters.AddWithValue("@email", txtEmailID.Text);


                        MemoryStream mem = new MemoryStream();
                        userPictureBox.Image.Save(mem, userPictureBox.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@picture", mem.ToArray());

                        cmd.Parameters.AddWithValue("@mobile", txtMobileNo.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBoxForUpdateProfile.Show();
                            DataBinding();
                        }

                        con.Close();
                    }
                }
            }
        }

        private void SettingPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        public void DataBinding()
        {
            txtName.Text = LoginPage.username;
            //txtPassword.Text = LoginPage.password;
            dtpDateOfBrith.Value = LoginPage.dateofbrith;
            txtEmailID.Text = LoginPage.emailId;
            txtMobileNo.Text = LoginPage.mobileno;
            txtAddress.Text = LoginPage.address;
            userPictureBox.Image = LoginPage.userImage;
            lblProfilename.Text = LoginPage.userrole;

            string encrypt = LoginPage.password;
            byte[] data = Convert.FromBase64String(encrypt);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtPassword.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "select Image :- ";
            open.Filter = "IMAGE FILE (* .png ;*.jpg ;*.bmp;*.gif)| *.png;*.jpg;*.bmp;*.gif ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    userPictureBox.Image = Image.FromFile(open.FileName);
                }
                catch (Exception)
                {
                    MessageBoxforBrowseImage.Show();
                }
            }
        }
    }

}
