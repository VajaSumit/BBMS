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
    public partial class BloodTransferPage : Form
    {
        public BloodTransferPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        ViewAllBloodTransferRecords viewallbloodtransfer;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPatientNo_Leave(object sender, EventArgs e)
        {
            if (cmbPatientNo.SelectedItem == null)
            {
                errorProvider1.SetError(this.cmbPatientNo, "Please Select The Patient ID ..");
                cmbPatientNo.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cmbGender_Leave(object sender, EventArgs e)
        {
            if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender, "please select gender...");
                cmbGender.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void cmbCity_Leave(object sender, EventArgs e)
        {
            if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider3.SetError(this.cmbCity, "please select city...");
                cmbCity.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void cmbBloodGroup_Leave(object sender, EventArgs e)
        {
            if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider4.SetError(this.cmbBloodGroup, "please select blood group...");
                cmbBloodGroup.Focus();
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void cmbHospitalName_Leave(object sender, EventArgs e)
        {
            if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbHospitalName, "Please Select The Hspital Name ..");
                cmbHospitalName.Focus();
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void cmbDoctorName_Leave(object sender, EventArgs e)
        {
            if (cmbDoctorName.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbDoctorName, "Please Select The Doctor Name ..");
                cmbDoctorName.Focus();
            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void cmbBloodBottle_Leave(object sender, EventArgs e)
        {
            if (cmbBloodBottle.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbBloodBottle, "Please Select The Bottle-unit's ..");
                cmbBloodBottle.Focus();
            }
            else
            {
                errorProvider7.Clear();
            }
        }

        private void txtBottleUsed_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBottleUsed.Text))
            {
                errorProvider8.SetError(this.txtBottleUsed, "Please Enter Bottle used details ..");
                txtBottleUsed.Focus();
            }
            else
            {
                errorProvider8.Clear();
            }
        }

        private void BloodTransferPage_Load(object sender, EventArgs e)
        {
            BindingThePatientNo();
            DataBinding();
            DataBindingForDoctorName();
            DataBindingForHospitalName();
            cmbGender.SelectedItem = "Select Gender";
            cmbCity.SelectedItem = "Select City";
            cmbBloodGroup.SelectedItem = "Select Blood Group";
            btnBloodTransfer.Enabled = false;

        }

        public void ClearData()
        {
            BindingThePatientNo();

            DataBindingForDoctorName();
            DataBindingForHospitalName();

            btnBloodTransfer.Enabled = false;


            cmbPatientNo.SelectedItem = null;
            txtName.Clear();
            dtpDateOfBrith.Value = DateTime.Now;
            txtMobileNo.Clear();
            RegistrationDate.Value = DateTime.Now;
            txtEmailID.Clear();
            txtAddress.Clear();
            BloodTransferDate.Value = DateTime.Now;
            cmbGender.SelectedItem = "Select Gender";
            cmbCity.SelectedItem = "Select City";
            cmbBloodGroup.SelectedItem = "Select Blood Group";
            cmbDoctorName.SelectedItem = null;
            cmbHospitalName.SelectedItem = null;
            cmbBloodBottle.SelectedItem = null;
            txtBottleUsed.Clear();



        }

        public void BindingThePatientNo()
        {
            cmbPatientNo.Items.Clear();


            SqlConnection con = new SqlConnection(cs);
            string query = "select *from Patient_RegistrationTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string no = dr.GetString(1);
                cmbPatientNo.Items.Add(no);
            }
            con.Close();
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

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBoxForResetData1.Show();
            if (dr == DialogResult.Yes)
            {
                ClearData();
                DataBinding();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbPatientNo.SelectedItem == null)
            {
                errorProvider1.SetError(this.cmbPatientNo, "Please Select The Patient ID ..");
                cmbPatientNo.Focus();
            }
            else
            {
                DialogResult dr = MessageBoxForDeleteData1.Show();
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("exec DeleteBloodTransferRecord '" + cmbPatientNo.SelectedItem + "'", con);
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForDeleteData2.Show();
                        DataBinding();
                        ClearData();
                    }
                    con.Close();
                }
            }
        }

        private void BloodTransferList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(BloodTransferList.SelectedRows[0].Cells[0].Value.ToString());
            cmbPatientNo.SelectedItem = BloodTransferList.SelectedRows[0].Cells[1].Value.ToString();
            txtName.Text = BloodTransferList.SelectedRows[0].Cells[2].Value.ToString();
            dtpDateOfBrith.Value = Convert.ToDateTime(BloodTransferList.SelectedRows[0].Cells[3].Value.ToString());
            cmbGender.SelectedItem = BloodTransferList.SelectedRows[0].Cells[4].Value.ToString();
            txtMobileNo.Text = BloodTransferList.SelectedRows[0].Cells[5].Value.ToString();
            RegistrationDate.Value = Convert.ToDateTime(BloodTransferList.SelectedRows[0].Cells[6].Value.ToString());
            txtEmailID.Text = BloodTransferList.SelectedRows[0].Cells[7].Value.ToString();
            cmbCity.SelectedItem = BloodTransferList.SelectedRows[0].Cells[8].Value.ToString();
            txtAddress.Text = BloodTransferList.SelectedRows[0].Cells[9].Value.ToString();
            BloodTransferDate.Value = Convert.ToDateTime(BloodTransferList.SelectedRows[0].Cells[10].Value.ToString());
            cmbBloodGroup.SelectedItem = BloodTransferList.SelectedRows[0].Cells[11].Value.ToString();
            cmbHospitalName.SelectedItem = BloodTransferList.SelectedRows[0].Cells[12].Value.ToString();
            cmbDoctorName.SelectedItem = BloodTransferList.SelectedRows[0].Cells[13].Value.ToString();
            cmbBloodBottle.SelectedItem = BloodTransferList.SelectedRows[0].Cells[14].Value.ToString();
            txtBottleUsed.Text = BloodTransferList.SelectedRows[0].Cells[15].Value.ToString();

        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListBloodTransferRecord", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            BloodTransferList.DataSource = data;
            btnBloodTransfer.Enabled = false;

        }

        private void btnBloodTransfer_Click(object sender, EventArgs e)
        {
            if (cmbPatientNo.SelectedItem == null)
            {
                errorProvider1.SetError(this.cmbPatientNo, "Please Select The Patient ID ..");
                cmbPatientNo.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender, "please select gender...");
                cmbGender.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider3.SetError(this.cmbCity, "please select city...");
                cmbCity.Focus();
            }
            else if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider4.SetError(this.cmbBloodGroup, "please select blood group...");
                cmbBloodGroup.Focus();
            }
            else if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbHospitalName, "Please Select The Hspital Name ..");
                cmbHospitalName.Focus();
            }
            else if (cmbDoctorName.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbDoctorName, "Please Select The Doctor Name ..");
                cmbDoctorName.Focus();
            }
            else if (cmbBloodBottle.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbBloodBottle, "Please Select The Bottle-unit's ..");
                cmbBloodBottle.Focus();
            }
            else if (string.IsNullOrEmpty(txtBottleUsed.Text))
            {
                errorProvider8.SetError(this.txtBottleUsed, "Please Enter Bottle used details ..");
                txtBottleUsed.Focus();
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                con1.Open();
                SqlCommand cmd1 = new SqlCommand("exec InsertBloodTransferRecord  '" + cmbPatientNo.SelectedItem + "','" + txtName.Text + "','" + dtpDateOfBrith.Value + "','" + cmbGender.SelectedItem + "','" + txtMobileNo.Text + "','" + RegistrationDate.Value + "','" + txtEmailID.Text + "','" + cmbCity.SelectedItem + "','" + txtAddress.Text + "','" + BloodTransferDate.Value + "','" + cmbBloodGroup.SelectedItem + "','" + cmbHospitalName.SelectedItem + "','" + cmbDoctorName.SelectedItem + "','" + cmbBloodBottle.SelectedItem + "','" + txtBottleUsed.Text + "'", con1);
                int a = cmd1.ExecuteNonQuery();
                if (a > 0)
                {
                    BloodStockRemove();
                    MessageBoxForInsertData1.Show();
                    ClearData();
                    DataBinding();

                }
                else
                {
                    MessageBoxForInsertData2.Show();
                }
                con1.Close();
            }
        }

        public void BloodStockRemove()
        {
            int bottle = int.Parse(cmbBloodBottle.SelectedItem.ToString());
            int n = 0;
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
                    if (oldstock != n)
                    {
                        int newstock = oldstock - bottle;

                        SqlConnection con1 = new SqlConnection(cs);
                        string query1 = "update BloodStockTbl set BloodStock=@newstock where BloodGroup=@bloodgroup";
                        SqlCommand cmd1 = new SqlCommand(query1, con1);
                        cmd1.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem);
                        cmd1.Parameters.AddWithValue("@newstock", newstock);
                        //con.Close();
                        con1.Open();
                        cmd1.ExecuteNonQuery();
                        con1.Close();
                    }


                }
            }
            con.Close();
        }



        private void btnAvailable_Click(object sender, EventArgs e)
        {
            if (cmbPatientNo.SelectedItem == null)
            {
                errorProvider1.SetError(this.cmbPatientNo, "Please Select The Patient ID ..");
                cmbPatientNo.Focus();
            }
            else if (cmbGender.SelectedItem.ToString() == "Select Gender")
            {
                errorProvider2.SetError(this.cmbGender, "please select gender...");
                cmbGender.Focus();
            }
            else if (cmbCity.SelectedItem.ToString() == "Select City")
            {
                errorProvider3.SetError(this.cmbCity, "please select city...");
                cmbCity.Focus();
            }
            else if (cmbBloodGroup.SelectedItem.ToString() == "Select Blood Group")
            {
                errorProvider4.SetError(this.cmbBloodGroup, "please select blood group...");
                cmbBloodGroup.Focus();
            }
            else if (cmbHospitalName.SelectedItem == null)
            {
                errorProvider5.SetError(this.cmbHospitalName, "Please Select The Hspital Name ..");
                cmbHospitalName.Focus();
            }
            else if (cmbDoctorName.SelectedItem == null)
            {
                errorProvider6.SetError(this.cmbDoctorName, "Please Select The Doctor Name ..");
                cmbDoctorName.Focus();
            }
            else if (cmbBloodBottle.SelectedItem == null)
            {
                errorProvider7.SetError(this.cmbBloodBottle, "Please Select The Bottle-unit's ..");
                cmbBloodBottle.Focus();
            }
            else if (string.IsNullOrEmpty(txtBottleUsed.Text))
            {
                errorProvider8.SetError(this.txtBottleUsed, "Please Enter Bottle used details ..");
                txtBottleUsed.Focus();
            }
            else
            {
                int bottle = int.Parse(cmbBloodBottle.SelectedItem.ToString());

                SqlConnection con = new SqlConnection(cs);
                string query = "select *from BloodStockTbl where BloodGroup=@bloodgroup";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@bloodgroup", cmbBloodGroup.SelectedItem);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int stock = dr.GetInt32(2);
                    if (stock == 0)
                    {
                        MessageBoxForBloodStockChecking1.Show();
                        btnBloodTransfer.Enabled = false;

                    }
                    else if (stock < bottle)
                    {
                        MessageBoxForBloodStockChecking1.Show();
                        btnBloodTransfer.Enabled = false;


                    }
                    else if (stock >= bottle)
                    {
                        MessageBoxForBloodStockChecking2.Show();
                        btnBloodTransfer.Enabled = true;
                    }
                }



            }
        }

        private void cmbPatientNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatientNo.SelectedItem == null)
            {
                errorProvider1.SetError(this.cmbPatientNo, "Please Select The Patient ID ..");
                cmbPatientNo.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select *from Patient_RegistrationTbl where PId=@PId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PId", cmbPatientNo.SelectedItem);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtName.Text = dr.GetString(2).ToString();
                    dtpDateOfBrith.Value = dr.GetDateTime(3);
                    cmbGender.SelectedItem = dr.GetString(4);
                    txtMobileNo.Text = dr.GetString(5);
                    RegistrationDate.Value = dr.GetDateTime(6);
                    txtEmailID.Text = dr.GetString(7).ToString();
                    cmbCity.SelectedItem = dr.GetString(8).ToString();
                    txtAddress.Text = dr.GetString(9).ToString();
                    cmbBloodGroup.SelectedItem = dr.GetString(10).ToString();
                    cmbHospitalName.SelectedItem = dr.GetString(11).ToString();
                    cmbDoctorName.SelectedItem = dr.GetString(12).ToString();

                }
                con.Close();
            }
        }

        private void btnViewAllBloodTransfer_Click(object sender, EventArgs e)
        {
            MasterPage m = new MasterPage();
            if (viewallbloodtransfer == null)
            {
                viewallbloodtransfer = new ViewAllBloodTransferRecords();
                viewallbloodtransfer.FormClosed += Viewallbloodtransfer_FormClosed;
                //viewallbloodtransfer.MdiParent = this;
                viewallbloodtransfer.Show();
            }
            else
            {
                viewallbloodtransfer.Activate();
            }
        }

        private void Viewallbloodtransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallbloodtransfer = null;
        }

    }
}