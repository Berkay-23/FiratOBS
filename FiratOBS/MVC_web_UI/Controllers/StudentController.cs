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
            return View();
        }

        [HttpGet]
        public IActionResult ReceivedLessons() // Alınan  Dersler
        {
            string studentData = TempData["studentModel"].ToString();
            StudentModel studentModel  = JsonSerializer.Deserialize<StudentModel>(studentData);

            Student student = _database.FindStudents(studentModel.Student.Number);

            ReceivedLessonsModel model = new ReceivedLessonsModel();
            model.ReceivedLessonsCode = student.ReceivedLessons;
            model.Periods = null;

            return View(model);
        }

        [HttpPost]
        public IActionResult ReceivedLessons(int selectPeriod)
        {
            string data = TempData["studentModel"].ToString();
            StudentModel studentModel = JsonSerializer.Deserialize<StudentModel>(data);

            Student student = _database.FindStudents(studentModel.Student.Number);

            LessonListing lessonListing = new LessonListing(student.ReceivedLessons);
            
            ReceivedLessonsModel model = new ReceivedLessonsModel();
            model.ReceivedLessonsCode = student.ReceivedLessons;
            model.Periods = lessonListing.GetLessons(selectPeriod);
            model.ReceivedLessons = _database.GetLessons(model.Periods);
            model.Selectperiod = lessonListing.GetLessonsName(selectPeriod);

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
            return View();
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
    }
}
