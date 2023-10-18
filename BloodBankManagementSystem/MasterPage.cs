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

        StaffPage staffpage;
        ViewAllStaffRecords viewallstaffrecords;

        DoctorRecordPage doctorrecordpage;
        ViewAllDoctorsRecordcs viewalldoctor;

        UserRecordPage userrecord;
        ViewAllUser viewalluser;

        AboutUs aboutus;

        HospitalRegistrationPage hospitalregistrationpage;
        ViewAllHospitals viewallhospitals;

        BloodDonationPage blooddonationpage;
        ViewAllBloodDonation viewallblooddonation;

        BloodStockPage bloodstock;

        BloodDiscardPage blooddiscardpage;

        BloodTransferPage bloodtransfer;
        ViewAllBloodTransferRecords viewallbloodtransfer;

        SettingPage settingpage;

        ReportForBloodDonationPage reportforblooddonation;
        ReportForBloodTransferPage reportforbloodtransfer;
        ReportForDoctorPage reportfordoctor;


        public MasterPage()
        {
            InitializeComponent();
        }

     

        private void customizeDailog()
        {
            panelDonorMenu.Visible = false;
            panelPatientMenu.Visible = false;
            panelUserMenu.Visible = false;
            panelStaffMenu.Visible = false;
            panelDoctorMenu.Visible = false;
            panelHospitalMenu.Visible = false;
            panelBloodDonationMenu.Visible = false;
            panelBloodTransferMenu.Visible = false;
            panelReportMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDonorMenu.Visible == true)
            {
                panelDonorMenu.Visible = false;
            }
            if (panelPatientMenu.Visible == true)
            {
                panelPatientMenu.Visible = false;
            }
            if (panelStaffMenu.Visible == true)
            {
                panelStaffMenu.Visible = false;
            }
            if (panelUserMenu.Visible == true)
            {
                panelUserMenu.Visible = false;
            }
            if (panelDoctorMenu.Visible == true)
            {
                panelDoctorMenu.Visible = false;
            }
            if (panelHospitalMenu.Visible == true)
            {
                panelHospitalMenu.Visible = false;
            }
            if (panelBloodDonationMenu.Visible == true)
            {
                panelBloodDonationMenu.Visible = false;
            }
            if (panelBloodTransferMenu.Visible == true)
            {
                panelBloodTransferMenu.Visible = false;
            }
            if (panelReportMenu.Visible == true)
            {
                panelReportMenu.Visible = false;
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


        private void btnBloodDonationMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBloodDonationMenu);
            Movepanel(btnBloodDonationMenu);
        }




        private void Movepanel(Control btn)
        {
            //panelslide.Width = btn.Width;
            //panelslide.Left = btn.Left;
            panelMove.Height = btn.Height;
            panelMove.Top = btn.Top;
            panelMove.Left = btn.Left;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labtime.Text  ="Time  :-   "+DateTime.Now.ToString("hh : mm : ss - tt");
            //lbltime2.Text ="Date  :-   "+DateTime.Now.ToString("dd -- MMMM -- yyyy") + " ,";
            //lbltime3.Text = "Day   :-   " + DateTime.Now.DayOfWeek.ToString();

        }

   


        private void MasterPage_Load(object sender, EventArgs e)
        {

            LoginPage l = new LoginPage();
            lblProfilename.Text = LoginPage.username;
            lblProfilename2.Text = LoginPage.userrole;
            userPictureBox.Image = LoginPage.userImage;

            lblProfilename3.Text = LoginPage.username;
            lblProfilename4.Text = LoginPage.userrole;
            userPictureBox2.Image = LoginPage.userImage;


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

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelMenu.Height += 12;
                if (panelMenu.Height>=180)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelMenu.Height -= 12;
                if (panelMenu.Height <= 50)
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
                panelSliderMenu.Width -= 12;
                if (panelSliderMenu.Width <= 50)
                {
                    sidebarExpand = false;
                    silderTransition.Stop();

                    //btnHomeMenu.Width = panelSliderMenu.Width;
                    //btnDonorMenu.Width = panelSliderMenu.Width;
                    //btnBloodDonationMenu.Width = panelSliderMenu.Width;
                    //btnPatientMenu.Width = panelSliderMenu.Width;
                    //btnBloodTransferMenu.Width = panelSliderMenu.Width;
                    //btnBloodStockMenu.Width = panelSliderMenu.Width;
                    //btnStaffMenu.Width = panelSliderMenu.Width;
                    //btnDonorMenu.Width = panelSliderMenu.Width;
                    //btnHospitalMenu.Width = panelSliderMenu.Width;
                    //btnReportsMenu.Width = panelSliderMenu.Width;
                    //btnAboutusMenu.Width = panelSliderMenu.Width;
                    //btnUserMenu.Width = panelSliderMenu.Width;
                }
            }
            else
            {
                panelSliderMenu.Width += 12;
                if (panelSliderMenu.Width >= 180)
                {
                    sidebarExpand = true;
                    silderTransition.Stop();

                    //btnHomeMenu.Width = panelSliderMenu.Width;
                    //btnDonorMenu.Width = panelSliderMenu.Width;
                    //btnBloodDonationMenu.Width = panelSliderMenu.Width;
                    //btnPatientMenu.Width = panelSliderMenu.Width;
                    //btnBloodTransferMenu.Width = panelSliderMenu.Width;
                    //btnBloodStockMenu.Width = panelSliderMenu.Width;
                    //btnStaffMenu.Width = panelSliderMenu.Width;
                    //btnDonorMenu.Width = panelSliderMenu.Width;
                    //btnHospitalMenu.Width = panelSliderMenu.Width;
                    //btnReportsMenu.Width = panelSliderMenu.Width;
                    //btnAboutusMenu.Width = panelSliderMenu.Width;
                    //btnUserMenu.Width = panelSliderMenu.Width;


                }
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            silderTransition.Start();
        }

     
  
        private void Doctorrecordpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            doctorrecordpage = null;
        }

        private void Staffpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            staffpage = null;
        }


    
        private void btnDateTime_Click(object sender, EventArgs e)
        {
            if (btnDateTime.Checked==true)
            {
                panelDataTime.Visible = true;
            }
            else if (btnDateTime.Checked==false)
            {
                panelDataTime.Visible = false;
            }
            else
            {
                panelDataTime.Visible = false;
            }


     
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            //DialogResult dr = MessageBox.Show("Are You Sure ! You Wan't To Logout ", "Logout Information !", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            DialogResult dr = LogoutDialogBox.Show();
            if (dr == DialogResult.Yes)
            {
                this.Close();
                LoginPage l = new LoginPage();
                l.Show();
            }
     
        }

        private void btnHomeMenu_MouseEnter(object sender, EventArgs e)
        {
            btnHomeMenu.ForeColor = Color.White;
            Movepanel(btnHomeMenu);
        }

        private void btnHomeMenu_MouseLeave(object sender, EventArgs e)
        {
            btnHomeMenu.ForeColor = Color.DimGray;
        }

        private void btnDonorMenu_MouseEnter(object sender, EventArgs e)
        {
            btnDonorMenu.ForeColor = Color.White;
            Movepanel(btnDonorMenu);   
        }

        private void btnDonorMenu_MouseLeave(object sender, EventArgs e)
        {
            btnDonorMenu.ForeColor = Color.DimGray;
        }

        private void btnBloodDonationMenu_MouseEnter(object sender, EventArgs e)
        {
            btnBloodDonationMenu.ForeColor = Color.White;
            Movepanel(btnBloodDonationMenu);
        }

        private void btnBloodDonationMenu_MouseLeave(object sender, EventArgs e)
        {
            btnBloodDonationMenu.ForeColor = Color.DimGray;
        }

     

        private void btnPatientMenu_Click(object sender, EventArgs e)
        {
            Movepanel(btnPatientMenu);
            showSubMenu(panelPatientMenu);
        }


    private void btnPatientsRegistration_Click_1(object sender, EventArgs e)
    {
            hideSubMenu();
           

            //PatientRegistration p = new PatientRegistration();
            //p.MdiParent = this;
            //p.Show();

            if (patientregistration == null)
            {
                patientregistration = new PatientRegistration();
                patientregistration.FormClosed += Patientregistration_FormClosed1;
                patientregistration.MdiParent = this;
                patientregistration.Show();
            }
            else
            {
                patientregistration.Activate();
            }
            
     }

        private void Patientregistration_FormClosed1(object sender, FormClosedEventArgs e)
        {
            patientregistration = null;
        }

        private void btnEditPatients_Click_1(object sender, EventArgs e)
        {
            //EditPatientPage p = new EditPatientPage();
            //p.MdiParent = this;
            //p.Show();
            hideSubMenu();

            if (editpatient == null)
            {
                editpatient = new EditPatientPage();
                editpatient.FormClosed += Editpatient_FormClosed1;
                editpatient.MdiParent = this;
                editpatient.Show();
            }
            else
            {
                editpatient.Activate();
            }

        }

        private void Editpatient_FormClosed1(object sender, FormClosedEventArgs e)
        {
            editpatient = null;
        }

        private void btnAddBloodTransfer_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            if (bloodtransfer == null)
            {
                bloodtransfer = new BloodTransferPage();
                bloodtransfer.FormClosed += Bloodtransfer_FormClosed1;
                bloodtransfer.MdiParent = this;
                bloodtransfer.Show();
            }
            else
            {
                bloodtransfer.Activate();
            }
        }

        private void Bloodtransfer_FormClosed1(object sender, FormClosedEventArgs e)
        {
            bloodtransfer = null;
        }

        private void btnBloodStockMenu_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodStockMenu);
            if (bloodstock == null)
            {
                bloodstock = new BloodStockPage();
                bloodstock.FormClosed += Bloodstock_FormClosed1;
                bloodstock.MdiParent = this;
                bloodstock.Show();

            }
            else
            {
                bloodstock.Activate();
            }
        }

        private void Bloodstock_FormClosed1(object sender, FormClosedEventArgs e)
        {
            bloodstock = null;
        }

        private void btnBloodDiscardMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodDiscardMenu);
            if (blooddiscardpage == null)
            {
                blooddiscardpage = new BloodDiscardPage();
                blooddiscardpage.FormClosed += Blooddiscardpage_FormClosed1;
                blooddiscardpage.MdiParent = this;
                blooddiscardpage.Show();
            }
            else
            {
                blooddiscardpage.Activate();
            }
        }

        private void Blooddiscardpage_FormClosed1(object sender, FormClosedEventArgs e)
        {
            blooddiscardpage = null;
        }

        private void btnAddBloodDonation_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        

            if (blooddonationpage == null)
            {
                blooddonationpage = new BloodDonationPage();
                blooddonationpage.FormClosed += Blooddonationpage_FormClosed2;
                blooddonationpage.MdiParent = this;
                blooddonationpage.Show();
            }
            else
            {
                blooddonationpage.Activate();
            }
        }

        private void Blooddonationpage_FormClosed2(object sender, FormClosedEventArgs e)
        {
            blooddonationpage = null;
        }

        private void btnViewAllBloodDonation_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            if (viewallblooddonation == null)
            {
                viewallblooddonation = new ViewAllBloodDonation();
                viewallblooddonation.FormClosed += Viewallblooddonation_FormClosed;
                viewallblooddonation.MdiParent = this;
                viewallblooddonation.Show();
            }
            else
            {
                viewallblooddonation.Activate();
            }
        }

        private void Viewallblooddonation_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallblooddonation = null;
        }

        private void btnBloodTransferMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelBloodTransferMenu);
            Movepanel(btnBloodTransferMenu);
        }

        private void btnViewAllBloodTransferRecords_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            if (viewallbloodtransfer == null)
            {
                viewallbloodtransfer = new ViewAllBloodTransferRecords();
                viewallbloodtransfer.FormClosed += Viewallbloodtransfer_FormClosed;
                viewallbloodtransfer.MdiParent = this;
                viewallbloodtransfer.Show();
            }
            else
            {
                viewallbloodtransfer.Activate();
            }
        }

        private void Viewallbloodtransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallbloodtransfer = null;
        }

        private void btnViewAllPatients_Click_1(object sender, EventArgs e)
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

        private void btnHospitalMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHospitalMenu);
            Movepanel(btnHospitalMenu);
        }

     

        private void btnHospitalRegistration_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();

            if (hospitalregistrationpage == null)
            {
                hospitalregistrationpage = new HospitalRegistrationPage();
                hospitalregistrationpage.FormClosed += Hospitalregistrationpage_FormClosed;
                hospitalregistrationpage.MdiParent = this;
                hospitalregistrationpage.Show();
            }
            else
            {
                hospitalregistrationpage.Activate();
            }

        }

        private void Hospitalregistrationpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            hospitalregistrationpage = null;
        }

        private void btnViewAllHospital_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();

            if (viewallhospitals == null)
            {
                viewallhospitals = new ViewAllHospitals();
                viewallhospitals.FormClosed += Viewallhospitals_FormClosed;
                viewallhospitals.MdiParent = this;
                viewallhospitals.Show();
            }
            else
            {
                viewallhospitals.Activate();
            }
        }

        private void Viewallhospitals_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallhospitals = null;
        }

        private void btnDoctorMenu_Click_1(object sender, EventArgs e)
        {
            Movepanel(btnDoctorMenu);
            showSubMenu(panelDoctorMenu);
        }

        private void btnAddDoctorMenu_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            if (doctorrecordpage == null)
            {
                doctorrecordpage = new DoctorRecordPage();
                doctorrecordpage.FormClosed += Doctorrecordpage_FormClosed1;
                doctorrecordpage.MdiParent = this;
                doctorrecordpage.Show();
            }
            else
            {
                doctorrecordpage.Activate();
            }
        }
        private void Doctorrecordpage_FormClosed1(object sender, FormClosedEventArgs e)
        {
            doctorrecordpage = null;
        }
        private void btnViewAllDoctor_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            if (viewalldoctor == null)
            {
                viewalldoctor = new ViewAllDoctorsRecordcs();
                viewalldoctor.FormClosed += Viewalldoctor_FormClosed;
                viewalldoctor.MdiParent = this;
                viewalldoctor.Show();
            }
            else
            {
                viewalldoctor.Activate();
            }
        }
        private void Viewalldoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewalldoctor = null;
        }

        private void btnStaffMenu_Click_1(object sender, EventArgs e)
        {
            Movepanel(btnStaffMenu);
            showSubMenu(panelStaffMenu);
        }

        private void btnAddStaffMenu_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            //staffpage p = new staffpage();
            //p.MdiParent = this;
            //p.Show();

            if (staffpage == null)
            {
                staffpage = new StaffPage();
                staffpage.FormClosed += Staffpage_FormClosed1;
                staffpage.MdiParent = this;
                staffpage.Show();
            }
            else
            {
                doctorrecordpage.Activate();
            }

        }
        private void Staffpage_FormClosed1(object sender, FormClosedEventArgs e)
        {
            staffpage = null;
        }

        private void btnViewAllStaffMenu_Click_1(object sender, EventArgs e)
        {
            //ViewAllStaffRecords v = new ViewAllStaffRecords();
            //v.MdiParent = this;
            //v.Show();

            hideSubMenu();
            if (viewallstaffrecords == null)
            {
                viewallstaffrecords = new ViewAllStaffRecords();
                viewallstaffrecords.FormClosed += Viewallstaffrecords_FormClosed;
                viewallstaffrecords.MdiParent = this;
                viewallstaffrecords.Show();
            }
            else
            {
                viewallstaffrecords.Activate();
            }
        }

        private void Viewallstaffrecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewallstaffrecords = null;
        }

        private void btnUserMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelUserMenu);
            Movepanel(btnUserMenu);
        }

        private void btnAddUserMenu_Click_1(object sender, EventArgs e)
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

        private void btnViewAllUserMenu_Click_1(object sender, EventArgs e)
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

        private void btnReportsMenu_Click(object sender, EventArgs e)
        {
            Movepanel(btnReportsMenu);
            showSubMenu(panelReportMenu);
        }

        private void btnAboutusMenu_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Aboutus_FormClosed(object sender, FormClosedEventArgs e)
        {
            aboutus = null;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            if (settingpage == null)
            {
                settingpage = new SettingPage();
                settingpage.FormClosed += Settingpage_FormClosed;
                settingpage.MdiParent = this;
                settingpage.Show();
            }
            else
            {
                settingpage.Activate();
            }
        }

        private void Settingpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingpage = null;
        }

        private void userPictureBox2_Click(object sender, EventArgs e)
        {
            if (settingpage == null)
            {
                settingpage = new SettingPage();
                settingpage.FormClosed += Settingpage_FormClosed;
                settingpage.MdiParent = this;
                settingpage.Show();
            }
            else
            {
                settingpage.Activate();
            }
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {
            if (settingpage == null)
            {
                settingpage = new SettingPage();
                settingpage.FormClosed += Settingpage_FormClosed;
                settingpage.MdiParent = this;
                settingpage.Show();
            }
            else
            {
                settingpage.Activate();
            }
        }

        private void btnAboutusMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReportForBloodDonation_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            if (reportforblooddonation == null)
            {
                reportforblooddonation = new ReportForBloodDonationPage();
                reportforblooddonation.FormClosed += Reportforblooddonation_FormClosed;
                reportforblooddonation.MdiParent = this;
                reportforblooddonation.Show();
            }
            else
            {
                reportforblooddonation.Activate();
            }
        }

        private void Reportforblooddonation_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportforblooddonation = null;
        }

        private void btnReportForBloodTransfer_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            if (reportforbloodtransfer == null)
            {
                reportforbloodtransfer = new ReportForBloodTransferPage();
                reportforbloodtransfer.FormClosed += Reportforbloodtransfer_FormClosed;
                reportforbloodtransfer.MdiParent = this;
                reportforbloodtransfer.Show();
            }
            else
            {
                reportforbloodtransfer.Activate();
            }
        }

        private void Reportforbloodtransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportforbloodtransfer = null;
        }

        private void btnReportForDoctors_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            if (reportfordoctor == null)
            {
                reportfordoctor = new ReportForDoctorPage();
                reportfordoctor.FormClosed += Reportfordoctor_FormClosed;
                reportfordoctor.MdiParent = this;
                reportfordoctor.Show();
            }
            else
            {
                reportfordoctor.Activate();
            }
        }

        private void Reportfordoctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportfordoctor = null;
        }

        private void btnPatientMenu_MouseEnter_1(object sender, EventArgs e)
        {
            btnPatientMenu.ForeColor = Color.White;
            Movepanel(btnPatientMenu);
        }

        private void btnPatientMenu_MouseLeave_1(object sender, EventArgs e)
        {
            btnPatientMenu.ForeColor = Color.DimGray;
        }

        private void btnBloodTransferMenu_MouseEnter(object sender, EventArgs e)
        {
            btnBloodTransferMenu.ForeColor = Color.White;
            Movepanel(btnBloodTransferMenu);
        }

        private void btnBloodTransferMenu_MouseLeave(object sender, EventArgs e)
        {
            btnBloodTransferMenu.ForeColor = Color.DimGray;

        }

        private void btnBloodStockMenu_MouseEnter(object sender, EventArgs e)
        {
            btnBloodStockMenu.ForeColor = Color.White;
            Movepanel(btnBloodStockMenu);
        }

        private void btnBloodStockMenu_MouseLeave(object sender, EventArgs e)
        {
            btnBloodStockMenu.ForeColor = Color.DimGray;
        }

        private void btnBloodDiscardMenu_MouseEnter(object sender, EventArgs e)
        {
            btnBloodDiscardMenu.ForeColor = Color.White;
            Movepanel(btnBloodDiscardMenu);
        }

        private void btnBloodDiscardMenu_MouseLeave(object sender, EventArgs e)
        {
            btnBloodDiscardMenu.ForeColor = Color.DimGray;

        }

        private void btnHospitalMenu_MouseEnter(object sender, EventArgs e)
        {
            btnHospitalMenu.ForeColor = Color.White;
            Movepanel(btnHospitalMenu);
        }

        private void btnHospitalMenu_MouseLeave(object sender, EventArgs e)
        {
            btnHospitalMenu.ForeColor = Color.DimGray;

        }

        private void btnDoctorMenu_MouseEnter(object sender, EventArgs e)
        {
            btnDoctorMenu.ForeColor = Color.White;
            Movepanel(btnDoctorMenu);
        }

        private void btnDoctorMenu_MouseLeave(object sender, EventArgs e)
        {
            btnDoctorMenu.ForeColor = Color.DimGray;

        }

        private void btnStaffMenu_MouseEnter(object sender, EventArgs e)
        {
            btnStaffMenu.ForeColor = Color.White;
            Movepanel(btnStaffMenu);
        }

        private void btnStaffMenu_MouseLeave(object sender, EventArgs e)
        {
            btnStaffMenu.ForeColor = Color.DimGray;
         
        }

        private void btnUserMenu_MouseEnter(object sender, EventArgs e)
        {
            btnUserMenu.ForeColor = Color.White;
            Movepanel(btnUserMenu);
        }

        private void btnUserMenu_MouseLeave(object sender, EventArgs e)
        {
            btnUserMenu.ForeColor = Color.DimGray;

        }

        private void btnReportsMenu_MouseEnter(object sender, EventArgs e)
        {
            btnReportsMenu.ForeColor = Color.White;
            Movepanel(btnReportsMenu);
        }

        private void btnReportsMenu_MouseLeave(object sender, EventArgs e)
        {
            btnReportsMenu.ForeColor = Color.DimGray;
        }

   

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            silderTransition.Start();
        }
    }
}









