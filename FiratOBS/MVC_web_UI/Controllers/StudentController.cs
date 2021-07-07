using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Entities;
using MVC_web_UI.Models;
using DataAccess;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace MVC_web_UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly FirebaseDB _database = new FirebaseDB();

        [HttpGet]
        public IActionResult StudentMain(Student student) // Öğrenci Giriş Ekranı 
        {
            Academician academician = _database.FindAcademician(student.CounselorMail);

            StudentModel model = new StudentModel()
            {
                Student = student,
                AcademicianName = academician.FirstName,
                AcademicianSurname = academician.LastName
            };

            string data = JsonSerializer.Serialize(model);
            TempData["studentModel"] = data;

            return View(model);
        }

        [HttpGet]
        public IActionResult AcademicCalendar() // Akademik Takvim
        {
            return View();
        }

        [HttpGet]
        public IActionResult ConsultantInformation() // Danışman Bilgileri
        {
            StudentModel studentModel = DeserializeModel();

            return View(studentModel);
        }

        [HttpGet]
        public IActionResult ReceivedLessons() // Alınan  Dersler
        {
            StudentModel studentModel = DeserializeModel();
            Student student = _database.FindStudents(studentModel.Student.Number);

            ReceivedLessonsModel model = new ReceivedLessonsModel()
            {
                ReceivedLessonsCode = student.ReceivedLessons,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ReceivedLessons(int selectPeriod)
        {
            StudentModel studentModel = DeserializeModel();
            Student student = _database.FindStudents(studentModel.Student.Number);
            PeriodListing periodListing = new PeriodListing(student.ReceivedLessons);
            
            ReceivedLessonsModel model = new ReceivedLessonsModel()
            {
                ReceivedLessonsCode = student.ReceivedLessons,
                Periods = periodListing.GetPeriods(selectPeriod),
                ReceivedLessons = _database.GetLessons(periodListing.GetPeriods(selectPeriod)),
                Selectperiod = periodListing.GetPeriodsName(selectPeriod)
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult ExamSchedule() // Sınav Takvimi
        {
            return View();
        }

        [HttpGet]
        public IActionResult InternshipInformation() // Staj Bilgileri
        {
            return View();
        }

        [HttpGet]
        public IActionResult LessonEnrollment() // Ders Kaydı
        {
            return View();
        }

        [HttpGet]
        public IActionResult NoteList() // Not Listesi
        {
            StudentModel studentModel = DeserializeModel();
            Student student = _database.FindStudents(studentModel.Student.Number);
            PeriodListing periodListing = new PeriodListing(student.ReceivedLessons);

            NoteListModel model = new NoteListModel()
            {
                Periods = periodListing.GetPeriods() //periods (20-21 autumn, 20-21 spring)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult NoteList(string selectPeriod) // Not Listesi
        {
            StudentModel studentModel = DeserializeModel();
            Student student = _database.FindStudents(studentModel.Student.Number);
            PeriodListing periodListing = new PeriodListing(student.ReceivedLessons);

            string period = periodListing.ConvertPeriodName(selectPeriod), season = periodListing.ConvertSeasonName(selectPeriod);

            List<string> receivedLessons = _database.GetReceivedLessons(student.Number, periodListing.PeriodsToInt(selectPeriod).ToString());
            List<string> lessonNames = _database.GetLessonName(receivedLessons);
            List<StudentNoteInfo> studentNoteInfos = _database.GetStudentNoteInfos(receivedLessons,period,season,student.Number);
            

            NoteListModel model = new NoteListModel()
            {
                Periods = periodListing.GetPeriods(), //periods (20-21 autumn, 20-21 spring)
                ReceivedLessons = receivedLessons,
                StudentNoteInfos = studentNoteInfos,
                LessonNames = lessonNames,
                Period = selectPeriod
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult TranscriptScript() // Transkript Senaryosu
        {
            return View();
        }

        [HttpGet]
        public IActionResult AbsenceStatus() // Devamsızlık Durumu
        {
            return View();
        }

        private StudentModel DeserializeModel()
        {
            string data = TempData["studentModel"].ToString();
            StudentModel studentModel = JsonSerializer.Deserialize<StudentModel>(data);
            return studentModel;
        }
    }
}
