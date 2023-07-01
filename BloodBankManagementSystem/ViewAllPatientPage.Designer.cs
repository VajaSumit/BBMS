﻿namespace BloodBankManagementSystem
{
    partial class ViewAllPatientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllPatientPage));
            this.label27 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnviewall = new System.Windows.Forms.Button();
            this.btnSearrch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Snow;
            this.label27.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(108, 63);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(368, 49);
            this.label27.TabIndex = 65;
            this.label27.Text = "~ All Patient Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DId,
            this.DName,
            this.DAge,
            this.DGender,
            this.DMobile,
            this.DEmail,
            this.DCity,
            this.DAddress,
            this.DBloodGroup});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Linen;
            this.dataGridView1.Location = new System.Drawing.Point(177, 262);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 382);
            this.dataGridView1.TabIndex = 66;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DId
            // 
            this.DId.DataPropertyName = "PId";
            this.DId.HeaderText = "Patient ID";
            this.DId.Name = "DId";
            this.DId.ReadOnly = true;
            // 
            // DName
            // 
            this.DName.DataPropertyName = "PName";
            this.DName.HeaderText = "Name";
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            // 
            // DAge
            // 
            this.DAge.DataPropertyName = "PAge";
            this.DAge.HeaderText = "Age";
            this.DAge.Name = "DAge";
            this.DAge.ReadOnly = true;
            // 
            // DGender
            // 
            this.DGender.DataPropertyName = "PGender";
            this.DGender.HeaderText = "Gender";
            this.DGender.Name = "DGender";
            this.DGender.ReadOnly = true;
            // 
            // DMobile
            // 
            this.DMobile.DataPropertyName = "PMobile";
            this.DMobile.HeaderText = "Mobile";
            this.DMobile.Name = "DMobile";
            this.DMobile.ReadOnly = true;
            // 
            // DEmail
            // 
            this.DEmail.DataPropertyName = "PEmail";
            this.DEmail.HeaderText = "Email";
            this.DEmail.Name = "DEmail";
            this.DEmail.ReadOnly = true;
            // 
            // DCity
            // 
            this.DCity.DataPropertyName = "PCity";
            this.DCity.HeaderText = "City";
            this.DCity.Name = "DCity";
            this.DCity.ReadOnly = true;
            // 
            // DAddress
            // 
            this.DAddress.DataPropertyName = "PAddress";
            this.DAddress.HeaderText = "Address";
            this.DAddress.Name = "DAddress";
            this.DAddress.ReadOnly = true;
            // 
            // DBloodGroup
            // 
            this.DBloodGroup.DataPropertyName = "PBloodGroup";
            this.DBloodGroup.HeaderText = "BloodGroup";
            this.DBloodGroup.Name = "DBloodGroup";
            this.DBloodGroup.ReadOnly = true;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1255, 63);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(39, 32);
            this.btnclose.TabIndex = 67;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnviewall
            // 
            this.btnviewall.BackColor = System.Drawing.Color.DarkRed;
            this.btnviewall.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnviewall.Location = new System.Drawing.Point(829, 189);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(118, 31);
            this.btnviewall.TabIndex = 1;
            this.btnviewall.Text = "VIEW ALL";
            this.btnviewall.UseVisualStyleBackColor = false;
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // btnSearrch
            // 
            this.btnSearrch.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearrch.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearrch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearrch.Location = new System.Drawing.Point(991, 189);
            this.btnSearrch.Name = "btnSearrch";
            this.btnSearrch.Size = new System.Drawing.Size(118, 31);
            this.btnSearrch.TabIndex = 2;
            this.btnSearrch.Text = "SEARCH";
            this.btnSearrch.UseVisualStyleBackColor = false;
            this.btnSearrch.Click += new System.EventHandler(this.btnSearrch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSearchName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(940, 135);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(189, 25);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.Enter += new System.EventHandler(this.txtSearchName_Enter);
            this.txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(798, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 85;
            this.label2.Text = "Search By Name  :-";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ViewAllPatientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(1364, 788);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnSearrch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label27);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllPatientPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ViewAllPatientPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewAllPatientPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBloodGroup;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnviewall;
        private System.Windows.Forms.Button btnSearrch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}