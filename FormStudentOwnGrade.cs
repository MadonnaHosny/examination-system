using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;
using OnlineExaminationSystem.Records;

namespace OnlineExaminationSystem
{
    public partial class FormStudentOwnGrade : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormStudentOwnGrade()
        {
            InitializeComponent();
            InitilizeLists();
        }

        private void FormStudentOwnGrade_Load(object sender, EventArgs e)
        {
            //{Helper.StudentId}
            List<Course> courses = _context.Courses.ToList();
            var courseGrades = _context.Database.SqlQuery<StudentCourseGrades>($"GetStudentGradesInAllCourses {Helper.StudentId}").ToList();

            // lstGrade.Items.AddRange(courseGrades.Select( st => st.FinalGrade.ToString())); 
            // lstCourses.Items.AddRange(courseGrades.Where( st => st.CourseID == courses.Where(c => c.Id == st.CourseID).Select( c=> c.Name).FirstOrDefault()));
            lstCourses.Items.AddRange(courseGrades.Join(courses, sg => sg.CourseID, c => c.Id,
                                                         (fg, c) => $"{c.Name}: {fg.FinalGrade}")
                                                         .ToArray());
        }

        private void InitilizeLists()
        {
            lstCourses.BackColor = Color.WhiteSmoke;
            lstCourses.Font = new Font("Century Gothic", 13F);
            lstCourses.ForeColor = Color.Gray;
            lstCourses.SelectedItemBackColor = Color.FromArgb(186, 32, 38);

            //lstGrade.BackColor = Color.WhiteSmoke;
            //lstGrade.Font = new Font("Century Gothic", 13F);
            //lstGrade.ForeColor = Color.Gray;
            //lstGrade.SelectedItemBackColor = Color.FromArgb(186, 32, 38);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            using (FormStudentHome formStudentHome = new FormStudentHome())
            {
                formStudentHome.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                formStudentHome.ShowDialog();
            }
        }
    }
}
