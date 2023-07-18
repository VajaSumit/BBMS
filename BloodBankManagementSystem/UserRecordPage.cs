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
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using BloodBankManagementSystem.ClassFiles;
using System.Security.Cryptography;

namespace BloodBankManagementSystem
{
    public partial class UserRecordPage : Form
    {
        public UserRecordPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string hash = "f0xle@rn";


        HashCode hc = new HashCode();

     

        public void UserIdAutoGenerate()
        {
            txtUserid.Text = "U-" + DateTime.Now.ToString("hhmmss");

        }

        private void UserRecordPage_Load(object sender, EventArgs e)
        {
            DataBinding();
            UserIdAutoGenerate();
           

        }


        //public string imgurl = null;



        //private byte[] savephoto()
        //{
        //    MemoryStream ms = new MemoryStream();
        //    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
        //    return ms.GetBuffer();
        //}

        //private Image Getphoto(byte[] p)
        //{
        //    MemoryStream m = new MemoryStream(p);
        //    return Image.FromStream(m);
        //}

 

        public void ClearData()
        {

            UserIdAutoGenerate();
            txtName.Clear();
            txtPassword.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            txtEmailID.Clear();
            cmbUserRole.SelectedItem = null;
            cmbStatus.SelectedItem = null;
            pictureBox1.Image = null;
            txtMobileNo.Clear();
            txtAddress.Clear();
        }


        public void DataBinding()
        {
            // By Using Query

            SqlConnection con = new SqlConnection(cs);
            //con.Open();
            string query = "select *from Login_Master";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            UserDataList.RowTemplate.Height = 60;
            UserDataList.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)UserDataList.Columns[8];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //con.Close();

            //By Using Procedure

            //SqlConnection con = new SqlConnection(cs);


            ////SqlCommand cmd = new SqlCommand("exec ListUserRecord", con);
            ////SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //string query = "select *from Login_Master";
            //SqlDataAdapter sda = new SqlDataAdapter(query,con);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridView1.RowTemplate.Height = 75;
            //dataGridView1.DataSource = data;


            //DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            //dgv = (DataGridViewImageColumn)dataGridView1.Columns[8];
            //dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

 

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value) ;
            //{
            //    e.Cancel = true;
            //}
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
            //{
            //    if (cell.GetType()==typeof(DataGridViewImageCell))
            //    {
            //        cell.Value = DBNull.Value;
            //    }
            //}
        }


        private void UserDataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //HashCode hc = new HashCode();

            int i = int.Parse(UserDataList.SelectedRows[0].Cells[0].Value.ToString());
            txtUserid.Text = UserDataList.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = UserDataList.SelectedRows[0].Cells[2].Value.ToString();

            //int code = UserDataList.SelectedRows[0].Cells[3].Value.GetHashCode();
            //txtPassword.Text = code.ToString();

            string encrypt = UserDataList.SelectedRows[0].Cells[3].Value.ToString();
            byte[] data = Convert.FromBase64String(encrypt);
            using (MD5CryptoServiceProvider md5=new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes=new TripleDESCryptoServiceProvider() { Key=keys,Mode=CipherMode.ECB,Padding=PaddingMode.PKCS7 } )
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data,0,data.Length);
                    txtPassword.Text = UTF8Encoding.UTF8.GetString(results);
                }
            }

            dtpDateOfBrith.Value = Convert.ToDateTime(UserDataList.SelectedRows[0].Cells[4].Value.ToString());

            txtEmailID.Text = UserDataList.SelectedRows[0].Cells[5].Value.ToString();
            cmbUserRole.SelectedItem = UserDataList.SelectedRows[0].Cells[6].Value.ToString();
            cmbStatus.SelectedItem = UserDataList.SelectedRows[0].Cells[7].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])UserDataList.SelectedRows[0].Cells[8].Value);
            pictureBox1.Image = Image.FromStream(ms);

            txtMobileNo.Text = UserDataList.SelectedRows[0].Cells[9].Value.ToString();
            txtAddress.Text = UserDataList.SelectedRows[0].Cells[10].Value.ToString();
        }

  
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            DialogResult d=ResetDataDialogBox.Show();
            if (d == DialogResult.Yes)
            {
                ClearData();
                UserIdAutoGenerate();
            }
   
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
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
            else if (dtpDateOfBrith.Value.ToString("dd/MM/yyyy") == date)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Email Id !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbUserRole.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbUserRole, "Please Select User Role !");
                cmbUserRole.Focus();
            }
            else if (cmbStatus.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status !");
                cmbStatus.Focus();
            }
            else if (pictureBox1.Image == null)
            {
                errorProvider7.SetError(this.pictureBox1, "please select image !");
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider8.SetError(this.txtMobileNo, "Please Enter Mobile Number");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address");
                txtAddress.Focus();
            }
            else
            {
                //string id = txtUserid.Text;

                //SqlConnection con = new SqlConnection(cs);
                //con.Open();
                //SqlCommand cmd = new SqlCommand("exec DeleteUserRecord '" + id + "'", con);
                //int a = cmd.ExecuteNonQuery();
                //if (a > 0)
                //{
                //    MessageBox.Show("User Record Delete Successful !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ClearData();
                //    DataBinding();
                //}
                //else
                //{
                //    MessageBox.Show("User Record Not Deleted  !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
                //con.Close();

                DialogResult d=DeleteRecordDialogBox3.Show();
                if (d ==  DialogResult.Yes)
                {

                }
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from Login_Master where UserId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    DeleteRecordDialogBox1.Show();
                    ClearData();
                    UserIdAutoGenerate();
                    DataBinding();
                }
                else
                {
                    DeleteRecordDialogBox2.Show();
                }
                con.Close();

            }
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToString("dd/MM/yyyy");
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
            else if (dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Email Id !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbUserRole.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbUserRole, "Please Select User Role !");
                cmbUserRole.Focus();
            }
            else if (cmbStatus.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status !");
                cmbStatus.Focus();
            }
            else if (pictureBox1.Image == null)
            {
                errorProvider7.SetError(this.pictureBox1, "please select image !");
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider8.SetError(this.txtMobileNo, "Please Enter Mobile Number");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address");
                txtAddress.Focus();
            }
            else
            {
                //string id = txtUserid.Text;
                //string name = txtName.Text;
                //string password = txtPassword.Text;
                //DateTime dob = Convert.ToDateTime(dtpDateOfBrith.Value.ToString("dd/MM/yyyy"));
                //string email = txtEmailID.Text;
                //int userrole = int.Parse(cmbUserRole.SelectedItem.ToString());
                //bool status = Convert.ToBoolean(cmbStatus.SelectedItem.ToString());
                ////byte[] photo = savephoto();

                //MemoryStream mem = new MemoryStream();
                //pictureBox1.Image.Save(mem, pictureBox1.Image.RawFormat);

                //string mobile = txtMobileNo.Text;
                //string address = txtAddress.Text;

                //SqlConnection con = new SqlConnection(cs);
                //con.Open();
                //SqlCommand cmd = new SqlCommand("exec UpdateUserRecord '" + id + "','" + name + "','" + password + "','" + dob + "','" + email + "','" + userrole + "','" + status + "','" + mem.ToArray() + "','" + mobile + "','" + address + "'", con);
                //int a = cmd.ExecuteNonQuery();
                //if (a > 0)
                //{
                //    MessageBox.Show("User Record Update Successful !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ClearData();
                //    DataBinding();
                //}
                //else
                //{
                //    MessageBox.Show("User Record Not Updated  !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
                //con.Close();

                //****************************


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
                        string query = "update Login_Master set UserName=@name,Password=@password,Dob=@dob,Email=@email,UserRole=@userrole,Status=@status,Picture=@picture,Mobile=@mobile,Address=@address where UserId=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@password", UserPassword);
                        cmd.Parameters.AddWithValue("@dob", dtpDateOfBrith.Value.ToString("dd/MM/yyyy"));
                        cmd.Parameters.AddWithValue("@email", txtEmailID.Text);
                        cmd.Parameters.AddWithValue("@userrole", cmbUserRole.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem);

                        MemoryStream mem = new MemoryStream();
                        pictureBox1.Image.Save(mem, pictureBox1.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@picture", mem.ToArray());

                        cmd.Parameters.AddWithValue("@mobile", txtMobileNo.Text);
                        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            UpdateRecordDialogBox1.Show();
                            ClearData();
                            UserIdAutoGenerate();
                            DataBinding();
                        }
                        else
                        {
                            UpdateRecordDialogBox2.Show();
                        }
                        con.Close();
                    }
                }
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToString("dd/MM/yyyy");
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
            else if (dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Email Id !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbUserRole.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbUserRole, "Please Select User Role !");
                cmbUserRole.Focus();
            }
            else if (cmbStatus.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status !");
                cmbStatus.Focus();
            }
            else if (pictureBox1.Image == null)
            {
                errorProvider7.SetError(this.pictureBox1, "please select image !");
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider8.SetError(this.txtMobileNo, "Please Enter Mobile Number");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address");
                txtAddress.Focus();
            }
            else
            {
                //string id = txtUserid.Text;
                //string name = txtName.Text;
                //string password = txtPassword.Text;
                //DateTime dob = Convert.ToDateTime(dtpDateOfBrith.Value.ToString("dd/MM/yyyy"));
                //string email = txtEmailID.Text;
                //int userrole = int.Parse(cmbUserRole.SelectedItem.ToString());
                //bool status = Convert.ToBoolean(cmbStatus.SelectedItem.ToString());
                ////byte[] photo = savephoto();

                //MemoryStream mem = new MemoryStream();
                //pictureBox1.Image.Save(mem, pictureBox1.Image.RawFormat);

                //string mobile = txtMobileNo.Text;
                //string address = txtAddress.Text;



                //SqlConnection con = new SqlConnection(cs);
                //con.Open();
                //SqlCommand cmd = new SqlCommand("exec InsertUserRecord '" + id + "','" + name + "','" + password + "','" + dob + "','" + email + "','" + userrole + "','" + status + "','" + mem.ToArray() + "','" + mobile + "','" + address + "'", con);
                //int a = cmd.ExecuteNonQuery();
                //if (a > 0)
                //{
                //    MessageBox.Show("User Record Save Successful !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    ClearData();
                //    UserIdAutoGenerate();
                //    DataBinding();
                //}
                //else
                //{
                //    MessageBox.Show("User Record Not Saved  !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
                //con.Close();


                // ***************************

                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "select *from Login_Master where UserId=@id";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                cmd1.Parameters.AddWithValue("@id", txtUserid.Text);
                con1.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.HasRows)
                {
                    SaveRecordDailogBox1.Show();
                    con1.Close();
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
                            string query = "insert into Login_Master values(@id,@name,@password,@dob,@email,@userrole,@status,@picture,@mobile,@address)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                            cmd.Parameters.AddWithValue("@name", txtName.Text);
                            //cmd.Parameters.AddWithValue("@password", hc.PassHash(txtPassword.Text));

                            cmd.Parameters.AddWithValue("@password", UserPassword);

                            cmd.Parameters.AddWithValue("@dob", dtpDateOfBrith.Value.ToString("dd/MM/yyyy"));
                            cmd.Parameters.AddWithValue("@email", txtEmailID.Text);
                            cmd.Parameters.AddWithValue("@userrole", cmbUserRole.SelectedItem);
                            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem);

                            MemoryStream mem = new MemoryStream();
                            pictureBox1.Image.Save(mem, pictureBox1.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@picture", mem.ToArray());

                            cmd.Parameters.AddWithValue("@mobile", txtMobileNo.Text);
                            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                            con.Open();
                            int a = cmd.ExecuteNonQuery();

                            if (a > 0)
                            {
                                SaveRecordDialogBox2.Show();
                                ClearData();
                                UserIdAutoGenerate();
                                DataBinding();
                            }
                            else
                            {
                                SaveRecordDialogBox3.Show();
                            }

                            con.Close();

                        }
                    }
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "select Image :- ";
            open.Filter = "IMAGE FILE (* .png ;*.jpg ;*.bmp;*.gif)| *.png;*.jpg;*.bmp;*.gif ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Bitmap m= new Bitmap(open.FileName);
                //pictureBox1.Image = m;

                //imgurl = open.FileName;
                //pictureBox1.Image = Image.FromFile(open.FileName);

                try
                {
                    pictureBox1.Image = Image.FromFile(open.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Select The Valid Image !");
                }
            }
        }

        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else
            {
                errorProvider1.Clear();
                txtPassword.Focus();
            }
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtPassword_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) == true)
            {
                errorProvider2.SetError(this.txtPassword, "Please Enter Password !");
                txtPassword.Focus();
            }
            else
            {
                errorProvider2.Clear();
                dtpDateOfBrith.Focus();
            }
        }

        private void txtEmailID_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Email Id !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
            }
            else
            {
                errorProvider4.Clear();
                cmbUserRole.Focus();
            }
        }

        private void cmbUserRole_Leave_1(object sender, EventArgs e)
        {
            if (cmbUserRole.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbUserRole, "Please Select User Role !");
                cmbUserRole.Focus();
            }
            else
            {
                errorProvider5.Clear();
                cmbStatus.Focus();

            }
        }

        private void cmbStatus_Leave_1(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status !");
                cmbStatus.Focus();
            }
            else
            {
                errorProvider6.Clear();

            }
        }

        private void txtMobileNo_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider8.SetError(this.txtMobileNo, "Please Enter Mobile Number");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider8.Clear();
                txtAddress.Focus();
            }
        }

        private void txtMobileNo_KeyPress_1(object sender, KeyPressEventArgs e)
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
                errorProvider8.SetError(this.txtMobileNo, "Please Enter Only Numeric Value");

            }
        }

        private void txtAddress_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address");
                txtAddress.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void chkshowpassword_CheckedChanged_1(object sender, EventArgs e)
        {
         
        }

        private void dtpDateOfBrith_Leave_1(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (dtpDateOfBrith.Value.ToString("dd/MM/yyyy") == date)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider3.Clear();
                txtEmailID.Focus();
            }
        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshowpassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else if (chkshowpassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
