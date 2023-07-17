namespace BloodBankManagementSystem
{
    partial class ViewAllDonorsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllDonorsPage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnviewall = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.DDob,
            this.DGender,
            this.DMobile,
            this.DEmail,
            this.DCity,
            this.DAddress,
            this.DBloodGroup,
            this.DHeight,
            this.DWeight});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.Linen;
            this.dataGridView1.Location = new System.Drawing.Point(116, 392);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(999, 382);
            this.dataGridView1.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Colonna MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label27.Location = new System.Drawing.Point(109, 85);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(342, 37);
            this.label27.TabIndex = 64;
            this.label27.Text = "~ All Donor Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(639, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 18);
            this.label2.TabIndex = 81;
            this.label2.Text = "Search By Name  :-";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // btnclose
            // 
            this.btnclose.Animated = true;
            this.btnclose.AnimatedGIF = true;
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(1041, 87);
            this.btnclose.Name = "btnclose";
            this.btnclose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.Size = new System.Drawing.Size(36, 35);
            this.btnclose.TabIndex = 130;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // btnviewall
            // 
            this.btnviewall.Animated = true;
            this.btnviewall.AnimatedGIF = true;
            this.btnviewall.AutoRoundedCorners = true;
            this.btnviewall.BackColor = System.Drawing.Color.Transparent;
            this.btnviewall.BorderColor = System.Drawing.Color.Navy;
            this.btnviewall.BorderRadius = 16;
            this.btnviewall.BorderThickness = 2;
            this.btnviewall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewall.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewall.FillColor2 = System.Drawing.Color.White;
            this.btnviewall.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewall.ForeColor = System.Drawing.Color.Black;
            this.btnviewall.Location = new System.Drawing.Point(677, 301);
            this.btnviewall.Name = "btnviewall";
            this.btnviewall.Size = new System.Drawing.Size(131, 35);
            this.btnviewall.TabIndex = 132;
            this.btnviewall.Text = "View All";
            this.btnviewall.Click += new System.EventHandler(this.btnviewall_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.AnimatedGIF = true;
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Navy;
            this.btnSearch.BorderRadius = 16;
            this.btnSearch.BorderThickness = 2;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor2 = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(839, 301);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(131, 35);
            this.btnSearch.TabIndex = 133;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Animated = true;
            this.txtSearchName.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchName.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearchName.BorderRadius = 10;
            this.txtSearchName.BorderThickness = 2;
            this.txtSearchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchName.DefaultText = "";
            this.txtSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.Location = new System.Drawing.Point(788, 248);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtSearchName.PlaceholderText = "";
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.Size = new System.Drawing.Size(199, 24);
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // DId
            // 
            this.DId.DataPropertyName = "DId";
            this.DId.HeaderText = "Donor ID";
            this.DId.Name = "DId";
            this.DId.ReadOnly = true;
            this.DId.Width = 80;
            // 
            // DName
            // 
            this.DName.DataPropertyName = "DName";
            this.DName.HeaderText = "Name";
            this.DName.Name = "DName";
            this.DName.ReadOnly = true;
            // 
            // DDob
            // 
            this.DDob.DataPropertyName = "DDob";
            this.DDob.HeaderText = "DateOfBrith";
            this.DDob.Name = "DDob";
            this.DDob.ReadOnly = true;
            // 
            // DGender
            // 
            this.DGender.DataPropertyName = "DGender";
            this.DGender.HeaderText = "Gender";
            this.DGender.Name = "DGender";
            this.DGender.ReadOnly = true;
            this.DGender.Width = 90;
            // 
            // DMobile
            // 
            this.DMobile.DataPropertyName = "DMobile";
            this.DMobile.HeaderText = "Mobile";
            this.DMobile.Name = "DMobile";
            this.DMobile.ReadOnly = true;
            // 
            // DEmail
            // 
            this.DEmail.DataPropertyName = "DEmail";
            this.DEmail.HeaderText = "Email";
            this.DEmail.Name = "DEmail";
            this.DEmail.ReadOnly = true;
            // 
            // DCity
            // 
            this.DCity.DataPropertyName = "DCity";
            this.DCity.HeaderText = "City";
            this.DCity.Name = "DCity";
            this.DCity.ReadOnly = true;
            // 
            // DAddress
            // 
            this.DAddress.DataPropertyName = "DAddress";
            this.DAddress.HeaderText = "Address";
            this.DAddress.Name = "DAddress";
            this.DAddress.ReadOnly = true;
            // 
            // DBloodGroup
            // 
            this.DBloodGroup.DataPropertyName = "DBloodGroup";
            this.DBloodGroup.HeaderText = "BloodGroup";
            this.DBloodGroup.Name = "DBloodGroup";
            this.DBloodGroup.ReadOnly = true;
            this.DBloodGroup.Width = 50;
            // 
            // DHeight
            // 
            this.DHeight.DataPropertyName = "DHeight";
            this.DHeight.HeaderText = "Height";
            this.DHeight.Name = "DHeight";
            this.DHeight.ReadOnly = true;
            this.DHeight.Width = 50;
            // 
            // DWeight
            // 
            this.DWeight.DataPropertyName = "DWeight";
            this.DWeight.HeaderText = "Weight";
            this.DWeight.Name = "DWeight";
            this.DWeight.ReadOnly = true;
            this.DWeight.Width = 50;
            // 
            // ViewAllDonorsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 749);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnviewall);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllDonorsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "View All DonorsPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewAllDonorsPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private Guna.UI2.WinForms.Guna2GradientButton btnviewall;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn DBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn DHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn DWeight;
    }
}