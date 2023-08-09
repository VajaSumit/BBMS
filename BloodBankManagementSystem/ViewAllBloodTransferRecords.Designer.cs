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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label41 = new System.Windows.Forms.Label();
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
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodTransferList)).BeginInit();
            this.SuspendLayout();
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
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1317, 49);
            this.guna2GradientPanel1.TabIndex = 261;
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
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BloodTransferList.DefaultCellStyle = dataGridViewCellStyle2;
            this.BloodTransferList.GridColor = System.Drawing.Color.Linen;
            this.BloodTransferList.Location = new System.Drawing.Point(12, 120);
            this.BloodTransferList.MultiSelect = false;
            this.BloodTransferList.Name = "BloodTransferList";
            this.BloodTransferList.ReadOnly = true;
            this.BloodTransferList.RowHeadersWidth = 45;
            this.BloodTransferList.RowTemplate.ReadOnly = true;
            this.BloodTransferList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodTransferList.Size = new System.Drawing.Size(1375, 346);
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
            // ViewAllBloodTransferRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 493);
            this.Controls.Add(this.BloodTransferList);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllBloodTransferRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewAllBloodTransferRecords";
            this.Load += new System.EventHandler(this.ViewAllBloodTransferRecords_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodTransferList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Label label41;
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
    }
}