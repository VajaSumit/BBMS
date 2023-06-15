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
            btnHome.ForeColor = Color.DimGray;
            btnDonor.ForeColor = Color.DimGray;
            btnPatient.ForeColor = Color.DimGray;
            btnBloodDonor.ForeColor = Color.DimGray;
            btnBloodTransfar.ForeColor = Color.DimGray;
            BtnBloodStock.ForeColor = Color.DimGray;
            btnReport.ForeColor = Color.DimGray;
            btnSettings.ForeColor = Color.DimGray;
            btnLogout.ForeColor = Color.DimGray;

            btnDonorRegistration.ForeColor = Color.DimGray;
            btnViewAllDonor.ForeColor = Color.DimGray;
            btnEditDonor.ForeColor = Color.DimGray;

            btnPatientRegistration.ForeColor = Color.DimGray;
            btnViewAllpatient.ForeColor = Color.DimGray;
            btnEditpatient.ForeColor = Color.DimGray;

            btnDonorReport.ForeColor = Color.DimGray;
            btnpatientReport.ForeColor = Color.DimGray;

            btnSettingUser.ForeColor = Color.DimGray;
            btnAttendance.ForeColor = Color.DimGray;
            btnEmployee.ForeColor = Color.DimGray;

            b.ForeColor = Color.White;
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnHome);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnHome);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);
        }

        private void btnDonor_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnDonor);
            panelDonor.Visible = true;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnDonor);


        }

        private void btnDonor_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);


        }

        private void btnPatient_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnPatient);
            panelPatient.Visible = true;
            panelDonor.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnPatient);


        }

        private void btnPatient_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);


        }

        private void btnBloodDonor_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnBloodDonor);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnBloodDonor);




        }

        private void btnBloodDonor_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);

        }

        private void btnBloodTransfar_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnBloodTransfar);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnBloodTransfar);



        }

        private void btnBloodTransfar_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);

        }

        private void BtnBloodStock_MouseEnter(object sender, EventArgs e)
        {
            dimgray(BtnBloodStock);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(BtnBloodStock);



        }

        private void BtnBloodStock_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);

        }

        private void btnReport_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnReport);
            panelReport.Visible = true;
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnReport);


        }

        private void btnReport_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);

        }

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnSettings);
            panelSettings.Visible = true;
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            movepanel(btnSettings);


        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            dimgray(btnHomeExtra);


        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            dimgray(btnLogout);
            panelDonor.Visible = false;
            panelPatient.Visible = false;
            panelReport.Visible = false;
            panelSettings.Visible = false;
            movepanel(btnLogout);


        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
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
            labtime.Text = DateTime.Now.ToString("hh : mm : ss - tt");

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

            timer1.Enabled = true;
            timer1.Start();
     


        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage l = new LoginPage();
            l.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage h = new HomePage();
            h.MdiParent = this;
            h.Show();
        }








    }
}

