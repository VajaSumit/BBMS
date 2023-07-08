namespace BloodBankManagementSystem
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMarquee = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.exitlink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkshowpassword = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cmdUserRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // lblMarquee
            // 
            this.lblMarquee.AutoSize = true;
            this.lblMarquee.BackColor = System.Drawing.Color.Transparent;
            this.lblMarquee.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarquee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMarquee.Location = new System.Drawing.Point(30, 601);
            this.lblMarquee.Name = "lblMarquee";
            this.lblMarquee.Size = new System.Drawing.Size(149, 44);
            this.lblMarquee.TabIndex = 56;
            this.lblMarquee.Text = "~ Donate Blood ,\r\n       Save  Life";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // exitlink
            // 
            this.exitlink.AutoSize = true;
            this.exitlink.BackColor = System.Drawing.Color.Transparent;
            this.exitlink.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlink.ForeColor = System.Drawing.Color.White;
            this.exitlink.Location = new System.Drawing.Point(741, 642);
            this.exitlink.Name = "exitlink";
            this.exitlink.Size = new System.Drawing.Size(33, 17);
            this.exitlink.TabIndex = 61;
            this.exitlink.TabStop = true;
            this.exitlink.Text = "Exit";
            this.exitlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exitlink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // chkshowpassword
            // 
            this.chkshowpassword.AutoSize = true;
            this.chkshowpassword.BackColor = System.Drawing.Color.Transparent;
            this.chkshowpassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkshowpassword.BackgroundImage")));
            this.chkshowpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkshowpassword.FlatAppearance.BorderSize = 4;
            this.chkshowpassword.Font = new System.Drawing.Font("Perpetua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkshowpassword.ForeColor = System.Drawing.Color.Black;
            this.chkshowpassword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkshowpassword.Location = new System.Drawing.Point(558, 474);
            this.chkshowpassword.Name = "chkshowpassword";
            this.chkshowpassword.Size = new System.Drawing.Size(46, 17);
            this.chkshowpassword.TabIndex = 4;
            this.chkshowpassword.Text = "          ";
            this.chkshowpassword.UseVisualStyleBackColor = false;
            this.chkshowpassword.CheckedChanged += new System.EventHandler(this.chkshowpassword_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogin.BackgroundImage")));
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.FlatAppearance.BorderSize = 2;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(397, 522);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(101, 39);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            this.btnlogin.MouseEnter += new System.EventHandler(this.btnlogin_MouseEnter);
            this.btnlogin.MouseHover += new System.EventHandler(this.btnlogin_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "USERROLE   :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Accept our Terms and Condition to Login ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(311, 600);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Accept T/C ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(343, 422);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(208, 24);
            this.txtusername.TabIndex = 1;
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave_1);
            // 
            // cmdUserRole
            // 
            this.cmdUserRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmdUserRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmdUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdUserRole.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUserRole.FormattingEnabled = true;
            this.cmdUserRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Doctor",
            "Staff"});
            this.cmdUserRole.Location = new System.Drawing.Point(343, 376);
            this.cmdUserRole.Name = "cmdUserRole";
            this.cmdUserRole.Size = new System.Drawing.Size(208, 25);
            this.cmdUserRole.TabIndex = 0;
            this.cmdUserRole.SelectedIndexChanged += new System.EventHandler(this.cmdUserRole_SelectedIndexChanged);
            this.cmdUserRole.Enter += new System.EventHandler(this.cmdUserRole_Enter);
            this.cmdUserRole.Leave += new System.EventHandler(this.cmdUserRole_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "USERNAME  :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "PASSWORD :-";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(344, 470);
            this.txtpassword.MaxLength = 10;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(208, 24);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.Enter += new System.EventHandler(this.txtpassword_Enter);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = " Welcome To  Blood Bank  Management System";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(745, 8);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(37, 29);
            this.btnclose.TabIndex = 64;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(781, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 673);
            this.panel1.TabIndex = 65;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 673);
            this.panel2.TabIndex = 66;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 10);
            this.panel3.TabIndex = 67;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(10, 663);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 10);
            this.panel4.TabIndex = 68;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(380, 644);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 17);
            this.linkLabel1.TabIndex = 69;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Read T/C";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(791, 673);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitlink);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMarquee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdUserRole);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.chkshowpassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label lblMarquee;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel exitlink;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdUserRole;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox chkshowpassword;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}