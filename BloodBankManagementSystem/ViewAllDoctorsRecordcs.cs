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
    public partial class ViewAllDoctorsRecordcs : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ViewAllDoctorsRecordcs()
        {
            InitializeComponent();
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

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllDoctorsRecordcs_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
