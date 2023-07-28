using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BloodBankManagementSystem
{
    public partial class DoctorRecordPage : Form
    {
        public DoctorRecordPage()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DoctorIdAutoGenerate()
        {
            txtDoctorID.Text = "D-" + DateTime.Now.ToString("hhmmssdd");

        }

        private void DoctorRecordPage_Load(object sender, EventArgs e)
        {
            DoctorIdAutoGenerate();
            DataBinding();
            DataBindingForHospitalName();
            cmbGender.SelectedItem = "Select Gender";
            cmbGender.ForeColor = Color.Silver;
            cmbStatus.SelectedItem = "Select Status";
            cmbStatus.ForeColor = Color.Silver;
            cmbState.SelectedItem = "Select State";
            cmbState.ForeColor = Color.Silver;
            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            cmbMedicalDegree.SelectedItem = "Select Degree";
            cmbMedicalDegree.ForeColor = Color.Silver;
            cmbSpecialist.SelectedItem = "Select Specialist";
            cmbSpecialist.ForeColor = Color.Silver;
            cmbHospitalName.SelectedItem = null;
            cmbHospitalName.ForeColor = Color.Silver;
        }

        private void txtDoctorName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctorName.Text)==true)
            {
                errorProvider1.SetError(this.txtDoctorName,"Please Enter Doctor Name !");
                txtDoctorName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtDoctorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if(ch == 8)
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
                errorProvider1.SetError(this.txtDoctorName,"Please Enter Only Latter's !");
            }

        }

        private void cmbGender_Enter(object sender, EventArgs e)
        {
            cmbGender.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender,"Please Select Gender");
                cmbGender.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void dtpDateOfBrith_Leave(object sender, EventArgs e)
        {
            if (dtpDateOfBrith.Value.ToString("dd/MM/yyyy") ==  DateTime.Now.ToString("dd/MM/yyyy"))
            {
                errorProvider3.SetError(this.dtpDateOfBrith,"Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void dtpDateOfBrith_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateOfBrith.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Doctor Mobile Number !");
                txtMobileNo.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsNumber(ch))
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
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Only Number's !");
            }
        }

        private void txtEmailID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider5.SetError(this.txtEmailID, "Please Enter The Email ..");
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

        private void cmbStatus_Enter(object sender, EventArgs e)
        {
            cmbStatus.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbStatus_Leave(object sender, EventArgs e)
        {
            if (cmbStatus.SelectedItem.ToString() == "Select Status")
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status");
                cmbStatus.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void cmbState_Enter(object sender, EventArgs e)
        {
            cmbState.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbState_Leave(object sender, EventArgs e)
        {

            if (cmbState.SelectedItem.ToString() == "Select State")
            {
                errorProvider7.SetError(this.cmbState, "Please Select State");
                cmbState.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void cmbCity_Enter(object sender, EventArgs e)
        {
            cmbCity.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider8.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void cmbMedicalDegree_Enter(object sender, EventArgs e)
        {
            cmbMedicalDegree.ForeColor = Color.FromArgb(68, 88, 112);

        }

        private void cmbMedicalDegree_Leave(object sender, EventArgs e)
        {
            if (cmbMedicalDegree.SelectedItem.ToString() == "Select Degree")
            {
                errorProvider10.SetError(this.cmbMedicalDegree, "Please Select Degree");
                cmbMedicalDegree.Focus();
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void txtYearOfGeaduation_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYearOfGeaduation.Text) == true)
            {
                errorProvider11.SetError(this.txtYearOfGeaduation, "Please Enter Year Of Geaduation !");
                txtYearOfGeaduation.Focus();
            }
            else
            {
                errorProvider11.Clear();
            }
        }

        private void txtYearOfGeaduation_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsNumber(ch))
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
                errorProvider11.SetError(this.txtYearOfGeaduation, "Please Enter Only Number's !");
            }
        }

        private void txtYearOfExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsNumber(ch))
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
                errorProvider12.SetError(this.txtYearOfExperience, "Please Enter Only Number's !");
            }
        }

        private void txtYearOfExperience_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtYearOfExperience.Text) == true)
            {
                errorProvider12.SetError(this.txtYearOfExperience, "Please Enter Year Of Experience !");
                txtYearOfExperience.Focus();
            }
            else
            {
                errorProvider12.Clear();
            }
        }

        private void cmbSpecialist_Enter(object sender, EventArgs e)
        {
            cmbSpecialist.ForeColor = Color.FromArgb(68, 88, 112);
        }

        private void cmbSpecialist_Leave(object sender, EventArgs e)
        {
            if (cmbSpecialist.SelectedItem.ToString() == "Select Specialist")
            {
                errorProvider13.SetError(this.cmbSpecialist, "Please Select Specialist");
                cmbSpecialist.Focus();
            }
            else
            {
                errorProvider13.Clear();
            }
        }

        private void txtLicenseNumber_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLicenseNumber.Text) == true)
            {
                errorProvider14.SetError(this.txtLicenseNumber, "Please Enter License Number !");
                txtLicenseNumber.Focus();
            }
            else
            {
                errorProvider14.Clear();
            }
        }

        private void cmbHospitalName_Leave(object sender, EventArgs e)
        {
            if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider15.SetError(this.cmbHospitalName, "Please Select Hospital Name");
                cmbHospitalName.Focus();
            }
            else
            {
                errorProvider15.Clear();
            }
        }

        private void cmbHospitalName_Enter(object sender, EventArgs e)
        {
            cmbHospitalName.ForeColor = Color.FromArgb(68,88,112);
        }

        private void txtHospitalAddress_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHospitalAddress.Text) == true)
            {
                errorProvider16.SetError(this.txtHospitalAddress, "Please Enter Hospital Address !");
                txtHospitalAddress.Focus();
            }
            else
            {
                errorProvider16.Clear();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxForResetData.Show();
            if (dr == DialogResult.Yes)
            {
                ClearData();
                DoctorIdAutoGenerate();
                DataBinding();
            }
          
        }

        public void ClearData()
        {
            DoctorIdAutoGenerate();
            DataBindingForHospitalName();
            DataBinding();
            txtDoctorName.Clear();
            cmbGender.SelectedItem = "Select Gender";
            cmbGender.ForeColor = Color.Silver;
            dtpDateOfBrith.Value = DateTime.Now;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbStatus.SelectedItem = "Select Status";
            cmbStatus.ForeColor = Color.Silver;
            cmbState.SelectedItem = "Select State";
            cmbState.ForeColor = Color.Silver;
            cmbCity.SelectedItem = "Select City";
            cmbCity.ForeColor = Color.Silver;
            txtAddress.Clear();
            cmbMedicalDegree.SelectedItem = "Select Degree";
            cmbMedicalDegree.ForeColor = Color.Silver;
            txtYearOfExperience.Clear();
            txtYearOfGeaduation.Clear();
            cmbSpecialist.SelectedItem = "Select Specialist";
            cmbSpecialist.ForeColor = Color.Silver;
            txtLicenseNumber.Clear();
            cmbHospitalName.SelectedItem = null;
            cmbHospitalName.ForeColor = Color.Silver;
            txtHospitalAddress.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctorName.Text) == true)
            {
                errorProvider1.SetError(this.txtDoctorName, "Please Enter Doctor Name !");
                txtDoctorName.Focus();
            }
            else if(cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if(dtpDateOfBrith.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else if(string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Doctor Mobile Number !");
                txtMobileNo.Focus();
            }
            else if(string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider5.SetError(this.txtEmailID, "Please Enter The Email ..");
                txtEmailID.Focus();
            }
            else if(Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
            }
            else if(cmbStatus.SelectedItem.ToString() == "Select Status")
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status");
                cmbStatus.Focus();
            }
            else if(cmbState.SelectedItem.ToString() == "Select State")
            {
                errorProvider7.SetError(this.cmbState, "Please Select State");
                cmbState.Focus();
            }
            else if(cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider8.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if(string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbMedicalDegree.SelectedItem.ToString() == "Select Degree")
            {
                errorProvider10.SetError(this.cmbMedicalDegree, "Please Select Degree");
                cmbMedicalDegree.Focus();
            }
            else if(string.IsNullOrEmpty(txtYearOfGeaduation.Text) == true)
            {
                errorProvider11.SetError(this.txtYearOfGeaduation, "Please Enter Year Of Geaduation !");
                txtYearOfGeaduation.Focus();
            }
            else if(string.IsNullOrEmpty(txtYearOfExperience.Text) == true)
            {
                errorProvider12.SetError(this.txtYearOfExperience, "Please Enter Year Of Experience !");
                txtYearOfExperience.Focus();
            }
            else if(cmbSpecialist.SelectedItem.ToString() == "Select Specialist")
            {
                errorProvider13.SetError(this.cmbSpecialist, "Please Select Specialist");
                cmbSpecialist.Focus();
            }
            else if(string.IsNullOrEmpty(txtLicenseNumber.Text) == true)
            {
                errorProvider14.SetError(this.txtLicenseNumber, "Please Enter License Number !");
                txtLicenseNumber.Focus();
            }
            else if(cmbHospitalName.SelectedItem == null)
            {
                errorProvider15.SetError(this.cmbHospitalName, "Please Select Hospital Name");
                cmbHospitalName.Focus();
            }
            else if(string.IsNullOrEmpty(txtHospitalAddress.Text) == true)
            {
                errorProvider16.SetError(this.txtHospitalAddress, "Please Enter Hospital Address !");
                txtHospitalAddress.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from DoctorTbl where DId=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtDoctorID.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBoxForInsertData1.Show();
                    con.Close();

                }
                else
                {
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("exec InsertDoctorRecordRegistration  '" + txtDoctorID.Text + "','" + txtDoctorName.Text + "','" + cmbGender.SelectedItem.ToString() + "','" + dtpDateOfBrith.Value + "','" + txtMobileNo.Text + "','" + txtEmailID.Text + "','" + RegistrationDate.Value + "','" + cmbStatus.SelectedItem.ToString() + "','" + cmbState.SelectedItem.ToString() + "','" + cmbCity.SelectedItem.ToString() + "','" + txtAddress.Text + "','" + cmbMedicalDegree.SelectedItem.ToString() + "','" + txtYearOfGeaduation.Text + "','" + txtYearOfExperience.Text + "','" + cmbSpecialist.SelectedItem.ToString() + "','" + txtLicenseNumber.Text + "','" + cmbHospitalName.SelectedItem.ToString() + "','" + txtHospitalAddress.Text + "'" , con1);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForInsertData2.Show();
                        DoctorIdAutoGenerate();
                        ClearData();
                        DataBinding();
                        DataBindingForHospitalName();

                    }
                    else
                    {
                        MessageBoxForInsertData3.Show();
                    }
                    con1.Close();

                }
            }
        }


        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListDoctorRecordRegistration", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            DoctorList.DataSource = data;

        }

        public void DataBindingForHospitalName()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select *from HospitalTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr =cmd.ExecuteReader();
            while(dr.Read())
            {
                string name = dr.GetString(2);
                cmbHospitalName.Items.Add(name);
            }
            con.Close();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctorName.Text) == true)
            {
                errorProvider1.SetError(this.txtDoctorName, "Please Enter Doctor Name !");
                txtDoctorName.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (dtpDateOfBrith.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Doctor Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider5.SetError(this.txtEmailID, "Please Enter The Email ..");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbStatus.SelectedItem.ToString() == "Select Status")
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status");
                cmbStatus.Focus();
            }
            else if (cmbState.SelectedItem.ToString() == "Select State")
            {
                errorProvider7.SetError(this.cmbState, "Please Select State");
                cmbState.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider8.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbMedicalDegree.SelectedItem.ToString() == "Select Degree")
            {
                errorProvider10.SetError(this.cmbMedicalDegree, "Please Select Degree");
                cmbMedicalDegree.Focus();
            }
            else if (string.IsNullOrEmpty(txtYearOfGeaduation.Text) == true)
            {
                errorProvider11.SetError(this.txtYearOfGeaduation, "Please Enter Year Of Geaduation !");
                txtYearOfGeaduation.Focus();
            }
            else if (string.IsNullOrEmpty(txtYearOfExperience.Text) == true)
            {
                errorProvider12.SetError(this.txtYearOfExperience, "Please Enter Year Of Experience !");
                txtYearOfExperience.Focus();
            }
            else if (cmbSpecialist.SelectedItem.ToString() == "Select Specialist")
            {
                errorProvider13.SetError(this.cmbSpecialist, "Please Select Specialist");
                cmbSpecialist.Focus();
            }
            else if (string.IsNullOrEmpty(txtLicenseNumber.Text) == true)
            {
                errorProvider14.SetError(this.txtLicenseNumber, "Please Enter License Number !");
                txtLicenseNumber.Focus();
            }
            else if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider15.SetError(this.cmbHospitalName, "Please Select Hospital Name");
                cmbHospitalName.Focus();
            }
            else if (string.IsNullOrEmpty(txtHospitalAddress.Text) == true)
            {
                errorProvider16.SetError(this.txtHospitalAddress, "Please Enter Hospital Address !");
                txtHospitalAddress.Focus();
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("exec UpdateDoctorRecordRegistration  '" + txtDoctorID.Text + "','" + txtDoctorName.Text + "','" + cmbGender.SelectedItem.ToString() + "','" + dtpDateOfBrith.Value + "','" + txtMobileNo.Text + "','" + txtEmailID.Text + "','" + RegistrationDate.Value + "','" + cmbStatus.SelectedItem.ToString() + "','" + cmbState.SelectedItem.ToString() + "','" + cmbCity.SelectedItem.ToString() + "','" + txtAddress.Text + "','" + cmbMedicalDegree.SelectedItem.ToString() + "','" + txtYearOfGeaduation.Text + "','" + txtYearOfExperience.Text + "','" + cmbSpecialist.SelectedItem.ToString() + "','" + txtLicenseNumber.Text + "','" + cmbHospitalName.SelectedItem.ToString() + "','" + txtHospitalAddress.Text + "'", con1);
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBoxForUpdateData1.Show();
                    DoctorIdAutoGenerate();
                    ClearData();
                    DataBinding();
                    DataBindingForHospitalName();

                }
                else
                {
                    MessageBoxForUpdateData2.Show();
                }
                con1.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctorName.Text) == true)
            {
                errorProvider1.SetError(this.txtDoctorName, "Please Enter Doctor Name !");
                txtDoctorName.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (dtpDateOfBrith.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
            {
                errorProvider3.SetError(this.dtpDateOfBrith, "Please Select Date Of Brith");
                dtpDateOfBrith.Focus();
            }
            else if (string.IsNullOrEmpty(txtMobileNo.Text) == true)
            {
                errorProvider4.SetError(this.txtMobileNo, "Please Enter Doctor Mobile Number !");
                txtMobileNo.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmailID.Text) == true)
            {
                errorProvider5.SetError(this.txtEmailID, "Please Enter The Email ..");
                txtEmailID.Focus();
            }
            else if (Regex.IsMatch(txtEmailID.Text, patten) == false)
            {
                txtEmailID.Focus();
                errorProvider5.SetError(this.txtEmailID, "Invalid Email");
            }
            else if (cmbStatus.SelectedItem.ToString() == "Select Status")
            {
                errorProvider6.SetError(this.cmbStatus, "Please Select Status");
                cmbStatus.Focus();
            }
            else if (cmbState.SelectedItem.ToString() == "Select State")
            {
                errorProvider7.SetError(this.cmbState, "Please Select State");
                cmbState.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider8.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if (string.IsNullOrEmpty(txtAddress.Text) == true)
            {
                errorProvider9.SetError(this.txtAddress, "Please Enter Address !");
                txtAddress.Focus();
            }
            else if (cmbMedicalDegree.SelectedItem.ToString() == "Select Degree")
            {
                errorProvider10.SetError(this.cmbMedicalDegree, "Please Select Degree");
                cmbMedicalDegree.Focus();
            }
            else if (string.IsNullOrEmpty(txtYearOfGeaduation.Text) == true)
            {
                errorProvider11.SetError(this.txtYearOfGeaduation, "Please Enter Year Of Geaduation !");
                txtYearOfGeaduation.Focus();
            }
            else if (string.IsNullOrEmpty(txtYearOfExperience.Text) == true)
            {
                errorProvider12.SetError(this.txtYearOfExperience, "Please Enter Year Of Experience !");
                txtYearOfExperience.Focus();
            }
            else if (cmbSpecialist.SelectedItem.ToString() == "Select Specialist")
            {
                errorProvider13.SetError(this.cmbSpecialist, "Please Select Specialist");
                cmbSpecialist.Focus();
            }
            else if (string.IsNullOrEmpty(txtLicenseNumber.Text) == true)
            {
                errorProvider14.SetError(this.txtLicenseNumber, "Please Enter License Number !");
                txtLicenseNumber.Focus();
            }
            else if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider15.SetError(this.cmbHospitalName, "Please Select Hospital Name");
                cmbHospitalName.Focus();
            }
            else if (string.IsNullOrEmpty(txtHospitalAddress.Text) == true)
            {
                errorProvider16.SetError(this.txtHospitalAddress, "Please Enter Hospital Address !");
                txtHospitalAddress.Focus();
            }
            else
            {
                DialogResult dr = MessageBoxForDeleteData1.Show();
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("exec DeleteDoctorRecordRegistration  '" + txtDoctorID.Text + "'", con1);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForDeleteData2.Show();
                        DoctorIdAutoGenerate();
                        ClearData();
                        DataBinding();
                        DataBindingForHospitalName();

                    }
                    else
                    {
                        MessageBoxForDeleteData3.Show();
                    }
                    con1.Close();
                }
                
            }
        }

        private void DoctorList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(DoctorList.SelectedRows[0].Cells[0].Value.ToString());
            txtDoctorID.Text = DoctorList.SelectedRows[0].Cells[1].Value.ToString();
            txtDoctorName.Text = DoctorList.SelectedRows[0].Cells[2].Value.ToString();
            cmbGender.SelectedItem = DoctorList.SelectedRows[0].Cells[3].Value.ToString();
            dtpDateOfBrith.Value = Convert.ToDateTime(DoctorList.SelectedRows[0].Cells[4].Value.ToString());
            txtMobileNo.Text = DoctorList.SelectedRows[0].Cells[5].Value.ToString();
            txtEmailID.Text = DoctorList.SelectedRows[0].Cells[6].Value.ToString();
            RegistrationDate.Value =Convert.ToDateTime(DoctorList.SelectedRows[0].Cells[7].Value.ToString());
            cmbStatus.SelectedItem = DoctorList.SelectedRows[0].Cells[8].Value.ToString();
            cmbState.SelectedItem = DoctorList.SelectedRows[0].Cells[9].Value.ToString();
            cmbCity.SelectedItem = DoctorList.SelectedRows[0].Cells[10].Value.ToString();
            txtAddress.Text  = DoctorList.SelectedRows[0].Cells[11].Value.ToString();
            cmbMedicalDegree.SelectedItem = DoctorList.SelectedRows[0].Cells[12].Value.ToString();
            txtYearOfGeaduation.Text = DoctorList.SelectedRows[0].Cells[13].Value.ToString();
            txtYearOfExperience.Text = DoctorList.SelectedRows[0].Cells[14].Value.ToString();
            cmbSpecialist.SelectedItem = DoctorList.SelectedRows[0].Cells[15].Value.ToString();
            txtLicenseNumber.Text = DoctorList.SelectedRows[0].Cells[16].Value.ToString();
            cmbHospitalName.SelectedItem = DoctorList.SelectedRows[0].Cells[17].Value.ToString();
            txtHospitalAddress.Text = DoctorList.SelectedRows[0].Cells[18].Value.ToString();


        }
    }
}
