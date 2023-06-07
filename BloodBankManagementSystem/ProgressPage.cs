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
  
    public partial class ProgressPage : Form
    { 
        
        public ProgressPage()
        {
            InitializeComponent();
        }

      

        //int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //   label2.Text = i.ToString() + " % ";
            ////   this.Text = "Progress (" + i.ToString() + "%)";
            //   progressBar1.Value = i;
            //   if (i == 100)
            //   {
            //       timer1.Enabled = false;
            //       LoginPage l = new LoginPage();
            //       l.Show();
            //       this.Hide();
            //   }
            //   i = i + 3;


            if (progressbarpanal.Width!=toppanal.Width)
            {
                //   label1.Text = progressbarpanal.Width + "%";
                    progressbarpanal.Width = progressbarpanal.Width + 1;
            }
            else
            {

                 timer1.Enabled = false;
                LoginPage l = new LoginPage();
                l.Show();
                this.Hide();
            }
        }

   

        private void ProgressPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

    
    }
}
