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
    public partial class AdminUserAddPage : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public AdminUserAddPage()
        {
            InitializeComponent();
            BindingData();
            AutoIncrementId();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage l = new LoginPage();
            l.Show();
        }

        private void AdminUserAddPage_Load(object sender, EventArgs e)
        {
        }

        public void BindingData()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select *from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        public void ClearData()
        {
            txtusriformationname.Clear();
            txtuserinformationusername.Clear();
            txtuserinformationpassword.Clear();
        }

        private void btnsaveuser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusriformationname.Text) == true)
            {
                errorProvider1.SetError(this.txtusriformationname, "Please Enter Name !");
                txtusriformationname.Focus();
            }
            else if (string.IsNullOrEmpty(txtuserinformationusername.Text) == true)
            {

                errorProvider2.SetError(this.txtuserinformationusername, "Please Enter UserName !");
                txtuserinformationusername.Focus();
            }
            else if (string.IsNullOrEmpty(txtuserinformationpassword.Text) == true)
            {
                errorProvider3.SetError(this.txtuserinformationpassword, "Please Enter Password !");
                txtuserinformationpassword.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "insert into UserTbl values(@name,@uname,@pass)";
                SqlCommand cmd = new SqlCommand(query, con);
                //cmd.Parameters.AddWithValue("@id",txtuserinformationuserid.Text);
                cmd.Parameters.AddWithValue("@name", txtusriformationname.Text);
                cmd.Parameters.AddWithValue("@uname", txtuserinformationusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtuserinformationpassword.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Inserte successful ","Data Insert Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearData();
                    BindingData();
                    AutoIncrementId();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted !! ", "Data Insert Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();

            }
        }

        private void txtusriformationname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusriformationname.Text)==true)
            {
                errorProvider1.SetError(this.txtusriformationname, "Please Enter Name !");
                txtusriformationname.Focus();
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtuserinformationusername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserinformationusername.Text)==true)
            {

                errorProvider2.SetError(this.txtuserinformationusername, "Please Enter UserName !");
                txtuserinformationusername.Focus();
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void txtuserinformationpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtuserinformationpassword.Text)==true)
            {
                errorProvider3.SetError(this.txtuserinformationpassword, "Please Enter Password !");
                txtuserinformationpassword.Focus();
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void btnupdateuser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusriformationname.Text) == true)
            {
                errorProvider1.SetError(this.txtusriformationname, "Please Enter Name !");
                txtusriformationname.Focus();
            }
            else if (string.IsNullOrEmpty(txtuserinformationusername.Text) == true)
            {

                errorProvider2.SetError(this.txtuserinformationusername, "Please Enter UserName !");
                txtuserinformationusername.Focus();
            }
            else if (string.IsNullOrEmpty(txtuserinformationpassword.Text) == true)
            {
                errorProvider3.SetError(this.txtuserinformationpassword, "Please Enter Password !");
                txtuserinformationpassword.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "update UserTbl set name=@name,username=@uname,password=@pass where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtuserinformationuserid.Text);
                cmd.Parameters.AddWithValue("@name", txtusriformationname.Text);
                cmd.Parameters.AddWithValue("@uname", txtuserinformationusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtuserinformationpassword.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Update successful ", "Data Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    BindingData();
                  
                }
                else
                {
                    MessageBox.Show("Data Not Updated !! ", "Data Update Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();

            }
        }

        private void btndeleteuser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusriformationname.Text) == true)
            {
                errorProvider1.SetError(this.txtusriformationname, "Please Enter Name !");
                txtusriformationname.Focus();
            }
            else if (string.IsNullOrEmpty(txtuserinformationusername.Text) == true)
            {

                errorProvider2.SetError(this.txtuserinformationusername, "Please Enter UserName !");
                txtuserinformationusername.Focus();
            }
            else if (string.IsNullOrEmpty(txtuserinformationpassword.Text) == true)
            {
                errorProvider3.SetError(this.txtuserinformationpassword, "Please Enter Password !");
                txtuserinformationpassword.Focus();
            }
            else
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "delete from UserTbl where id=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", txtuserinformationuserid.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Data Delete successful ", "Data Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    BindingData();
                }
                else
                {
                    MessageBox.Show("Data Not Deleted !! ", "Data Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                con.Close();

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtuserinformationuserid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtusriformationname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtuserinformationusername.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtuserinformationpassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }


        public void AutoIncrementId()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "select id from UserTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            if (data.Rows.Count<1)
            {
                txtuserinformationuserid.Text = "1";
            }
            else
            {
                SqlConnection con1 = new SqlConnection(cs);
                string query1 = "select max(id) from UserTbl";
                SqlCommand cmd1 = new SqlCommand(query1, con1);
                con1.Open();
                int id = Convert.ToInt32(cmd1.ExecuteScalar());
                con1.Close();
                id = id + 1;
                txtuserinformationuserid.Text = id.ToString();
                
             
            }
        }
    }
}
