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
using System.Data.SqlClient;
using System.Configuration;

namespace BloodBankManagementSystem
{
    public partial class ViewAllUser : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public ViewAllUser()
        {
            InitializeComponent();
        }

        public void DataBinding()
        {
       

            //SqlConnection con = new SqlConnection(cs);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("exec ListUserRecord", con);
            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable data = new DataTable();
            //sda.Fill(data);
            //dataGridView1.RowTemplate.Height = 75;
            //dataGridView1.DataSource = data;

            //DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            //dgv = (DataGridViewImageColumn)dataGridView1.Columns[8];
            //dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //con.Close();


            // By Using Query

            SqlConnection con = new SqlConnection(cs);
            //con.Open();
            string query = "select *from Login_Master";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[8];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //con.Close();
        }

        private void ViewAllUser_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
