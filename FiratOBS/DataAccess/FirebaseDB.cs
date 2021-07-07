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

        public void UpdateStudentNoteInfo(string period, string season, string lesson, string number, StudentNoteInfo studentinfo)
        {
            _client = new FirebaseClient(_config);
            _client.Set($"Periods/{period}/{season}/{lesson}/StudentNotes/{number}", studentinfo);
        }

        public void UpdateLesson(string period, string season, string lessonName, Lesson lesson)
        {
            _client = new FirebaseClient(_config);
            _client.Update($"Lessons/{period}/{season}/{lessonName}",lesson);
        }

        public List<StudentNoteInfo> GetStudentInfos(string period, string season, string lesson)
        {
            _client = new FirebaseClient(_config);

            FirebaseResponse response = _client.Get($"Periods/{period}/{season}/{lesson}/StudentNotes");
            dynamic data = JsonConvert.DeserializeObject<dynamic>(response.Body);
            List<StudentNoteInfo> studentNoteInfos = new List<StudentNoteInfo>();

            foreach (var item in data)
            {
                studentNoteInfos.Add(JsonConvert.DeserializeObject<StudentNoteInfo>(((JProperty)item).Value.ToString()));
            }
            return studentNoteInfos;
        }

        //-----------------------------------------------------

        public Student FindStudents(string number)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get("Students/" + number);
            Student student = JsonConvert.DeserializeObject<Student>(response.Body);
            return student;
        }

        public Academician FindAcademician(string mail)
        {
            _client = new FirebaseClient(_config);
            FirebaseResponse response = _client.Get("Academics/" + mail);
            Academician academician = JsonConvert.DeserializeObject<Academician>(response.Body);
            return academician;
        }

        //public void AddStudentToFireBase(Student student)
        //{
        //    _client = new FirebaseClient(_config);

        //    //PushResponse response = _client.Push("Students/", student);
        //    //response.Result.name = student.Number;
        //    _client.Set("Students/" + student.Number, student);
        //}

        //public void AddAcademicianToFireBase(Academician academician)
        //{
        //    _client = new FirebaseClient(_config);
        //    SetResponse setResponse = _client.Set("Academics/" + academician.Mail, academician);
        //}

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
    }
}
