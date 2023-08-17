using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BloodBankManagementSystem
{
    public partial class ReportForBloodDonationPage : Form
    {
        public ReportForBloodDonationPage()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataBinding()
        {
            //SqlConnection con = new SqlConnection(cs);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("exec ListBloodDonationRecord", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //BloodDonationList.DataSource = data;


            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListBloodDonationRecord", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);

            CrystalReport1 myreport = new CrystalReport1();
            myreport.SetDataSource(data);
            crystalReportViewer1.ReportSource = myreport;

        }

        private void ReportForBloodDonationPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select *from BloodDonationTbl where BloodDonationDate=@BDate";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@BDate", BloodDonationDate.Value);
            DataTable data = new DataTable();
            sda.Fill(data);

            if (data.Rows.Count > 0)
            {
                MessageBoxForSearchData1.Show();
                //BloodDonationList.DataSource = data;
                CrystalReport1 myreport = new CrystalReport1();
                myreport.SetDataSource(data);
                crystalReportViewer1.ReportSource = myreport;

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
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Name ... !");
                txtSearchName.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "select *from BloodDonationTbl where Name=@name";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Name", txtSearchName.Text);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    MessageBoxForSearchData1.Show();
                    //BloodDonationList.DataSource = data;
                    CrystalReport1 myreport = new CrystalReport1();
                    myreport.SetDataSource(data);
                    crystalReportViewer1.ReportSource = myreport;

                }
                else
                {
                    MessageBoxForSearchData2.Show();
                    DataBinding();
                }


                con.Close();
            }
        }

        private void btnSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSwitch1.Checked == true)
            {
                BloodDonationDate.Enabled = true;
                btnSearch1.Enabled = true;
            }
            else if (btnSwitch1.Checked == false)
            {
                BloodDonationDate.Enabled = false ;
                btnSearch1.Enabled = false;
            }
        }

        private void btnSwitch2_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSwitch2.Checked == true)
            {
                txtSearchName.Enabled = true;
                btnSearch2.Enabled = true;
            }
            else if (btnSwitch2.Checked == false)
            {
                txtSearchName.Enabled = false ;
                btnSearch2.Enabled = false;
            }
        }

        private void txtSearchName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text))
            {
                errorProvider1.SetError(this.txtSearchName, "Please Enter The Name ... !");
                txtSearchName.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
