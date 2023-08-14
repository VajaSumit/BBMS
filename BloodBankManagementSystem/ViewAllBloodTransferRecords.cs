﻿using System;
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
    public partial class ViewAllBloodTransferRecords : Form
    {
        public ViewAllBloodTransferRecords()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllBloodTransferRecords_Load(object sender, EventArgs e)
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
            BloodTransferList.DataSource = data;
            

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DataBinding();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                BloodTransferList.DataSource = data;

            }
            else
            {
                MessageBoxForSearchData2.Show();
                DataBinding();
            }


            con.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
