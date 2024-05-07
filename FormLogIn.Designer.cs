namespace OnlineExaminationSystem
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogIn = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            lblGoSignUp = new Label();
            Email = new Label();
            label4 = new Label();
            lblReqEmail = new Label();
            lblReqPassword = new Label();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogIn.BackColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 13F);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(162, 340);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(108, 45);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Login";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Right;
            txtEmail.Location = new Point(52, 138);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 34);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Right;
            txtPassword.Location = new Point(52, 261);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(324, 34);
            txtPassword.TabIndex = 1;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(326, 17);
            ctrlBox.MaximizeBox = true;
            ctrlBox.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            ctrlBox.MaximizeHoverForeColor = Color.Gray;
            ctrlBox.MaximizeNormalForeColor = Color.Gray;
            ctrlBox.MinimizeBox = true;
            ctrlBox.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            ctrlBox.MinimizeHoverForeColor = Color.Gray;
            ctrlBox.MinimizeNormalForeColor = Color.Gray;
            ctrlBox.Name = "ctrlBox";
            ctrlBox.Size = new Size(100, 25);
            ctrlBox.Style = MetroSet_UI.Enums.Style.Light;
            ctrlBox.StyleManager = null;
            ctrlBox.TabIndex = 21;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // lblGoSignUp
            // 
            lblGoSignUp.AutoSize = true;
            lblGoSignUp.BackColor = SystemColors.ButtonHighlight;
            lblGoSignUp.Font = new Font("Century Gothic", 11F);
            lblGoSignUp.ForeColor = Color.Gray;
            lblGoSignUp.Location = new Point(36, 409);
            lblGoSignUp.Name = "lblGoSignUp";
            lblGoSignUp.Size = new Size(352, 22);
            lblGoSignUp.TabIndex = 3;
            lblGoSignUp.Text = "Don't have an account yet?  Sign Up";
            lblGoSignUp.Click += lblGoSignUp_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.ButtonHighlight;
            Email.Font = new Font("Century Gothic", 13F);
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(52, 97);
            Email.Name = "Email";
            Email.Size = new Size(71, 25);
            Email.TabIndex = 19;
            Email.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Century Gothic", 13F);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(52, 223);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // lblReqEmail
            // 
            lblReqEmail.AutoSize = true;
            lblReqEmail.BackColor = SystemColors.ButtonHighlight;
            lblReqEmail.Font = new Font("Century Gothic", 10F);
            lblReqEmail.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqEmail.Location = new Point(52, 175);
            lblReqEmail.Name = "lblReqEmail";
            lblReqEmail.Size = new Size(166, 21);
            lblReqEmail.TabIndex = 22;
            lblReqEmail.Text = "This field is required";
            lblReqEmail.Visible = false;
            // 
            // lblReqPassword
            // 
            lblReqPassword.AutoSize = true;
            lblReqPassword.BackColor = SystemColors.ButtonHighlight;
            lblReqPassword.Font = new Font("Century Gothic", 10F);
            lblReqPassword.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqPassword.Location = new Point(52, 298);
            lblReqPassword.Name = "lblReqPassword";
            lblReqPassword.Size = new Size(166, 21);
            lblReqPassword.TabIndex = 23;
            lblReqPassword.Text = "This field is required";
            lblReqPassword.Visible = false;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 476);
            Controls.Add(lblReqPassword);
            Controls.Add(lblReqEmail);
            Controls.Add(lblGoSignUp);
            Controls.Add(ctrlBox);
            Controls.Add(btnLogIn);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Font = new Font("Century Gothic", 13F);
            Name = "FormLogIn";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ITI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lblGoSignUp;
        private Label Email;
        private Label label4;
        private Label lblReqEmail;
        private Label lblReqPassword;
    }
}
