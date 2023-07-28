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
using System.Configuration;
using System.Data.SqlClient;

namespace BloodBankManagementSystem
{
    public partial class HospitalRegistrationPage : Form
    {
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public HospitalRegistrationPage()
        {
            InitializeComponent();
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HospitalAutoGenerate()
        {
            txthospitalID.Text = "H-" + DateTime.Now.ToString("hhmmssdd");

        }

        private void HospitalRegistrationPage_Load(object sender, EventArgs e)
        {
            HospitalAutoGenerate();
            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            cmbOwnershipType.SelectedItem = "Select Ownership Type";
            cmbOwnershipType.ForeColor = Color.Silver;
            cmbHospitalType.SelectedItem = "Select Hospital Type";
            cmbHospitalType.ForeColor = Color.Silver;
            DataBinding();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)==true)
            {
                errorProvider1.SetError(this.txtName,"Please Enter The Hospital Name !");
                txtName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider2.SetError(this.txtMobileNo, "Please Enter The Hospital Mobile Number !");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
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
                errorProvider2.SetError(this.txtMobileNo,"Please Enter Only Numbers !");
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
                errorProvider1.SetError(this.txtName, "Please Enter The Only Latters , Can't Enter Numeric Value !");
            }
        }

        private void txtTelephoneNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTelephoneNo.Text) == true)
            {
                errorProvider3.SetError(this.txtTelephoneNo, "Please Enter The Hospital Telephone Number !");
                txtTelephoneNo.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtEmailID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Hospital Email ID !");
                txtEmailID.Focus();
            }
            else if(Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                
                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
                txtEmailID.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider5.SetError(this.cmbCity,"Please Select a City");
                cmbCity.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void cmbCity_Enter(object sender, EventArgs e)
        {
            cmbCity.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void txtOwnerName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOwnerName.Text) == true)
            {
                errorProvider6.SetError(this.txtOwnerName, "Please Enter The Hospital Owner Name !");
                txtOwnerName.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void txtOwnerName_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider6.SetError(this.txtOwnerName, "Please Enter The Only Latters , Can't Enter Numeric Value !");
            }
        }

        private void txtOwnerMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
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
                errorProvider7.SetError(this.txtOwnerMobile, "Please Enter Only Numbers !");
            }
        }

        private void txtOwnerMobile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOwnerMobile.Text)==true)
            {
                errorProvider7.SetError(this.txtOwnerMobile,"Please Enter The Hospital Owner Mobile Number !");
                txtOwnerName.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void cmbOwnershipType_Enter(object sender, EventArgs e)
        {
            cmbOwnershipType.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbOwnershipType_Leave(object sender, EventArgs e)
        {
            if (cmbOwnershipType.SelectedItem.ToString() == "Select Ownership Type")
            {
                errorProvider8.SetError(this.cmbOwnershipType, "Please Select a Ownership Type");
                cmbOwnershipType.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void cmbHospitalType_Enter(object sender, EventArgs e)
        {
            cmbHospitalType.ForeColor = Color.FromArgb(68,88,112);
        }

        private void cmbHospitalType_Leave(object sender, EventArgs e)
        {
            if (cmbHospitalType.SelectedItem.ToString() == "Select Hospital Type")
            {
                errorProvider9.SetError(this.cmbHospitalType, "Please Select a Hospital Type");
                cmbHospitalType.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void cmbHospitalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHospitalType.SelectedItem.ToString() == "Specialty Hospital")
            {
                txtIfSpecialtyHospital.Enabled = true;
            }
            else
            {
                txtIfSpecialtyHospital.Enabled = false;
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider10.SetError(this.txtAddress,"Please Enter The Address");
                txtAddress.Focus();
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void txtIfSpecialtyHospital_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIfSpecialtyHospital.Text)==true)
            {
                errorProvider11.SetError(this.txtIfSpecialtyHospital,"Please Enter The Specialty Of Hospital !");
               
            }
            else
            {
                errorProvider11.Clear();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter The Hospital Name !");
                txtName.Focus();
            }
            else if(string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider2.SetError(this.txtMobileNo, "Please Enter The Hospital Mobile Number !");
                txtMobileNo.Focus();
            }
            else if(string.IsNullOrEmpty(txtTelephoneNo.Text) == true)
            {
                errorProvider3.SetError(this.txtTelephoneNo, "Please Enter The Hospital Telephone Number !");
                txtTelephoneNo.Focus();
            }
            else if(string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Hospital Email ID !");
                txtEmailID.Focus();
            }
            else if(Regex.IsMatch(txtEmailID.Text, patten) == false)
            {

                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
                txtEmailID.Focus();
            }
            else if(cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider5.SetError(this.cmbCity, "Please Select a City");
                cmbCity.Focus();
            }
            else if(string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider10.SetError(this.txtAddress, "Please Enter The Address");
                txtAddress.Focus();
            }
            else if(string.IsNullOrEmpty(txtOwnerName.Text) == true)
            {
                errorProvider6.SetError(this.txtOwnerName, "Please Enter The Hospital Owner Name !");
                txtOwnerName.Focus();
            }
            else if(string.IsNullOrEmpty(txtOwnerMobile.Text) == true)
            {
                errorProvider7.SetError(this.txtOwnerMobile, "Please Enter The Hospital Owner Mobile Number !");
                txtOwnerName.Focus();
            }
            else if(cmbOwnershipType.SelectedItem.ToString() == "Select Ownership Type")
            {
                errorProvider8.SetError(this.cmbOwnershipType, "Please Select a Ownership Type");
                cmbOwnershipType.Focus();
            }
            else if (cmbHospitalType.SelectedItem.ToString() == "Select Hospital Type")
            {
                errorProvider9.SetError(this.cmbHospitalType, "Please Select a Hospital Type");
                cmbHospitalType.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from HospitalTbl where HospitalId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id",txthospitalID.Text);
                con.Open();
                SqlDataReader dr=cmd.ExecuteReader();
                if (dr.HasRows==true)
                {
                    MessageBoxForInsertData1.Show();
                    con.Close();

                }
                else
                {
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("exec InsertHospitalRecordRegistration  '" + txthospitalID.Text + "','" + txtName.Text + "','" + txtMobileNo.Text + "','" + txtTelephoneNo.Text + "','" + txtEmailID.Text + "','" + cmbCity.SelectedItem.ToString() + "','" + txtAddress.Text + "','" + ToDayDate.Value + "','" + txtOwnerName.Text + "','" + txtOwnerMobile.Text + "','" + cmbOwnershipType.SelectedItem.ToString() + "','" + cmbHospitalType.SelectedItem.ToString() + "','" + txtIfSpecialtyHospital.Text + "'", con1);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForInsertData2.Show();
                        HospitalAutoGenerate();
                        ClearData();
                        DataBinding();
                    }
                    else
                    {
                        MessageBoxForInsertData3.Show();
                    }
                    con1.Close();

                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxForResetData1.Show();
            if (dr == DialogResult.Yes)
            {
                ClearData();
            }

            
        }

        public void ClearData()
        {
           
            HospitalAutoGenerate();
            txtName.Clear();
            txtMobileNo.Clear();
            txtTelephoneNo.Clear();
            txtEmailID.Clear();
            txtAddress.Clear();
            txtOwnerName.Clear();
            txtOwnerMobile.Clear();
            txtIfSpecialtyHospital.Clear();

            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            cmbOwnershipType.SelectedItem = "Select Ownership Type";
            cmbOwnershipType.ForeColor = Color.Silver;
            cmbHospitalType.SelectedItem = "Select Hospital Type";
            cmbHospitalType.ForeColor = Color.Silver;
        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListHospitalRecordRegistration",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            HospitalList.DataSource = data;

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter The Hospital Name !");
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider2.SetError(this.txtMobileNo, "Please Enter The Hospital Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtTelephoneNo.Text) == true)
            {
                errorProvider3.SetError(this.txtTelephoneNo, "Please Enter The Hospital Telephone Number !");
                txtTelephoneNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Hospital Email ID !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {

                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
                txtEmailID.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider5.SetError(this.cmbCity, "Please Select a City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider10.SetError(this.txtAddress, "Please Enter The Address");
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(txtOwnerName.Text) == true)
            {
                errorProvider6.SetError(this.txtOwnerName, "Please Enter The Hospital Owner Name !");
                txtOwnerName.Focus();
            }
            else if (string.IsNullOrEmpty(txtOwnerMobile.Text) == true)
            {
                errorProvider7.SetError(this.txtOwnerMobile, "Please Enter The Hospital Owner Mobile Number !");
                txtOwnerName.Focus();
            }
            else if (cmbOwnershipType.SelectedItem.ToString() == "Select Ownership Type")
            {
                errorProvider8.SetError(this.cmbOwnershipType, "Please Select a Ownership Type");
                cmbOwnershipType.Focus();
            }
            else if (cmbHospitalType.SelectedItem.ToString() == "Select Hospital Type")
            {
                errorProvider9.SetError(this.cmbHospitalType, "Please Select a Hospital Type");
                cmbHospitalType.Focus();
            }
            else
            {
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("exec UpdateHospitalRecordRegistration  '" + txthospitalID.Text + "','" + txtName.Text + "','" + txtMobileNo.Text + "','" + txtTelephoneNo.Text + "','" + txtEmailID.Text + "','" + cmbCity.SelectedItem.ToString() + "','" + txtAddress.Text + "','" + ToDayDate.Value + "','" + txtOwnerName.Text + "','" + txtOwnerMobile.Text + "','" + cmbOwnershipType.SelectedItem.ToString() + "','" + cmbHospitalType.SelectedItem.ToString() + "','" + txtIfSpecialtyHospital.Text + "'", con1);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForUpdateData1.Show();
                        HospitalAutoGenerate();
                        ClearData();
                        DataBinding();
                    }
                    else
                    {
                        MEssageBoxForUpdateData2.Show();
                    }
                    con1.Close();
            }
            

        }

        private void btndelete_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtName.Text) == true)
            {
                errorProvider1.SetError(this.txtName, "Please Enter The Hospital Name !");
                txtName.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider2.SetError(this.txtMobileNo, "Please Enter The Hospital Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtTelephoneNo.Text) == true)
            {
                errorProvider3.SetError(this.txtTelephoneNo, "Please Enter The Hospital Telephone Number !");
                txtTelephoneNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider4.SetError(this.txtEmailID, "Please Enter The Hospital Email ID !");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {

                errorProvider4.SetError(this.txtEmailID, "Invalid Email");
                txtEmailID.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider5.SetError(this.cmbCity, "Please Select a City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider10.SetError(this.txtAddress, "Please Enter The Address");
                txtAddress.Focus();
            }
            else if (string.IsNullOrEmpty(txtOwnerName.Text) == true)
            {
                errorProvider6.SetError(this.txtOwnerName, "Please Enter The Hospital Owner Name !");
                txtOwnerName.Focus();
            }
            else if (string.IsNullOrEmpty(txtOwnerMobile.Text) == true)
            {
                errorProvider7.SetError(this.txtOwnerMobile, "Please Enter The Hospital Owner Mobile Number !");
                txtOwnerName.Focus();
            }
            else if (cmbOwnershipType.SelectedItem.ToString() == "Select Ownership Type")
            {
                errorProvider8.SetError(this.cmbOwnershipType, "Please Select a Ownership Type");
                cmbOwnershipType.Focus();
            }
            else if (cmbHospitalType.SelectedItem.ToString() == "Select Hospital Type")
            {
                errorProvider9.SetError(this.cmbHospitalType, "Please Select a Hospital Type");
                cmbHospitalType.Focus();
            }
            else
            {
                DialogResult dr = MessageBoxForDeleteData3.Show();
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("exec DeleteHospitalRecordRegistration  '" + txthospitalID.Text + "'", con1);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForDeleteData1.Show();
                        HospitalAutoGenerate();
                        ClearData();
                        DataBinding();
                    }
                    else
                    {
                        MessageBoxForDeleteData2.Show();
                    }
                    con1.Close();
                }
            }

        }

        private void HospitalList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(HospitalList.SelectedRows[0].Cells[0].Value.ToString());
            txthospitalID.Text = HospitalList.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = HospitalList.SelectedRows[0].Cells[2].Value.ToString();
            txtMobileNo.Text = HospitalList.SelectedRows[0].Cells[3].Value.ToString();
            txtTelephoneNo.Text = HospitalList.SelectedRows[0].Cells[4].Value.ToString();
            txtEmailID.Text = HospitalList.SelectedRows[0].Cells[5].Value.ToString();
             cmbCity.SelectedItem = HospitalList.SelectedRows[0].Cells[6].Value.ToString();
            txtAddress.Text = HospitalList.SelectedRows[0].Cells[7].Value.ToString();
            ToDayDate.Value = Convert.ToDateTime(HospitalList.SelectedRows[0].Cells[8].Value.ToString());
            txtOwnerName.Text = HospitalList.SelectedRows[0].Cells[9].Value.ToString();
            txtOwnerMobile.Text = HospitalList.SelectedRows[0].Cells[10].Value.ToString();
            cmbOwnershipType.SelectedItem = HospitalList.SelectedRows[0].Cells[11].Value.ToString();
            cmbHospitalType.SelectedItem = HospitalList.SelectedRows[0].Cells[12].Value.ToString();
            txtIfSpecialtyHospital.Text = HospitalList.SelectedRows[0].Cells[13].Value.ToString();

        }
    }
}
