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
using System.Data.SqlClient;
using System.Configuration;

namespace BloodBankManagementSystem
{
    public partial class DonorRegistrationPage : Form
    {
        public DonorRegistrationPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";


    private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DonorRegistrationPage_Load(object sender, EventArgs e)
        {
            DonorIdAutoGenerate();
            cmbGender.SelectedItem = "Select Gender";
            cmbGender.ForeColor = Color.Silver;
            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            cmbBloodGroup.SelectedItem = "Select Blood Group";
            cmbBloodGroup.ForeColor = Color.Silver;
        }

        public void DonorIdAutoGenerate()
        {
            txtDonorNo.Text = "D-" + DateTime.Now.ToString("hhmmssdd");

        }


        public void ClearData()
        {
           
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
            txtHeight.Clear();
            txtWeight.Clear();
            ToDayDate.Value = DateTime.Now;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
            txtDonorNo.Text = "D-" + DateTime.Now.ToString("hhmmssdd");

        }

  

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider2.SetError(this.txtName, "Please Enter The Donor Name ..");
                txtName.Focus();
            }
            else if(dtpDateOfBrith.Value.ToShortDateString() == date)
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                cmbGender.Focus();
                errorProvider4.SetError(this.cmbGender, "Please select gender !!");
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider5.SetError(this.txtMobileNo, "Please Enter the Mobile Number");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider6.SetError(this.txtEmailID, "Please Enter The Email ..");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider6.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                cmbCity.Focus();
                errorProvider7.SetError(this.cmbCity, "Please select city !!");
            }

            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address ..");
                txtAddress.Focus();
            }
            else if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                cmbBloodGroup.Focus();
                errorProvider9.SetError(this.cmbBloodGroup, "Please select blood group !!");
            }

            else if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider10.SetError(this.txtHeight, "Please Enter the height ");
                txtHeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider11.SetError(this.txtWeight, "Please Enter the Weight ");
                txtWeight.Focus();
            }
            else
            {
                // Data Inserting By Using Query

                //SqlConnection con = new SqlConnection(cs);
                //string query = "insert into Donor_RegistrationTbl values(@id,@name,@age,@gender,@mobile,@email,@city,@address,@bloodgroup,@height,@weight)";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@id", txtDonorNo.Text);
                //cmd.Parameters.AddWithValue("@name", txtName.Text);
                //cmd.Parameters.AddWithValue("@age", txtAge.Text);
                //cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                //cmd.Parameters.AddWithValue("@mobile", txtMobileNo.Text);
                //cmd.Parameters.AddWithValue("@email", txtEmailID.Text);
                //cmd.Parameters.AddWithValue("@city", cmbCity.SelectedItem.ToString());
                //cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                //cmd.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem.ToString());
                //cmd.Parameters.AddWithValue("@height", txtHeight.Text);
                //cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                //con.Open();

                SqlConnection con1 = new SqlConnection(cs);
                string query = "select *from Donor_RegistrationTbl where DId=@id";
                SqlCommand cmd1 = new SqlCommand(query, con1);
                cmd1.Parameters.AddWithValue("@id", txtDonorNo.Text);
                con1.Open();
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.HasRows)
                {
                    SaveDailogBox3.Show();
                    con1.Close();
                }
                else
                {

                    //Data Insert By using Procedure

                    string id = txtDonorNo.Text;
                    string name = txtName.Text;
                    string gender = cmbGender.SelectedItem.ToString();
                    string mobile = txtMobileNo.Text;
                    string email = txtEmailID.Text;
                    string city = cmbCity.SelectedItem.ToString();
                    string address = txtAddress.Text;
                    string bloodgroup = cmbBloodGroup.SelectedItem.ToString();
                    int height = int.Parse(txtHeight.Text);
                    int weight = int.Parse(txtWeight.Text);

                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec InsertDonorRecordRegistration '" + id + "','" + name + "','" + dtpDateOfBrith.Value + "','" + gender + "','" + ToDayDate.Value  + "','" + mobile + "','" + email + "','" + city + "','" + address + "','" + bloodgroup + "','" + height + "','" + weight + "'", con);

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        //MessageBox.Show("Donor Registration Successful !", "Registration Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SaveButtonMessageDialog.Show();
                        ClearData();
                        DonorIdAutoGenerate();

                    }
                    else
                    {
                        //MessageBox.Show("Donor Registration Faild !", "Registration Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SaveButtonMessageBox2.Show();

                    }
                    con.Close();
                }

            }


        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
           DialogResult d=ResetButtonDailogBox.Show();
            if (d==DialogResult.Yes)
            {
                ClearData();
                txtDonorNo.Text = "D-" + DateTime.Now.ToString("hhmmssdd");
            }

           
        }

        private void txtName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider2.SetError(this.txtName, "Please Enter The Donor Name ..");
                txtName.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
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
                errorProvider2.SetError(this.txtName, "Please Enter The Only Latters , Can't Enter Numeric Value !");
            }
        }


        private void cmbGender_Leave_1(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                cmbGender.Focus();
                errorProvider4.SetError(this.cmbGender, "Please select gender !!");
            }
            else
            {
                errorProvider4.Clear();
            }

        }

        private void txtMobileNo_Leave_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider5.SetError(this.txtMobileNo, "Please Enter the Mobile Number");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }

        }

        private void txtMobileNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)   //backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider5.SetError(this.txtMobileNo, "Please Enter Only Numeric Value");

            }

        }

        private void txtEmailID_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider6.SetError(this.txtEmailID, "Please Enter The Email ..");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider6.SetError(this.txtEmailID, "Invalid Email");
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void cmbCity_Leave_1(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                cmbCity.Focus();
                errorProvider7.SetError(this.cmbCity, "Please select city !!");
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtAddress_Leave_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address ..");
                txtAddress.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void cmbBloodGroup_Leave_1(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                cmbBloodGroup.Focus();
                errorProvider9.SetError(this.cmbBloodGroup, "Please select blood group !!");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void txtHeight_Leave_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider10.SetError(this.txtHeight, "Please Enter the height ");
                txtHeight.Focus();
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void txtHeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)   //backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider10.SetError(this.txtHeight, "Please Enter Only Numeric Value");

            }
        }

        private void txtWeight_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider11.SetError(this.txtWeight, "Please Enter the Weight ");
                txtWeight.Focus();
            }
            else
            {
                errorProvider11.Clear();
            }
        }

        private void txtWeight_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8)   //backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider11.SetError(this.txtWeight, "Please Enter Only Numeric Value");

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
            }
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
    }
}
