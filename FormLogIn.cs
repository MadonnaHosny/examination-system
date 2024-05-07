
using MetroSet_UI.Forms;
using Microsoft.EntityFrameworkCore;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormLogIn : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormLogIn()
        {
            InitializeComponent();
            this.FormClosed += (sender, e) => _context?.Dispose();

        }


        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int flag = ValidateFields(email, password);

            if (flag == 1)
            {
                var user = _context.People.Where(p => p.Email == email && p.Password == Helper.Encrypt(password)).FirstOrDefault();
                if (user != null)
                {
                    var isStudent = _context.Students.Where(s => s.Id == user.Id).FirstOrDefault();
                    if (isStudent != null)
                    {
                        Helper.StudentId = user.Id;
                        using (FormStudentHome formHomeStudent = new FormStudentHome ())
                        {

                            Helper.HideFormSmoothly(this);

                            formHomeStudent.ShowDialog();
                        }
                    }
                    else
                    {
                        // here
                        Helper.InstructorId = user.Id;
                        using (FormHomePageInstractor formHomeInstructor = new FormHomePageInstractor())
                        {
                            formHomeInstructor.StartPosition = FormStartPosition.CenterScreen;

                            Helper.HideFormSmoothly(this);

                            formHomeInstructor.ShowDialog();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblGoSignUp_Click(object sender, EventArgs e)
        {
            using (FormSignUp frmSignup = new FormSignUp())
            {
                frmSignup.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmSignup.ShowDialog();
            }
        }

        private int ValidateFields(string email, string password)
        {
            int flag = 1;

            if (string.IsNullOrWhiteSpace(email))
            {
                lblReqEmail.Visible = true;
                flag = 0;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblReqPassword.Visible = true;
                flag = 0;
            }
            return flag;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblReqEmail.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblReqPassword.Visible = false;

        }
    }
}
