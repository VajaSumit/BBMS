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

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        public void PatientAutoIncrementID()
        {
            txtPatientNo.Text = "P-" + DateTime.Now.ToString("hhmmss");
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            PatientAutoIncrementID();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)==true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
            txtName.BackColor = Color.White;

        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAge.Text) == true)
            {
                errorProvider2.SetError(this.txtAge, "Please Enter Age !");
                txtAge.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
            txtAge.BackColor = Color.White;

        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem==null)
            {
                errorProvider3.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
            cmbGender.BackColor = Color.White;

        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
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
            txtMobileNo.BackColor = Color.White;

        }

        private void txtEmailID_Leave(object sender, EventArgs e)
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
            txtEmailID.BackColor = Color.White;

        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem==null)
            {
                errorProvider6.SetError(this.cmbCity, "Please Select A City");
                cmbCity.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
            cmbCity.BackColor = Color.White;

        }

        private void txtAddress_Leave(object sender, EventArgs e)
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
            txtAddress.BackColor = Color.White;

        }

        private void cmbBloodGroup_Leave(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem==null)
            {
                errorProvider8.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
            cmbBloodGroup.BackColor = Color.White;

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider2.SetError(this.txtAge, "Please Enter Only Numeric Value !");
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
                errorProvider4.SetError(this.txtAge, "Please Enter Only Numeric Value !");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllData();
            PatientAutoIncrementID();
         
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtAge.Text) == true)
            {
                errorProvider2.SetError(this.txtAge, "Please Enter Age !");
                txtAge.Focus();
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
                string id = txtPatientNo.Text;
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string gender = cmbGender.SelectedItem.ToString();
                string mobile = txtMobileNo.Text;
                string email = txtEmailID.Text;
                string city = cmbCity.SelectedItem.ToString();
                string address = txtAddress.Text;
                string bloodgroup = cmbBloodGroup.SelectedItem.ToString();

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("exec InsertPatientRecordRegistration '" + id + "','" + name + "','" + age + "','" + gender + "','" + mobile + "','" + email + "','" + city + "','" + address + "','" + bloodgroup + "','",con);
                int a = cmd.ExecuteNonQuery();
                if ( a > 0)
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

        public void ClearAllData()
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedItem = null;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbCity.SelectedItem = null;
            txtAddress.Clear();
            cmbBloodGroup.SelectedItem = null;
        }

        private void txtPatientNo_Enter(object sender, EventArgs e)
        {
            txtPatientNo.BackColor = Color.LightCyan;

        }

        private void txtPatientNo_Leave(object sender, EventArgs e)
        {
            txtPatientNo.BackColor = Color.White;

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.LightCyan;

        }

        private void txtAge_Enter(object sender, EventArgs e)
        {
            txtAge.BackColor = Color.LightCyan;

        }

        private void cmbGender_Enter(object sender, EventArgs e)
        {
            cmbGender.BackColor = Color.LightCyan;

        }

        private void txtMobileNo_Enter(object sender, EventArgs e)
        {
            txtMobileNo.BackColor = Color.LightCyan;

        }

        private void txtEmailID_Enter(object sender, EventArgs e)
        {
            txtEmailID.BackColor = Color.LightCyan;

        }

        private void cmbCity_Enter(object sender, EventArgs e)
        {
            cmbCity.BackColor = Color.LightCyan;

        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.BackColor = Color.LightCyan;

        }

        private void cmbBloodGroup_Enter(object sender, EventArgs e)
        {
            cmbBloodGroup.BackColor = Color.LightCyan;

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
