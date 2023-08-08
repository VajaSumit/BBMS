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
    public partial class BloodDiscardPage : Form
    {
        public BloodDiscardPage()
        {
            InitializeComponent();
        }
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void Databinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select *from BloodStockTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            BloodDonationList.DataSource = data;

        }

        private void BloodDiscardPage_Load(object sender, EventArgs e)
        {
            Databinding();


        }

        private void BloodDonationList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(BloodDonationList.SelectedRows[0].Cells[0].Value);
            txtBloodGroup.Text = BloodDonationList.SelectedRows[0].Cells[1].Value.ToString();
            txtBloodStock.Text = BloodDonationList.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (txtBloodGroup.Text == "" || txtBloodStock.Text == "")
            {
                MessageBoxForBloodDiscard1.Show();
            }
            else
            {
                int s = 0;
                //DateTime p = Convert.ToDateTime("0/0/" + DateTime.Now.ToString("yyyy"));

                DialogResult dr = MessageBoxForBloodDiscard2.Show();
                if (dr == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "update BloodStockTbl set BloodStock=@stock , UpdatedDate=@upDate where BloodGroup=@bloodgroup";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bloodgroup", txtBloodGroup.Text);
                    cmd.Parameters.AddWithValue("@stock", s);
                    cmd.Parameters.AddWithValue("@upDate", DateTime.Now.ToShortDateString());
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBoxForDiscard3.Show();
                        txtBloodGroup.Clear();
                        txtBloodStock.Clear();
                        Databinding();
                    }
                    con.Close();
                }
            }
        }
    }
}