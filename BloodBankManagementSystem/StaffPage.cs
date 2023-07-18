using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace BloodBankManagementSystem
{
    public partial class StaffPage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
      
         public StaffPage()
        {
            InitializeComponent();
        }


        public void SatffIDAutoGenerate()
        {
            txtStaffID.Text = "U-" + DateTime.Now.ToString("hhmmss");

        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            SatffIDAutoGenerate();
            DataBinding();
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

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                errorProvider2.SetError(this.cmbGender, "Please select Gender");
                cmbGender.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void dtpDateOfBrith_Leave(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (dtpDateOfBrith.Value.ToShortDateString() == date)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider3.Clear();
                //DateTime selectedDate = dtpDateOfBrith.Value;
                //    int age = DateTime.Now.Year - selectedDate.Year;
                //    if (DateTime.Now.DayOfYear < selectedDate.DayOfYear)
                //    {
                //        age -= 1;
                //    }
                //    txtAge.Text = age.ToString();
            }
        }

        private void cmbJobRole_Leave(object sender, EventArgs e)
        {
            if (cmbJobRole.SelectedItem==null)
            {
                errorProvider4.SetError(this.cmbJobRole,"Please Select The Work Role !!");
                cmbJobRole.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem==null)
            {
                errorProvider5.SetError(this.cmbStatus,"Please Select Status (true/false) ! ");
                cmbStatus.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNo.Text)==true)
            {
                errorProvider6.SetError(this.txtMobileNo,"Please Enter Mobile Number !");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
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
                errorProvider6.SetError(this.txtMobileNo,"Please Enter Only Digits !");
            }
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem==null)
            {
                errorProvider7.SetError(this.cmbCity,"Please Select City !");
                cmbCity.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text)==true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address !");
                txtAddress.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void dtpDateOfBrith_ValueChanged(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (dtpDateOfBrith.Value.ToShortDateString() == date)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider3.Clear();
                //DateTime selectedDate = dtpDateOfBrith.Value;
                //int age = DateTime.Now.Year - selectedDate.Year;
                //if (DateTime.Now.DayOfYear < selectedDate.DayOfYear)
                //{
                //    age -= 1;
                //}
                //txtAge.Text = age.ToString();

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearData()
        {
            SatffIDAutoGenerate();
            txtName.Clear();
            cmbGender.SelectedItem = null;
            dtpDateOfBrith.Value = DateTime.Now;
            cmbJobRole.SelectedItem = null;
            cmbStatus.SelectedItem = null;
            txtMobileNo.Clear();
            cmbCity.SelectedItem = null;
            txtAddress.Clear();


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
           else if(cmbGender.SelectedItem == null)
            {
                errorProvider2.SetError(this.cmbGender, "Please select Gender");
                cmbGender.Focus();
            }
           else if(dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else if(cmbJobRole.SelectedItem == null)
            {
                errorProvider4.SetError(this.cmbJobRole, "Please Select The Work Role !!");
                cmbJobRole.Focus();
            }
            else if (cmbStatus.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbStatus, "Please Select Status (true/false) ! ");
                cmbStatus.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider6.SetError(this.txtMobileNo, "Please Enter Mobile Number !");
                txtMobileNo.Focus();
            }
           else if(cmbCity.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbCity, "Please Select City !");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address !");
                txtAddress.Focus();
            }
            else
            {

                SqlConnection con1 = new SqlConnection(cs);
                string query = "select *from  StaffTbl where StaffId=@id";
                SqlCommand cmd1 = new SqlCommand(query, con1);
                cmd1.Parameters.AddWithValue("@id", txtStaffID.Text);
                con1.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.HasRows)
                {
                    SaveRecordDialogBox1.Show();
                    con1.Close();
                }
                else
                {
                    string id = txtStaffID.Text;
                    string name = txtName.Text;
                    string gender = cmbGender.SelectedItem.ToString();
                    //DateTime dob = Convert.ToDateTime(dtpDateOfBrith.Value.ToString("dd/MM/yyyy"));
                   
                    string jobrole = cmbJobRole.SelectedItem.ToString();
                    string status = cmbStatus.SelectedItem.ToString();
                    string mobile = txtMobileNo.Text;
                    string city = cmbCity.SelectedItem.ToString();
                    string address = txtAddress.Text;

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec InsertStaffRecord '" + id + "','" + name + "','" + gender + "','" + dtpDateOfBrith.Value + "','" + jobrole + "','" + status + "','" + mobile + "','" + city + "','" + address + "'", con);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        SaveRecordDialogbox2.Show();
                        SatffIDAutoGenerate();
                        ClearData();
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

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult d=ResetDataDailogBox.Show();
            if (d == DialogResult.Yes)
            {
                ClearData();
                SatffIDAutoGenerate();
            }
          
        }


        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListStaffRecord", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            StaffDataList.DataSource = data;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else if (cmbGender.SelectedItem == null)
            {
                errorProvider2.SetError(this.cmbGender, "Please select Gender");
                cmbGender.Focus();
            }
            else if (dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else if (cmbJobRole.SelectedItem == null)
            {
                errorProvider4.SetError(this.cmbJobRole, "Please Select The Work Role !!");
                cmbJobRole.Focus();
            }
            else if (cmbStatus.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbStatus, "Please Select Status (true/false) ! ");
                cmbStatus.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider6.SetError(this.txtMobileNo, "Please Enter Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (cmbCity.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbCity, "Please Select City !");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address !");
                txtAddress.Focus();
            }
            else
            {

                string id = txtStaffID.Text;
                string name = txtName.Text;
                string gender = cmbGender.SelectedItem.ToString();
                //DateTime dob = Convert.ToDateTime(dtpDateOfBrith.Value.ToString("dd/MM/yyyy"));
              
                string jobrole = cmbJobRole.SelectedItem.ToString();
                string status = cmbStatus.SelectedItem.ToString();
                string mobile = txtMobileNo.Text;
                string city = cmbCity.SelectedItem.ToString();
                string address = txtAddress.Text;

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("exec UpdateStaffRecord '" + id + "','" + name + "','" + gender + "','" + dtpDateOfBrith.Value + "','"  + jobrole + "','" + status + "','" + mobile + "','" + city + "','" + address + "'", con);
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    UpdateRecordDialogBox1.Show();
                    SatffIDAutoGenerate();
                    ClearData();
                    DataBinding();
                }
                else
                {
                    UpdateRecordDialogBox2.Show();
                }
                con.Close();

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else if (cmbGender.SelectedItem == null)
            {
                errorProvider2.SetError(this.cmbGender, "Please select Gender");
                cmbGender.Focus();
            }
            else if (dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else if (cmbJobRole.SelectedItem == null)
            {
                errorProvider4.SetError(this.cmbJobRole, "Please Select The Work Role !!");
                cmbJobRole.Focus();
            }
            else if (cmbStatus.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbStatus, "Please Select Status (true/false) ! ");
                cmbStatus.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider6.SetError(this.txtMobileNo, "Please Enter Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (cmbCity.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbCity, "Please Select City !");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address !");
                txtAddress.Focus();
            }
            else
            {
                DialogResult d=DeleteRecordDialogBox1.Show();
                if (d == DialogResult.Yes)
                {
                    string id = txtStaffID.Text;

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec DeleteStaffRecord '" + id + "' ", con);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        DeleteRecordDialogBox2.Show();
                        SatffIDAutoGenerate();
                        ClearData();
                        DataBinding();
                    }
                    else
                    {
                        DeleteRecordDialogBox3.Show();
                    }
                    con.Close();
                }
           

            }
        }

        private void StaffDataList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(StaffDataList.SelectedRows[0].Cells[0].Value.ToString());
            txtStaffID.Text = StaffDataList.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = StaffDataList.SelectedRows[0].Cells[2].Value.ToString();
             cmbGender.SelectedItem = StaffDataList.SelectedRows[0].Cells[3].Value.ToString();
            dtpDateOfBrith.Value = Convert.ToDateTime(StaffDataList.SelectedRows[0].Cells[4].Value.ToString());
            cmbJobRole.SelectedItem = StaffDataList.SelectedRows[0].Cells[5].Value.ToString();
            cmbStatus.SelectedItem = StaffDataList.SelectedRows[0].Cells[6].Value.ToString();
            txtMobileNo.Text = StaffDataList.SelectedRows[0].Cells[7].Value.ToString();
            cmbCity.SelectedItem = StaffDataList.SelectedRows[0].Cells[8].Value.ToString();
            txtAddress.Text = StaffDataList.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            //DateTime selectedDate = dtpDateOfBrith.Value;
            //int age = DateTime.Now.Year - selectedDate.Year;
            //if (DateTime.Now.DayOfYear < selectedDate.DayOfYear)
            //{
            //    age -= 1;
            //}
            //txtAge.Text = age.ToString();
        }
    }
}
