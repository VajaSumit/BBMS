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
    public partial class ImageSliderPage : Form
    {
        public ImageSliderPage()
        {
            InitializeComponent();
        }

        public int imgnumber = 1;

        public void loadnextimg()
        {
            timer1.Start();
            imgnumber = imgnumber + 1;
            if (imgnumber > 4)
            {
                imgnumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\images" + imgnumber + ".jpg");
            loadchecked();

        }

        public void loadpreviousimg()
        {
            timer1.Start();
            imgnumber = imgnumber - 1;
            if (imgnumber < 1)
            {
                imgnumber = 4;
            }
            pictureBox1.ImageLocation =  string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\images" + imgnumber + ".jpg");
            loadchecked();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadnextimg();
        }

        private void btnleftside_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            loadpreviousimg();
        }

        private void btnrightside_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            loadnextimg();
        }
        private void ImageSliderPage_Load(object sender, EventArgs e)
        {
          
                  pictureBox1.ImageLocation=string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\images\ " + imgnumber + ".jpg");
        }

        public void loadchecked()
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
        }

        public void changedcheck()
        {
            timer1.Start();
            if (radioButton1.Checked == true)
            {
                imgnumber = 1;
            }
            else if (radioButton2.Checked == true)
            {
                imgnumber = 2;
            }
            else if (radioButton3.Checked == true)
            {
                imgnumber = 3;
            }
            else if (radioButton4.Checked == true)
            {
                imgnumber = 4;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\Sumit\Documents\Visual Studio 2015\Projects\BloodBankManagementSystem\BloodBankManagementSystem\images\ " + imgnumber + ".jpg");

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            changedcheck();

        }
    }
}
