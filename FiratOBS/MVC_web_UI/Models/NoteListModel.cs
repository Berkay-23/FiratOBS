using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace MVC_web_UI.Models
{
    public class NoteListModel
    {
        public List<string> Periods { get; set; } // 20-21 Autumn ...
        public List<string> ReceivedLessons { get; set; } // YMH-111 ...
        public List<string> LessonNames { get; set; } // Bilgisayar bilimlerine giriş ...
        public List<StudentNoteInfo>  StudentNoteInfos { get; set; } // 190541001...
        public string Period { get; set; }
    }
}
