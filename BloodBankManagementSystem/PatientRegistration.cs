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
            txtPatientNo.Text = "P-" + DateTime.Now.ToString("hhmmssdd");
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            PatientAutoIncrementID();
            cmbGender.SelectedItem = "Select Gender";
            cmbGender.ForeColor = Color.Silver;
            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            cmbBloodGroup.SelectedItem = "Select Blood Group";
            cmbBloodGroup.ForeColor = Color.Silver;
            DataBindingForDoctorName();
            DataBindingForHospitalName();
        }


        public void ClearAllData()
        {
            DataBindingForDoctorName();
            DataBindingForHospitalName();
            txtName.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            cmbGender.SelectedItem = "Select Gender";
            cmbGender.ForeColor = Color.Silver;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            txtAddress.Clear();
            cmbBloodGroup.SelectedItem = "Select Blood Group";
            cmbBloodGroup.ForeColor = Color.Silver;
            cmbHospitalName.SelectedItem = null;
            cmbDoctorName.SelectedItem = null;
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
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
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
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider6.SetError(this.cmbCity, "Please Select A City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider7.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider8.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else if(cmbHospitalName.SelectedItem == null)
            {
                errorProvider9.SetError(this.cmbHospitalName, "Please Select Hospital Name");
                cmbHospitalName.Focus();
            }
            else if(cmbDoctorName.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDoctorName, "Please Select Doctor");
                cmbDoctorName.Focus();
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
                    SaveRecordDialogBox3.Show();
                    con1.Close();
                }
                else
                {


                    string id = txtPatientNo.Text;
                    string name = txtName.Text;
                    string gender = cmbGender.SelectedItem.ToString();
                    string mobile = txtMobileNo.Text;
                    string registrationdate = RegistrationDate.Value.ToString();
                    string email = txtEmailID.Text;
                    string city = cmbCity.SelectedItem.ToString();
                    string address = txtAddress.Text;
                    string bloodgroup = cmbBloodGroup.SelectedItem.ToString();
                    string hospitalname = cmbHospitalName.SelectedItem.ToString();
                    string doctorname = cmbDoctorName.SelectedItem.ToString();

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec InsertPatientRecordRegistration '" + id + "','" + name + "','" + dtpDateOfBrith.Value + "','" + gender + "','" + mobile + "','" + RegistrationDate.Value + "','" + email + "','" + city + "','" + address + "','" + bloodgroup + "','" + hospitalname + "','" + doctorname + "'", con);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        SaveRecordDialogBox1.Show();
                        ClearAllData();
                        PatientAutoIncrementID();
                       


                    }
                    else
                    {
                        SaveRecordDialogBox2.Show();
                    }
                }


            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
               DialogResult d=ResetDataDialogBox.Show();
            if (d==DialogResult.Yes)
            {
                ClearAllData();
                PatientAutoIncrementID();

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
            if (cmbGender.SelectedItem.ToString() == "Select Gender")
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
            if (cmbCity.SelectedItem.ToString() == "Select City")
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
            if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
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

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGender_Enter(object sender, EventArgs e)
        {
            cmbGender.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbCity_Enter(object sender, EventArgs e)
        {
            cmbCity.ForeColor = Color.FromArgb(68, 88, 112);

        }

        private void cmbBloodGroup_Enter(object sender, EventArgs e)
        {
            cmbBloodGroup.ForeColor = Color.FromArgb(68, 88, 112);

        }

        private void btnclose_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbHospitalName_Leave(object sender, EventArgs e)
        {
            if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider9.SetError(this.cmbHospitalName, "Please Select Hospital Name");
                cmbHospitalName.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void cmbDoctorName_Leave(object sender, EventArgs e)
        {
            if (cmbDoctorName.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDoctorName, "Please Select Doctor");
                cmbDoctorName.Focus();
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        public void DataBindingForHospitalName()
        {
            cmbHospitalName.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "select *from HospitalTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetString(2);
                cmbHospitalName.Items.Add(name);
            }
            con.Close();
        }
      
        public void DataBindingForDoctorName()
        {
            cmbDoctorName.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "select *from DoctorTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetString(2);
                cmbDoctorName.Items.Add(name);
            }
            con.Close();
        }
    }
}
