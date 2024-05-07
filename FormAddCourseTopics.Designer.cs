namespace OnlineExaminationSystem
{
    partial class FormAddCourseTopics
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
            lblReqCourse = new Label();
            Email = new Label();
            txtCourse = new TextBox();
            btnLogIn = new Button();
            btnClose = new Button();
            txtHours = new TextBox();
            label1 = new Label();
            lblReqHours = new Label();
            lblTopic = new Label();
            btnAddTopic = new Button();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            SuspendLayout();
            // 
            // lblReqCourse
            // 
            lblReqCourse.Anchor = AnchorStyles.None;
            lblReqCourse.AutoSize = true;
            lblReqCourse.BackColor = SystemColors.ButtonHighlight;
            lblReqCourse.Font = new Font("Century Gothic", 10F);
            lblReqCourse.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqCourse.Location = new Point(166, 139);
            lblReqCourse.Name = "lblReqCourse";
            lblReqCourse.Size = new Size(166, 21);
            lblReqCourse.TabIndex = 25;
            lblReqCourse.Text = "This field is required";
            lblReqCourse.Visible = false;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.BackColor = SystemColors.ButtonHighlight;
            Email.Font = new Font("Century Gothic", 13F);
            Email.ForeColor = Color.Gray;
            Email.Location = new Point(34, 111);
            Email.Name = "Email";
            Email.Size = new Size(87, 25);
            Email.TabIndex = 24;
            Email.Text = "Course";
            // 
            // txtCourse
            // 
            txtCourse.Anchor = AnchorStyles.None;
            txtCourse.Location = new Point(166, 104);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(204, 32);
            txtCourse.TabIndex = 23;
            txtCourse.TextChanged += txtCourse_TextChanged;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 32, 38);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 13F);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(698, 270);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(108, 45);
            btnLogIn.TabIndex = 26;
            btnLogIn.Text = "Add";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.None;
            btnClose.BackColor = Color.FromArgb(186, 32, 38);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(186, 32, 38);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(186, 32, 38);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 32, 38);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 13F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(78, 270);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(108, 45);
            btnClose.TabIndex = 27;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtHours
            // 
            txtHours.Anchor = AnchorStyles.Right;
            txtHours.Location = new Point(165, 185);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(205, 32);
            txtHours.TabIndex = 28;
            txtHours.TextChanged += txtHours_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 13F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(34, 192);
            label1.Name = "label1";
            label1.Size = new Size(70, 25);
            label1.TabIndex = 29;
            label1.Text = "Hours";
            // 
            // lblReqHours
            // 
            lblReqHours.Anchor = AnchorStyles.None;
            lblReqHours.AutoSize = true;
            lblReqHours.BackColor = SystemColors.ButtonHighlight;
            lblReqHours.Font = new Font("Century Gothic", 10F);
            lblReqHours.ForeColor = Color.FromArgb(186, 32, 38);
            lblReqHours.Location = new Point(165, 220);
            lblReqHours.Name = "lblReqHours";
            lblReqHours.Size = new Size(166, 21);
            lblReqHours.TabIndex = 30;
            lblReqHours.Text = "This field is required";
            lblReqHours.Visible = false;
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.BackColor = SystemColors.ButtonHighlight;
            lblTopic.Font = new Font("Century Gothic", 13F);
            lblTopic.ForeColor = Color.Gray;
            lblTopic.Location = new Point(398, 111);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(70, 25);
            lblTopic.TabIndex = 32;
            lblTopic.Text = "Topic";
            lblTopic.Visible = false;
            // 
            // btnAddTopic
            // 
            btnAddTopic.Anchor = AnchorStyles.None;
            btnAddTopic.BackColor = Color.FromArgb(186, 32, 38);
            btnAddTopic.FlatAppearance.BorderColor = Color.FromArgb(186, 32, 38);
            btnAddTopic.FlatAppearance.BorderSize = 0;
            btnAddTopic.FlatAppearance.MouseDownBackColor = Color.FromArgb(186, 32, 38);
            btnAddTopic.FlatAppearance.MouseOverBackColor = Color.FromArgb(186, 32, 38);
            btnAddTopic.FlatStyle = FlatStyle.Flat;
            btnAddTopic.Font = new Font("Century Gothic", 13F);
            btnAddTopic.ForeColor = Color.White;
            btnAddTopic.Location = new Point(698, 105);
            btnAddTopic.Name = "btnAddTopic";
            btnAddTopic.Size = new Size(167, 40);
            btnAddTopic.TabIndex = 33;
            btnAddTopic.Text = "+ Add Topics";
            btnAddTopic.UseVisualStyleBackColor = false;
            btnAddTopic.Click += btnAddTopic_Click;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(765, 22);
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
            ctrlBox.TabIndex = 34;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // FormAddCourseTopics
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 368);
            Controls.Add(ctrlBox);
            Controls.Add(btnAddTopic);
            Controls.Add(lblTopic);
            Controls.Add(lblReqHours);
            Controls.Add(label1);
            Controls.Add(txtHours);
            Controls.Add(btnClose);
            Controls.Add(btnLogIn);
            Controls.Add(lblReqCourse);
            Controls.Add(Email);
            Controls.Add(txtCourse);
            Name = "FormAddCourseTopics";
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Text = "Add Courses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReqCourse;
        private Label Email;
        private TextBox txtCourse;
        private Button btnLogIn;
        private Button btnClose;
        private TextBox txtHours;
        private Label label1;
        private Label lblReqHours;
        private Label lblTopic;
        private Button btnAddTopic;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
    }
}