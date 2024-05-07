
using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormExamAnswers : MetroSetForm
    {
        FormStudentHome formStudentHome;
        private int count = 0;
        private int student_Id;
        private List<Question> questionsInExam = new List<Question>();
        private List<string> StudentAnswers = new List<string>();
        private List<bool> IsChecked = new List<bool>();
        private List<Question> randomizedQuestions = new List<Question>();
        private Question currentQuestion;
        private OnlineExaminationSystemContext context;
        private static Dictionary<int, List<Question>> studentQuestionMap = new Dictionary<int, List<Question>>();
        private System.Windows.Forms.Timer examTimer;
        private int examDurationInSeconds;
        int answerCount = 0;
        public FormExamAnswers(int _studentID)
        {
            InitializeComponent();
            this.student_Id = _studentID;
            //  this.formStudentHome = _formStudentHome;// Assign the reference passed from outside
        }

        private void FormExamAnswers_Load_1(object sender, EventArgs e)
        {
            context = new OnlineExaminationSystemContext();
            examTimer = new System.Windows.Forms.Timer();
            examDurationInSeconds = context.Exams.FirstOrDefault(e => e.Id == Helper.ExamId)?.Duration * 60  ?? 3;
            examTimer.Interval = 1000; // 1 second
            examTimer.Tick += new EventHandler(examTimer_Tick);
            examTimer.Start();

            LoadExamQuestions();
        }

        private void LoadExamQuestions()
        {
            int CrsID = context.Exams?.FirstOrDefault(e => e.Id == Helper.ExamId)?.CId ?? 0;
            CourseName.Text = context.Courses.FirstOrDefault(c => c.Id == CrsID)?.Name;

            drt.Text = TimeSpan.FromSeconds((double)(context.Exams.FirstOrDefault(e => e.Id == Helper.ExamId)?.Duration * 60 ?? 180)).ToString(@"hh\:mm\:ss");
            var exam = context.Exams.Include(e => e.QIds).ThenInclude(q => q.QuestionAnswers).FirstOrDefault(e => e.Id == Helper.ExamId);

            int totalMarks = exam.QIds.Sum(q => q.Mark);
            Marks.Text = totalMarks.ToString() + " Marks";
            questionsInExam = exam.QIds.ToList();

            if (studentQuestionMap.ContainsKey(student_Id))
            {
                randomizedQuestions = studentQuestionMap[student_Id];
            }
            else
            {
                randomizedQuestions = questionsInExam.OrderBy(q => Guid.NewGuid()).ToList();
                studentQuestionMap[student_Id] = randomizedQuestions;
            }

            for (int i = 0; i < randomizedQuestions.Count; i++)
            {
                StudentAnswers.Add(" ");
                IsChecked.Add(false);
            }

            LoadQuestionAndAnswers();
        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = TimeSpan.FromSeconds(examDurationInSeconds);
            drt.Text = remainingTime.ToString(@"hh\:mm\:ss");
            examDurationInSeconds--;

            if (examDurationInSeconds < 0)
            {
                drt.Text = remainingTime.ToString(@"hh\:mm\:ss");
                if (Ch1.Checked) StudentAnswers[answerCount] = Ch1.Text;
                else if (Ch2.Checked) StudentAnswers[answerCount] = Ch2.Text;
                else if (Ch3.Checked) StudentAnswers[answerCount] = Ch3.Text;

                examTimer.Stop();
                SaveStudentAnswers();
            }
        }

        private void LoadQuestionAndAnswers()
        {
            currentQuestion = randomizedQuestions[count];
            for (int i = 0; i < questionsInExam.Count; i++)
            {
                if (currentQuestion.QuestionText == questionsInExam[i].QuestionText)
                {
                    answerCount = i;
                }
            }
            int Qnum = count + 1;
            QuestionNumber.Text = "Q" + Qnum + ".";
            QuesText.Text = currentQuestion.QuestionText.ToString();
            var answersInQuestion = currentQuestion.QuestionAnswers.ToList();

            PrevBtn.Enabled = count != 0;
            NextBtn.Text = count == questionsInExam.Count - 1 ? "Submit" : "Next";

            if (currentQuestion.Type == "MCQ")
            {
                Ch1.Text = answersInQuestion[0].AnswerText;
                Ch2.Text = answersInQuestion[1].AnswerText;
                Ch3.Text = answersInQuestion[2].AnswerText;
                Ch2.Visible = true;
            }
            else if (currentQuestion.Type == "TF")
            {
                Ch1.Text = answersInQuestion[0].AnswerText;
                Ch2.Visible = false;
                Ch3.Text = answersInQuestion[1].AnswerText;
            }

            Ch1.Checked = IsChecked[count] && Ch1.Text == StudentAnswers[answerCount];
            Ch2.Checked = IsChecked[count] && Ch2.Text == StudentAnswers[answerCount];
            Ch3.Checked = IsChecked[count] && Ch3.Text == StudentAnswers[answerCount];
        }

        private void SaveStudentAnswers()
        {
            string studentFname = context.People.FirstOrDefault(s => s.Id == student_Id)?.Fname;
            string studentLName = context.People.FirstOrDefault(s => s.Id == student_Id)?.Lname;
            string fullName = studentFname + " " + studentLName;

            var Result = context.Database.ExecuteSqlRaw("EXEC GetStudentExamAnswers {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10} , {11}",
                Helper.ExamId, fullName, StudentAnswers[0], StudentAnswers[1], StudentAnswers[2],
                StudentAnswers[3], StudentAnswers[4], StudentAnswers[5], StudentAnswers[6],
                StudentAnswers[7], StudentAnswers[8], StudentAnswers[9]);

            context.StudentExams.FirstOrDefault(s => s.StId == student_Id && s.EId == Helper.ExamId).IsTaken = 1;
            context.SaveChanges();

            ///

            int numRowsAffected = context.Database.ExecuteSql($"Exec [ExamCorrection] {Helper.StudentId},{Helper.ExamId}");
            var studentGrade = context.StudentExams.Where(se => se.StId == Helper.StudentId && se.EId == Helper.ExamId).Select(se => se.ExamGrade).FirstOrDefault();
            ///
            var exams = context.Exams.Include(e => e.QIds).ThenInclude(q => q.QuestionAnswers).FirstOrDefault(e => e.Id == Helper.ExamId);

            int examMarks = exams.QIds.Sum(q => q.Mark);
            if (examDurationInSeconds < 0)
            {
                MessageBox.Show($"Time's up! Your exam has ended.\nYour grade is {studentGrade} / {examMarks}");

            }
            else
            {
                MessageBox.Show($"Your Exam Submited Sucessfully.\nYour grade is {studentGrade} / {examMarks}");

            }
            this.Hide();

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void FormExamAnswers_FormClosed(object sender, FormClosedEventArgs e)
        {
            context.Dispose();
        }

        private void PrevBtn_Click_2(object sender, EventArgs e)
        {
            if (count > 0)
            {

                if (Ch1.Checked) StudentAnswers[answerCount] = Ch1.Text;
                else if (Ch2.Checked) StudentAnswers[answerCount] = Ch2.Text;
                else if (Ch3.Checked) StudentAnswers[answerCount] = Ch3.Text;


                IsChecked[count] = true;

                count--;
                LoadQuestionAndAnswers();
            }
        }

        private void NextBtn_Click_2(object sender, EventArgs e)
        {
            if (Ch1.Checked) StudentAnswers[answerCount] = Ch1.Text;
            else if (Ch2.Checked) StudentAnswers[answerCount] = Ch2.Text;
            else if (Ch3.Checked) StudentAnswers[answerCount] = Ch3.Text;

            IsChecked[count] = true;

            if (count < questionsInExam.Count - 1)
            {
                count++;
                LoadQuestionAndAnswers();
            }
            else
            {
                SaveStudentAnswers();
                examTimer.Stop();
            }
        }
        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormExamAnswers_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}



















































































































