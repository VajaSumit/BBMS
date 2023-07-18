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
    public partial class ViewAllPatientPage : Form
    {
        public ViewAllPatientPage()
        {
            InitializeComponent();
            DataBinding();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllPatientPage_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListPatientRecordRegistration", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
          
        }

      
    
    

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                SqlCommand cmd = new SqlCommand("exec SearchPatientRecordRegistration '" + name + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                sda.Fill(data);

                if (data.Rows.Count > 0)
                {
                    SearchDataDialogBox1.Show();
                    dataGridView1.DataSource = data;
                    txtSearchName.Clear();
                }
                else
                {
                    SearchDataDialogBox2.Show();
                    DataBinding();
                }


                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void txtSearchName_Leave_1(object sender, EventArgs e)
        {
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
    }
}
