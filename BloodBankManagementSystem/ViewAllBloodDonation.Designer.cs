﻿namespace BloodBankManagementSystem
{
    partial class ViewAllBloodDonation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllBloodDonation));
            this.BloodDonationList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalExam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pules = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InegularAntibodies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hemoglobin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label41 = new System.Windows.Forms.Label();
            this.btnViewAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label19 = new System.Windows.Forms.Label();
            this.BloodDonationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.MessageBoxForSearchData1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageBoxForSearchData2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BloodDonationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BloodDonationList
            // 
            this.BloodDonationList.AllowUserToAddRows = false;
            this.BloodDonationList.AllowUserToDeleteRows = false;
            this.BloodDonationList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BloodDonationList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BloodDonationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BloodDonationList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BDid,
            this.DName,
            this.Dob,
            this.Gender,
            this.RDate,
            this.Mobile,
            this.Email,
            this.City,
            this.Address,
            this.BloodGroup,
            this.BDDate,
            this.Height,
            this.Weight,
            this.BP1,
            this.BP2,
            this.MedicalExam,
            this.Pules,
            this.Donation,
            this.InegularAntibodies,
            this.Hemoglobin});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BloodDonationList.DefaultCellStyle = dataGridViewCellStyle1;
            this.BloodDonationList.GridColor = System.Drawing.Color.Linen;
            this.BloodDonationList.Location = new System.Drawing.Point(12, 298);
            this.BloodDonationList.MultiSelect = false;
            this.BloodDonationList.Name = "BloodDonationList";
            this.BloodDonationList.ReadOnly = true;
            this.BloodDonationList.RowHeadersWidth = 45;
            this.BloodDonationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodDonationList.Size = new System.Drawing.Size(1193, 475);
            this.BloodDonationList.TabIndex = 332;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // BDid
            // 
            this.BDid.DataPropertyName = "BDId";
            this.BDid.HeaderText = "Donor ID";
            this.BDid.Name = "BDid";
            this.BDid.ReadOnly = true;
            this.BDid.Width = 55;
            // 
            // DName
            // 
            this.DName.DataPropertyName = "Name";
            this.DName.HeaderText = "Name";
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "Dob";
            this.Dob.HeaderText = "DateOfBrith";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 50;
            // 
            // RDate
            // 
            this.RDate.DataPropertyName = "RegistrationDate";
            this.RDate.HeaderText = "Registration Date";
            this.RDate.Name = "RDate";
            this.RDate.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 90;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // BloodGroup
            // 
            this.BloodGroup.DataPropertyName = "BloodGroup";
            this.BloodGroup.HeaderText = "BloodGroup";
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.ReadOnly = true;
            this.BloodGroup.Width = 50;
            // 
            // BDDate
            // 
            this.BDDate.DataPropertyName = "BloodDonationDate";
            this.BDDate.HeaderText = "BloodDonationDate";
            this.BDDate.Name = "BDDate";
            this.BDDate.ReadOnly = true;
            // 
            // Height
            // 
            this.Height.DataPropertyName = "Height";
            this.Height.HeaderText = "Height";
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Width = 40;
            // 
            // Weight
            // 
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 40;
            // 
            // BP1
            // 
            this.BP1.DataPropertyName = "BP1";
            this.BP1.HeaderText = "BP1";
            this.BP1.Name = "BP1";
            this.BP1.ReadOnly = true;
            this.BP1.Width = 20;
            // 
            // BP2
            // 
            this.BP2.DataPropertyName = "BP2";
            this.BP2.HeaderText = "BP2";
            this.BP2.Name = "BP2";
            this.BP2.ReadOnly = true;
            this.BP2.Width = 20;
            // 
            // MedicalExam
            // 
            this.MedicalExam.DataPropertyName = "MedicalExam";
            this.MedicalExam.HeaderText = "Medical Exam";
            this.MedicalExam.Name = "MedicalExam";
            this.MedicalExam.ReadOnly = true;
            // 
            // Pules
            // 
            this.Pules.DataPropertyName = "Pules";
            this.Pules.HeaderText = "Pules";
            this.Pules.Name = "Pules";
            this.Pules.ReadOnly = true;
            this.Pules.Width = 25;
            // 
            // Donation
            // 
            this.Donation.DataPropertyName = "Donation";
            this.Donation.HeaderText = "Donation";
            this.Donation.Name = "Donation";
            this.Donation.ReadOnly = true;
            // 
            // InegularAntibodies
            // 
            this.InegularAntibodies.DataPropertyName = "InegularAntibodies";
            this.InegularAntibodies.HeaderText = "InegularAntibodies";
            this.InegularAntibodies.Name = "InegularAntibodies";
            this.InegularAntibodies.ReadOnly = true;
            // 
            // Hemoglobin
            // 
            this.Hemoglobin.DataPropertyName = "Hemoglobin";
            this.Hemoglobin.HeaderText = "Hemoglobin";
            this.Hemoglobin.Name = "Hemoglobin";
            this.Hemoglobin.ReadOnly = true;
            this.Hemoglobin.Width = 50;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.AutoRoundedCorners = true;
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BorderRadius = 72;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(699, 129);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(376, 146);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 335;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 22);
            this.panel1.TabIndex = 336;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoRoundedCorners = true;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 23;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.btnclose);
            this.guna2GradientPanel1.Controls.Add(this.label41);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightCyan;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 22);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1238, 49);
            this.guna2GradientPanel1.TabIndex = 337;
            // 
            // btnclose
            // 
            this.btnclose.Animated = true;
            this.btnclose.AnimatedGIF = true;
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BorderColor = System.Drawing.Color.Transparent;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.Black;
            this.btnclose.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1044, 14);
            this.btnclose.Name = "btnclose";
            this.btnclose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.Size = new System.Drawing.Size(31, 28);
            this.btnclose.TabIndex = 130;
            this.btnclose.Text = "X";
            this.btnclose.UseTransparentBackground = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Underline);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(350, 14);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(333, 28);
            this.label41.TabIndex = 62;
            this.label41.Text = "All Blood Donation Records";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Animated = true;
            this.btnViewAll.AnimatedGIF = true;
            this.btnViewAll.AutoRoundedCorners = true;
            this.btnViewAll.BackColor = System.Drawing.Color.Transparent;
            this.btnViewAll.BorderColor = System.Drawing.Color.Navy;
            this.btnViewAll.BorderRadius = 13;
            this.btnViewAll.BorderThickness = 1;
            this.btnViewAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAll.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewAll.FillColor2 = System.Drawing.Color.White;
            this.btnViewAll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnViewAll.ForeColor = System.Drawing.Color.Black;
            this.btnViewAll.Location = new System.Drawing.Point(463, 245);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(112, 29);
            this.btnViewAll.TabIndex = 134;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AnimatedGIF = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Navy;
            this.btnSearch.BorderRadius = 13;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(314, 246);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 29);
            this.btnSearch.TabIndex = 135;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(288, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 32);
            this.label19.TabIndex = 343;
            this.label19.Text = "Search By Blood  :-\r\n  Donation Date  ";
            // 
            // BloodDonationDate
            // 
            this.BloodDonationDate.Animated = true;
            this.BloodDonationDate.AutoRoundedCorners = true;
            this.BloodDonationDate.BorderRadius = 10;
            this.BloodDonationDate.BorderThickness = 1;
            this.BloodDonationDate.Checked = true;
            this.BloodDonationDate.CustomFormat = "dd/MM/yyyy";
            this.BloodDonationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BloodDonationDate.FocusedColor = System.Drawing.Color.White;
            this.BloodDonationDate.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.BloodDonationDate.ForeColor = System.Drawing.Color.White;
            this.BloodDonationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BloodDonationDate.Location = new System.Drawing.Point(411, 191);
            this.BloodDonationDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.BloodDonationDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BloodDonationDate.Name = "BloodDonationDate";
            this.BloodDonationDate.Size = new System.Drawing.Size(197, 22);
            this.BloodDonationDate.TabIndex = 344;
            this.BloodDonationDate.Value = new System.DateTime(2023, 8, 10, 0, 0, 0, 0);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(44, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(266, 23);
            this.label17.TabIndex = 345;
            this.label17.Text = "*  Search Blood Donation Record  :";
            // 
            // MessageBoxForSearchData1
            // 
            this.MessageBoxForSearchData1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxForSearchData1.Caption = "Search Record Infromation";
            this.MessageBoxForSearchData1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageBoxForSearchData1.Parent = null;
            this.MessageBoxForSearchData1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxForSearchData1.Text = "Blood Donation Record Found...";
            // 
            // MessageBoxForSearchData2
            // 
            this.MessageBoxForSearchData2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxForSearchData2.Caption = "Search Record Infroamtion";
            this.MessageBoxForSearchData2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageBoxForSearchData2.Parent = null;
            this.MessageBoxForSearchData2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxForSearchData2.Text = "Blood Donation Record Not Found !";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(78, 182);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(140, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 346;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // ViewAllBloodDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 788);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.BloodDonationDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.BloodDonationList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllBloodDonation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllBloodDonation";
            this.Load += new System.EventHandler(this.ViewAllBloodDonation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BloodDonationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BloodDonationList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn BP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pules;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donation;
        private System.Windows.Forms.DataGridViewTextBoxColumn InegularAntibodies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hemoglobin;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewAll;
        private Guna.UI2.WinForms.Guna2DateTimePicker BloodDonationDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxForSearchData1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxForSearchData2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}