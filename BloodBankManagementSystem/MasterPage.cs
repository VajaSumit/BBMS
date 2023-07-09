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

        HomePage homepage;
        DonorRegistrationPage donorregistration;
        ViewAllDonorsPage viewalldonor;
        EditDonorPage editdonor;
        PatientRegistration patientregistration;
        ViewAllPatientPage viewallpatient;
        EditPatientPage editpatient;
        AboutUs aboutus;
        UserRecordPage userrecord;
        ViewAllUser viewalluser;

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

    

        private void customizeDailog()
        {
            panelDonorMenu.Visible = false;
            panelPatientMenu.Visible = false;
            panelUserMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDonorMenu.Visible==true)
            {
                panelDonorMenu.Visible = false;
            }
            if (panelPatientMenu.Visible==true)
            {
                panelPatientMenu.Visible = false;
            }
            if (panelUserMenu.Visible==true)
            {
                panelUserMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnHomeMenu_Click(object sender, EventArgs e)
        {
            Movepanel(btnHomeMenu);

            hideSubMenu();
            //HomePage h = new HomePage();
            //h.MdiParent = this;
            //h.Show();

            if (homepage == null)
            {
                homepage = new HomePage();
                homepage.FormClosed += Homepage_FormClosed;
                homepage.MdiParent = this;
                homepage.Show();
            }
            else
            {
                homepage.Activate();
            }


        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            homepage = null;
        }

        private void btnDonorMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDonorMenu);
            Movepanel(btnDonorMenu);
        }

        private void btnDonorsRegistration_Click(object sender, EventArgs e)
        {
            //openChildForm(new DonorRegistrationPage());
            //DonorRegistrationPage d = new DonorRegistrationPage();
            //d.MdiParent = this;
            //d.Show();
            hideSubMenu();


            if (donorregistration == null)
            {
                donorregistration = new DonorRegistrationPage();
                donorregistration.FormClosed += Donorregistration_FormClosed;
                donorregistration.MdiParent = this;
                donorregistration.Show();
            }
            else
            {
                donorregistration.Activate();
            }
        }

        private void Donorregistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            donorregistration = null;
        }

        private void btnEditDonors_Click(object sender, EventArgs e)
        {
            //EditDonorPage p = new EditDonorPage();
            //p.MdiParent = this;
            //p.Show();
            hideSubMenu();

            if (editdonor == null)
            {
                editdonor = new EditDonorPage();
                editdonor.FormClosed += Editdonor_FormClosed;
                editdonor.MdiParent = this;
                editdonor.Show();
            }
            else
            {
                editdonor.Activate();
            }
        }

        private void Editdonor_FormClosed(object sender, FormClosedEventArgs e)
        {
            editdonor = null;
        }

        private void btnViewAllDonors_Click(object sender, EventArgs e)
        {
            //openChildForm(new ViewAllDonorsPage());
            //ViewAllDonorsPage v = new ViewAllDonorsPage();
            //v.MdiParent = this;
            //v.Show();
            hideSubMenu();

            if (viewalldonor == null)
            {
                viewalldonor = new ViewAllDonorsPage();
                viewalldonor.FormClosed += Viewalldonor_FormClosed;
                viewalldonor.MdiParent = this;
                viewalldonor.Show();
            }
            else
            {
                viewalldonor.Activate();
            }

        }

        private void Viewalldonor_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewalldonor = null;
        }

        private void btnPatientMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelPatientMenu);
            Movepanel(btnPatientMenu);

        }

        private void btnPatientsRegistration_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            //PatientRegistration p = new PatientRegistration();
            //p.MdiParent = this;
            //p.Show();

            if (patientregistration == null)
            {
                patientregistration = new PatientRegistration();
                patientregistration.FormClosed += Patientregistration_FormClosed;
                patientregistration.MdiParent = this;
                patientregistration.Show();
            }
            else
            {
                patientregistration.Activate();
            }


        }

        private void Patientregistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            patientregistration = null;
        }

        private void btnEditPatients_Click(object sender, EventArgs e)
        {
            //EditPatientPage p = new EditPatientPage();
            //p.MdiParent = this;
            //p.Show();
            hideSubMenu();

            if (editpatient == null)
            {
                editpatient = new EditPatientPage();
                editpatient.FormClosed += Editpatient_FormClosed;
                editpatient.MdiParent = this;
                editpatient.Show();
            }
            else
            {
                editpatient.Activate();
            }

        }

        private void Editpatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            editpatient = null;
        }

        private void btnViewAllPatients_Click(object sender, EventArgs e)
        {
            //ViewAllPatientPage p = new ViewAllPatientPage();
            //p.MdiParent = this;
            //p.Show();
            hideSubMenu();

            if (viewallpatient == null)
            {
                viewallpatient = new ViewAllPatientPage();
                viewallpatient.FormClosed += Viewallpatient_FormClosed;
                viewallpatient.MdiParent = this;
                viewallpatient.Show();
            }
            else
            {
                viewallpatient.Activate();
            }

        }

        private void Viewallpatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallpatient = null;
        }

        private void btnUserMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUserMenu);
            Movepanel(btnUserMenu);
        }

        private void btnAddUserMenu_Click(object sender, EventArgs e)
        {
            //UserRecordPage p = new UserRecordPage();
            //p.MdiParent = this;
            //p.Show();
            hideSubMenu();

            if (userrecord == null)
            {
                userrecord = new UserRecordPage();
                userrecord.FormClosed += Userrecord_FormClosed;
                userrecord.MdiParent = this;
                userrecord.Show();
            }
            else
            {
                userrecord.Activate();
            }
        }

        private void Userrecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            userrecord = null;
        }

        private void btnViewAllUserMenu_Click(object sender, EventArgs e)
        {
            //ViewAllUser v = new ViewAllUser();
            //v.MdiParent = this;
            //v.Show();
            hideSubMenu();

            if (viewalluser == null)
            {
                viewalluser = new ViewAllUser();
                viewalluser.FormClosed += Viewalluser_FormClosed;
                viewalluser.MdiParent = this;
                viewalluser.Show();
            }
            else
            {
                viewalluser.Activate();
            }
        }

        private void Viewalluser_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewalluser = null;
        }

        private void btnBloodDonationMenu_Click(object sender, EventArgs e)
        {

            hideSubMenu();
            Movepanel(btnBloodDonationMenu);


        }

        private void btnBloodTransferMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodTransferMenu);


        }

        private void btnBloodStockMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodStockMenu);


        }

        private void btnBloodTypeMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodTypeMenu);


        }

        private void btnStaffMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnStaffMenu);


        }

        private void btnDoctorMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnDoctorMenu);


        }

        private void btnHospitalMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnHospitalMenu);


        }

        private void btnReportsMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnReportsMenu);


        }

        private void btnAboutusMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnAboutusMenu);

            if (aboutus == null)
            {
                aboutus = new AboutUs();
                aboutus.FormClosed += Aboutus_FormClosed;
                aboutus.MdiParent = this;
                aboutus.Show();
            }
            else
            {
                aboutus.Activate();
            }


        }

        private void Aboutus_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutus = null;
        }

        private void Movepanel(Control btn)
        {
            //panelslide.Width = btn.Width;
            //panelslide.Left = btn.Left;
            panelMove.Height = btn.Height;
            panelMove.Top = btn.Top;
            panelMove.Left = btn.Left;
          
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeMenu_Leave(object sender, EventArgs e)
        {
            //btnHomeMenu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnDonorMenu_Leave(object sender, EventArgs e)
        {
            //btnDonorMenu.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labtime.Text = "Time  :-   " + DateTime.Now.ToString("hh : mm : ss - tt");
            lbltime2.Text = "Date  :-   " + DateTime.Now.ToString("dd -- MMMM -- yyyy") + " ,";
            lbltime3.Text = "Day  :-   " + DateTime.Now.DayOfWeek.ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dr=MessageBox.Show("Are You Sure ! You Wan't To Logout ","Logout Information !",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (dr==DialogResult.OK)
            {
                this.Close();
            }
            else if (dr==DialogResult.Cancel)
            {
                
            }
            else
            {
                
            }
        }

        private void btnHomeMenu_MouseHover(object sender, EventArgs e)
        {
            Movepanel(btnHomeMenu);
        }

        private void btnDonorMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnDonorMenu);

        }

        private void btnHomeMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnHomeMenu);

        }

        private void btnBloodDonationMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnBloodDonationMenu);

        }

        private void btnPatientMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnPatientMenu);

        }

        private void btnBloodTransferMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnBloodTransferMenu);

        }

        private void btnBloodStockMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnBloodStockMenu);

        }

        private void btnBloodTypeMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnBloodTypeMenu);

        }

        private void btnStaffMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnStaffMenu);

        }

        private void btnDoctorMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnDoctorMenu);

        }

        private void btnHospitalMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnHospitalMenu);

        }

        private void btnReportsMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnReportsMenu);

        }

        private void btnUserMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnUserMenu);

        }

        private void btnAboutusMenu_MouseEnter(object sender, EventArgs e)
        {
            Movepanel(btnAboutusMenu);

        }

        private void MasterPage_Load(object sender, EventArgs e)
        {

        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelMenu.Height += 15;
                if (panelMenu.Height>=225)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelMenu.Height -= 15;
                if (panelMenu.Height <= 70)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            silderTransition.Start();
        }

        bool sidebarExpand = true;

        private void silderTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelSliderMenu.Width -= 5;
                if (panelSliderMenu.Width <= 73)
                {
                    sidebarExpand = false;
                    silderTransition.Stop();

                    btnHomeMenu.Width = panelSliderMenu.Width;
                    btnDonorMenu.Width = panelSliderMenu.Width;
                    btnBloodDonationMenu.Width = panelSliderMenu.Width;
                    btnPatientMenu.Width = panelSliderMenu.Width;
                    btnBloodTransferMenu.Width = panelSliderMenu.Width;
                    btnBloodStockMenu.Width = panelSliderMenu.Width;
                    btnStaffMenu.Width = panelSliderMenu.Width;
                    btnDonorMenu.Width = panelSliderMenu.Width;
                    btnHospitalMenu.Width = panelSliderMenu.Width;
                    btnReportsMenu.Width = panelSliderMenu.Width;
                    btnAboutusMenu.Width = panelSliderMenu.Width;
                    btnUserMenu.Width = panelSliderMenu.Width;
                }
            }
            else
            {
                panelSliderMenu.Width += 5;
                if (panelSliderMenu.Width >= 225)
                {
                    sidebarExpand = true;
                    silderTransition.Stop();

                    btnHomeMenu.Width = panelSliderMenu.Width;
                    btnDonorMenu.Width = panelSliderMenu.Width;
                    btnBloodDonationMenu.Width = panelSliderMenu.Width;
                    btnPatientMenu.Width = panelSliderMenu.Width;
                    btnBloodTransferMenu.Width = panelSliderMenu.Width;
                    btnBloodStockMenu.Width = panelSliderMenu.Width;
                    btnStaffMenu.Width = panelSliderMenu.Width;
                    btnDonorMenu.Width = panelSliderMenu.Width;
                    btnHospitalMenu.Width = panelSliderMenu.Width;
                    btnReportsMenu.Width = panelSliderMenu.Width;
                    btnAboutusMenu.Width = panelSliderMenu.Width;
                    btnUserMenu.Width = panelSliderMenu.Width;


                }
            }
        }

        private void btnAboutusMenu_MouseHover(object sender, EventArgs e)
        {
            Movepanel(btnAboutusMenu);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            silderTransition.Start();
        }

        //private Form activeForm = null;
        //private void openChildForm(Form childform)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //        activeForm = childform;
        //        childform.TopLevel = false;
        //        childform.FormBorderStyle = FormBorderStyle.None;
        //        childform.Dock = DockStyle.Fill;
        //        //panelChildForm.Tag = childform;
        //        this.Tag = childform;
        //        childform.BringToFront();
        //        childform.Show();
        //    }
        //}
    }
}

