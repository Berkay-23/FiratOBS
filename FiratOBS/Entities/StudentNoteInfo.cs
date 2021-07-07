using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentNoteInfo
    {
        public string StudentNumber { get; set; }
        public double MidtermExam { get; set; }
        public double FinalExamination { get; set; }
        public double MakeupExam { get; set; }
        public double Average { get; set; }
        public string LetterGrade { get; set; }
        public string Status { get; set; }
    }
}
