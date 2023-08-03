namespace BloodBankManagementSystem
{
    partial class ViewAllDoctorsRecordcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllDoctorsRecordcs));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.DoctorList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Registration_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalDegree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfGraduation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfExperience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicalLicenseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label41 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // DoctorList
            // 
            this.DoctorList.AllowUserToAddRows = false;
            this.DoctorList.AllowUserToDeleteRows = false;
            this.DoctorList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DoctorList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DoctorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DoctorId,
            this.DoctorName,
            this.Gender,
            this.Dob,
            this.MobileNo,
            this.EmailId,
            this.Registration_Date,
            this.Status,
            this.State,
            this.City,
            this.Address,
            this.MedicalDegree,
            this.YearOfGraduation,
            this.YearOfExperience,
            this.Specialist,
            this.MedicalLicenseNo,
            this.HospitalName,
            this.HospitalAddress});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorList.DefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorList.GridColor = System.Drawing.Color.Linen;
            this.DoctorList.Location = new System.Drawing.Point(58, 266);
            this.DoctorList.MultiSelect = false;
            this.DoctorList.Name = "DoctorList";
            this.DoctorList.ReadOnly = true;
            this.DoctorList.RowTemplate.ReadOnly = true;
            this.DoctorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorList.Size = new System.Drawing.Size(1071, 525);
            this.DoctorList.TabIndex = 254;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // DoctorId
            // 
            this.DoctorId.DataPropertyName = "DId";
            this.DoctorId.HeaderText = "Doctor ID";
            this.DoctorId.Name = "DoctorId";
            this.DoctorId.ReadOnly = true;
            this.DoctorId.Width = 50;
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "Name";
            this.DoctorName.HeaderText = "Doctor Name";
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 50;
            // 
            // Dob
            // 
            this.Dob.DataPropertyName = "Dob";
            this.Dob.HeaderText = "DateOfBrith";
            this.Dob.Name = "Dob";
            this.Dob.ReadOnly = true;
            this.Dob.Width = 50;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            // 
            // EmailId
            // 
            this.EmailId.DataPropertyName = "Email";
            this.EmailId.HeaderText = "Email ID";
            this.EmailId.Name = "EmailId";
            this.EmailId.ReadOnly = true;
            this.EmailId.Width = 70;
            // 
            // Registration_Date
            // 
            this.Registration_Date.DataPropertyName = "RegistrationDate";
            this.Registration_Date.HeaderText = "Registration Date";
            this.Registration_Date.Name = "Registration_Date";
            this.Registration_Date.ReadOnly = true;
            this.Registration_Date.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 80;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 120;
            // 
            // MedicalDegree
            // 
            this.MedicalDegree.DataPropertyName = "MedicalDegree";
            this.MedicalDegree.HeaderText = "Medical Degree";
            this.MedicalDegree.Name = "MedicalDegree";
            this.MedicalDegree.ReadOnly = true;
            // 
            // YearOfGraduation
            // 
            this.YearOfGraduation.DataPropertyName = "YearOfGraduation";
            this.YearOfGraduation.HeaderText = "YearOfGraduation";
            this.YearOfGraduation.Name = "YearOfGraduation";
            this.YearOfGraduation.ReadOnly = true;
            // 
            // YearOfExperience
            // 
            this.YearOfExperience.DataPropertyName = "YearOfExperience";
            this.YearOfExperience.HeaderText = "YearOfExperience";
            this.YearOfExperience.Name = "YearOfExperience";
            this.YearOfExperience.ReadOnly = true;
            this.YearOfExperience.Width = 60;
            // 
            // Specialist
            // 
            this.Specialist.DataPropertyName = "Specialist";
            this.Specialist.HeaderText = "Specialist";
            this.Specialist.Name = "Specialist";
            this.Specialist.ReadOnly = true;
            this.Specialist.Width = 80;
            // 
            // MedicalLicenseNo
            // 
            this.MedicalLicenseNo.DataPropertyName = "MedicalLicenseNo";
            this.MedicalLicenseNo.HeaderText = "MedicalLicenseNo";
            this.MedicalLicenseNo.Name = "MedicalLicenseNo";
            this.MedicalLicenseNo.ReadOnly = true;
            this.MedicalLicenseNo.Width = 80;
            // 
            // HospitalName
            // 
            this.HospitalName.DataPropertyName = "HospitalName";
            this.HospitalName.HeaderText = "HospitalName";
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.ReadOnly = true;
            // 
            // HospitalAddress
            // 
            this.HospitalAddress.DataPropertyName = "HospitalAddress";
            this.HospitalAddress.HeaderText = "HospitalAddress";
            this.HospitalAddress.Name = "HospitalAddress";
            this.HospitalAddress.ReadOnly = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.AutoRoundedCorners = true;
            this.guna2PictureBox1.BorderRadius = 45;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(878, 167);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(209, 92);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 259;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(146, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 23);
            this.label17.TabIndex = 256;
            this.label17.Text = "* Records :";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.AutoRoundedCorners = true;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.guna2GradientPanel1.BorderRadius = 23;
            this.guna2GradientPanel1.BorderThickness = 1;
            this.guna2GradientPanel1.Controls.Add(this.guna2CircleButton1);
            this.guna2GradientPanel1.Controls.Add(this.label41);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.LightCyan;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 22);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1306, 49);
            this.guna2GradientPanel1.TabIndex = 261;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Animated = true;
            this.guna2CircleButton1.AnimatedGIF = true;
            this.guna2CircleButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Black;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe Fluent Icons", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Location = new System.Drawing.Point(1098, 8);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(31, 28);
            this.guna2CircleButton1.TabIndex = 130;
            this.guna2CircleButton1.Text = "X";
            this.guna2CircleButton1.UseTransparentBackground = true;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Colonna MT", 20.25F, System.Drawing.FontStyle.Underline);
            this.label41.ForeColor = System.Drawing.Color.Black;
            this.label41.Location = new System.Drawing.Point(406, 15);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(243, 28);
            this.label41.TabIndex = 62;
            this.label41.Text = "All Doctors Records";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 22);
            this.panel1.TabIndex = 260;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.AutoRoundedCorners = true;
            this.guna2PictureBox2.BorderRadius = 32;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox2.Location = new System.Drawing.Point(123, 179);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(141, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 262;
            this.guna2PictureBox2.TabStop = false;
            // 
            // ViewAllDoctorsRecordcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1323, 788);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DoctorList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllDoctorsRecordcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllDoctorsRecordcs";
            this.Load += new System.EventHandler(this.ViewAllDoctorsRecordcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.DataGridView DoctorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registration_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalDegree;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfGraduation;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfExperience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialist;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicalLicenseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalAddress;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}