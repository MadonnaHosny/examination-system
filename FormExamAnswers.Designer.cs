namespace OnlineExaminationSystem
{
    partial class FormExamAnswers
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
            components = new System.ComponentModel.Container();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            CrsName = new MetroSet_UI.Controls.MetroSetLabel();
            CourseName = new MetroSet_UI.Controls.MetroSetLabel();
            metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            Marks = new MetroSet_UI.Controls.MetroSetLabel();
            QuestionNumber = new MetroSet_UI.Controls.MetroSetLabel();
            QuesText = new MetroSet_UI.Controls.MetroSetLabel();
            time = new MetroSet_UI.Controls.MetroSetLabel();
            drt = new MetroSet_UI.Controls.MetroSetLabel();
            timerExam = new System.Windows.Forms.Timer(components);
            PrevBtn = new Button();
            NextBtn = new Button();
            BackBtn = new Button();
            Ch1 = new RadioButton();
            Ch2 = new RadioButton();
            Ch3 = new RadioButton();
            SuspendLayout();
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(1024, 9);
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
            ctrlBox.TabIndex = 22;
            ctrlBox.Text = "metroSetControlBox1";
            ctrlBox.ThemeAuthor = "Narwin";
            ctrlBox.ThemeName = "MetroLite";
            // 
            // CrsName
            // 
            CrsName.Font = new Font("Century Gothic", 15F);
            CrsName.IsDerivedStyle = true;
            CrsName.Location = new Point(24, 82);
            CrsName.Name = "CrsName";
            CrsName.Size = new Size(192, 28);
            CrsName.Style = MetroSet_UI.Enums.Style.Light;
            CrsName.StyleManager = null;
            CrsName.TabIndex = 36;
            CrsName.Text = "Course Name:";
            CrsName.ThemeAuthor = "Narwin";
            CrsName.ThemeName = "MetroLite";
            // 
            // CourseName
            // 
            CourseName.Font = new Font("Century Gothic", 15F);
            CourseName.IsDerivedStyle = true;
            CourseName.Location = new Point(228, 82);
            CourseName.Name = "CourseName";
            CourseName.Size = new Size(142, 29);
            CourseName.Style = MetroSet_UI.Enums.Style.Light;
            CourseName.StyleManager = null;
            CourseName.TabIndex = 37;
            CourseName.Text = "Label1";
            CourseName.ThemeAuthor = "Narwin";
            CourseName.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            metroSetLabel4.Font = new Font("Century Gothic", 15F);
            metroSetLabel4.IsDerivedStyle = true;
            metroSetLabel4.Location = new Point(859, 84);
            metroSetLabel4.Name = "metroSetLabel4";
            metroSetLabel4.Size = new Size(98, 37);
            metroSetLabel4.Style = MetroSet_UI.Enums.Style.Light;
            metroSetLabel4.StyleManager = null;
            metroSetLabel4.TabIndex = 40;
            metroSetLabel4.Text = "Marks:";
            metroSetLabel4.ThemeAuthor = "Narwin";
            metroSetLabel4.ThemeName = "MetroLite";
            // 
            // Marks
            // 
            Marks.Font = new Font("Century Gothic", 15F);
            Marks.IsDerivedStyle = true;
            Marks.Location = new Point(963, 84);
            Marks.Name = "Marks";
            Marks.Size = new Size(98, 27);
            Marks.Style = MetroSet_UI.Enums.Style.Light;
            Marks.StyleManager = null;
            Marks.TabIndex = 41;
            Marks.Text = "Label";
            Marks.ThemeAuthor = "Narwin";
            Marks.ThemeName = "MetroLite";
            // 
            // QuestionNumber
            // 
            QuestionNumber.Font = new Font("Century Gothic", 15F);
            QuestionNumber.IsDerivedStyle = true;
            QuestionNumber.Location = new Point(77, 199);
            QuestionNumber.Name = "QuestionNumber";
            QuestionNumber.Size = new Size(78, 35);
            QuestionNumber.Style = MetroSet_UI.Enums.Style.Light;
            QuestionNumber.StyleManager = null;
            QuestionNumber.TabIndex = 42;
            QuestionNumber.Text = "Q";
            QuestionNumber.ThemeAuthor = "Narwin";
            QuestionNumber.ThemeName = "MetroLite";
            // 
            // QuesText
            // 
            QuesText.Font = new Font("Century Gothic", 15F);
            QuesText.IsDerivedStyle = true;
            QuesText.Location = new Point(151, 199);
            QuesText.Name = "QuesText";
            QuesText.Size = new Size(956, 47);
            QuesText.Style = MetroSet_UI.Enums.Style.Light;
            QuesText.StyleManager = null;
            QuesText.TabIndex = 43;
            QuesText.Text = "Q.";
            QuesText.ThemeAuthor = "Narwin";
            QuesText.ThemeName = "MetroLite";
            // 
            // time
            // 
            time.Font = new Font("Century Gothic", 15F);
            time.IsDerivedStyle = true;
            time.Location = new Point(464, 82);
            time.Name = "time";
            time.Size = new Size(143, 27);
            time.Style = MetroSet_UI.Enums.Style.Light;
            time.StyleManager = null;
            time.TabIndex = 50;
            time.Text = "Duration:";
            time.ThemeAuthor = "Narwin";
            time.ThemeName = "MetroLite";
            // 
            // drt
            // 
            drt.Font = new Font("Century Gothic", 15F);
            drt.IsDerivedStyle = true;
            drt.Location = new Point(601, 86);
            drt.Name = "drt";
            drt.Size = new Size(143, 27);
            drt.Style = MetroSet_UI.Enums.Style.Light;
            drt.StyleManager = null;
            drt.TabIndex = 51;
            drt.ThemeAuthor = "Narwin";
            drt.ThemeName = "MetroLite";
            // 
            // PrevBtn
            // 
            PrevBtn.BackColor = Color.FromArgb(186, 32, 38);
            PrevBtn.FlatStyle = FlatStyle.Flat;
            PrevBtn.Font = new Font("Century Gothic", 15F);
            PrevBtn.ForeColor = Color.White;
            PrevBtn.Location = new Point(216, 412);
            PrevBtn.Name = "PrevBtn";
            PrevBtn.Size = new Size(131, 53);
            PrevBtn.TabIndex = 53;
            PrevBtn.Text = "Previous";
            PrevBtn.UseVisualStyleBackColor = false;
            PrevBtn.Click += PrevBtn_Click_2;
            // 
            // NextBtn
            // 
            NextBtn.BackColor = Color.FromArgb(186, 32, 38);
            NextBtn.FlatStyle = FlatStyle.Flat;
            NextBtn.Font = new Font("Century Gothic", 15F);
            NextBtn.ForeColor = Color.White;
            NextBtn.Location = new Point(795, 412);
            NextBtn.Name = "NextBtn";
            NextBtn.Size = new Size(131, 53);
            NextBtn.TabIndex = 54;
            NextBtn.Text = "Next";
            NextBtn.UseVisualStyleBackColor = false;
            NextBtn.Click += NextBtn_Click_2;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.White;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Font = new Font("Century Gothic", 12F);
            BackBtn.ForeColor = Color.FromArgb(186, 32, 38);
            BackBtn.Location = new Point(-2, 6);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(40, 34);
            BackBtn.TabIndex = 55;
            BackBtn.Text = "<<";
            BackBtn.TextAlign = ContentAlignment.MiddleRight;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click_1;
            // 
            // Ch1
            // 
            Ch1.AutoSize = true;
            Ch1.BackColor = Color.White;
            Ch1.Font = new Font("Century Gothic", 15F);
            Ch1.Location = new Point(108, 303);
            Ch1.Name = "Ch1";
            Ch1.Size = new Size(189, 35);
            Ch1.TabIndex = 56;
            Ch1.TabStop = true;
            Ch1.Text = "radioButton1";
            Ch1.UseVisualStyleBackColor = false;
            // 
            // Ch2
            // 
            Ch2.AutoSize = true;
            Ch2.BackColor = Color.White;
            Ch2.Font = new Font("Century Gothic", 15F);
            Ch2.Location = new Point(485, 303);
            Ch2.Name = "Ch2";
            Ch2.Size = new Size(189, 35);
            Ch2.TabIndex = 57;
            Ch2.TabStop = true;
            Ch2.Text = "radioButton1";
            Ch2.UseVisualStyleBackColor = false;
            // 
            // Ch3
            // 
            Ch3.AutoSize = true;
            Ch3.BackColor = Color.White;
            Ch3.Font = new Font("Century Gothic", 15F);
            Ch3.ForeColor = Color.Gray;
            Ch3.Location = new Point(862, 303);
            Ch3.Name = "Ch3";
            Ch3.Size = new Size(189, 35);
            Ch3.TabIndex = 58;
            Ch3.TabStop = true;
            Ch3.Text = "radioButton1";
            Ch3.UseVisualStyleBackColor = false;
            // 
            // FormExamAnswers
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1139, 500);
            Controls.Add(Ch3);
            Controls.Add(Ch2);
            Controls.Add(Ch1);
            Controls.Add(BackBtn);
            Controls.Add(NextBtn);
            Controls.Add(PrevBtn);
            Controls.Add(drt);
            Controls.Add(time);
            Controls.Add(QuesText);
            Controls.Add(QuestionNumber);
            Controls.Add(Marks);
            Controls.Add(metroSetLabel4);
            Controls.Add(CourseName);
            Controls.Add(CrsName);
            Controls.Add(ctrlBox);
            Font = new Font("Century Gothic", 13F);
            Name = "FormExamAnswers";
            Padding = new Padding(12, 74, 12, 13);
            SmallLineColor1 = Color.Transparent;
            SmallLineColor2 = Color.White;
            FormClosing += FormExamAnswers_FormClosing;
            Load += FormExamAnswers_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label Duration;
        private Label drtaion;
        private MetroSet_UI.Controls.MetroSetLabel CourseName;
        private MetroSet_UI.Controls.MetroSetLabel C;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel Marks;
        private MetroSet_UI.Controls.MetroSetLabel QuestionNumber;
        private MetroSet_UI.Controls.MetroSetLabel QuesText;
        private MetroSet_UI.Controls.MetroSetLabel time;
        private MetroSet_UI.Controls.MetroSetLabel drt;
        private MetroSet_UI.Controls.MetroSetLabel CrsName;
        private System.Windows.Forms.Timer timerExam;
        private Button PrevBtn;
        private Button NextBtn;
        private Button BackBtn;
        private RadioButton Ch1;
        private RadioButton Ch2;
        private RadioButton Ch3;
    }
}