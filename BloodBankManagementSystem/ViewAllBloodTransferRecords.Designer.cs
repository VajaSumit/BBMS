namespace BloodBankManagementSystem
{
    partial class ViewAllBloodTransferRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllBloodTransferRecords));
            this.BloodTransferList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodTransferd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hospitalname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodBottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.MessageBoxForSearchData1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageBoxForSearchData2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label41 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BloodTransferDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnViewAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BloodTransferList)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BloodTransferList
            // 
            this.BloodTransferList.AllowUserToAddRows = false;
            this.BloodTransferList.AllowUserToDeleteRows = false;
            this.BloodTransferList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BloodTransferList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BloodTransferList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BloodTransferList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PId,
            this.PName,
            this.Dob,
            this.Gender,
            this.Mobile,
            this.registration_Date,
            this.Email,
            this.City,
            this.Address,
            this.BloodTransferd,
            this.BloodGroup,
            this.Hospitalname,
            this.Doctorname,
            this.BloodBottle,
            this.BloodUsed});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BloodTransferList.DefaultCellStyle = dataGridViewCellStyle1;
            this.BloodTransferList.GridColor = System.Drawing.Color.Linen;
            this.BloodTransferList.Location = new System.Drawing.Point(12, 299);
            this.BloodTransferList.MultiSelect = false;
            this.BloodTransferList.Name = "BloodTransferList";
            this.BloodTransferList.ReadOnly = true;
            this.BloodTransferList.RowHeadersWidth = 45;
            this.BloodTransferList.RowTemplate.ReadOnly = true;
            this.BloodTransferList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodTransferList.Size = new System.Drawing.Size(1194, 477);
            this.BloodTransferList.TabIndex = 334;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 25;
            // 
            // PId
            // 
            this.PId.DataPropertyName = "PId";
            this.PId.HeaderText = "Patient ID";
            this.PId.Name = "PId";
            this.PId.ReadOnly = true;
            this.PId.Width = 50;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "Name";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "Dob";
            this.Dob.HeaderText = "Date Of Brith";
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
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "Mobile";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // registration_Date
            // 
            this.registration_Date.DataPropertyName = "RegistrationDate";
            this.registration_Date.HeaderText = "Registration Date";
            this.registration_Date.Name = "registration_Date";
            this.registration_Date.ReadOnly = true;
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
            // BloodTransferd
            // 
            this.BloodTransferd.DataPropertyName = "BloodTransferDate";
            this.BloodTransferd.HeaderText = "Blood Transfer Date";
            this.BloodTransferd.Name = "BloodTransferd";
            this.BloodTransferd.ReadOnly = true;
            // 
            // BloodGroup
            // 
            this.BloodGroup.DataPropertyName = "BloodGroup";
            this.BloodGroup.HeaderText = "BloodGroup";
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.ReadOnly = true;
            this.BloodGroup.Width = 50;
            // 
            // Hospitalname
            // 
            this.Hospitalname.DataPropertyName = "HospitalName";
            this.Hospitalname.HeaderText = "Hospital Name";
            this.Hospitalname.Name = "Hospitalname";
            this.Hospitalname.ReadOnly = true;
            // 
            // Doctorname
            // 
            this.Doctorname.DataPropertyName = "DoctorName";
            this.Doctorname.HeaderText = "Doctor Name";
            this.Doctorname.Name = "Doctorname";
            this.Doctorname.ReadOnly = true;
            // 
            // BloodBottle
            // 
            this.BloodBottle.DataPropertyName = "BloodBottle";
            this.BloodBottle.HeaderText = "Blood Bottlle";
            this.BloodBottle.Name = "BloodBottle";
            this.BloodBottle.ReadOnly = true;
            this.BloodBottle.Width = 50;
            // 
            // BloodUsed
            // 
            this.BloodUsed.DataPropertyName = "BloodUsed";
            this.BloodUsed.HeaderText = "Blood Used";
            this.BloodUsed.Name = "BloodUsed";
            this.BloodUsed.ReadOnly = true;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // MessageBoxForSearchData1
            // 
            this.MessageBoxForSearchData1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxForSearchData1.Caption = "Search Record information";
            this.MessageBoxForSearchData1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageBoxForSearchData1.Parent = null;
            this.MessageBoxForSearchData1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxForSearchData1.Text = "Blood Transfer Record Found..";
            // 
            // MessageBoxForSearchData2
            // 
            this.MessageBoxForSearchData2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxForSearchData2.Caption = "Search Record information";
            this.MessageBoxForSearchData2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageBoxForSearchData2.Parent = null;
            this.MessageBoxForSearchData2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxForSearchData2.Text = "Blood Transfer Record Not Found. !";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 22);
            this.panel1.TabIndex = 351;
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
            this.guna2GradientPanel1.TabIndex = 352;
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
            this.btnclose.Location = new System.Drawing.Point(1027, 14);
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
            this.label41.Size = new System.Drawing.Size(325, 28);
            this.label41.TabIndex = 62;
            this.label41.Text = "All Blood Transfer Records";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(697, 133);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(348, 131);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 335;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(115, 175);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(140, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 336;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(320, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 32);
            this.label19.TabIndex = 348;
            this.label19.Text = "Search By Blood  :-\r\n  Transfer Date  ";
            // 
            // BloodTransferDate
            // 
            this.BloodTransferDate.Animated = true;
            this.BloodTransferDate.AutoRoundedCorners = true;
            this.BloodTransferDate.BorderRadius = 10;
            this.BloodTransferDate.BorderThickness = 1;
            this.BloodTransferDate.Checked = true;
            this.BloodTransferDate.CustomFormat = "dd/MM/yyyy";
            this.BloodTransferDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BloodTransferDate.FocusedColor = System.Drawing.Color.White;
            this.BloodTransferDate.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.BloodTransferDate.ForeColor = System.Drawing.Color.White;
            this.BloodTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BloodTransferDate.Location = new System.Drawing.Point(443, 179);
            this.BloodTransferDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.BloodTransferDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BloodTransferDate.Name = "BloodTransferDate";
            this.BloodTransferDate.Size = new System.Drawing.Size(197, 22);
            this.BloodTransferDate.TabIndex = 349;
            this.BloodTransferDate.Value = new System.DateTime(2023, 8, 10, 0, 0, 0, 0);
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
            this.btnViewAll.Location = new System.Drawing.Point(495, 233);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(112, 29);
            this.btnViewAll.TabIndex = 346;
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
            this.btnSearch.Location = new System.Drawing.Point(346, 234);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 29);
            this.btnSearch.TabIndex = 347;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(86, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(268, 23);
            this.label17.TabIndex = 350;
            this.label17.Text = "*  Search Blood Transfer Record  :";
            // 
            // ViewAllBloodTransferRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 788);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.BloodTransferDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.BloodTransferList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllBloodTransferRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllBloodTransferRecords";
            this.Load += new System.EventHandler(this.ViewAllBloodTransferRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BloodTransferList)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BloodTransferList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodTransferd;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hospitalname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodBottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodUsed;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxForSearchData1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxForSearchData2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewAll;
        private Guna.UI2.WinForms.Guna2DateTimePicker BloodTransferDate;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}