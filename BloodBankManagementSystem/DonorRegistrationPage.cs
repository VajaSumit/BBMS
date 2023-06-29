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

        }

        public void DonorIdAutoGenerate()
        {
            txtDonorNo.Text = "D-" + DateTime.Now.ToString("hhmmss");

        }

        private void txtDonorNo_Leave(object sender, EventArgs e)
        {
            txtDonorNo.BackColor = Color.White;

        }

        private void txtName_Leave(object sender, EventArgs e)
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

            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.Black;
        }

        private void txtAge_Leave(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtAge.Text)==true)
            {
                errorProvider3.SetError(this.txtAge, "Please Enter the Age");
                txtAge.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }

            txtAge.BackColor = Color.White;
            txtAge.ForeColor = Color.Black;
        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
         

            if (cmbGender.SelectedItem == null)
            {
                cmbGender.Focus();
                errorProvider4.SetError(this.cmbGender, "Please select gender !!");
            }
            else
            {
                errorProvider4.Clear();
            }

            cmbGender.BackColor = Color.White;
            cmbGender.ForeColor = Color.Black;
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
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

            txtMobileNo.BackColor = Color.White;
            txtMobileNo.ForeColor = Color.Black;

        }

        private void txtEmailID_Leave(object sender, EventArgs e)
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

            txtEmailID.BackColor = Color.White;
            txtEmailID.ForeColor = Color.Black;
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
          

            if (cmbCity.SelectedItem == null)
            {
                cmbCity.Focus();
                errorProvider7.SetError(this.cmbCity, "Please select city !!");
            }
            else
            {
                errorProvider7.Clear();
            }
            cmbCity.BackColor = Color.White;
            cmbCity.ForeColor = Color.Black;

        }

        private void txtAddress_Leave(object sender, EventArgs e)
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
            txtAddress.BackColor = Color.White;
            txtAddress.ForeColor = Color.Black;
        }

        private void cmbBloodGroup_Leave(object sender, EventArgs e)
        {
          


                if (cmbBloodGroup.SelectedItem == null)
                {
                    cmbBloodGroup.Focus();
                    errorProvider9.SetError(this.cmbBloodGroup, "Please select blood group !!");
                }
                else
                {
                    errorProvider9.Clear();
                }

            cmbBloodGroup.BackColor = Color.White;
            cmbBloodGroup.ForeColor = Color.Black;



        }

        private void txtHeight_Leave(object sender, EventArgs e)
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
            txtHeight.BackColor = Color.White;
            txtHeight.ForeColor = Color.Black;

        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
           


            if (string.IsNullOrEmpty(txtWeight.Text)==true)
            {
                errorProvider11.SetError(this.txtWeight, "Please Enter the Weight ");
                txtWeight.Focus();
            }
            else
            {
                errorProvider11.Clear();
            }
            txtWeight.BackColor = Color.White;
            txtWeight.ForeColor = Color.Black;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider2.SetError(this.txtName, "Please Enter The Donor Name ..");
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtAge.Text) == true)
            {
                errorProvider3.SetError(this.txtAge, "Please Enter the Age");
                txtAge.Focus();
            }
            else if (cmbGender.SelectedItem == null)
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
            else if (cmbCity.SelectedItem == null)
            {
                cmbCity.Focus();
                errorProvider7.SetError(this.cmbCity, "Please select city !!");
            }

            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider8.SetError(this.txtAddress, "Please Enter The Address ..");
                txtAddress.Focus();
            }
            else if (cmbBloodGroup.SelectedItem == null)
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
                //MessageBox.Show("Data Inserted ...!");

                SqlConnection con = new SqlConnection(cs);
                string query = "insert into Donor_RegistrationTbl values(@id,@name,@age,@gender,@mobile,@email,@city,@address,@bloodgroup,@height,@weight)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtDonorNo.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@mobile", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@email", txtEmailID.Text);
                cmd.Parameters.AddWithValue("@city", cmbCity.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@height", txtHeight.Text);
                cmd.Parameters.AddWithValue("@weight", txtWeight.Text);
                con.Open();

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    MessageBox.Show("Donor Registration Successful !", "Registration Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    DonorIdAutoGenerate();

                }
                else
                {
                    MessageBox.Show("Donor Registration Faild !", "Registration Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();

            }




        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider3.SetError(this.txtAge, "Please Enter Only Numeric Value");

            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem == null)
            {
                cmbGender.Focus();
                errorProvider4.SetError(this.cmbGender, "Please select gender !!");
            }

            else
            {
                errorProvider4.Clear();
            }
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem == null)
            {
                cmbCity.Focus();
                errorProvider7.SetError(this.cmbCity, "Please select city !!");
            }
            else
            {
                errorProvider7.Clear();
            }

        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem == null)
            {
                cmbBloodGroup.Focus();
                errorProvider9.SetError(this.cmbBloodGroup, "Please select blood group !!");
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        public void ClearData()
        {
           
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedItem = null;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbCity.SelectedItem = null;
            txtAddress.Clear();
            cmbBloodGroup.SelectedItem = null;
            txtHeight.Clear();
            txtWeight.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
            txtDonorNo.Text = "D-" + DateTime.Now.ToString("hhmmss");

        }

        private void txtDonorNo_Enter(object sender, EventArgs e)
        {
            txtDonorNo.BackColor = Color.LightCyan;

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

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            txtHeight.BackColor = Color.LightCyan;

        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            txtWeight.BackColor = Color.LightCyan;

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
