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
    public partial class ViewAllBloodDonation : Form
    {
        public ViewAllBloodDonation()
        {
            InitializeComponent();
        }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewAllBloodDonation_Load(object sender, EventArgs e)
        {
            DataBinding();
        }

        public void DataBinding()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("exec ListBloodDonationRecord", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            BloodDonationList.DataSource = data;


        }
    }
}