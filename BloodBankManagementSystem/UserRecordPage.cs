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

        HashCode hc = new HashCode();

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                errorProvider8.SetError(this.txtMobileNo, "Please Enter Only Numeric Value");

            }

        }

        public void UserIdAutoGenerate()
        {
            txtUserid.Text = "U-" + DateTime.Now.ToString("hhmmss");

        }

        private void UserRecordPage_Load(object sender, EventArgs e)
        {
            DataBinding();
            UserIdAutoGenerate();
           

        }

        private void txtUserid_Enter(object sender, EventArgs e)
        {
            txtUserid.BackColor = Color.LightCyan;
        }

        private void txtUserid_Leave(object sender, EventArgs e)
        {
            txtUserid.BackColor = Color.White;
            txtName.Focus();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.LightCyan;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;

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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightCyan;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
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

        private void dtpDateOfBrith_Enter(object sender, EventArgs e)
        {
            dtpDateOfBrith.CalendarForeColor = Color.Black;
        }

        private void dtpDateOfBrith_Leave(object sender, EventArgs e)
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

        private void txtEmailID_Enter(object sender, EventArgs e)
        {
            txtEmailID.BackColor = Color.LightCyan;
        }

        private void txtEmailID_Leave(object sender, EventArgs e)
        {
            txtEmailID.BackColor = Color.White;
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

        private void cmbUserRole_Enter(object sender, EventArgs e)
        {
            cmbUserRole.BackColor = Color.LightCyan;
        }

        private void cmbUserRole_Leave(object sender, EventArgs e)
        {
            cmbUserRole.BackColor = Color.White;
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

        private void cmbStatus_Enter(object sender, EventArgs e)
        {
            cmbStatus.BackColor = Color.LightCyan;
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            cmbStatus.BackColor = Color.White;
            if (cmbStatus.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status !");
                cmbStatus.Focus();
            }
            else
            {
                errorProvider6.Clear();
                btnBrowse.Focus();
            }
        }

        private void txtMobileNo_Enter(object sender, EventArgs e)
        {
            txtMobileNo.BackColor = Color.LightCyan;
        }



        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            txtMobileNo.BackColor = Color.White;
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

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.LightCyan;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.White;
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

        //public string imgurl = null;

        private void btnBrawse_Click(object sender, EventArgs e)
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
             
                pictureBox1.Image = Image.FromFile(open.FileName);
            }

        }

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {

            UserIdAutoGenerate();
            txtName.Clear();
            txtPassword.Clear();
            //dtpDateOfBrith.Value = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            txtEmailID.Clear();
            cmbUserRole.SelectedItem = null;
            cmbStatus.SelectedItem = null;
            pictureBox1.Image = null;
            txtMobileNo.Clear();
            txtAddress.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
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


                SqlConnection con = new SqlConnection(cs);
                string query = "insert into Login_Master values(@id,@name,@password,@dob,@email,@userrole,@status,@picture,@mobile,@address)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@password", hc.PassHash(txtPassword.Text));
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
                    MessageBox.Show("User Record Save Successful !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    UserIdAutoGenerate();
                    DataBinding();
                }
                else
                {
                    MessageBox.Show("User Record Not Saved  !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
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

        private void btnupdate_Click(object sender, EventArgs e)
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


                SqlConnection con = new SqlConnection(cs);
                string query = "update Login_Master set UserName=@name,Password=@password,Dob=@dob,Email=@email,UserRole=@userrole,Status=@status,Picture=@picture,Mobile=@mobile,Address=@address where UserId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
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
                    MessageBox.Show("User Record Update Successful !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    UserIdAutoGenerate();
                    DataBinding();
                }
                else
                {
                    MessageBox.Show("User Record Not Updated  !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
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


                SqlConnection con = new SqlConnection(cs);
                string query = "delete from Login_Master where UserId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtUserid.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("User Record Delete Successful !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    UserIdAutoGenerate();
                    DataBinding();
                }
                else
                {
                    MessageBox.Show("User Record Not Delete  !", "User Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
       
           
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

        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
  

        }

        private void UserDataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = int.Parse(UserDataList.SelectedRows[0].Cells[0].Value.ToString());
            txtUserid.Text = UserDataList.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = UserDataList.SelectedRows[0].Cells[2].Value.ToString();
            txtPassword.Text = UserDataList.SelectedRows[0].Cells[3].Value.ToString();

            dtpDateOfBrith.Value = Convert.ToDateTime(UserDataList.SelectedRows[0].Cells[4].Value);

            txtEmailID.Text = UserDataList.SelectedRows[0].Cells[5].Value.ToString();
            cmbUserRole.SelectedItem = UserDataList.SelectedRows[0].Cells[6].Value.ToString();
            cmbStatus.SelectedItem = UserDataList.SelectedRows[0].Cells[7].Value.ToString();

            MemoryStream ms = new MemoryStream((byte[])UserDataList.SelectedRows[0].Cells[8].Value);
            pictureBox1.Image = Image.FromStream(ms);
            txtMobileNo.Text = UserDataList.SelectedRows[0].Cells[9].Value.ToString();
            txtAddress.Text = UserDataList.SelectedRows[0].Cells[10].Value.ToString();
        }
    }
}
