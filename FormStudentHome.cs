
using OnlineExaminationSystem.Helpers;
using OnlineExaminationSystem;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using OnlineExaminationSystem.Context;
using Microsoft.EntityFrameworkCore;

namespace OnlineExaminationSystem
{
    public partial class FormStudentHome : MetroSetForm
    {
        OnlineExaminationSystemContext _context;

        private Dictionary<int, FormExamAnswers> examForms = new Dictionary<int, FormExamAnswers>();

        FormExamAnswers formExamAnswers;
        public FormStudentHome()
        {
            InitializeComponent();
        }

        private void FormStudentHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Dispose of all exam forms when closing the main form
            foreach (var form in examForms.Values)
            {
                form.Dispose();
            }
        }


        private void TakeExamBtn_Click_2(object sender, EventArgs e)
        {
            Helper.ExamId = _context.Database.SqlQuery<int>($"GetExamIdByStudentId {Helper.StudentId}").AsEnumerable().FirstOrDefault();

            if (Helper.ExamId == -1)
            {
                MessageBox.Show("You Have No Assigned Exam Now", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Check if an instance for the student ID already exists and is not disposed
                if (examForms.ContainsKey(Helper.StudentId) && !examForms[Helper.StudentId].IsDisposed)
                {
                    // If the form exists, reset its state and show it
                    formExamAnswers = examForms[Helper.StudentId];
                    formExamAnswers.Show();
                }
                else
                {
                    // If not, create a new instance and store it
                    formExamAnswers = new FormExamAnswers(Helper.StudentId);
                    examForms[Helper.StudentId] = formExamAnswers;
                    formExamAnswers.Show();
                }
            }
        }

        private void showGradesBtn_Click(object sender, EventArgs e)
        {
            using (FormStudentOwnGrade formStudentOwnGrade = new FormStudentOwnGrade())
            {

                Helper.HideFormSmoothly(this);

                formStudentOwnGrade.ShowDialog();
            }
        }

        private void FormStudentHome_Load(object sender, EventArgs e)
        {
            _context = new OnlineExaminationSystemContext();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Helper.SignOut();
            this.Close();
        }
    }
}






