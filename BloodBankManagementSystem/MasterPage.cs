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

        BloodStockPage bloodstock;

        BloodDiscardPage blooddiscardpage;

        BloodTransferPage bloodtransfer;
         
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
            if (panelStaffMenu.Visible == true)
            {
                panelStaffMenu.Visible = false;
            }
            if (panelUserMenu.Visible==true)
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

        //Form1 form1;
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


            //if (form1 == null)
            //{
            //    form1 = new Form1();
            //    form1.FormClosed += Form1_FormClosed;
            //    form1.MdiParent = this;
            //    form1.Show();
            //}
            //else
            //{
            //    form1.Activate();
            //}

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //form1 = null;
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

            if (blooddonationpage == null)
            {
                blooddonationpage = new BloodDonationPage();
                blooddonationpage.FormClosed += Blooddonationpage_FormClosed;
                blooddonationpage.MdiParent = this;
                blooddonationpage.Show();
            }
            else
            {
                blooddonationpage.Activate();
            }



        }

        private void Blooddonationpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            blooddonationpage = null;
        }

        private void btnBloodTransferMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodTransferMenu);

            if (bloodtransfer == null)
            {
                bloodtransfer = new BloodTransferPage();
                bloodtransfer.FormClosed += Bloodtransfer_FormClosed;
                bloodtransfer.MdiParent = this;
                bloodtransfer.Show();
            }
            else
            {
                bloodtransfer.Activate();
            }


        }

        private void Bloodtransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            bloodtransfer = null;
        }

        private void btnBloodStockMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodStockMenu);
            if (bloodstock == null)
            {
                bloodstock = new BloodStockPage();
                bloodstock.FormClosed += Bloodstock_FormClosed;
                bloodstock.MdiParent = this;
                bloodstock.Show();
            }
            else
            {
                bloodstock.Activate();
            }


        }

        private void btnBloodTypeMenu_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnBloodDiscardMenu);
            if (blooddiscardpage == null)
            {
                blooddiscardpage = new BloodDiscardPage();
                blooddiscardpage.FormClosed += Blooddiscardpage_FormClosed;
                blooddiscardpage.MdiParent = this;
                blooddiscardpage.Show();
            }
            else
            {
                blooddiscardpage.Activate();
            }




        }

        private void Blooddiscardpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            blooddiscardpage = null;
        }

        private void Bloodstock_FormClosed(object sender, FormClosedEventArgs e)
        {
            bloodstock = null;
        }

        private void btnStaffMenu_Click(object sender, EventArgs e)
        {
            Movepanel(btnStaffMenu);
            showSubMenu(panelStaffMenu);

        }

        private void btnDoctorMenu_Click(object sender, EventArgs e)
        {
            Movepanel(btnDoctorMenu);
            showSubMenu(panelDoctorMenu);


        }

 
        private void btnAboutusMenu_Click(object sender, EventArgs e)
        {
            Movepanel(btnAboutusMenu);
            hideSubMenu();

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            labtime.Text  ="Time  :-   "+DateTime.Now.ToString("hh : mm : ss - tt");
            //lbltime2.Text ="Date  :-   "+DateTime.Now.ToString("dd -- MMMM -- yyyy") + " ,";
            //lbltime3.Text = "Day   :-   " + DateTime.Now.DayOfWeek.ToString();

        }

   


        private void MasterPage_Load(object sender, EventArgs e)
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

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelMenu.Height += 15;
                if (panelMenu.Height>=195)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelMenu.Height -= 15;
                if (panelMenu.Height <= 73)
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
                panelSliderMenu.Width += 5;
                if (panelSliderMenu.Width >= 195)
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

     
        private void btnAddStaffMenu_Click(object sender, EventArgs e)
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

        private void Doctorrecordpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            doctorrecordpage = null;
        }

        private void Staffpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            staffpage = null;
        }

        private void btnViewAllStaffMenu_Click(object sender, EventArgs e)
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

        private void btnAddDoctorMenu_Click(object sender, EventArgs e)
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

        private void btnHospitalMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelHospitalMenu);
            Movepanel(btnHospitalMenu);
        }

        private void btnReportsMenu_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            Movepanel(btnReportsMenu);

        }

        private void btnViewAllDoctor_Click(object sender, EventArgs e)
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

        private void btnHospitalRegistration_Click(object sender, EventArgs e)
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

        private void btnViewAllHospital_Click(object sender, EventArgs e)
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

        private void btnPatientMenu_MouseEnter(object sender, EventArgs e)
        {
            btnPatientMenu.ForeColor = Color.White;
            Movepanel(btnPatientMenu);
        }

        private void btnPatientMenu_MouseLeave(object sender, EventArgs e)
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

        private void btnBloodTypeMenu_MouseEnter(object sender, EventArgs e)
        {
            btnBloodDiscardMenu.ForeColor = Color.White;
            Movepanel(btnBloodDiscardMenu);
        }

        private void btnBloodTypeMenu_MouseLeave(object sender, EventArgs e)
        {
            btnBloodDiscardMenu.ForeColor = Color.DimGray;
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

        private void btnDoctorMenu_MouseEnter(object sender, EventArgs e)
        {
            btnDoctorMenu.ForeColor = Color.White;
            Movepanel(btnDoctorMenu);
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

        private void btnReportsMenu_MouseEnter(object sender, EventArgs e)
        {
            btnReportsMenu.ForeColor = Color.White;
            Movepanel(btnReportsMenu);
        }

        private void btnReportsMenu_MouseLeave(object sender, EventArgs e)
        {
            btnReportsMenu.ForeColor = Color.DimGray;
        }

        private void btnAboutusMenu_MouseEnter(object sender, EventArgs e)
        {
            btnAboutusMenu.ForeColor = Color.White;
            Movepanel(btnAboutusMenu);
        }

        private void btnAboutusMenu_MouseLeave(object sender, EventArgs e)
        {
            btnAboutusMenu.ForeColor = Color.DimGray;
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

        private void btnDoctorMenu_MouseLeave(object sender, EventArgs e)
        {
            btnDoctorMenu.ForeColor = Color.DimGray;
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

