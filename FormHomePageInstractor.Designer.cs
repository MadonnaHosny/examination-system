namespace OnlineExaminationSystem
{
    partial class FormHomePageInstractor
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
            lblAssignCourseStudentD = new TabControl();
            tabPage1 = new TabPage();
            lblAssignCourseStudentQ = new Label();
            lblStudentC = new Label();
            comboStudentC = new ComboBox();
            lblInstructorC = new Label();
            comboInstructorC = new ComboBox();
            btnAssignCourse = new Button();
            label1 = new Label();
            comboCourses = new ComboBox();
            tabPage2 = new TabPage();
            lblAssignDepartmentStudentQ = new Label();
            lblStudentD = new Label();
            comboStudentD = new ComboBox();
            lblInstructorD = new Label();
            comboInstructorDep = new ComboBox();
            btnAssignDepartment = new Button();
            label4 = new Label();
            comboDepartment = new ComboBox();
            tabPage3 = new TabPage();
            btn_AddQuestionSave = new Button();
            lb_Answer3 = new Label();
            lb_Answer2 = new Label();
            lb_Answer1 = new Label();
            txt_MCQ_Answer1 = new TextBox();
            txt_MCQ_Answer3 = new TextBox();
            txt_MCQ_Answer2 = new TextBox();
            lb_ModelAnswer = new Label();
            cmb_ModelAnswer = new ComboBox();
            Rh_QuestionText = new RichTextBox();
            lb_QuestionText = new Label();
            lb_Mark = new Label();
            numMark = new NumericUpDown();
            cmbComplexity = new ComboBox();
            lb_Complexity = new Label();
            cmbType = new ComboBox();
            lb_Type = new Label();
            cmbCourses = new ComboBox();
            lb_Course = new Label();
            tabPage4 = new TabPage();
            btn_generateExam = new Button();
            lb_date = new Label();
            lb_Duration = new Label();
            numeric_Duration = new NumericUpDown();
            DateTimeForExam = new MonthCalendar();
            numeric_MCQ_Questions = new NumericUpDown();
            label3 = new Label();
            numeric_TFQuestions = new NumericUpDown();
            lb_numOfTFQuestions = new Label();
            cmb_Courses = new ComboBox();
            lbCourses = new Label();
            tabPage5 = new TabPage();
            lstTopics = new MetroSet_UI.Controls.MetroSetListBox();
            btnNewCourse = new Button();
            button1 = new Button();
            label2 = new Label();
            comboCorsesesForTopics = new ComboBox();
            tabPage6 = new TabPage();
            btn_Search_Grades = new Button();
            grd_StudentsGrades = new DataGridView();
            cmb_Course_Grades = new ComboBox();
            label5 = new Label();
            tabPage7 = new TabPage();
            btn_Save_Dept = new Button();
            cmb_Mgr = new ComboBox();
            label6 = new Label();
            lb_DeptName = new Label();
            txt_DeptName = new TextBox();
            ctrlBox = new MetroSet_UI.Controls.MetroSetControlBox();
            btnSignOut = new Button();
            lblAssignCourseStudentD.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Duration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_MCQ_Questions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_TFQuestions).BeginInit();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grd_StudentsGrades).BeginInit();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // lblAssignCourseStudentD
            // 
            lblAssignCourseStudentD.Controls.Add(tabPage1);
            lblAssignCourseStudentD.Controls.Add(tabPage2);
            lblAssignCourseStudentD.Controls.Add(tabPage3);
            lblAssignCourseStudentD.Controls.Add(tabPage4);
            lblAssignCourseStudentD.Controls.Add(tabPage5);
            lblAssignCourseStudentD.Controls.Add(tabPage6);
            lblAssignCourseStudentD.Controls.Add(tabPage7);
            lblAssignCourseStudentD.Location = new Point(15, 70);
            lblAssignCourseStudentD.Name = "lblAssignCourseStudentD";
            lblAssignCourseStudentD.SelectedIndex = 0;
            lblAssignCourseStudentD.Size = new Size(1045, 530);
            lblAssignCourseStudentD.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblAssignCourseStudentQ);
            tabPage1.Controls.Add(lblStudentC);
            tabPage1.Controls.Add(comboStudentC);
            tabPage1.Controls.Add(lblInstructorC);
            tabPage1.Controls.Add(comboInstructorC);
            tabPage1.Controls.Add(btnAssignCourse);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboCourses);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1037, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Assign Course";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAssignCourseStudentQ
            // 
            lblAssignCourseStudentQ.AutoSize = true;
            lblAssignCourseStudentQ.BackColor = SystemColors.ButtonHighlight;
            lblAssignCourseStudentQ.Font = new Font("Century Gothic", 15F);
            lblAssignCourseStudentQ.ForeColor = Color.Black;
            lblAssignCourseStudentQ.Location = new Point(640, 445);
            lblAssignCourseStudentQ.Name = "lblAssignCourseStudentQ";
            lblAssignCourseStudentQ.Size = new Size(335, 31);
            lblAssignCourseStudentQ.TabIndex = 10;
            lblAssignCourseStudentQ.Text = "Assign Course for Student?";
            lblAssignCourseStudentQ.Click += lblAssignCourse_Click;
            // 
            // lblStudentC
            // 
            lblStudentC.AutoSize = true;
            lblStudentC.BackColor = SystemColors.ButtonHighlight;
            lblStudentC.ForeColor = Color.Gray;
            lblStudentC.Location = new Point(413, 84);
            lblStudentC.Name = "lblStudentC";
            lblStudentC.Size = new Size(167, 25);
            lblStudentC.TabIndex = 9;
            lblStudentC.Text = "Select Student";
            lblStudentC.Visible = false;
            // 
            // comboStudentC
            // 
            comboStudentC.FormattingEnabled = true;
            comboStudentC.Location = new Point(256, 137);
            comboStudentC.Name = "comboStudentC";
            comboStudentC.Size = new Size(479, 33);
            comboStudentC.TabIndex = 8;
            comboStudentC.Visible = false;
            // 
            // lblInstructorC
            // 
            lblInstructorC.AutoSize = true;
            lblInstructorC.BackColor = SystemColors.ButtonHighlight;
            lblInstructorC.ForeColor = Color.Gray;
            lblInstructorC.Location = new Point(413, 84);
            lblInstructorC.Name = "lblInstructorC";
            lblInstructorC.Size = new Size(184, 25);
            lblInstructorC.TabIndex = 7;
            lblInstructorC.Text = "Select Instructor";
            // 
            // comboInstructorC
            // 
            comboInstructorC.FormattingEnabled = true;
            comboInstructorC.Location = new Point(266, 137);
            comboInstructorC.Name = "comboInstructorC";
            comboInstructorC.Size = new Size(469, 33);
            comboInstructorC.TabIndex = 6;
            // 
            // btnAssignCourse
            // 
            btnAssignCourse.BackColor = Color.FromArgb(186, 32, 38);
            btnAssignCourse.FlatStyle = FlatStyle.Flat;
            btnAssignCourse.ForeColor = Color.White;
            btnAssignCourse.Location = new Point(398, 370);
            btnAssignCourse.Name = "btnAssignCourse";
            btnAssignCourse.Size = new Size(225, 50);
            btnAssignCourse.TabIndex = 5;
            btnAssignCourse.Text = "Assign Course";
            btnAssignCourse.UseVisualStyleBackColor = false;
            btnAssignCourse.Click += btnAssignCourse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(420, 242);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 4;
            label1.Text = "Select Course";
            // 
            // comboCourses
            // 
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(256, 287);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(479, 33);
            comboCourses.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblAssignDepartmentStudentQ);
            tabPage2.Controls.Add(lblStudentD);
            tabPage2.Controls.Add(comboStudentD);
            tabPage2.Controls.Add(lblInstructorD);
            tabPage2.Controls.Add(comboInstructorDep);
            tabPage2.Controls.Add(btnAssignDepartment);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comboDepartment);
            tabPage2.Location = new Point(4, 35);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1037, 491);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Assign Department";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblAssignDepartmentStudentQ
            // 
            lblAssignDepartmentStudentQ.AutoSize = true;
            lblAssignDepartmentStudentQ.BackColor = SystemColors.ButtonHighlight;
            lblAssignDepartmentStudentQ.Font = new Font("Century Gothic", 15F);
            lblAssignDepartmentStudentQ.ForeColor = Color.Black;
            lblAssignDepartmentStudentQ.Location = new Point(590, 446);
            lblAssignDepartmentStudentQ.Name = "lblAssignDepartmentStudentQ";
            lblAssignDepartmentStudentQ.Size = new Size(398, 31);
            lblAssignDepartmentStudentQ.TabIndex = 15;
            lblAssignDepartmentStudentQ.Text = "Assign Department for Student?";
            lblAssignDepartmentStudentQ.Click += label2_Click;
            // 
            // lblStudentD
            // 
            lblStudentD.AutoSize = true;
            lblStudentD.BackColor = SystemColors.ButtonHighlight;
            lblStudentD.ForeColor = Color.Gray;
            lblStudentD.Location = new Point(421, 74);
            lblStudentD.Name = "lblStudentD";
            lblStudentD.Size = new Size(167, 25);
            lblStudentD.TabIndex = 14;
            lblStudentD.Text = "Select Student";
            lblStudentD.Visible = false;
            // 
            // comboStudentD
            // 
            comboStudentD.FormattingEnabled = true;
            comboStudentD.Location = new Point(264, 135);
            comboStudentD.Name = "comboStudentD";
            comboStudentD.Size = new Size(490, 33);
            comboStudentD.TabIndex = 13;
            comboStudentD.Visible = false;
            // 
            // lblInstructorD
            // 
            lblInstructorD.AutoSize = true;
            lblInstructorD.BackColor = SystemColors.ButtonHighlight;
            lblInstructorD.ForeColor = Color.Gray;
            lblInstructorD.Location = new Point(421, 74);
            lblInstructorD.Name = "lblInstructorD";
            lblInstructorD.Size = new Size(184, 25);
            lblInstructorD.TabIndex = 12;
            lblInstructorD.Text = "Select Instructor";
            // 
            // comboInstructorDep
            // 
            comboInstructorDep.FormattingEnabled = true;
            comboInstructorDep.Location = new Point(264, 135);
            comboInstructorDep.Name = "comboInstructorDep";
            comboInstructorDep.Size = new Size(490, 33);
            comboInstructorDep.TabIndex = 11;
            // 
            // btnAssignDepartment
            // 
            btnAssignDepartment.BackColor = Color.FromArgb(186, 32, 38);
            btnAssignDepartment.FlatStyle = FlatStyle.Flat;
            btnAssignDepartment.ForeColor = Color.White;
            btnAssignDepartment.Location = new Point(392, 361);
            btnAssignDepartment.Name = "btnAssignDepartment";
            btnAssignDepartment.Size = new Size(236, 40);
            btnAssignDepartment.TabIndex = 10;
            btnAssignDepartment.Text = "Assign Department";
            btnAssignDepartment.UseVisualStyleBackColor = false;
            btnAssignDepartment.Click += btnAssignDepartment_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(411, 233);
            label4.Name = "label4";
            label4.Size = new Size(217, 25);
            label4.TabIndex = 9;
            label4.Text = "Select Department";
            // 
            // comboDepartment
            // 
            comboDepartment.FormattingEnabled = true;
            comboDepartment.Location = new Point(264, 286);
            comboDepartment.Name = "comboDepartment";
            comboDepartment.Size = new Size(490, 33);
            comboDepartment.TabIndex = 8;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btn_AddQuestionSave);
            tabPage3.Controls.Add(lb_Answer3);
            tabPage3.Controls.Add(lb_Answer2);
            tabPage3.Controls.Add(lb_Answer1);
            tabPage3.Controls.Add(txt_MCQ_Answer1);
            tabPage3.Controls.Add(txt_MCQ_Answer3);
            tabPage3.Controls.Add(txt_MCQ_Answer2);
            tabPage3.Controls.Add(lb_ModelAnswer);
            tabPage3.Controls.Add(cmb_ModelAnswer);
            tabPage3.Controls.Add(Rh_QuestionText);
            tabPage3.Controls.Add(lb_QuestionText);
            tabPage3.Controls.Add(lb_Mark);
            tabPage3.Controls.Add(numMark);
            tabPage3.Controls.Add(cmbComplexity);
            tabPage3.Controls.Add(lb_Complexity);
            tabPage3.Controls.Add(cmbType);
            tabPage3.Controls.Add(lb_Type);
            tabPage3.Controls.Add(cmbCourses);
            tabPage3.Controls.Add(lb_Course);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1037, 492);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Add Questions";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_AddQuestionSave
            // 
            btn_AddQuestionSave.BackColor = Color.FromArgb(186, 32, 38);
            btn_AddQuestionSave.ForeColor = Color.White;
            btn_AddQuestionSave.Location = new Point(718, 385);
            btn_AddQuestionSave.Name = "btn_AddQuestionSave";
            btn_AddQuestionSave.Size = new Size(229, 50);
            btn_AddQuestionSave.TabIndex = 54;
            btn_AddQuestionSave.Text = "Save";
            btn_AddQuestionSave.UseVisualStyleBackColor = false;
            btn_AddQuestionSave.Click += btn_AddQuestionSave_Click;
            // 
            // lb_Answer3
            // 
            lb_Answer3.AutoSize = true;
            lb_Answer3.BackColor = SystemColors.ButtonHighlight;
            lb_Answer3.Font = new Font("Century Gothic", 13F);
            lb_Answer3.ForeColor = Color.Gray;
            lb_Answer3.Location = new Point(733, 278);
            lb_Answer3.Name = "lb_Answer3";
            lb_Answer3.Size = new Size(176, 25);
            lb_Answer3.TabIndex = 53;
            lb_Answer3.Text = "MCQ Answer 3";
            // 
            // lb_Answer2
            // 
            lb_Answer2.AutoSize = true;
            lb_Answer2.BackColor = SystemColors.ButtonHighlight;
            lb_Answer2.Font = new Font("Century Gothic", 13F);
            lb_Answer2.ForeColor = Color.Gray;
            lb_Answer2.Location = new Point(409, 278);
            lb_Answer2.Name = "lb_Answer2";
            lb_Answer2.Size = new Size(176, 25);
            lb_Answer2.TabIndex = 52;
            lb_Answer2.Text = "MCQ Answer 2";
            // 
            // lb_Answer1
            // 
            lb_Answer1.AutoSize = true;
            lb_Answer1.BackColor = SystemColors.ButtonHighlight;
            lb_Answer1.Font = new Font("Century Gothic", 13F);
            lb_Answer1.ForeColor = Color.Gray;
            lb_Answer1.Location = new Point(99, 278);
            lb_Answer1.Name = "lb_Answer1";
            lb_Answer1.Size = new Size(176, 25);
            lb_Answer1.TabIndex = 51;
            lb_Answer1.Text = "MCQ Answer 1";
            // 
            // txt_MCQ_Answer1
            // 
            txt_MCQ_Answer1.Location = new Point(58, 319);
            txt_MCQ_Answer1.Name = "txt_MCQ_Answer1";
            txt_MCQ_Answer1.Size = new Size(252, 34);
            txt_MCQ_Answer1.TabIndex = 50;
            // 
            // txt_MCQ_Answer3
            // 
            txt_MCQ_Answer3.Location = new Point(695, 319);
            txt_MCQ_Answer3.Name = "txt_MCQ_Answer3";
            txt_MCQ_Answer3.Size = new Size(252, 34);
            txt_MCQ_Answer3.TabIndex = 49;
            // 
            // txt_MCQ_Answer2
            // 
            txt_MCQ_Answer2.Location = new Point(370, 319);
            txt_MCQ_Answer2.Name = "txt_MCQ_Answer2";
            txt_MCQ_Answer2.Size = new Size(252, 34);
            txt_MCQ_Answer2.TabIndex = 48;
            // 
            // lb_ModelAnswer
            // 
            lb_ModelAnswer.AutoSize = true;
            lb_ModelAnswer.BackColor = SystemColors.ButtonHighlight;
            lb_ModelAnswer.Font = new Font("Century Gothic", 13F);
            lb_ModelAnswer.ForeColor = Color.Gray;
            lb_ModelAnswer.Location = new Point(75, 402);
            lb_ModelAnswer.Name = "lb_ModelAnswer";
            lb_ModelAnswer.Size = new Size(170, 25);
            lb_ModelAnswer.TabIndex = 47;
            lb_ModelAnswer.Text = "Model Answer";
            // 
            // cmb_ModelAnswer
            // 
            cmb_ModelAnswer.FormattingEnabled = true;
            cmb_ModelAnswer.Location = new Point(284, 402);
            cmb_ModelAnswer.Name = "cmb_ModelAnswer";
            cmb_ModelAnswer.Size = new Size(363, 33);
            cmb_ModelAnswer.TabIndex = 46;
            // 
            // Rh_QuestionText
            // 
            Rh_QuestionText.BackColor = Color.White;
            Rh_QuestionText.Location = new Point(511, 84);
            Rh_QuestionText.Name = "Rh_QuestionText";
            Rh_QuestionText.Size = new Size(436, 148);
            Rh_QuestionText.TabIndex = 45;
            Rh_QuestionText.Text = "";
            // 
            // lb_QuestionText
            // 
            lb_QuestionText.AutoSize = true;
            lb_QuestionText.BackColor = SystemColors.ButtonHighlight;
            lb_QuestionText.Font = new Font("Century Gothic", 13F);
            lb_QuestionText.ForeColor = Color.Gray;
            lb_QuestionText.Location = new Point(511, 39);
            lb_QuestionText.Name = "lb_QuestionText";
            lb_QuestionText.Size = new Size(156, 25);
            lb_QuestionText.TabIndex = 44;
            lb_QuestionText.Text = "Question Text";
            // 
            // lb_Mark
            // 
            lb_Mark.AutoSize = true;
            lb_Mark.BackColor = SystemColors.ButtonHighlight;
            lb_Mark.Font = new Font("Century Gothic", 13F);
            lb_Mark.ForeColor = Color.Gray;
            lb_Mark.Location = new Point(41, 207);
            lb_Mark.Name = "lb_Mark";
            lb_Mark.Size = new Size(168, 25);
            lb_Mark.TabIndex = 43;
            lb_Mark.Text = "Question Mark";
            // 
            // numMark
            // 
            numMark.Location = new Point(297, 198);
            numMark.Name = "numMark";
            numMark.Size = new Size(150, 34);
            numMark.TabIndex = 42;
            // 
            // cmbComplexity
            // 
            cmbComplexity.FormattingEnabled = true;
            cmbComplexity.Location = new Point(296, 145);
            cmbComplexity.Name = "cmbComplexity";
            cmbComplexity.Size = new Size(151, 33);
            cmbComplexity.TabIndex = 41;
            // 
            // lb_Complexity
            // 
            lb_Complexity.AutoSize = true;
            lb_Complexity.BackColor = SystemColors.ButtonHighlight;
            lb_Complexity.Font = new Font("Century Gothic", 13F);
            lb_Complexity.ForeColor = Color.Gray;
            lb_Complexity.Location = new Point(41, 153);
            lb_Complexity.Name = "lb_Complexity";
            lb_Complexity.Size = new Size(237, 25);
            lb_Complexity.TabIndex = 40;
            lb_Complexity.Text = "Question Complexity";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(295, 92);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 33);
            cmbType.TabIndex = 39;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // lb_Type
            // 
            lb_Type.AutoSize = true;
            lb_Type.BackColor = SystemColors.ButtonHighlight;
            lb_Type.Font = new Font("Century Gothic", 13F);
            lb_Type.ForeColor = Color.Gray;
            lb_Type.Location = new Point(41, 100);
            lb_Type.Name = "lb_Type";
            lb_Type.Size = new Size(165, 25);
            lb_Type.TabIndex = 38;
            lb_Type.Text = "Question Type";
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(295, 39);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(151, 33);
            cmbCourses.TabIndex = 37;
            // 
            // lb_Course
            // 
            lb_Course.AutoSize = true;
            lb_Course.BackColor = SystemColors.ButtonHighlight;
            lb_Course.Font = new Font("Century Gothic", 13F);
            lb_Course.ForeColor = Color.Gray;
            lb_Course.Location = new Point(41, 39);
            lb_Course.Name = "lb_Course";
            lb_Course.Size = new Size(87, 25);
            lb_Course.TabIndex = 36;
            lb_Course.Text = "Course";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(btn_generateExam);
            tabPage4.Controls.Add(lb_date);
            tabPage4.Controls.Add(lb_Duration);
            tabPage4.Controls.Add(numeric_Duration);
            tabPage4.Controls.Add(DateTimeForExam);
            tabPage4.Controls.Add(numeric_MCQ_Questions);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(numeric_TFQuestions);
            tabPage4.Controls.Add(lb_numOfTFQuestions);
            tabPage4.Controls.Add(cmb_Courses);
            tabPage4.Controls.Add(lbCourses);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1037, 492);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Generate Exam";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_generateExam
            // 
            btn_generateExam.BackColor = Color.FromArgb(186, 32, 38);
            btn_generateExam.ForeColor = Color.White;
            btn_generateExam.Location = new Point(36, 399);
            btn_generateExam.Name = "btn_generateExam";
            btn_generateExam.Size = new Size(228, 59);
            btn_generateExam.TabIndex = 42;
            btn_generateExam.Text = "Generate";
            btn_generateExam.UseVisualStyleBackColor = false;
            btn_generateExam.Click += btn_generateExam_Click;
            // 
            // lb_date
            // 
            lb_date.AutoSize = true;
            lb_date.Location = new Point(36, 251);
            lb_date.Name = "lb_date";
            lb_date.Size = new Size(219, 25);
            lb_date.TabIndex = 41;
            lb_date.Text = "Choose Exam Date";
            // 
            // lb_Duration
            // 
            lb_Duration.AutoSize = true;
            lb_Duration.Location = new Point(36, 203);
            lb_Duration.Name = "lb_Duration";
            lb_Duration.Size = new Size(342, 25);
            lb_Duration.TabIndex = 40;
            lb_Duration.Text = "Choose Exam Duration in (Min)";
            // 
            // numeric_Duration
            // 
            numeric_Duration.Location = new Point(715, 194);
            numeric_Duration.Maximum = new decimal(new int[] { 1800, 0, 0, 0 });
            numeric_Duration.Name = "numeric_Duration";
            numeric_Duration.Size = new Size(216, 34);
            numeric_Duration.TabIndex = 39;
            // 
            // DateTimeForExam
            // 
            DateTimeForExam.Location = new Point(669, 251);
            DateTimeForExam.Name = "DateTimeForExam";
            DateTimeForExam.TabIndex = 38;
            // 
            // numeric_MCQ_Questions
            // 
            numeric_MCQ_Questions.Location = new Point(715, 140);
            numeric_MCQ_Questions.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numeric_MCQ_Questions.Name = "numeric_MCQ_Questions";
            numeric_MCQ_Questions.Size = new Size(216, 34);
            numeric_MCQ_Questions.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 149);
            label3.Name = "label3";
            label3.Size = new Size(588, 25);
            label3.TabIndex = 36;
            label3.Text = "Choose Number of MCQ Questions (7 Questions Max)";
            // 
            // numeric_TFQuestions
            // 
            numeric_TFQuestions.Location = new Point(715, 84);
            numeric_TFQuestions.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numeric_TFQuestions.Name = "numeric_TFQuestions";
            numeric_TFQuestions.Size = new Size(216, 34);
            numeric_TFQuestions.TabIndex = 35;
            // 
            // lb_numOfTFQuestions
            // 
            lb_numOfTFQuestions.AutoSize = true;
            lb_numOfTFQuestions.Location = new Point(36, 93);
            lb_numOfTFQuestions.Name = "lb_numOfTFQuestions";
            lb_numOfTFQuestions.Size = new Size(560, 25);
            lb_numOfTFQuestions.TabIndex = 34;
            lb_numOfTFQuestions.Text = "Choose Number of T/F Questions (3 Questions Max)";
            // 
            // cmb_Courses
            // 
            cmb_Courses.Font = new Font("Century Gothic", 11F);
            cmb_Courses.FormattingEnabled = true;
            cmb_Courses.Location = new Point(715, 33);
            cmb_Courses.Name = "cmb_Courses";
            cmb_Courses.Size = new Size(216, 29);
            cmb_Courses.TabIndex = 33;
            cmb_Courses.Text = "You have no courses";
            // 
            // lbCourses
            // 
            lbCourses.AutoSize = true;
            lbCourses.Location = new Point(36, 41);
            lbCourses.Name = "lbCourses";
            lbCourses.Size = new Size(248, 25);
            lbCourses.TabIndex = 32;
            lbCourses.Text = "Choose Course Name";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lstTopics);
            tabPage5.Controls.Add(btnNewCourse);
            tabPage5.Controls.Add(button1);
            tabPage5.Controls.Add(label2);
            tabPage5.Controls.Add(comboCorsesesForTopics);
            tabPage5.Location = new Point(4, 35);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1037, 491);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Show Courses";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // lstTopics
            // 
            lstTopics.BackColor = Color.White;
            lstTopics.BorderColor = Color.LightGray;
            lstTopics.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstTopics.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstTopics.Font = new Font("Microsoft Sans Serif", 10F);
            lstTopics.HoveredItemBackColor = Color.LightGray;
            lstTopics.HoveredItemColor = Color.DimGray;
            lstTopics.IsDerivedStyle = true;
            lstTopics.ItemHeight = 30;
            lstTopics.Location = new Point(710, 73);
            lstTopics.MultiSelect = false;
            lstTopics.Name = "lstTopics";
            lstTopics.SelectedIndex = -1;
            lstTopics.SelectedItem = null;
            lstTopics.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstTopics.SelectedItemColor = Color.White;
            lstTopics.SelectedText = null;
            lstTopics.SelectedValue = null;
            lstTopics.ShowBorder = false;
            lstTopics.ShowScrollBar = false;
            lstTopics.Size = new Size(206, 233);
            lstTopics.Style = MetroSet_UI.Enums.Style.Light;
            lstTopics.StyleManager = null;
            lstTopics.TabIndex = 30;
            lstTopics.ThemeAuthor = "Narwin";
            lstTopics.ThemeName = "MetroLite";
            lstTopics.SelectedIndexChanged += lstTopics_SelectedIndexChanged;
            // 
            // btnNewCourse
            // 
            btnNewCourse.BackColor = Color.FromArgb(186, 32, 38);
            btnNewCourse.FlatStyle = FlatStyle.Flat;
            btnNewCourse.ForeColor = Color.White;
            btnNewCourse.Location = new Point(710, 386);
            btnNewCourse.Name = "btnNewCourse";
            btnNewCourse.Size = new Size(206, 42);
            btnNewCourse.TabIndex = 29;
            btnNewCourse.Text = "Add New Course";
            btnNewCourse.UseVisualStyleBackColor = false;
            btnNewCourse.Click += btnNewCourse_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(186, 32, 38);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(93, 386);
            button1.Name = "button1";
            button1.Size = new Size(200, 42);
            button1.TabIndex = 28;
            button1.Text = "Show topics";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(153, 103);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 27;
            label2.Text = "Select Course";
            // 
            // comboCorsesesForTopics
            // 
            comboCorsesesForTopics.FormattingEnabled = true;
            comboCorsesesForTopics.Location = new Point(53, 168);
            comboCorsesesForTopics.Name = "comboCorsesesForTopics";
            comboCorsesesForTopics.Size = new Size(349, 33);
            comboCorsesesForTopics.TabIndex = 26;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(btn_Search_Grades);
            tabPage6.Controls.Add(grd_StudentsGrades);
            tabPage6.Controls.Add(cmb_Course_Grades);
            tabPage6.Controls.Add(label5);
            tabPage6.Location = new Point(4, 35);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1037, 491);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Students Grades";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // btn_Search_Grades
            // 
            btn_Search_Grades.BackColor = Color.FromArgb(186, 32, 38);
            btn_Search_Grades.ForeColor = Color.White;
            btn_Search_Grades.Location = new Point(779, 427);
            btn_Search_Grades.Name = "btn_Search_Grades";
            btn_Search_Grades.Size = new Size(228, 59);
            btn_Search_Grades.TabIndex = 30;
            btn_Search_Grades.Text = "Search";
            btn_Search_Grades.UseVisualStyleBackColor = false;
            btn_Search_Grades.Click += btn_Search_Grades_Click;
            // 
            // grd_StudentsGrades
            // 
            grd_StudentsGrades.AllowUserToAddRows = false;
            grd_StudentsGrades.AllowUserToDeleteRows = false;
            grd_StudentsGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_StudentsGrades.Location = new Point(44, 85);
            grd_StudentsGrades.Name = "grd_StudentsGrades";
            grd_StudentsGrades.ReadOnly = true;
            grd_StudentsGrades.RowHeadersWidth = 51;
            grd_StudentsGrades.Size = new Size(963, 321);
            grd_StudentsGrades.TabIndex = 29;
            // 
            // cmb_Course_Grades
            // 
            cmb_Course_Grades.FormattingEnabled = true;
            cmb_Course_Grades.Location = new Point(587, 32);
            cmb_Course_Grades.Name = "cmb_Course_Grades";
            cmb_Course_Grades.Size = new Size(334, 33);
            cmb_Course_Grades.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(75, 35);
            label5.Name = "label5";
            label5.Size = new Size(248, 25);
            label5.TabIndex = 27;
            label5.Text = "Choose Course Name";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(btn_Save_Dept);
            tabPage7.Controls.Add(cmb_Mgr);
            tabPage7.Controls.Add(label6);
            tabPage7.Controls.Add(lb_DeptName);
            tabPage7.Controls.Add(txt_DeptName);
            tabPage7.Location = new Point(4, 35);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1037, 491);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Add Department";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // btn_Save_Dept
            // 
            btn_Save_Dept.BackColor = Color.FromArgb(186, 32, 38);
            btn_Save_Dept.ForeColor = Color.White;
            btn_Save_Dept.Location = new Point(379, 287);
            btn_Save_Dept.Name = "btn_Save_Dept";
            btn_Save_Dept.Size = new Size(228, 59);
            btn_Save_Dept.TabIndex = 52;
            btn_Save_Dept.Text = "Save";
            btn_Save_Dept.UseVisualStyleBackColor = false;
            btn_Save_Dept.Click += btn_Save_Dept_Click;
            // 
            // cmb_Mgr
            // 
            cmb_Mgr.FormattingEnabled = true;
            cmb_Mgr.Location = new Point(525, 165);
            cmb_Mgr.Name = "cmb_Mgr";
            cmb_Mgr.Size = new Size(363, 33);
            cmb_Mgr.TabIndex = 51;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Font = new Font("Century Gothic", 13F);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(116, 168);
            label6.Name = "label6";
            label6.Size = new Size(252, 25);
            label6.TabIndex = 50;
            label6.Text = "Department Manager";
            // 
            // lb_DeptName
            // 
            lb_DeptName.AutoSize = true;
            lb_DeptName.BackColor = SystemColors.ButtonHighlight;
            lb_DeptName.Font = new Font("Century Gothic", 13F);
            lb_DeptName.ForeColor = Color.Gray;
            lb_DeptName.Location = new Point(116, 90);
            lb_DeptName.Name = "lb_DeptName";
            lb_DeptName.Size = new Size(217, 25);
            lb_DeptName.TabIndex = 49;
            lb_DeptName.Text = "Department Name";
            // 
            // txt_DeptName
            // 
            txt_DeptName.Location = new Point(525, 90);
            txt_DeptName.Name = "txt_DeptName";
            txt_DeptName.Size = new Size(363, 34);
            txt_DeptName.TabIndex = 48;
            // 
            // ctrlBox
            // 
            ctrlBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ctrlBox.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            ctrlBox.CloseHoverForeColor = Color.White;
            ctrlBox.CloseNormalForeColor = Color.Gray;
            ctrlBox.DisabledForeColor = Color.DimGray;
            ctrlBox.IsDerivedStyle = true;
            ctrlBox.Location = new Point(979, 7);
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
            // btnSignOut
            // 
            btnSignOut.BackColor = Color.White;
            btnSignOut.FlatAppearance.BorderSize = 0;
            btnSignOut.FlatStyle = FlatStyle.Flat;
            btnSignOut.ForeColor = Color.FromArgb(186, 32, 38);
            btnSignOut.Location = new Point(19, 24);
            btnSignOut.Name = "btnSignOut";
            btnSignOut.Size = new Size(200, 40);
            btnSignOut.TabIndex = 23;
            btnSignOut.Text = "Sign Out?";
            btnSignOut.UseVisualStyleBackColor = false;
            btnSignOut.Click += btnSignOut_Click;
            // 
            // FormHomePageInstractor
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 646);
            Controls.Add(btnSignOut);
            Controls.Add(ctrlBox);
            Controls.Add(lblAssignCourseStudentD);
            Font = new Font("Century Gothic", 13F);
            Name = "FormHomePageInstractor";
            Padding = new Padding(12, 67, 12, 12);
            SmallLineColor1 = Color.FromArgb(186, 32, 38);
            SmallLineColor2 = Color.FromArgb(186, 32, 38);
            Load += FormHomePageInstractor_Load;
            lblAssignCourseStudentD.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeric_Duration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_MCQ_Questions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_TFQuestions).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grd_StudentsGrades).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl lblAssignCourseStudentD;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblInstructorC;
        private ComboBox comboInstructorC;
        private Button btnAssignCourse;
        private Label label1;
        private ComboBox comboCourses;
        private MetroSet_UI.Controls.MetroSetControlBox ctrlBox;
        private Label lblInstructorD;
        private ComboBox comboInstructorDep;
        private Button btnAssignDepartment;
        private Label label4;
        private ComboBox comboDepartment;
        private Label lblStudentC;
        private ComboBox comboStudentC;
        private Label lblAssignCourseStudentQ;
        private Label lblAssignDepartmentStudentQ;
        private Label lblStudentD;
        private ComboBox comboStudentD;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MetroSet_UI.Controls.MetroSetListBox lstTopics;
        private Button btnNewCourse;
        private Button button1;
        private Label label2;
        private ComboBox comboCorsesesForTopics;
        private RichTextBox Rh_QuestionText;
        private Label lb_QuestionText;
        private Label lb_Mark;
        private NumericUpDown numMark;
        private ComboBox cmbComplexity;
        private Label lb_Complexity;
        private ComboBox cmbType;
        private Label lb_Type;
        private ComboBox cmbCourses;
        private Label lb_Course;
        private Label lb_Answer3;
        private Label lb_Answer2;
        private Label lb_Answer1;
        private TextBox txt_MCQ_Answer1;
        private TextBox txt_MCQ_Answer3;
        private TextBox txt_MCQ_Answer2;
        private Label lb_ModelAnswer;
        private ComboBox cmb_ModelAnswer;
        private Button btn_Back;
        private Button btn_AddQuestionSave;
        private Label lb_date;
        private Label lb_Duration;
        private NumericUpDown numeric_Duration;
        private MonthCalendar DateTimeForExam;
        private NumericUpDown numeric_MCQ_Questions;
        private Label label3;
        private NumericUpDown numeric_TFQuestions;
        private Label lb_numOfTFQuestions;
        private ComboBox cmb_Courses;
        private Label lbCourses;
        private Button btn_generateExam;
        private TabPage tabPage6;
        private ComboBox cmb_Course_Grades;
        private Label label5;
        private DataGridView grd_StudentsGrades;
        private Button btn_Search_Grades;
        private TabPage tabPage7;
        private ComboBox cmb_Mgr;
        private Label label6;
        private Label lb_DeptName;
        private TextBox txt_DeptName;
        private Button btn_Save_Dept;
        private Button btnSignOut;
    }
}