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
                errorProvider3.SetError(cmbGender, "Please Select Gender");
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
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Mobile Number  !");
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
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
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
                errorProvider6.SetError(cmbCity, "Please Select City");
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
                errorProvider8.SetError(cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
            cmbBloodGroup.BackColor = Color.White;

        }

        private void txtHeight_Leave(object sender, EventArgs e)
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
            txtHeight.BackColor = Color.White;

        }

        private void txtWeight_Leave(object sender, EventArgs e)
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
            txtWeight.BackColor = Color.White;

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
                errorProvider2.SetError(this.txtAge, "Please Enter Only Numeric Value");

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
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Only Numeric Value");

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
                errorProvider9.SetError(this.txtHeight, "Please Enter Only Numeric Value");

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
                errorProvider10.SetError(this.txtWeight, "Please Enter Only Numeric Value");

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            txtDonorNo.Clear();
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtDonorNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmbGender.SelectedItem = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailID.Text= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cmbCity.SelectedItem = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            cmbBloodGroup.SelectedItem = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            txtHeight.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            txtWeight.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();


        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select *from Donor_RegistrationTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void EditDonorPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnupdate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Data Updated !!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
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
                MessageBox.Show("Data Deleted !!");
            }
        }

        private void txtDonorNo_Enter(object sender, EventArgs e)
        {
            txtDonorNo.BackColor = Color.LightCyan;

        }

        private void txtDonorNo_Leave(object sender, EventArgs e)
        {
            txtDonorNo.BackColor = Color.White;
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

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
            

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
