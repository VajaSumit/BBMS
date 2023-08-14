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
            DataBinding2();


        }

        private void BloodDonationList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(BloodDonationList.SelectedRows[0].Cells[0].Value);
            txtBloodGroup.Text = BloodDonationList.SelectedRows[0].Cells[1].Value.ToString();
            txtBloodStock.Text = BloodDonationList.SelectedRows[0].Cells[2].Value.ToString();

        }
        private void btnDiscard_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBloodGroup.Text))
            {
                errorProvider1.SetError(this.txtBloodGroup, "please Enter The Blood Group....");
            }
            else if(string.IsNullOrEmpty(txtBloodStock.Text))
            {
                errorProvider2.SetError(this.txtBloodStock, "please Enter The Blood Stock...");
            }
            else if(cmbResult.SelectedItem == null)
            {
                errorProvider3.SetError(this.cmbResult, "please select the  result..");
            }
            else if(string.IsNullOrEmpty(txtReason.Text))
            {
                errorProvider4.SetError(this.txtReason, "please Enter The Reason..");
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
                    cmd.Parameters.AddWithValue("@stock",0);
                    cmd.Parameters.AddWithValue("@upDate", DateTime.Now.ToShortDateString());
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        InsertBottleDiscardDetails();
                        ClearData();
                        MessageBoxForDiscard3.Show();
                        Databinding();
                        DataBinding2();
                    }
                    con.Close();
                }
            }
        }

        public void ClearData()
        {
            txtBloodGroup.Clear();
            txtBloodStock.Clear();
            cmbResult.SelectedItem = null;
            txtReason.Clear();
            Databinding();
            DataBinding2();
        }

        public void DataBinding2()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "select *from BloodDiscardTbl";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            BloodDiscardList.DataSource = data;

            
        }
       
        public void InsertBottleDiscardDetails()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "insert into BloodDiscardTbl values(@bloodgroup,@bloodbottle,@discarddate,@result,@reason)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@bloodgroup", txtBloodGroup.Text);
            cmd.Parameters.AddWithValue("@bloodbottle",txtBloodStock.Text);
            cmd.Parameters.AddWithValue("@discarddate",BloodDiscardDate.Value);
            cmd.Parameters.AddWithValue("@result", cmbResult.SelectedItem);
            cmd.Parameters.AddWithValue("@reason",txtReason.Text);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
            
                ClearData();
            }

            con.Close();

        }

        private void txtBloodGroup_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBloodGroup.Text))
            {
                errorProvider1.SetError(this.txtBloodGroup, "please Enter The Blood Group....");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtBloodStock_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBloodStock.Text))
            {
                errorProvider2.SetError(this.txtBloodStock, "please Enter The Blood Stock...");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void cmbResult_Leave(object sender, EventArgs e)
        {
            if (cmbResult.SelectedItem == null)
            {
                errorProvider3.SetError(this.cmbResult, "please select the  result..");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void txtReason_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReason.Text))
            {
                errorProvider4.SetError(this.txtReason, "please Enter The Reason..");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBoxForResetData.Show();
            if (d == DialogResult.Yes)
            {
                ClearData();
            }
        }
    }
}