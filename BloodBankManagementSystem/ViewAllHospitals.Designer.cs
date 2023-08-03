namespace BloodBankManagementSystem
{
    partial class ViewAllHospitals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllHospitals));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.HospitalList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnershipType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HospitalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyHospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label41 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalList)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox1.Location = new System.Drawing.Point(855, 174);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(236, 118);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 220;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.AutoRoundedCorners = true;
            this.guna2PictureBox2.BorderRadius = 32;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.guna2PictureBox2.Location = new System.Drawing.Point(114, 221);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(167, 66);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 219;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Underline);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(112, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 23);
            this.label17.TabIndex = 217;
            this.label17.Text = "* Hospital  Records  :";
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // HospitalList
            // 
            this.HospitalList.AllowUserToAddRows = false;
            this.HospitalList.AllowUserToDeleteRows = false;
            this.HospitalList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HospitalList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HospitalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HospitalList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.HospitalId,
            this.HospitalName,
            this.MobileNo,
            this.TelephoneNo,
            this.EmailId,
            this.City,
            this.Address,
            this.RegistrationDate,
            this.OwnerName,
            this.OwnerMobileNo,
            this.OwnershipType,
            this.HospitalType,
            this.SpecialtyHospital});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HospitalList.DefaultCellStyle = dataGridViewCellStyle2;
            this.HospitalList.GridColor = System.Drawing.Color.Linen;
            this.HospitalList.Location = new System.Drawing.Point(67, 316);
            this.HospitalList.MultiSelect = false;
            this.HospitalList.Name = "HospitalList";
            this.HospitalList.ReadOnly = true;
            this.HospitalList.RowTemplate.ReadOnly = true;
            this.HospitalList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HospitalList.Size = new System.Drawing.Size(1094, 408);
            this.HospitalList.TabIndex = 215;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // HospitalId
            // 
            this.HospitalId.DataPropertyName = "HospitalId";
            this.HospitalId.HeaderText = "Hospital ID";
            this.HospitalId.Name = "HospitalId";
            this.HospitalId.ReadOnly = true;
            this.HospitalId.Width = 50;
            // 
            // HospitalName
            // 
            this.HospitalName.DataPropertyName = "Name";
            this.HospitalName.HeaderText = "Hospital Name";
            this.HospitalName.Name = "HospitalName";
            this.HospitalName.ReadOnly = true;
            // 
            // MobileNo
            // 
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            this.MobileNo.Width = 50;
            // 
            // TelephoneNo
            // 
            this.TelephoneNo.DataPropertyName = "TelephoneNo";
            this.TelephoneNo.HeaderText = "Telephone/STD";
            this.TelephoneNo.Name = "TelephoneNo";
            this.TelephoneNo.ReadOnly = true;
            this.TelephoneNo.Width = 50;
            // 
            // EmailId
            // 
            this.EmailId.DataPropertyName = "EmailId";
            this.EmailId.HeaderText = "Email ID";
            this.EmailId.Name = "EmailId";
            this.EmailId.ReadOnly = true;
            this.EmailId.Width = 70;
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
            // RegistrationDate
            // 
            this.RegistrationDate.DataPropertyName = "RegistrationDate";
            this.RegistrationDate.HeaderText = "Registration Date";
            this.RegistrationDate.Name = "RegistrationDate";
            this.RegistrationDate.ReadOnly = true;
            this.RegistrationDate.Width = 80;
            // 
            // OwnerName
            // 
            this.OwnerName.DataPropertyName = "OwnerName";
            this.OwnerName.HeaderText = "Owner Name";
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.ReadOnly = true;
            // 
            // OwnerMobileNo
            // 
            this.OwnerMobileNo.DataPropertyName = "OwnerMobileNo";
            this.OwnerMobileNo.HeaderText = "Owner Mobile No";
            this.OwnerMobileNo.Name = "OwnerMobileNo";
            this.OwnerMobileNo.ReadOnly = true;
            this.OwnerMobileNo.Width = 60;
            // 
            // OwnershipType
            // 
            this.OwnershipType.DataPropertyName = "OwnershipType";
            this.OwnershipType.HeaderText = "Ownership Type";
            this.OwnershipType.Name = "OwnershipType";
            this.OwnershipType.ReadOnly = true;
            this.OwnershipType.Width = 80;
            // 
            // HospitalType
            // 
            this.HospitalType.DataPropertyName = "HospitalType";
            this.HospitalType.HeaderText = "HospitalType";
            this.HospitalType.Name = "HospitalType";
            this.HospitalType.ReadOnly = true;
            this.HospitalType.Width = 80;
            // 
            // SpecialtyHospital
            // 
            this.SpecialtyHospital.DataPropertyName = "SpecialtyHospital";
            this.SpecialtyHospital.HeaderText = "Specialty Hospital";
            this.SpecialtyHospital.Name = "SpecialtyHospital";
            this.SpecialtyHospital.ReadOnly = true;
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1290, 49);
            this.guna2GradientPanel1.TabIndex = 263;
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
            this.label41.Location = new System.Drawing.Point(440, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(249, 28);
            this.label41.TabIndex = 62;
            this.label41.Text = "All Hospital Records";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1290, 22);
            this.panel1.TabIndex = 262;
            // 
            // ViewAllHospitals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 749);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HospitalList);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.label17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllHospitals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllHospitals";
            this.Load += new System.EventHandler(this.ViewAllHospitals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalList)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.DataGridView HospitalList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnershipType;
        private System.Windows.Forms.DataGridViewTextBoxColumn HospitalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyHospital;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Panel panel1;
    }
}