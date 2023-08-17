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
    public partial class ReportForBloodTransferPage : Form
    {
        public ReportForBloodTransferPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForBloodTransferPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListBloodTransferRecord", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);

            CrystalReport2 report = new CrystalReport2();
            report.SetDataSource(data);
            crystalReportViewer1.ReportSource = report;

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSwitch1.Checked == true)
            {
                BloodTransferDate.Enabled = true;
                btnSearch1.Enabled = true;
            }
            else if (btnSwitch1.Checked == false)
            {
                BloodTransferDate.Enabled = false;
                btnSearch1.Enabled = false;
            }
        }

        private void btnSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSwitch2.Checked==true)
            {
                txtSearchName.Enabled = true;
                btnSearch2.Enabled = true;
            }
            else if (btnSwitch2.Checked==false)
            {
                txtSearchName.Enabled = false;
                btnSearch2.Enabled = false;
            }
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select *from BloodTransferTbl where BloodTransferDate=@BDate";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@BDate", BloodTransferDate.Value);
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count > 0)
            {
                MessageBoxForSearchData1.Show();
                CrystalReport2 report = new CrystalReport2();
                report.SetDataSource(data);
                crystalReportViewer1.ReportSource = report;

            }
            else
            {
                MessageBoxForSearchData2.Show();
                DataBinding();
            }


            con.Close();
        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Name ..!");
                txtSearchName.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "select *from BloodTransferTbl where Name=@nm";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@nm", txtSearchName.Text);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    MessageBoxForSearchData1.Show();
                    CrystalReport2 report = new CrystalReport2();
                    report.SetDataSource(data);
                    crystalReportViewer1.ReportSource = report;

                }
                else
                {
                    MessageBoxForSearchData2.Show();
                    DataBinding();
                }


                con.Close();
            }
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Name ..!");
                txtSearchName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
