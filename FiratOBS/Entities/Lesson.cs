using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lesson
    {
        public string LessonName { get; set; } // Ders adı
        public string LessonId { get; set; } // Ders id
        public string LessonType { get; set; } // Ders türü (seçmeli/zorunlu) 
        public int AKTS { get; set; } // Avrupa Kredi Transfer Sistemi
        public int Credit { get; set; } // Kerdi puanı
        public int Class { get; set; } // Sınıf (1,2,3,4...)
        public int Quota { get; set; } // Kontejyan
        public List<StudentNoteInfo> StudentNotes { get; set; }
    }
}
