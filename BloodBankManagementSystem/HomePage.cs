using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }






        int imgnumber = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (imgnumber >= 6)
            {
                imgnumber = 1;
            }
            loadchecked(imgnumber);
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\Images\" + imgnumber + ".jpg");
            imgnumber = imgnumber + 1;
        }

        public void loadchecked(int imgnumber)
        {
            if (imgnumber == 1)
            {
                radioButton1.Checked = true;
            }
            else if (imgnumber == 2)
            {
                radioButton2.Checked = true;
            }
            else if (imgnumber == 3)
            {
                radioButton3.Checked = true;
            }
            else if (imgnumber == 4)
            {
                radioButton4.Checked = true;
            }
            else if (imgnumber == 5)
            {
                radioButton5.Checked = true;
            }
        }



        //public void changedcheck()
        //{
        //    timer1.Start();
        //    if (radioButton1.Checked == true)
        //    {
        //        imgnumber = 1;
        //    }
        //    else if (radioButton2.Checked == true)
        //    {
        //        imgnumber = 2;
        //    }
        //    else if (radioButton3.Checked == true)
        //    {
        //        imgnumber = 3;
        //    }
        //    else if (radioButton4.Checked == true)
        //    {
        //        imgnumber = 4;
        //    }
        //    else if (radioButton5.Checked == true)
        //    {
        //        imgnumber = 5;
        //    }
        //    pictureBox1.ImageLocation = string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\Images\ " + imgnumber + ".jpg");

        //}

        //public void loadnextimg()
        //{
        //    timer1.Start();
        //    imgnumber = imgnumber + 1;
        //    if (imgnumber > 5)
        //    {
        //        imgnumber = 1;
        //    }
        //    pictureBox1.ImageLocation = string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\Images" + imgnumber + ".jpg");
        //    loadchecked(imgnumber);

        //}

        //public void loadpreviousimg()
        //{
        //    timer1.Start();
        //    imgnumber = imgnumber - 1;
        //    if (imgnumber < 1)
        //    {
        //        imgnumber = 5;
        //    }
        //    pictureBox1.ImageLocation = string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\Images" + imgnumber + ".jpg");
        //    loadchecked(imgnumber);

        //}
        private void HomePage_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
