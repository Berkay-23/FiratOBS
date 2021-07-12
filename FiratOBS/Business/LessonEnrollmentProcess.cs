using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public class LessonEnrollmentProcess
    {
        public string NextPeriod { get; set; }
        public string NextSeason { get; set; }

        private readonly FirebaseDB _database = new FirebaseDB();

        public LessonEnrollmentProcess(string nextPeriod, string nextSeason)
        {
            NextPeriod = nextPeriod;
            NextSeason = nextSeason;
        }

        public List<string> GetLessonsToBeLearned(Student student)
        {
            List<List<string>> lessonsLearnedBelow = student.LessonsLearnedBelow;

            List<string> autumnSeason = null, springSeason = null;

            if (lessonsLearnedBelow != null)
            {
                autumnSeason = lessonsLearnedBelow[0];
                springSeason = lessonsLearnedBelow[1];
            }

            if (NextSeason.Equals("Autumn"))
            {
                return autumnSeason;
            }
            else if(NextSeason.Equals("Spring"))
            {
                return springSeason;
            }
            else
            {
                return null;
            }
        }
        
        public List<string> GetRegisteredLessons(Student student)
        {
            return null;
        }
    }
}
