using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;
using OnlineExaminationSystem.Records;
using System.Data;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormHomePageInstractor : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        int NumOfTFQuestions, NumOfMCQ_Questions;


        /// add course topics

        private List<TextBox> topicTextBoxes = new List<TextBox>();
        int topicCount = 0;

        int xLocation = 95;
        int yLocation = 490;

        /// 

        public FormHomePageInstractor()
        {
            InitializeComponent();
            InitilizeShowCoursesTab();
        }
        private void FormHomePageInstractor_Load(object sender, EventArgs e)
        {

            List<Course> courses = _context.Courses.ToList();
            List<Instructor> instructors = _context.Instructors.ToList();
            List<Student> students = _context.Students.ToList();

            List<Department> departments = _context.Departments.ToList();
            var coursesInsturctor = _context.Courses
                    .Where(c => c.Ins.Any(i => i.Id == Helper.InstructorId))
                    .Select(c => new { CourseId = c.Id, CourseName = c.Name })
                    .ToList();
            /// assign course
            comboCourses.DataSource = courses;
            comboCourses.DisplayMember = "Name";
            comboCourses.ValueMember = "Id";


            comboInstructorC.DataSource = instructors;
            comboInstructorC.DisplayMember = "FullName";
            comboInstructorC.ValueMember = "Id";


            comboStudentC.DataSource = students;
            comboStudentC.DisplayMember = "FullName";
            comboStudentC.ValueMember = "Id";
            ///

            /// assign department
            comboInstructorDep.DataSource = instructors;
            comboInstructorDep.DisplayMember = "FullName";
            comboInstructorDep.ValueMember = "Id";

            comboDepartment.DataSource = departments;
            comboDepartment.DisplayMember = "Name";
            comboDepartment.ValueMember = "Id";

            comboStudentD.DataSource = students;
            comboStudentD.DisplayMember = "FullName";
            comboStudentD.ValueMember = "Id";

            /// 

            ///
            comboCorsesesForTopics.DataSource = courses;
            comboCorsesesForTopics.DisplayMember = "Name";
            comboCorsesesForTopics.ValueMember = "Id";
            ///

            cmbCourses.DataSource = courses;
            cmbCourses.DisplayMember = "Name";
            cmbCourses.ValueMember = "Id";

            List<string> Types = new List<string>() { "MCQ", "TF" };
            cmbType.DataSource = Types;

            List<string> Complexity = new List<string>() { "E", "M", "H" };
            cmbComplexity.DataSource = Complexity;

            cmb_Courses.DataSource = coursesInsturctor;
            cmb_Courses.DisplayMember = "CourseName";
            cmb_Courses.ValueMember = "CourseName";

            cmb_Course_Grades.DataSource = courses;
            cmb_Course_Grades.DisplayMember = "Name";
            cmb_Course_Grades.ValueMember = "Id";

            var Inst = (from I in _context.Instructors
                        select new
                        {
                            I.Id,
                            FullNamee = I.Fname + " " + I.Lname
                        }).ToList();
            cmb_Mgr.DataSource = Inst;
            cmb_Mgr.DisplayMember = "FullNamee";
            cmb_Mgr.ValueMember = "Id";
        }

        private void btnAssignCourse_Click(object sender, EventArgs e)
        {
            var courseId = Convert.ToInt32(comboCourses.SelectedValue);
            if (!lblStudentC.Visible)
            {
                try
                {

                    var instructorId = Convert.ToInt32(comboInstructorC.SelectedValue);

                    bool isAssignedCourse = _context.Instructors
                    .Where(i => i.Id == instructorId)
                    .SelectMany(i => i.CIds)
                    .Any(c => c.Id == courseId);

                    if (!isAssignedCourse)
                    {
                        _context.Database.ExecuteSqlInterpolated($"Exec [AddInstructorCrs] {instructorId}, {courseId}");
                        MessageBox.Show("Course Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Instructor is already assigned to this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                try
                {

                    var studentId = Convert.ToInt32(comboStudentC.SelectedValue);

                    bool isAssignedCourse = _context.Students
                    .Where(i => i.Id == studentId)
                    .SelectMany(i => i.CIds)
                    .Any(c => c.Id == courseId);

                    if (!isAssignedCourse)
                    {
                        _context.Database.ExecuteSqlInterpolated($"Exec [AddStudentCourse] {studentId}, {courseId}");
                        MessageBox.Show("Course Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Student is already assigned to this course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnAssignDepartment_Click(object sender, EventArgs e)
        {
            int deptId = Convert.ToInt32(comboDepartment.SelectedValue);
            if (!lblStudentD.Visible)
            {
                try
                {

                    int instructorId = Convert.ToInt32(comboInstructorDep.SelectedValue);

                    Instructor instructor = _context.Instructors.Where(i => i.Id == instructorId).FirstOrDefault();

                    if (instructor.DeptId != deptId)
                    {
                        instructor.DeptId = deptId;
                        _context.SaveChanges();
                        MessageBox.Show("Department Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Instructor is already assigned to this Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                try
                {

                    int studentId = Convert.ToInt32(comboStudentD.SelectedValue);

                    Student student = _context.Students.Where(i => i.Id == studentId).FirstOrDefault();

                    if (student.DeptId != deptId)
                    {
                        student.DeptId = deptId;
                        _context.SaveChanges();
                        MessageBox.Show("Department Assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The Student is already assigned to this Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void lblAssignCourse_Click(object sender, EventArgs e)
        {
            lblStudentC.Visible = !lblStudentC.Visible;
            comboStudentC.Visible = !comboStudentC.Visible;

            lblInstructorC.Visible = !lblInstructorC.Visible;
            comboInstructorC.Visible = !comboInstructorC.Visible;

            if (!lblStudentC.Visible)
                lblAssignCourseStudentQ.Text = "Assign Course for Student?";
            else
                lblAssignCourseStudentQ.Text = "Assign Course for Instructor?";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblStudentD.Visible = !lblStudentD.Visible;
            comboStudentD.Visible = !comboStudentD.Visible;

            lblInstructorD.Visible = !lblInstructorD.Visible;
            comboInstructorDep.Visible = !comboInstructorDep.Visible;

            if (!lblStudentD.Visible)
                lblAssignDepartmentStudentQ.Text = "Assign Department for Student?";
            else
                lblAssignDepartmentStudentQ.Text = "Assign Department for Instructor?";
        }

        private void InitilizeShowCoursesTab()
        {
            lstTopics.BackColor = Color.WhiteSmoke;
            lstTopics.Font = new Font("Century Gothic", 13F);
            lstTopics.ForeColor = Color.Gray;
            lstTopics.SelectedItemBackColor = Color.FromArgb(186, 32, 38);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var topics = _context.Topics.FromSql($"CourseWithTopics {comboCourses.SelectedValue}").ToList();

            //grdTopics.DataSource = topics;
            //grdTopics.Columns["CId"].Visible = false;
            //grdTopics.Columns["TId"].Visible = false;
            //grdTopics.Columns["CIdNavigation"].Visible = false;

            lstTopics.Items.Clear();
            lstTopics.Items.AddRange(topics.Select(t => t.Name));

        }

        private void btnNewCourse_Click(object sender, EventArgs e)
        {
            using (FormAddCourseTopics frmAddCorseTopics = new FormAddCourseTopics())
            {
                frmAddCorseTopics.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmAddCorseTopics.ShowDialog();
            }
        }

        private void btn_AddQuestionSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = true;
                string msg = "";
                List<string> QuestionAnswers = new List<string>();
                int courseId = (int)cmbCourses.SelectedValue;
                string type = cmbType.SelectedValue.ToString();
                string complexity = cmbComplexity.SelectedValue.ToString();
                int mark = (int)numMark.Value;
                string questionText = Rh_QuestionText.Text;
                int IndexModelAnsr = cmb_ModelAnswer.SelectedIndex;
                if (mark == 0)
                {
                    msg = "Mark must not be Zero";
                    flag = false;
                }
                if (questionText.Length == 0)
                {
                    msg = "Please Insert Question To Continue the process";
                    flag = false;
                }
                if (type == "TF")
                {
                    QuestionAnswers = new() { "T", "F" };

                }
                else if (type == "MCQ")
                {
                    if (txt_MCQ_Answer1.Text.Length == 0 || txt_MCQ_Answer2.Text.Length == 0 || txt_MCQ_Answer3.Text.Length == 0)
                    {
                        flag = false;
                        msg = "You must Enter 3 Answers";
                    }
                    else
                    {
                        string ModelAsr1 = txt_MCQ_Answer1.Text;
                        string ModelAsr2 = txt_MCQ_Answer2.Text;
                        string ModelAsr3 = txt_MCQ_Answer3.Text;
                        QuestionAnswers = new() { ModelAsr1, ModelAsr2, ModelAsr3 };
                    }
                }
                if (flag == true)
                {
                    var result = _context.Database.ExecuteSql($"InsertQuestion {questionText},{type},{complexity},{mark},{courseId}");
                    if (result > 0)
                    {
                        MessageBox.Show("Question is added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Rh_QuestionText.Text = string.Empty;
                        int QuestionIDRes = _context.Questions.OrderBy(P => P.Id).Select(P => P.Id).Last();
                        for (int i = 0; i < QuestionAnswers.Count; i++)
                        {
                            int ModelAnswerRes = 0;
                            if (i == IndexModelAnsr)
                            {
                                ModelAnswerRes = 1;
                            }
                            else
                            {
                                ModelAnswerRes = 0;
                            }
                            var QuestionAnswerresult = _context.Database.ExecuteSql($"SP_InsertIntoQuestionAnswer {QuestionAnswers[i]},{ModelAnswerRes},{QuestionIDRes}");

                        }
                    }
                    else
                    {
                        msg = "Question Insertion has a problem";
                    }
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show($"{msg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> TFModelAnswer = new List<string>() { "True", "False" };
            List<string> MCQModelAnswer = new List<string> { "MCQ Answer 1", "MCQ Answer 2", "MCQ Answer 3" };
            if (cmbType.SelectedValue.ToString() == "TF")
            {
                lb_Answer1.Visible = false;
                lb_Answer2.Visible = false;
                lb_Answer3.Visible = false;
                txt_MCQ_Answer1.Visible = false;
                txt_MCQ_Answer2.Visible = false;
                txt_MCQ_Answer3.Visible = false;
                cmb_ModelAnswer.DataSource = TFModelAnswer;
            }
            else
            {
                lb_Answer1.Visible = true;
                lb_Answer2.Visible = true;
                lb_Answer3.Visible = true;
                txt_MCQ_Answer1.Visible = true;
                txt_MCQ_Answer2.Visible = true;
                txt_MCQ_Answer3.Visible = true;
                cmb_ModelAnswer.DataSource = MCQModelAnswer;
            }
        }

        private void btn_generateExam_Click(object sender, EventArgs e)
        {
            try
            {
                string CourseNamee = cmb_Courses.SelectedValue.ToString();
                NumOfTFQuestions = (int)numeric_TFQuestions.Value;
                NumOfMCQ_Questions = (int)numeric_MCQ_Questions.Value;
                int day = DateTimeForExam.SelectionStart.Day;
                int month = DateTimeForExam.SelectionStart.Month;
                int year = DateTimeForExam.SelectionStart.Year;
                int duration = (int)numeric_Duration.Value;
                bool flag = true;
                string errorMessage = "";

                if (NumOfTFQuestions == 0 || NumOfMCQ_Questions == 0)
                {
                    errorMessage = "num of questions must not be zero";
                    flag = false;
                }
                if (NumOfTFQuestions + NumOfMCQ_Questions != 10)
                {
                    flag = false;
                    errorMessage = "num of exam questions must be 10";
                }

                if (DateTime.Now.Date > DateTimeForExam.SelectionStart.Date)
                {
                    flag = false;
                    errorMessage = "Please choose sufficient date";
                }
                if (duration == 0)
                {
                    errorMessage = "Duration must not be zero";
                    flag = false;
                }


                var result = _context.Database.ExecuteSql($"SP_GenerateExam {CourseNamee},{NumOfTFQuestions},{NumOfMCQ_Questions},{year},{month},{day},{duration},{Helper.InstructorId}");

                if (result > 0 && flag == true)
                {
                    MessageBox.Show("Exam is generated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    int courseId = _context.Courses.Where(c => c.Name == CourseNamee).Select(c => c.Id).FirstOrDefault();
                    int examId = _context.Exams.Where(e => e.Date == new DateOnly(year, month, day) && e.CId == courseId && e.Duration == duration).Select(e => e.Id).FirstOrDefault();
                    AssignExam(CourseNamee, examId);
                }
                else if (flag == false)
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorMessage = string.Empty;
                }
                else
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorMessage = string.Empty;
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            this.cmb_Courses.Refresh();
        }

        private void btn_Search_Grades_Click(object sender, EventArgs e)
        {
            int courseId = (int)cmb_Course_Grades.SelectedValue;

            var query = (from se in _context.StudentExams
                         join s in _context.Students on se.StId equals s.Id
                         join E in _context.Exams on se.EId equals E.Id
                         join C in _context.Courses on E.CId equals C.Id
                         where E.CId == courseId && se.ExamGrade != null && se.IsTaken == 1 // Filter for course ID 1
                         select new
                         {
                             StudentFName = s.Fname,
                             StudentLName = s.Lname,
                             StudentEmail = s.Email,
                             Grade = se.ExamGrade,
                         }).ToList();
            if (query.Count == 0)
            {
                MessageBox.Show("There is no Students Assigned to this course yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            grd_StudentsGrades.DataSource = query;
            grd_StudentsGrades.AutoResizeColumns();
        }

        private void btn_Save_Dept_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string msg = "";
            int InstId = (int)cmb_Mgr.SelectedValue;

            if (txt_DeptName.Text.Length == 0)
            {
                flag = false;
                msg = "Please Enter Department Name";
            }
            else
            {
                var result = _context.Database.ExecuteSql($"exec SP_InsertIntoDepartment {txt_DeptName.Text},{InstId}");
                if (result == 0 || flag == false)
                {
                    msg = "Something Went Wrong";
                }
                else
                {
                    MessageBox.Show("Department Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (msg.Length > 0)
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AssignExam(string courseName, int examId)
        {
            List<int> studentIds = _context.Database.SqlQuery<int>($"GetStudentsByCourseName {courseName}").ToList();
            foreach (int studentId in studentIds)
            {
                var result = _context.Database.ExecuteSql($"SP_InsertIntoStudentExam {studentId},{examId}");
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Helper.SignOut();
        }

        private void lstTopics_SelectedIndexChanged(object sender)
        {

        }
        /// add course topics
        //private void CloseAddCorseTopicForm()
        //{


        //    using (FormCourseTopics formCourseTopics = new FormCourseTopics())
        //    {
        //        formCourseTopics.StartPosition = FormStartPosition.CenterScreen;

        //        Helper.HideFormSmoothly(this);

        //        formCourseTopics.ShowDialog();
        //    }
        //}

        //private void btnAddAdd_Click(object sender, EventArgs e)
        //{
        //    string courseName = txtCourseAdd.Text;
        //    string hours = txtHoursAdd.Text;
        //    // string topic = txtTopic.Text;
        //    //  bool h = int.TryParse(txtHours.Text, out int hours);
        //    int flag = ValidateFields(courseName, hours);

        //    if (flag == 1)
        //    {
        //        try
        //        {
        //            bool courseExist = _context.Courses.Any(c => c.Name == courseName);
        //            if (courseExist)
        //            {
        //                MessageBox.Show("Course Already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            }
        //            else
        //            {
        //                _context.Database.ExecuteSql($"Exec [SP_addCourse] {courseName}, {hours}");
        //                ///
        //                foreach (TextBox topicTextBox in topicTextBoxes)
        //                {
        //                    string topic = topicTextBox.Text.Trim();

        //                    if (!string.IsNullOrWhiteSpace(topic))
        //                    {
        //                        int courseId = _context.Courses.Where(c => c.Name == courseName).Select(c => c.Id).FirstOrDefault();
        //                        _context.Database.ExecuteSqlInterpolated($"Exec [SP_addTopic] {courseId}, {topic}");
        //                    }
        //                }
        //                ///

        //                MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //              //  CloseAddCorseTopicForm();
        //            }

        //        }
        //        catch
        //        {
        //            MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        }

        //    }
        //}


        //private int ValidateFields(string courseName, string hours)
        //{
        //    int flag = 1;

        //    if (string.IsNullOrWhiteSpace(courseName))
        //    {
        //        lblReqCourseAdd.Visible = true;
        //        flag = 0;
        //    }

        //    if (string.IsNullOrWhiteSpace(hours))
        //    {
        //        lblReqHoursAdd.Visible = true;
        //        flag = 0;
        //    }
        //    return flag;
        //}

        //private void btnAddTopicAdd_Click(object sender, EventArgs e)
        //{
        //    TextBox newTopicTextBox = new TextBox();
        //    newTopicTextBox.Width = 200;
        //    newTopicTextBox.Height = 32;
        //    newTopicTextBox.Location = new Point(600, 700);
        //    newTopicTextBox.BringToFront();
        //    topicTextBoxes.Add(newTopicTextBox);
        //    Controls.Add(newTopicTextBox);

        //    lblTopicAdd.Visible = true;
        //    topicCount++;

        //    if (topicCount >= 3)
        //    {
        //        btnAddTopicAdd.Visible = false;
        //    }
        //}

        //private void txtCourseAdd_TextChanged(object sender, EventArgs e)
        //{
        //    lblReqCourseAdd.Visible = false;

        //}

        //private void txtHoursAdd_TextChanged(object sender, EventArgs e)
        //{
        //    lblReqHoursAdd.Visible = false;
        //}

        /// 
    }
}
