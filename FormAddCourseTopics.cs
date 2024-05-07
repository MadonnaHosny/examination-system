using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Helpers;
using System.Windows.Forms;

namespace OnlineExaminationSystem
{
    public partial class FormAddCourseTopics : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();
        private List<TextBox> topicTextBoxes = new List<TextBox>();
        int topicCount = 0;

        int xLocation = 49;
        int yLocation = 486;
        public FormAddCourseTopics()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseAddCorseTopicForm();
        }


        private void CloseAddCorseTopicForm()
        {


            using (FormHomePageInstractor formHomrPageInstructor = new FormHomePageInstractor())
            {
                formHomrPageInstructor.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                formHomrPageInstructor.ShowDialog();
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string courseName = txtCourse.Text;
            string hours = txtHours.Text;
            // string topic = txtTopic.Text;
            //  bool h = int.TryParse(txtHours.Text, out int hours);
            int flag = ValidateFields(courseName, hours);

            if (flag == 1)
            {
                try
                {
                    bool courseExist = _context.Courses.Any(c => c.Name == courseName);
                    if (courseExist)
                    {
                        MessageBox.Show("Course Already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        _context.Database.ExecuteSql($"Exec [SP_addCourse] {courseName}, {hours}");
                        ///
                        foreach (TextBox topicTextBox in topicTextBoxes)
                        {
                            string topic = topicTextBox.Text.Trim();

                            if (!string.IsNullOrWhiteSpace(topic))
                            {
                                int courseId = _context.Courses.Where(c => c.Name == courseName).Select(c => c.Id).FirstOrDefault();
                                _context.Database.ExecuteSqlInterpolated($"Exec [SP_addTopic] {courseId}, {topic}");
                            }
                        }
                        ///

                        MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CloseAddCorseTopicForm();
                    }

                }
                catch
                {
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private int ValidateFields(string courseName, string hours)
        {
            int flag = 1;

            if (string.IsNullOrWhiteSpace(courseName))
            {
                lblReqCourse.Visible = true;
                flag = 0;
            }

            if (string.IsNullOrWhiteSpace(hours))
            {
                lblReqHours.Visible = true;
                flag = 0;
            }
            return flag;
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            lblReqCourse.Visible = false;

        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            lblReqHours.Visible = false;

        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            TextBox newTopicTextBox = new TextBox();
            newTopicTextBox.Width = 200;
            newTopicTextBox.Height = 32;
            newTopicTextBox.Location = new Point(yLocation, xLocation += 55);

            topicTextBoxes.Add(newTopicTextBox);
            Controls.Add(newTopicTextBox);

            lblTopic.Visible = true;
            topicCount++;

            if (topicCount >= 3)
            {
                btnAddTopic.Visible = false;
            }
        }
    }
}