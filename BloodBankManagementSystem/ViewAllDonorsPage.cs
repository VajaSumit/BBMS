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
    public partial class ViewAllDonorsPage : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ViewAllDonorsPage()
        {
            InitializeComponent();
        }

        private void ViewAllDonorsPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        public void DataBinding()
        {
            //Data Fatch By Using Query

            //SqlConnection con = new SqlConnection(cs);
            //string query = "select *from Donor_RegistrationTbl";
            //SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridView1.DataSource = data;

            // Data Fatch By Using Procedure

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListDonorRecordRegistration",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            
        }





        private void btnclose_Click_1(object sender, EventArgs e)
        {
        }

  

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text) == true)
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter Name");
                txtSearchName.Focus();
            }
            else
            {
                errorProvider1.Clear();

                string name = txtSearchName.Text;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("exec SearchDonorRecordRegistration '" + name + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    SearchDataDialogBox.Show();
                    dataGridView1.DataSource = data;
                    txtSearchName.Clear();
                }
                else
                {
                    SearchDailogBox2.Show();
                    DataBinding();
                }
                con.Close();
            }
        }

        private void btnviewall_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            txtSearchName.BackColor = Color.White;

            if (string.IsNullOrEmpty(txtSearchName.Text) == true)
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter Name");
                txtSearchName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
