using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace MVC_web_UI.Models
{
    public class ReceivedLessonsModel
    {
        public List<Lesson> ReceivedLessons { get; set; }
        public List<List<string>> ReceivedLessonsCode { get; set; }
        public List<string> Periods { get; set; }
        public string Selectperiod { get; set; }
    }
}
