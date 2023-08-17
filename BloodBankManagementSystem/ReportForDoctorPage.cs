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
    public partial class ReportForDoctorPage : Form
    {
        public ReportForDoctorPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForDoctorPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListDoctorRecordRegistration", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);

            CrystalReport3 report = new CrystalReport3();
            report.SetDataSource(data);
            crystalReportViewer1.ReportSource = report;
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Doctor Name ..");
                txtSearchName.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "select *from DoctorTbl where Name=@nm";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@nm", txtSearchName.Text);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    MessageBooxForSearchData1.Show();
                    CrystalReport3 report = new CrystalReport3();
                    report.SetDataSource(data);
                    crystalReportViewer1.ReportSource = report;
                    txtSearchName.Clear();

                }
                else
                {
                    MessageBoxForSearchData2.Show();
                    DataBinding();
                    txtSearchName.Clear();
                }
            }
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Doctor Name ..");
                txtSearchName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
