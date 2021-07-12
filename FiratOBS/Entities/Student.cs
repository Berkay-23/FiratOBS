using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Student
    {
        public string Number { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Password { get; set; } 
        public string Faculty { get; set; } 
        public string Department { get; set; }
        public string CounselorMail { get; set; } 
        public int Class { get; set; }
        public double TranscriptNote { get; set; }
        public List<double> ANOS { get; set; }
        public List<string> RegisteredLessons  { get; set; }
        public List<List<string>> ReceivedLessons { get; set; }
        public List<List<string>> LessonsLearnedBelow { get; set; }
    }
}
    