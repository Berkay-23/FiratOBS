using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace Business
{
    public class LoginProcess
    {
        private readonly FirebaseDB _database = new FirebaseDB();
        private Student Student {  get; set; }
        private Academician Academician { get; set; }

        private readonly PasswordHash _passwordHash = new PasswordHash();

        public Exception FindStudent(User user)
        {
            Student student = _database.FindStudents(user.UserName);

            if (student != null)
            {
                string decryptedPassword = _passwordHash.Decrypt(student.Password);

                if (decryptedPassword.Equals(user.Password))
                {
                    return new Exception("Login Successful"); // Successful
                }
                else
                {
                    return new Exception("Student wrong password"); // Wrong password
                }
            }
            else
            {
                return new Exception("Student not found"); // Student not found
            }
        }

        public Exception FindAcademician(User user)
        {
            Academician academician = _database.FindAcademician(user.UserName);

            if (academician != null)
            {
                string decryptedPassword = _passwordHash.Decrypt(academician.Password);

                if (decryptedPassword.Equals(user.Password))
                {
                    return new Exception("Login Successful"); // Successful
                }
                else
                {
                    return new Exception("Academician wrong password"); // Wrong password
                }
            }
            else
            {
                return new Exception("Academician not found"); // Academician not found
            };
        }
    }
}
