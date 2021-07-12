using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_web_UI.Models
{
    public class LessonEnrollmentModel
    {
        public List<string> RegisteredLessons { get; set; }
        public List<string> LessonsToBeLearned { get; set; }
        public string NetxPeriod { get; set; }
        public string NextSeason { get; set; }
    }
}
