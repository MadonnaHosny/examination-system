using MetroSet_UI.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using OnlineExaminationSystem.Context;
using OnlineExaminationSystem.Entities;
using OnlineExaminationSystem.Helpers;

namespace OnlineExaminationSystem
{
    public partial class FormSignUp : MetroSetForm
    {
        OnlineExaminationSystemContext _context = new OnlineExaminationSystemContext();

        public FormSignUp()
        {
            InitializeComponent();

            FormClosed += (sender, e) => _context?.Dispose();

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string ssn = txtSsn.Text;

            int flag = ValidateFields(email, password, fname, lname, ssn);

            if (flag == 1)
            {
                try
                {
                    Student existStudent = _context.Students.Where(s => s.Ssn == ssn || s.Email == email).FirstOrDefault();

                    if (existStudent == null)
                    {
                        Student student = new Student()
                        {
                            Fname = fname,
                            Lname = txtLname.Text,
                            Email = email,
                            Password = Helper.Encrypt(txtPassword.Text),
                            AccountState = "Active",
                            Ssn = ssn
                        };
                        _context.Students.Add(student);
                        _context.SaveChanges();


                        MessageBox.Show("Account created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.StudentId = student.Id;

                        using (FormStudentHome frmHomeStudent = new FormStudentHome())
                        {
                            frmHomeStudent.StartPosition = FormStartPosition.CenterScreen;

                            Helper.HideFormSmoothly(this);

                            frmHomeStudent.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Student with the same SSN or email already exist", "Student already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblgologin_Click(object sender, EventArgs e)
        {

            using (FormLogIn frmLogin = new FormLogIn())
            {
                frmLogin.StartPosition = FormStartPosition.CenterScreen;

                Helper.HideFormSmoothly(this);

                frmLogin.ShowDialog();
            }
        }
        private int ValidateFields(string email, string password, string fname, string lname, string ssn)
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

            if (string.IsNullOrWhiteSpace(fname))
            {
                lblReqFname.Visible = true;
                flag = 0;
            }
            if (string.IsNullOrWhiteSpace(lname))
            {
                lblReqLname.Visible = true;
                flag = 0;
            }
            if (string.IsNullOrWhiteSpace(ssn))
            {
                lblReqSSN.Visible = true;
                flag = 0;
            }
            return flag;
        }
        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            lblReqFname.Visible = false;

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            lblReqLname.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblReqEmail.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblReqPassword.Visible = false;
        }

        private void txtSsn_TextChanged(object sender, EventArgs e)
        {
            lblReqSSN.Visible = false;
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
