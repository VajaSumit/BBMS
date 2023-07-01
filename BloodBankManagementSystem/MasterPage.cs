using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class MasterPage : Form
    {
        private int childFormNumber = 0;

        public MasterPage()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        /*
        private void btnHome_Click(object sender, EventArgs e)
        {
            movepanel(btnHome);
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            movepanel(btnDonor);
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            movepanel(btnPatient);
            panelDonor.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnBloodDonor_Click(object sender, EventArgs e)
        {
            movepanel(btnBloodDonor);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnBloodTransfar_Click(object sender, EventArgs e)
        {
            movepanel(btnBloodTransfar);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
        }

        private void BtnBloodStock_Click(object sender, EventArgs e)
        {
            movepanel(BtnBloodStock);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            movepanel(btnReport);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelSettings.Visible = false;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            movepanel(btnSettings);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            movepanel(btnLogout);
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnHome);

        }

        private void btnDonor_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnDonor);
    
        }

        private void btnPatient_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnPatient);

        }

        private void btnBloodDonor_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnBloodDonor);
        }

        private void btnBloodTransfar_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnBloodTransfar);
        }

        private void BtnBloodStock_MouseHover(object sender, EventArgs e)
        {
            movepanel(BtnBloodStock);
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnReport);

        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnSettings);

        }

        private void btnLogout_MouseHover(object sender, EventArgs e)
        {
            movepanel(btnLogout);
        }

        private void btnDonor_MouseLeave(object sender, EventArgs e)
        {
            panelDonor.Visible = false;
        }


        private void btnPatient_MouseLeave(object sender, EventArgs e)
        {
            panelPatient.Visible = false;
        }


        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            panelReport.Visible = false;
        }


        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
        }

        private void panelDonor_MouseEnter(object sender, EventArgs e)
        {
            panelDonor.Visible = true;
        }

        private void panelDonor_MouseLeave(object sender, EventArgs e)
        {
            panelDonor.Visible = false;
        }

        private void panelPatient_MouseEnter(object sender, EventArgs e)
        {
            panelPatient.Visible = true;
        }

        private void panelPatient_MouseLeave(object sender, EventArgs e)
        {
            panelPatient.Visible = false;
        }

        private void panelReport_MouseEnter(object sender, EventArgs e)
        {
            panelReport.Visible = true;
        }

        private void panelReport_MouseLeave(object sender, EventArgs e)
        {
            panelReport.Visible = false;
        }

        private void panelSettings_MouseEnter(object sender, EventArgs e)
        {
            panelSettings.Visible = true;
        }

        private void panelSettings_MouseLeave(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
        }

        private void btnDonor_MouseEnter(object sender, EventArgs e)
        {
            panelDonor.Visible = true;
       
        }

        private void btnPatient_MouseEnter(object sender, EventArgs e)
        {
            panelPatient.Visible = true;
        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            panelReport.Visible = true;
        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            panelSettings.Visible = true;
        }



    

        private void movepanel(Control btn)
            {
                 //panelslide.Width = btn.Width;
                 //panelslide.Left = btn.Left;
            }

    */

        private void dimgray(Button b)
        {
            btnHome.ForeColor = Color.Black;
            btnDonor.ForeColor = Color.Black;
            btnPatient.ForeColor = Color.Black;
            btnBloodDonetion.ForeColor = Color.Black;
            btnBloodTransfar.ForeColor = Color.Black;
            btnBloodStock.ForeColor = Color.Black;
            btnReport.ForeColor = Color.Black;
            btnSettings.ForeColor = Color.Black;
            btnBloodType.ForeColor = Color.Black;
            btnStaff.ForeColor = Color.Black;
            btnDoctor.ForeColor = Color.Black;
            btnHospital.ForeColor = Color.Black;
            btnAboutUs.ForeColor = Color.Black;

            btnDonorRegistration.ForeColor = Color.Black;
            btnViewAllDonor.ForeColor = Color.Black;
            btnEditDonor.ForeColor = Color.Black;

            btnPatientRegistration.ForeColor = Color.Black;
            btnViewAllpatient.ForeColor = Color.Black;
            btnEditpatient.ForeColor = Color.Black;

            btnDonorReport.ForeColor = Color.Black;
            btnPatientReport.ForeColor = Color.Black;

            btnProfile.ForeColor = Color.Black;
            btnUser.ForeColor = Color.Black;
            btnLogout.ForeColor = Color.Black;


            b.ForeColor = Color.White;
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.FlatAppearance.BorderSize = 2;

            dimgray(btnHome);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnHome);

        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);
           
        }

        private void btnDonor_MouseEnter(object sender, EventArgs e)
        {
            btnDonor.FlatAppearance.BorderSize = 2;

            dimgray(btnDonor);
            panelDonor.Visible = true;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnDonor);



        }

        private void btnDonor_MouseLeave(object sender, EventArgs e)
        {
            btnDonor.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);


        }

        private void btnPatient_MouseEnter(object sender, EventArgs e)
        {
            btnPatient.FlatAppearance.BorderSize = 2;

            dimgray(btnPatient);
            panelPatient.Visible = true;
            panelDonor.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnPatient);


        }

        private void btnPatient_MouseLeave(object sender, EventArgs e)
        {
            btnPatient.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);


        }

        private void btnBloodDonor_MouseEnter(object sender, EventArgs e)
        {
            btnBloodDonetion.FlatAppearance.BorderSize = 2;

            dimgray(btnBloodDonetion);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnBloodDonetion);




        }

        private void btnBloodDonor_MouseLeave(object sender, EventArgs e)
        {
            btnBloodDonetion.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);


        }

        private void btnBloodTransfar_MouseEnter(object sender, EventArgs e)
        {
            btnBloodTransfar.FlatAppearance.BorderSize = 2;

            dimgray(btnBloodTransfar);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnBloodTransfar);




        }

        private void btnBloodTransfar_MouseLeave(object sender, EventArgs e)
        {
            btnBloodTransfar.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);



        }

        private void BtnBloodStock_MouseEnter(object sender, EventArgs e)
        {
            btnBloodStock.FlatAppearance.BorderSize = 2;

            dimgray(btnBloodStock);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnBloodStock);





        }

        private void BtnBloodStock_MouseLeave(object sender, EventArgs e)
        {
            btnBloodStock.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);


        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            btnReport.FlatAppearance.BorderSize = 2;

            dimgray(btnReport);
            panelReport.Visible = true;
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnReport);



        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            btnReport.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);


        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.FlatAppearance.BorderSize = 2;

            dimgray(btnSettings);
            panelSettings.Visible = true;
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            movepanel(btnSettings);



        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);



        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderSize = 2;

            dimgray(btnLogout);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnLogout);



        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderSize = 0;

            dimgray(btnHomeExtra);


        }

        private void panelDonor_MouseLeave(object sender, EventArgs e)
        {
            panelDonor.Visible = false;
        }


        private void panelPatient_MouseLeave(object sender, EventArgs e)
        {
            panelPatient.Visible = false;
        }

        private void panelReport_MouseLeave(object sender, EventArgs e)
        {
            panelReport.Visible = false;

        }

        private void panelSettings_MouseLeave(object sender, EventArgs e)
        {
            panelSettings.Visible = false;

        }

        private void movepanel(Control btn)
        {
            panelslide.Width = btn.Width;
            panelslide.Left = btn.Left;
        }

        public int imgnumber = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            labtime.Text = "Time : " + DateTime.Now.ToString("hh : mm : ss - tt");
            lbltime2.Text = "Date : " + DateTime.Now.ToString("dd -- MMMM -- yyyy") + " ,";
            lbltime3.Text = "Day : " +  DateTime.Now.DayOfWeek.ToString();


            //    string title = this.Text;
            //r:    // goto statment lable 

            //    for (int i = 0; i <= 273; i++)
            //    {
            //        this.Text = title.PadLeft(i);
            //        Thread.Sleep(40);
            //    }

            //    for (int j = 273; j >= 1; j--)
            //    {
            //        this.Text = title.PadLeft(j);
            //        Thread.Sleep(40);
            //    }
            //    goto r;


        }



        private void MasterPage_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
         
     


        }



        private void btnLogout_Click(object sender, EventArgs e)
        {

       
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            h.MdiParent = this;
            h.ShowIcon = false;
            h.Show();
        }

        private void panelslide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDonorRegistration_Click(object sender, EventArgs e)
        {
            DonorRegistrationPage d = new DonorRegistrationPage();
            d.MdiParent = this;
            d.ShowIcon = false;
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure ! You Want to Logout The Application !!", "Logout Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                this.Close();
                LoginPage l = new LoginPage();
                l.Show();
            }
            else if (dr == DialogResult.Cancel)
            {
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void btnBloodType_MouseEnter(object sender, EventArgs e)
        {
            btnBloodType.FlatAppearance.BorderSize = 2;

            dimgray(btnBloodType);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnBloodType);
        }

        private void btnBloodType_MouseLeave(object sender, EventArgs e)
        {
            btnBloodType.FlatAppearance.BorderSize = 0;

            dimgray(btnBloodType);

        }

        private void btnStaff_MouseEnter(object sender, EventArgs e)
        {
            btnStaff.FlatAppearance.BorderSize = 2;

            dimgray(btnStaff);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnStaff);


        }

        private void btnStaff_MouseLeave(object sender, EventArgs e)
        {
            btnStaff.FlatAppearance.BorderSize = 0;

            dimgray(btnStaff);

        }

        private void btnDoctor_MouseEnter(object sender, EventArgs e)
        {
            btnDoctor.FlatAppearance.BorderSize = 2;

            dimgray(btnDoctor);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnDoctor);


        }

        private void btnDoctor_MouseLeave(object sender, EventArgs e)
        {
            btnDoctor.FlatAppearance.BorderSize = 0;

            dimgray(btnDoctor);
        }

        private void btnHospital_MouseEnter(object sender, EventArgs e)
        {
            btnHospital.FlatAppearance.BorderSize = 2;

            dimgray(btnHospital);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnHospital);


        }

        private void btnHospital_MouseLeave(object sender, EventArgs e)
        {
            btnHospital.FlatAppearance.BorderSize = 0;

            dimgray(btnHospital);
        }

        private void btnAboutUs_MouseEnter(object sender, EventArgs e)
        {
            btnAboutUs.FlatAppearance.BorderSize = 2;

            dimgray(btnAboutUs);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnAboutUs);



        }

        private void btnAboutUs_MouseLeave(object sender, EventArgs e)
        {
            btnAboutUs.FlatAppearance.BorderSize = 0;

            dimgray(btnAboutUs);

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs a = new AboutUs();
            a.MdiParent = this;
            a.Show();
        }

        private void btnViewAllDonor_Click(object sender, EventArgs e)
        {
            ViewAllDonorsPage page = new ViewAllDonorsPage();
            page.MdiParent = this;
            page.Show();
        }

        private void btnEditDonor_Click(object sender, EventArgs e)
        {
            EditDonorPage editpage = new EditDonorPage();
            editpage.MdiParent = this;
            editpage.Show();
        }

        private void panelDonor_Leave(object sender, EventArgs e)
        {
            panelDonor.Visible = false;
        }

        private void panelPatient_Leave(object sender, EventArgs e)
        {
            panelPatient.Visible = false;
        }

        private void panelReport_Leave(object sender, EventArgs e)
        {
            panelReport.Visible = false;
        }

        private void panelSettings_Leave(object sender, EventArgs e)
        {
            panelSettings.Visible = false;
        }

        private void btnPatientRegistration_Click(object sender, EventArgs e)
        {
            PatientRegistration patientpage = new PatientRegistration();
            patientpage.MdiParent = this;
            patientpage.Show();
        }

        private void btnViewAllpatient_Click(object sender, EventArgs e)
        {
            ViewAllPatientPage PatientPage = new ViewAllPatientPage();
            PatientPage.MdiParent = this;
            PatientPage.Show();
        }

        private void btnEditpatient_Click(object sender, EventArgs e)
        {
            EditPatientPage page = new EditPatientPage();
            page.MdiParent = this;
            page.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

