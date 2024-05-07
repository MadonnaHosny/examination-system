namespace OnlineExaminationSystem
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            btnSignUp = new Button();
            txtSsn = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            lblgologin = new Label();
            pictureBox1 = new PictureBox();
            lblReqFname = new Label();
            lblReqLname = new Label();
            lblReqEmail = new Label();
            lblReqPassword = new Label();
            lblReqSSN = new Label();
            Email = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSignUp.BackColor = Color.FromArgb(186, 32, 38);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Century Gothic", 13F);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(251, 557);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(159, 47);
            btnSignUp.TabIndex = 21;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtSsn
            // 
            txtSsn.Anchor = AnchorStyles.None;
            txtSsn.Font = new Font("Century Gothic", 13F);
            txtSsn.ForeColor = Color.Gray;
            txtSsn.Location = new Point(196, 479);
            txtSsn.Name = "txtSsn";
            txtSsn.PlaceholderText = "SSN";
            txtSsn.Size = new Size(289, 34);
            txtSsn.TabIndex = 15;
            txtSsn.TextChanged += txtSsn_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Font = new Font("Century Gothic", 13F);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(196, 405);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(289, 34);
            txtPassword.TabIndex = 14;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Century Gothic", 13F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Location = new Point(196, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(289, 34);
            txtEmail.TabIndex = 13;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtLname
            // 
            txtLname.Anchor = AnchorStyles.None;
            txtLname.Font = new Font("Century Gothic", 13F);
            txtLname.ForeColor = Color.Gray;
            txtLname.Location = new Point(196, 257);
            txtLname.Name = "txtLname";
            txtLname.PlaceholderText = "Last Name";
            txtLname.Size = new Size(289, 34);
            txtLname.TabIndex = 12;
            txtLname.TextChanged += txtLname_TextChanged;
            // 
            // txtFname
            // 
            txtFname.Anchor = AnchorStyles.None;
            txtFname.Font = new Font("Century Gothic", 13F);
            txtFname.ForeColor = Color.Gray;
            txtFname.Location = new Point(196, 183);
            txtFname.Name = "txtFname";
            txtFname.PlaceholderText = "First Name";
            txtFname.Size = new Size(289, 34);
            txtFname.TabIndex = 11;
            txtFname.TextChanged += txtFname_TextChanged;
            // 
            // lblgologin
            // 
            lblgologin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblgologin.AutoSize = true;
            lblgologin.BackColor = SystemColors.ButtonHighlight;
            lblgologin.Font = new Font("Century Gothic", 11F);
            lblgologin.ForeColor = Color.Gray;
            lblgologin.Location = new Point(147, 636);
            lblgologin.Name = "lblgologin";
            lblgologin.Size = new Size(363, 22);
            lblgologin.TabIndex = 23;
            lblgologin.Text = "Already Registered? Click here to login";
            lblgologin.Click += lblgologin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(218, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 133);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblReqFname
            // 
            lblReqFname.Anchor = AnchorStyles.None;
            lblReqFname.AutoSize = true;
            lblReqFname.BackColor = SystemColors.ButtonHighlight;
            lblReqFname.Font = new Font("Century Gothic", 10F);
            lblReqFname.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqFname.Location = new Point(196, 220);
            lblReqFname.Name = "lblReqFname";
            lblReqFname.Size = new Size(166, 21);
            lblReqFname.TabIndex = 28;
            lblReqFname.Text = "This field is required";
            lblReqFname.Visible = false;
            // 
            // lblReqLname
            // 
            lblReqLname.Anchor = AnchorStyles.None;
            lblReqLname.AutoSize = true;
            lblReqLname.BackColor = SystemColors.ButtonHighlight;
            lblReqLname.Font = new Font("Century Gothic", 10F);
            lblReqLname.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqLname.Location = new Point(196, 294);
            lblReqLname.Name = "lblReqLname";
            lblReqLname.Size = new Size(166, 21);
            lblReqLname.TabIndex = 29;
            lblReqLname.Text = "This field is required";
            lblReqLname.Visible = false;
            // 
            // lblReqEmail
            // 
            lblReqEmail.Anchor = AnchorStyles.None;
            lblReqEmail.AutoSize = true;
            lblReqEmail.BackColor = SystemColors.ButtonHighlight;
            lblReqEmail.Font = new Font("Century Gothic", 10F);
            lblReqEmail.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqEmail.Location = new Point(196, 368);
            lblReqEmail.Name = "lblReqEmail";
            lblReqEmail.Size = new Size(166, 21);
            lblReqEmail.TabIndex = 30;
            lblReqEmail.Text = "This field is required";
            lblReqEmail.Visible = false;
            // 
            // lblReqPassword
            // 
            lblReqPassword.Anchor = AnchorStyles.None;
            lblReqPassword.AutoSize = true;
            lblReqPassword.BackColor = SystemColors.ButtonHighlight;
            lblReqPassword.Font = new Font("Century Gothic", 10F);
            lblReqPassword.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqPassword.Location = new Point(196, 442);
            lblReqPassword.Name = "lblReqPassword";
            lblReqPassword.Size = new Size(166, 21);
            lblReqPassword.TabIndex = 31;
            lblReqPassword.Text = "This field is required";
            lblReqPassword.Visible = false;
            // 
            // lblReqSSN
            // 
            lblReqSSN.Anchor = AnchorStyles.None;
            lblReqSSN.AutoSize = true;
            lblReqSSN.BackColor = SystemColors.ButtonHighlight;
            lblReqSSN.Font = new Font("Century Gothic", 10F);
            lblReqSSN.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqSSN.Location = new Point(196, 516);
            lblReqSSN.Name = "lblReqSSN";
            lblReqSSN.Size = new Size(166, 21);
            lblReqSSN.TabIndex = 32;
            lblReqSSN.Text = "This field is required";
            lblReqSSN.Visible = false;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.ButtonHighlight;
            Email.Font = new Font("Century Gothic", 13F);
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(33, 340);
            Email.Name = "Email";
            Email.Size = new Size(71, 25);
            Email.TabIndex = 33;
            Email.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 13F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(33, 192);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 34;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Century Gothic", 13F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(33, 266);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 35;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Century Gothic", 13F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(33, 414);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 36;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Century Gothic", 13F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(33, 488);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 37;
            label4.Text = "SSN";
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 670);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(lblReqSSN);
            Controls.Add(lblReqPassword);
            Controls.Add(lblReqEmail);
            Controls.Add(lblReqLname);
            Controls.Add(lblReqFname);
            Controls.Add(pictureBox1);
            Controls.Add(lblgologin);
            Controls.Add(btnSignUp);
            Controls.Add(txtSsn);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Name = "FormSignUp";
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormSignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtSsn;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtLname;
        private TextBox txtFname;
        private Label lblgologin;
        private PictureBox pictureBox1;
        private Label lblReqFname;
        private Label lblReqLname;
        private Label lblReqEmail;
        private Label lblReqPassword;
        private Label lblReqSSN;
        private Label Email;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}