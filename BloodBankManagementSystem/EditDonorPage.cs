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
    public partial class EditDonorPage : Form
    {
        public EditDonorPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
      

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  

    
  
     
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            txtDonorNo.Clear();
            txtName.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            cmbGender.SelectedItem = null;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbCity.SelectedItem = null;
            txtAddress.Clear();
            cmbBloodGroup.SelectedItem = null;
            txtHeight.Clear();
            txtWeight.Clear();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtDonorNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dtpDateOfBrith.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            cmbGender.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailID.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmbCity.SelectedItem = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            cmbBloodGroup.SelectedItem = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtHeight.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

        }

        public void DataBinding()
        {
            // Data Fatch By using query

            //SqlConnection con = new SqlConnection(cs);
            //string query = "select *from Donor_RegistrationTbl";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridView1.DataSource = data;

            // Data Fatch By using procedure

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListDonorRecordRegistration", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();
        }

        private void EditDonorPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

 

 


        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            txtDonorNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dtpDateOfBrith.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value);
            cmbGender.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailID.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmbCity.SelectedItem = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            cmbBloodGroup.SelectedItem = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtHeight.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else if(dtpDateOfBrith.Value.ToShortDateString() == date)
            {
                errorProvider2.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }

            else if (cmbGender.SelectedItem == null)
            {
                errorProvider3.SetError(cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number  !");
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
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbCity.SelectedItem == null)
            {
                errorProvider6.SetError(cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider7.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbBloodGroup.SelectedItem == null)
            {
                errorProvider8.SetError(cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider9.SetError(this.txtHeight, "Please Enter Height !");
                txtHeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider10.SetError(this.txtWeight, "Please Enter Weight !");
                txtWeight.Focus();
            }
            else
            {
                //Data Update By using Procedure

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
                SqlCommand cmd = new SqlCommand("exec UpdateDonorRecordRegistration '" + id + "','" + name + "','" + dtpDateOfBrith.Value.ToString("dd/MM/yyyy") + "','" + gender + "','" + mobile + "','" + email + "','" + city + "','" + address + "','" + bloodgroup + "','" + height + "','" + weight + "'", con);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    UpdateRecordDialogBox1.Show();
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



        private void btndelete_Click_1(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter Name !");
                txtName.Focus();
            }
            else if (dtpDateOfBrith.Value.ToShortDateString() == date)
            {
                errorProvider2.SetError(this.dtpDateOfBrith, "Please Select Date OF Brith");
                dtpDateOfBrith.Focus();
            }
            else if (cmbGender.SelectedItem == null)
            {
                errorProvider3.SetError(cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number  !");
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
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbCity.SelectedItem == null)
            {
                errorProvider6.SetError(cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider7.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbBloodGroup.SelectedItem == null)
            {
                errorProvider8.SetError(cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider9.SetError(this.txtHeight, "Please Enter Height !");
                txtHeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider10.SetError(this.txtWeight, "Please Enter Weight !");
                txtWeight.Focus();
            }
            else
            {
                //Data Delete By using Procedure

                DialogResult d=DeleteDialogBox3.Show();
                if (d == DialogResult.Yes)
                {
                    string id = txtDonorNo.Text;
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec DeleteDonorRecordRegistration '" + id + "'", con);

                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        DeleteDialogBox1.Show();
                        ClearData();
                        DataBinding();


                    }
                    else
                    {
                        DeleteDialogBox2.Show();
                    }
                    con.Close();
                }

                
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
          DialogResult d=ResetDialogBox.Show();
            if (d==DialogResult.Yes)
            {
                ClearData();
            }
        }

        private void txtDonorNo_Leave_1(object sender, EventArgs e)
        {
  
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
                errorProvider3.SetError(cmbGender, "Please Select Gender");
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
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number  !");
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
            else if (ch == 8)   //backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Only Numeric Value");

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
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
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
                errorProvider6.SetError(cmbCity, "Please Select City");
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
                errorProvider8.SetError(cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void txtHeight_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider9.SetError(this.txtHeight, "Please Enter Height !");
                txtHeight.Focus();
            }
            else
            {
                errorProvider9.Clear();
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
                errorProvider9.SetError(this.txtHeight, "Please Enter Only Numeric Value");

            }
        }

        private void txtWeight_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider10.SetError(this.txtWeight, "Please Enter Weight !");
                txtWeight.Focus();
            }
            else
            {
                errorProvider10.Clear();
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
                errorProvider10.SetError(this.txtWeight, "Please Enter Only Numeric Value");

            }
        }

        private void dtpDateOfBrith_Leave(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (dtpDateOfBrith.Value.ToShortDateString() == date)
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
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            if (dtpDateOfBrith.Value.ToShortDateString() == date)
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
