using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace DataAccess
{
    public class FirebaseDB
    {
        private FirebaseClient _client = null;
        private readonly IFirebaseConfig _config = new FirebaseConfig
        {
            AuthSecret = "uiJAuK2BJciEBqRmUQ8UiGgqKdgPkY6Xfi4Fmjl9",
            BasePath = "https://firatobs-455f3-default-rtdb.firebaseio.com/"
        };

        //------------------------------------------------------

        // Kodları verilen derslerin listesini getirir.
        public List<Lesson> GetLessons(List<string> lessonCodes) 
        {
            _client = new FirebaseClient(_config);

            List<Lesson> lessons = new List<Lesson>();

            foreach (string code in lessonCodes)
            {
                FirebaseResponse response = _client.Get($"Lessons/{code}"); 
                Lesson data = JsonConvert.DeserializeObject<Lesson>(response.Body);
                lessons.Add(data);
            }
            return lessons;
        }

        // Kodları verilen derslerin sadece isimlerini getirir
        public List<string> GetLessonName(List<string> lessonCodes) 
        {
            _client = new FirebaseClient(_config);

            List<string> lessonNames = new List<string>();

            foreach (string lessonCode in lessonCodes)
            {
                FirebaseResponse response = _client.Get($"Lessons/{lessonCode}/LessonName");
                string lessonName = JsonConvert.DeserializeObject<string>(response.Body);
                lessonNames.Add(lessonName);
            }
            return lessonNames;
        }

        //Öğrencinin bir (istenilen) dönemdeki derslerinin kodlarını getirir
        public List<string> GetReceivedLessons(string number, string index)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get($"Students/{number}/ReceivedLessons/{index}");
            List<string> receivedLessons = JsonConvert.DeserializeObject<List<string>>(response.Body);

            return receivedLessons;
        }

        // Öğrencinin verilen ders kodlarına göre not bilgilerini getirir.
        public List<StudentNoteInfo> GetStudentNoteInfos(List<string> receivedLessons, string period, string season, string number)
        {
            _client = new FirebaseClient(_config);

            List<StudentNoteInfo> studentNoteInfos = new List<StudentNoteInfo>();

            foreach (string lesson in receivedLessons)
            {
                FirebaseResponse response = _client.Get($"Periods/{period}/{season}/{lesson}/StudentNotes/{number}");
                StudentNoteInfo studentNoteInfo = JsonConvert.DeserializeObject<StudentNoteInfo>(response.Body);
                studentNoteInfos.Add(studentNoteInfo);
            }
            return studentNoteInfos;
        }

        // Öğrencin not bilgilerini günceller.
        public void UpdateStudentNoteInfo(string period, string season, string lesson, string number, StudentNoteInfo studentinfo)
        {
            _client = new FirebaseClient(_config);
            _client.Set($"Periods/{period}/{season}/{lesson}/StudentNotes/{number}", studentinfo);
        }

        // Ders bilgilerini günceller
        public void UpdateLesson(string period, string season, string lessonName, Lesson lesson)
        {
            _client = new FirebaseClient(_config);
            _client.Update($"Periods/{period}/{season}/{lessonName}",lesson);
        }


        // Öğrenci arama
        public Student FindStudents(string number)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get("Students/" + number);
            Student student = JsonConvert.DeserializeObject<Student>(response.Body);
            return student;
        }

        // Akademsiyen arama
        public Academician FindAcademician(string mail)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get("Academics/" + mail);
            Academician academician = JsonConvert.DeserializeObject<Academician>(response.Body);
            return academician;
        }

        // Öğrenci, akademisyen , ders eklemeleri 
        public void AddEntitiesToFirebase(string path, Object obj)
        {
            _client = new FirebaseClient(_config);
            _client.Set(path,obj);
        }

        public List<Student> ListStudents()
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get("Students");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            List<Student> students = new List<Student>();

            foreach (var item in data)
            {
                students.Add(JsonConvert.DeserializeObject<Student>(((JProperty)item).Value.ToString()));
            }
            return students;
        }

        // Bir öğrencinin alttan alınan ders bilgilerini güncelliyor.
        public List<string> UpdateLessonsLearnedBelow(List<string> receivedLessons, string period, string season, string number)
        {
            _client = new FirebaseClient(_config);

            List<string> lessonCodes = new List<string>();

            foreach (string lesson in receivedLessons)
            {
                FirebaseResponse response = _client.Get($"Periods/{period}/{season}/{lesson}/StudentNotes/{number}");
                StudentNoteInfo studentNoteInfo = JsonConvert.DeserializeObject<StudentNoteInfo>(response.Body);

                if (studentNoteInfo != null)
                {
                    if (studentNoteInfo.LetterGrade.Equals("FF"))
                    {
                        lessonCodes.Add(lesson);
                    }
                }
            }
            return lessonCodes;
        }

        public Lesson GetLesson(string lessonCode)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get($"Lessons/{lessonCode}");
            
            return JsonConvert.DeserializeObject<Lesson>(response.Body);
        }

        public StudentNoteInfo GetStudentNoteInfo(string period, string season, string lessonCode, string number)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get($"Periods/{period}/{season}/{lessonCode}/StudentNotes/{number}");
            return JsonConvert.DeserializeObject<StudentNoteInfo>(response.Body);
        }

        public List<StudentNoteInfo> GetStudentNoteInfos(string lesson)
        {
            _client = new FirebaseClient(_config);

            FirebaseResponse response = _client.Get($"Periods/20-21/Spring/{lesson}/StudentNotes/");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);

            List<StudentNoteInfo> students = new List<StudentNoteInfo>();

            foreach (var item in data)
            {
                students.Add(JsonConvert.DeserializeObject<StudentNoteInfo>(((JProperty)item).Value.ToString()));
            }

            return students;
        }
        
    }
}
