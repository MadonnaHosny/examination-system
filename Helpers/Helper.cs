using System.Text;
using System.Security.Cryptography;
using Microsoft.Identity.Client.NativeInterop;


namespace OnlineExaminationSystem.Helpers
{
    public class Helper
    {
        public static int StudentId = 0;
        public static int InstructorId = 0;
        public static int ExamId = 0;
        public static Form FormStudentHome;



        // For encrypting password
        public static string Encrypt(string password)
        {
            using (MD5CryptoServiceProvider md5 = new())
            {
                UTF8Encoding uTF8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(uTF8.GetBytes(password));
                return Convert.ToBase64String(data);

            }
        }

        public static void SignOut()
        {
            //StudentId = 0;
            //InstructorId = 0;
            Application.Restart();
        }

        // Hiding form in appealing way
        public static async void HideFormSmoothly(Form form)
        {
            for (double opacity = 1.0; opacity > 0; opacity -= 0.1)
            {
                form.Opacity = opacity;
                await Task.Delay(50);
            }

            form.Hide();
        }

        // Showing form in appealing way
        public static async void ShowFormSmoothly(Form form)
        {
            form.Opacity = 0;

            form.Show();

            for (double opacity = 0; opacity <= 1.0; opacity += 0.1)
            {
                form.Opacity = opacity;
                await Task.Delay(50);
            }

            form.Opacity = 1.0;
        }

    }
}
