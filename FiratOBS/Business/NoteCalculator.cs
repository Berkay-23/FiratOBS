using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business
{
    public class NoteCalculator
    {
        private readonly Random _random = new Random();

        public double NoteGenerate()
        {
            return _random.Next(20,101);
        }

        public double AvarageGenerate(double MEP, double midtermExam, double finalExam, double FEP)
        {
            string avg = string.Format("{0:0.00}", (midtermExam * MEP) + (finalExam * FEP));
            return Convert.ToDouble(avg);
        }

        public string LetterGradeGenerate(double avarage)
        {
            if (90 <= avarage && avarage <= 100)
            {
                return "AA";
            }
            else if (80 <= avarage && avarage < 90)
            {
                return  "BA";
            }
            else if (70 <= avarage && avarage < 80)
            {
                return "BB";
            }
            else if (60 <= avarage && avarage < 70)
            {
                return "CB";
            }
            else if (50 <= avarage && avarage < 60)
            {
                return "CC";
            }
            else
            {
                return "FF";
            }
        }

        public string StatusGenerate(string letterGrade)
        {
            if (!letterGrade.Equals("FF"))
                return "Geçti";
            else
            {
                return "Kaldı";
            }
        }
    }
}
