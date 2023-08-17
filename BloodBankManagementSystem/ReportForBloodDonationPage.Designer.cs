namespace BloodBankManagementSystem
{
    partial class ReportForBloodDonationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForBloodDonationPage));
            this.btnclose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearch1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnViewAll = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BloodDonationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.MessageBoxForSearchData1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.MessageBoxForSearchData2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnSwitch2 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.btnclose.Location = new System.Drawing.Point(1184, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnclose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnclose.Size = new System.Drawing.Size(28, 24);
            this.btnclose.TabIndex = 130;
            this.btnclose.Text = "X";
            this.btnclose.UseTransparentBackground = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 22);
            this.panel1.TabIndex = 353;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.guna2AnimateWindow1.Interval = 800;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(4, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(220, 18);
            this.label17.TabIndex = 361;
            this.label17.Text = "*  Search Blood Donation Record  :";
            // 
            // btnSearch1
            // 
            this.btnSearch1.Animated = true;
            this.btnSearch1.AnimatedGIF = true;
            this.btnSearch1.AutoRoundedCorners = true;
            this.btnSearch1.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch1.BorderColor = System.Drawing.Color.Navy;
            this.btnSearch1.BorderRadius = 11;
            this.btnSearch1.BorderThickness = 1;
            this.btnSearch1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch1.Enabled = false;
            this.btnSearch1.FillColor = System.Drawing.Color.White;
            this.btnSearch1.FillColor2 = System.Drawing.Color.White;
            this.btnSearch1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch1.ForeColor = System.Drawing.Color.Black;
            this.btnSearch1.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch1.Image")));
            this.btnSearch1.Location = new System.Drawing.Point(425, 32);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(30, 24);
            this.btnSearch1.TabIndex = 356;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
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
            this.btnViewAll.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.Color.Black;
            this.btnViewAll.Location = new System.Drawing.Point(930, 28);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(43, 29);
            this.btnViewAll.TabIndex = 355;
            this.btnViewAll.Text = "All";
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // BloodDonationDate
            // 
            this.BloodDonationDate.Animated = true;
            this.BloodDonationDate.AutoRoundedCorners = true;
            this.BloodDonationDate.BorderRadius = 10;
            this.BloodDonationDate.BorderThickness = 1;
            this.BloodDonationDate.Checked = true;
            this.BloodDonationDate.CustomFormat = "dd/MM/yyyy";
            this.BloodDonationDate.Enabled = false;
            this.BloodDonationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BloodDonationDate.FocusedColor = System.Drawing.Color.White;
            this.BloodDonationDate.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.BloodDonationDate.ForeColor = System.Drawing.Color.White;
            this.BloodDonationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BloodDonationDate.Location = new System.Drawing.Point(222, 32);
            this.BloodDonationDate.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.BloodDonationDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BloodDonationDate.Name = "BloodDonationDate";
            this.BloodDonationDate.Size = new System.Drawing.Size(197, 22);
            this.BloodDonationDate.TabIndex = 360;
            this.BloodDonationDate.Value = new System.DateTime(2023, 8, 10, 0, 0, 0, 0);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkBlue;
            this.label19.Location = new System.Drawing.Point(112, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 32);
            this.label19.TabIndex = 359;
            this.label19.Text = "Search By Blood  :-\r\n  Donation Date  ";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Animated = true;
            this.txtSearchName.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchName.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearchName.BorderRadius = 12;
            this.txtSearchName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchName.DefaultText = "";
            this.txtSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.Enabled = false;
            this.txtSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.txtSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchName.Location = new System.Drawing.Point(672, 33);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearchName.PlaceholderText = "Enter The Donor Name";
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.Size = new System.Drawing.Size(197, 22);
            this.txtSearchName.TabIndex = 363;
            this.txtSearchName.Leave += new System.EventHandler(this.txtSearchName_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(573, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 364;
            this.label2.Text = " Search By  :-\r\nDonor Name";
            // 
            // btnSearch2
            // 
            this.btnSearch2.Animated = true;
            this.btnSearch2.AnimatedGIF = true;
            this.btnSearch2.AutoRoundedCorners = true;
            this.btnSearch2.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch2.BorderColor = System.Drawing.Color.Navy;
            this.btnSearch2.BorderRadius = 11;
            this.btnSearch2.BorderThickness = 1;
            this.btnSearch2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch2.Enabled = false;
            this.btnSearch2.FillColor = System.Drawing.Color.White;
            this.btnSearch2.FillColor2 = System.Drawing.Color.White;
            this.btnSearch2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch2.ForeColor = System.Drawing.Color.Black;
            this.btnSearch2.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch2.Image")));
            this.btnSearch2.Location = new System.Drawing.Point(875, 31);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(30, 24);
            this.btnSearch2.TabIndex = 365;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // MessageBoxForSearchData1
            // 
            this.MessageBoxForSearchData1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxForSearchData1.Caption = "Search Record Information";
            this.MessageBoxForSearchData1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageBoxForSearchData1.Parent = null;
            this.MessageBoxForSearchData1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxForSearchData1.Text = "Record Found .....";
            // 
            // MessageBoxForSearchData2
            // 
            this.MessageBoxForSearchData2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageBoxForSearchData2.Caption = "Search Record Information";
            this.MessageBoxForSearchData2.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.MessageBoxForSearchData2.Parent = null;
            this.MessageBoxForSearchData2.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.MessageBoxForSearchData2.Text = "Record Not Found !";
            // 
            // btnSwitch1
            // 
            this.btnSwitch1.Animated = true;
            this.btnSwitch1.AutoRoundedCorners = true;
            this.btnSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnSwitch1.Location = new System.Drawing.Point(74, 34);
            this.btnSwitch1.Name = "btnSwitch1";
            this.btnSwitch1.Size = new System.Drawing.Size(35, 20);
            this.btnSwitch1.TabIndex = 367;
            this.btnSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.btnSwitch1.UseTransparentBackground = true;
            this.btnSwitch1.CheckedChanged += new System.EventHandler(this.btnSwitch1_CheckedChanged);
            // 
            // btnSwitch2
            // 
            this.btnSwitch2.Animated = true;
            this.btnSwitch2.AutoRoundedCorners = true;
            this.btnSwitch2.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitch2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSwitch2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSwitch2.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnSwitch2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.btnSwitch2.Location = new System.Drawing.Point(524, 33);
            this.btnSwitch2.Name = "btnSwitch2";
            this.btnSwitch2.Size = new System.Drawing.Size(35, 20);
            this.btnSwitch2.TabIndex = 368;
            this.btnSwitch2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnSwitch2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.btnSwitch2.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.btnSwitch2.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.btnSwitch2.UseTransparentBackground = true;
            this.btnSwitch2.CheckedChanged += new System.EventHandler(this.btnSwitch2_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 67);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1358, 720);
            this.crystalReportViewer1.TabIndex = 371;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(991, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(187, 61);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 380;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // ReportForBloodDonationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnclose;
            this.ClientSize = new System.Drawing.Size(1358, 788);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnSwitch2);
            this.Controls.Add(this.btnSwitch1);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.BloodDonationDate);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForBloodDonationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReportForBloodDonationPage";
            this.Load += new System.EventHandler(this.ReportForBloodDonationPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton btnclose;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch1;
        private Guna.UI2.WinForms.Guna2GradientButton btnViewAll;
        private Guna.UI2.WinForms.Guna2DateTimePicker BloodDonationDate;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch2;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxForSearchData1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageBoxForSearchData2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btnSwitch2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch btnSwitch1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}