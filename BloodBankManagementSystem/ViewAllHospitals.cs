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
    public partial class ViewAllHospitals : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public ViewAllHospitals()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListHospitalRecordRegistration", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            HospitalList.DataSource = data;

        }

        private void ViewAllHospitals_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Hospital Name ... ");
                txtSearchName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Hospital Name ... ");
                txtSearchName.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "select *from HospitalTbl where Name=@nm";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@nm", txtSearchName.Text);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    guna2MessageDialog1.Show();
                    HospitalList.DataSource = data;
                    txtSearchName.Clear();

                }
                else
                {
                    guna2MessageDialog2.Show();
                    DataBinding();
                    txtSearchName.Clear();
                }

            }
        }
    }
}
