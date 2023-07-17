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
using System.Text.RegularExpressions;

namespace BloodBankManagementSystem
{
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        public void PatientAutoIncrementID()
        {
            txtPatientNo.Text = "P-" + DateTime.Now.ToString("hhmmss");
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            PatientAutoIncrementID();
        }


        public void ClearAllData()
        {
            txtName.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            cmbGender.SelectedItem = null;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbCity.SelectedItem = null;
            txtAddress.Clear();
            cmbBloodGroup.SelectedItem = null;
        }

     


        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
             else if(dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider2.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else if (cmbGender.SelectedItem == null)
            {
                errorProvider3.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider5.SetError(this.txtEmailID, "Please Enter Email ID !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider6.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbCity.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbCity, "Please Select A City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider7.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbBloodGroup.SelectedItem == null)
            {
                errorProvider8.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else
            {

                SqlConnection con1 = new SqlConnection(cs);
                string query = "select *from Patient_RegistrationTbl where PId=@id";
                SqlCommand cmd1 = new SqlCommand(query, con1);
                cmd1.Parameters.AddWithValue("@id", txtPatientNo.Text);
                con1.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Alreay Exist the record ID !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con1.Close();
                }
                else
                {


                    string id = txtPatientNo.Text;
                    string name = txtName.Text;
                    string gender = cmbGender.SelectedItem.ToString();
                    string mobile = txtMobileNo.Text;
                    string email = txtEmailID.Text;
                    string city = cmbCity.SelectedItem.ToString();
                    string address = txtAddress.Text;
                    string bloodgroup = cmbBloodGroup.SelectedItem.ToString();

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec InsertPatientRecordRegistration '" + id + "','" + name + "','" + dtpDateOfBrith.Value + "','" + gender + "','" + mobile + "','" + email + "','" + city + "','" + address + "','" + bloodgroup + "'", con);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Patient Record Save SuccessFul", "Patient Record Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAllData();
                        PatientAutoIncrementID();


                    }
                    else
                    {
                        MessageBox.Show("Patient Record Not Save", "Patient Record Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }


            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            ClearAllData();
            PatientAutoIncrementID();
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
            }
        }

        private void txtName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
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
                errorProvider1.SetError(this.txtName, "Please Enter The Only Latters , Can't Enter Numeric Value !");
            }
        }


        private void cmbGender_Leave_1(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                errorProvider3.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtMobileNo_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number !");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtMobileNo_KeyPress_1(object sender, KeyPressEventArgs e)
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
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Only Numeric Value !");
            }
        }

        private void txtEmailID_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider5.SetError(this.txtEmailID, "Please Enter Email ID !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider6.SetError(this.txtEmailID, "Invalid Email");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void cmbCity_Leave_1(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbCity, "Please Select A City");
                cmbCity.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void txtAddress_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider7.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void cmbBloodGroup_Leave_1(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem == null)
            {
                errorProvider8.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void dtpDateOfBrith_Leave(object sender, EventArgs e)
        {
            if (dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider2.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void dtpDateOfBrith_ValueChanged(object sender, EventArgs e)
        {
            
            if (dtpDateOfBrith.Value == DateTime.Now)
            {
                errorProvider2.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }
    }
}
