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
    public partial class BloodDonationPage : Form
    {
        public BloodDonationPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        ViewAllBloodDonation viewallblooddonation;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BloodDonationPage_Load(object sender, EventArgs e)
        {
            BindingTheDonorNo();
            DataBinding();

            cmbDonorNo.SelectedItem = null;
            cmbGender.SelectedItem = "Select Gender";
            cmbCity.SelectedItem = "Select City";
            cmbBloodGroup.SelectedItem = "Select Blood Group";
        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text)==true)
            {
                errorProvider1.SetError(this.txtHeight, "Please Enter The Height !");
                txtHeight.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch)==true)
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
                errorProvider1.SetError(this.txtHeight, "Please Enter Only Numeric Value..");
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider2.SetError(this.txtWeight, "Please Enter The Weight !");
                txtWeight.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
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
                errorProvider2.SetError(this.txtWeight, "Please Enter Only Numeric Value..");
            }
        }

        private void txtBP1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBP1.Text) == true)
            {
                errorProvider3.SetError(this.txtBP1, "Please Enter The Blood Presure !");
                txtBP1.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtBP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
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
                errorProvider3.SetError(this.txtBP1, "Please Enter Only Numeric Value..");
            }
        }

        private void txtBP2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBP2.Text) == true)
            {
                errorProvider4.SetError(this.txtBP2, "Please Enter The Blood Presure !");
                txtBP2.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void txtBP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
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
                errorProvider4.SetError(this.txtBP2, "Please Enter Only Numeric Value..");
            }
        }

        private void txtMedicalExam_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMedicalExam.Text)==true)
            {
                errorProvider5.SetError(this.txtMedicalExam, "Please Enter The Medical Exam Result ...");
                txtMedicalExam.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void txtPules_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPules.Text) == true)
            {
                errorProvider6.SetError(this.txtPules, "Please Enter The Heart Rate...");
                txtPules.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void txtPules_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
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
                errorProvider6.SetError(this.txtPules, "Please Enter Only Numeric Value..");
            }
        }

        private void cmbDonation_Leave(object sender, EventArgs e)
        {
            if (cmbDonation.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbDonation, "Please Select The Donation..");
                cmbDonation.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtInegularAntibodiers_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInegularAntibodiers.Text) == true)
            {
                errorProvider8.SetError(this.txtInegularAntibodiers, "Please Enter The Inegular Antibodiers...");
                txtInegularAntibodiers.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void txtHemoglobin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHemoglobin.Text) == true)
            {
                errorProvider9.SetError(this.txtHemoglobin, "Please Enter The Hemoglobin...");
                txtHemoglobin.Focus();
            }
            else
            {
                errorProvider9.Clear();
            }
        }

        private void txtHemoglobin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsDigit(ch) == true)
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
                errorProvider9.SetError(this.txtHemoglobin, "Please Enter Only Numeric Value..");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxForResetData.Show();
            if (dr == DialogResult.Yes)
            {
                ClearData();
            }

        }

        public void ClearData()
        {
            BindingTheDonorNo();
            DataBinding();

            cmbDonorNo.SelectedItem = null;
            txtName.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            cmbGender.SelectedItem = "Select Gender";
            RegistrationDate.Value = DateTime.Now;
            txtMobileNo.Clear();
            txtEmailID.Clear();
            cmbCity.SelectedItem = "Select City";
            txtAddress.Clear();
            cmbBloodGroup.SelectedItem = "Select Blood Group";
            txtHeight.Clear();
            txtWeight.Clear();
            txtBP1.Clear();
            txtBP2.Clear();
            txtMedicalExam.Clear();
            txtPules.Clear();
            cmbDonation.SelectedItem = null;
            txtInegularAntibodiers.Clear();
            txtHemoglobin.Clear();


        }

   

        private void Viewallblooddonation_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallblooddonation = null;
        }

        private void btnViewAllBloodDonation_Click_1(object sender, EventArgs e)
        {
            MasterPage m = new MasterPage();
            if (viewallblooddonation == null)
            {
                viewallblooddonation = new ViewAllBloodDonation();
                viewallblooddonation.FormClosed += Viewallblooddonation_FormClosed;
                //viewallblooddonation.MdiParent = this;
                viewallblooddonation.Show();
            }
            else
            {
                viewallblooddonation.Activate();
            }
        }

        private void cmbDonorNo_Leave(object sender, EventArgs e)
        {
            if (cmbDonorNo.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDonorNo, "Please Select The Donor No ");
                cmbDonorNo.Focus();
            }
            else
            {
                errorProvider10.Clear();
            }
        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider11.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else
            {
                errorProvider11.Clear();
            }
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem.ToString()=="Select City")
            {
                errorProvider12.SetError(this.cmbCity,"Please Select City");
                cmbCity.Focus();
            }
            else
            {
                errorProvider12.Clear();
            }
        }

        private void cmbBloodGroup_Leave(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem.ToString()=="Select Blood Group")
            {
                errorProvider13.SetError(this.cmbBloodGroup,"Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else
            {
                errorProvider13.Clear();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (cmbDonorNo.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDonorNo, "Please Select The Donor No ");
                cmbDonorNo.Focus();
            }
            else if(cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider11.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if(cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider12.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if(cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider13.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else if(string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider1.SetError(this.txtHeight, "Please Enter The Height !");
                txtHeight.Focus();
            }
            else if(string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider2.SetError(this.txtWeight, "Please Enter The Weight !");
                txtWeight.Focus();
            }
            else if(string.IsNullOrEmpty(txtBP1.Text) == true)
            {
                errorProvider3.SetError(this.txtBP1, "Please Enter The Blood Presure !");
                txtBP1.Focus();
            }
            else if(string.IsNullOrEmpty(txtBP2.Text) == true)
            {
                errorProvider4.SetError(this.txtBP2, "Please Enter The Blood Presure !");
                txtBP2.Focus();
            }
            else if(string.IsNullOrEmpty(txtMedicalExam.Text) == true)
            {
                errorProvider5.SetError(this.txtMedicalExam, "Please Enter The Medical Exam Result ...");
                txtMedicalExam.Focus();
            }
            else if(string.IsNullOrEmpty(txtPules.Text) == true)
            {
                errorProvider6.SetError(this.txtPules, "Please Enter The Heart Rate...");
                txtPules.Focus();
            }
            else if(cmbDonation.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbDonation, "Please Select The Donation..");
                cmbDonation.Focus();
            }
            else if(string.IsNullOrEmpty(txtInegularAntibodiers.Text) == true)
            {
                errorProvider8.SetError(this.txtInegularAntibodiers, "Please Enter The Inegular Antibodiers...");
                txtInegularAntibodiers.Focus();
            }
            else if(string.IsNullOrEmpty(txtHemoglobin.Text) == true)
            {
                errorProvider9.SetError(this.txtHemoglobin, "Please Enter The Hemoglobin...");
                txtHemoglobin.Focus();
            }
            else
            {
                //SqlConnection con = new SqlConnection(cs);
                //string query = "select *from BloodDonationTbl where BDId=@id";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@id",cmbDonorNo.SelectedItem);
                //con.Open();
                //SqlDataReader dr = cmd.ExecuteReader();
                //if (dr.HasRows == true)
                //{
                //    MessageBoxForInsertData1.Show();
                //    con.Close();

                //}
                //else
                //{
                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd1 = new SqlCommand("exec InsertBloodDonationRecord  '" + cmbDonorNo.SelectedItem + "','" + txtName.Text + "','" + dtpDateOfBrith.Value + "','" + cmbGender.SelectedItem + "','" + RegistrationDate.Value + "','" + txtMobileNo.Text + "','" + txtEmailID.Text + "','" + cmbCity.SelectedItem + "','" + txtAddress.Text + "','" + cmbBloodGroup.SelectedItem + "','" + BloodDonationDate.Value + "','" + txtHeight.Text + "','" + txtWeight.Text + "','" + txtBP1.Text + "','" + txtBP2.Text + "','" + txtMedicalExam.Text + "','" + txtPules.Text + "','" + cmbDonation.SelectedItem + "','" + txtInegularAntibodiers.Text  + "','"+ txtHemoglobin.Text + "'", con1);
                    int a = cmd1.ExecuteNonQuery();
                    if (a > 0)
                    {
                        BloodStockAdd();
                        MessageBoxForInsertData2.Show();
                        ClearData();
                        DataBinding();



                    }
                    else
                    {
                        MessageBoxForInsertData3.Show();
                    }
                    con1.Close();

                //}

            }
        }

        public void BloodStockAdd()
        {

            //SqlConnection con = new SqlConnection(cs);
            //con.Open();
            //string query = "select BloodStock from BloodStockTbl where BloodGroup=@bloodgroup";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //sda.SelectCommand.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //if (data.Rows.Count < 1)
            //{
            //    int stock = 1;

            SqlConnection con = new SqlConnection(cs);
            string query = "select *from BloodStockTbl where BloodGroup=@bloodgroup";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int oldstock = dr.GetInt32(2);

                    //con.Close();
                    int newstock = oldstock + 1;

                    SqlConnection con1 = new SqlConnection(cs);
                    string query1 = "update BloodStockTbl set BloodStock=@newstock , UpdatedDate=@upDate where BloodGroup=@bloodgroup";
                    SqlCommand cmd1 = new SqlCommand(query1, con1);
                    cmd1.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem);
                    cmd1.Parameters.AddWithValue("@newstock", newstock);
                    cmd1.Parameters.AddWithValue("@upDate", BloodDonationDate.Value);
                    //con.Close();
                    con1.Open();
                    cmd1.ExecuteNonQuery();
                   
                    con1.Close();

                }
            }
            con.Close();
        }


        public void BindingTheDonorNo()
        {
            cmbDonorNo.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string query = "select *from Donor_RegistrationTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string no = dr.GetString(1);
                cmbDonorNo.Items.Add(no);
            }
            con.Close();
        }

        private void cmbDonorNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonorNo.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDonorNo, "Please Select The Donor No ");
                cmbDonorNo.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from Donor_RegistrationTbl where DId=@DId";
                SqlCommand cmd = new SqlCommand(query, con);
               cmd.Parameters.AddWithValue("@DId", cmbDonorNo.SelectedItem);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    txtName.Text = dr.GetString(2).ToString();
                    dtpDateOfBrith.Value = dr.GetDateTime(3);
                    cmbGender.SelectedItem = dr.GetString(4);
                    RegistrationDate.Value = dr.GetDateTime(5);
                    txtMobileNo.Text = dr.GetString(6).ToString();
                    txtEmailID.Text = dr.GetString(7).ToString();
                    cmbCity.SelectedItem = dr.GetString(8).ToString();
                    txtAddress.Text = dr.GetString(9).ToString();
                    cmbBloodGroup.SelectedItem = dr.GetString(10).ToString();
                    txtHeight.Text = dr.GetInt32(11).ToString();
                    txtWeight.Text = dr.GetInt32(12).ToString();

                }
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbDonorNo.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDonorNo, "Please Select The Donor No ");
                cmbDonorNo.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider11.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider12.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider13.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider1.SetError(this.txtHeight, "Please Enter The Height !");
                txtHeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider2.SetError(this.txtWeight, "Please Enter The Weight !");
                txtWeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtBP1.Text) == true)
            {
                errorProvider3.SetError(this.txtBP1, "Please Enter The Blood Presure !");
                txtBP1.Focus();
            }
            else if (string.IsNullOrEmpty(txtBP2.Text) == true)
            {
                errorProvider4.SetError(this.txtBP2, "Please Enter The Blood Presure !");
                txtBP2.Focus();
            }
            else if (string.IsNullOrEmpty(txtMedicalExam.Text) == true)
            {
                errorProvider5.SetError(this.txtMedicalExam, "Please Enter The Medical Exam Result ...");
                txtMedicalExam.Focus();
            }
            else if (string.IsNullOrEmpty(txtPules.Text) == true)
            {
                errorProvider6.SetError(this.txtPules, "Please Enter The Heart Rate...");
                txtPules.Focus();
            }
            else if (cmbDonation.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbDonation, "Please Select The Donation..");
                cmbDonation.Focus();
            }
            else if (string.IsNullOrEmpty(txtInegularAntibodiers.Text) == true)
            {
                errorProvider8.SetError(this.txtInegularAntibodiers, "Please Enter The Inegular Antibodiers...");
                txtInegularAntibodiers.Focus();
            }
            else if (string.IsNullOrEmpty(txtHemoglobin.Text) == true)
            {
                errorProvider9.SetError(this.txtHemoglobin, "Please Enter The Hemoglobin...");
                txtHemoglobin.Focus();
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("exec UpdateBloodDonationRecord  '" + cmbDonorNo.SelectedItem + "','" + txtName.Text + "','" + dtpDateOfBrith.Value + "','" + cmbGender.SelectedItem + "','" + RegistrationDate.Value + "','" + txtMobileNo.Text + "','" + txtEmailID.Text + "','" + cmbCity.SelectedItem + "','" + txtAddress.Text + "','" + cmbBloodGroup.SelectedItem + "','" + BloodDonationDate.Value + "','" + txtHeight.Text + "','" + txtWeight.Text + "','" + txtBP1.Text + "','" + txtBP2.Text + "','" + txtMedicalExam.Text + "','" + txtPules.Text + "','" + cmbDonation.SelectedItem + "','" + txtInegularAntibodiers.Text + "','" + txtHemoglobin.Text + "'", con1);
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBoxForUpdateData1.Show();
                    ClearData();
                    DataBinding();



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
            if (cmbDonorNo.SelectedItem == null)
            {
                errorProvider10.SetError(this.cmbDonorNo, "Please Select The Donor No ");
                cmbDonorNo.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider11.SetError(this.cmbGender, "Please Select Gender");
                cmbGender.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider12.SetError(this.cmbCity, "Please Select City");
                cmbCity.Focus();
            }
            else if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider13.SetError(this.cmbBloodGroup, "Please Select Blood Group");
                cmbBloodGroup.Focus();
            }
            else if (string.IsNullOrEmpty(txtHeight.Text) == true)
            {
                errorProvider1.SetError(this.txtHeight, "Please Enter The Height !");
                txtHeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtWeight.Text) == true)
            {
                errorProvider2.SetError(this.txtWeight, "Please Enter The Weight !");
                txtWeight.Focus();
            }
            else if (string.IsNullOrEmpty(txtBP1.Text) == true)
            {
                errorProvider3.SetError(this.txtBP1, "Please Enter The Blood Presure !");
                txtBP1.Focus();
            }
            else if (string.IsNullOrEmpty(txtBP2.Text) == true)
            {
                errorProvider4.SetError(this.txtBP2, "Please Enter The Blood Presure !");
                txtBP2.Focus();
            }
            else if (string.IsNullOrEmpty(txtMedicalExam.Text) == true)
            {
                errorProvider5.SetError(this.txtMedicalExam, "Please Enter The Medical Exam Result ...");
                txtMedicalExam.Focus();
            }
            else if (string.IsNullOrEmpty(txtPules.Text) == true)
            {
                errorProvider6.SetError(this.txtPules, "Please Enter The Heart Rate...");
                txtPules.Focus();
            }
            else if (cmbDonation.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbDonation, "Please Select The Donation..");
                cmbDonation.Focus();
            }
            else if (string.IsNullOrEmpty(txtInegularAntibodiers.Text) == true)
            {
                errorProvider8.SetError(this.txtInegularAntibodiers, "Please Enter The Inegular Antibodiers...");
                txtInegularAntibodiers.Focus();
            }
            else if (string.IsNullOrEmpty(txtHemoglobin.Text) == true)
            {
                errorProvider9.SetError(this.txtHemoglobin, "Please Enter The Hemoglobin...");
                txtHemoglobin.Focus();
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("exec DeleteBloodDonationRecord  '" + cmbDonorNo.SelectedItem + "'", con1);
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBoxForDeleteData1.Show();
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

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListBloodDonationRecord", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            BloodDonationList.DataSource = data;

            
        }

        private void BloodDonationList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(BloodDonationList.SelectedRows[0].Cells[0].Value);
            cmbDonorNo.SelectedItem = BloodDonationList.SelectedRows[0].Cells[1].Value;
            txtName.Text = BloodDonationList.SelectedRows[0].Cells[2].Value.ToString();
            dtpDateOfBrith.Value = Convert.ToDateTime(BloodDonationList.SelectedRows[0].Cells[3].Value);
            cmbGender.SelectedItem = BloodDonationList.SelectedRows[0].Cells[4].Value.ToString();
            RegistrationDate.Value = Convert.ToDateTime(BloodDonationList.SelectedRows[0].Cells[5].Value);
            txtMobileNo.Text = BloodDonationList.SelectedRows[0].Cells[6].Value.ToString();
            txtEmailID.Text = BloodDonationList.SelectedRows[0].Cells[7].Value.ToString();
            cmbCity.SelectedItem = BloodDonationList.SelectedRows[0].Cells[8].Value.ToString();
            txtAddress.Text = BloodDonationList.SelectedRows[0].Cells[9].Value.ToString();
            cmbBloodGroup.SelectedItem = BloodDonationList.SelectedRows[0].Cells[10].Value.ToString();
             BloodDonationDate.Value = Convert.ToDateTime(BloodDonationList.SelectedRows[0].Cells[11].Value);
            txtHeight.Text = BloodDonationList.SelectedRows[0].Cells[12].Value.ToString();
            txtWeight.Text = BloodDonationList.SelectedRows[0].Cells[13].Value.ToString();
            txtBP1.Text = BloodDonationList.SelectedRows[0].Cells[14].Value.ToString();
            txtBP2.Text = BloodDonationList.SelectedRows[0].Cells[15].Value.ToString();
            txtMedicalExam.Text = BloodDonationList.SelectedRows[0].Cells[16].Value.ToString();
            txtPules.Text = BloodDonationList.SelectedRows[0].Cells[17].Value.ToString();
            cmbDonation.SelectedItem = BloodDonationList.SelectedRows[0].Cells[18].Value.ToString();
            txtInegularAntibodiers.Text = BloodDonationList.SelectedRows[0].Cells[19].Value.ToString();
            txtHemoglobin.Text = BloodDonationList.SelectedRows[0].Cells[20].Value.ToString();





        }
    }
}
