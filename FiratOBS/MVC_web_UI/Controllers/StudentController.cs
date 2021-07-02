using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using MVC_web_UI.Models;
using DataAccess;

namespace MVC_web_UI.Controllers
{
    public class StudentController : Controller
    {
        private readonly FirebaseDB _database = new FirebaseDB();

        [HttpGet]
        public IActionResult StudentMain(Student student) // Öğrenci Giriş Ekranı 
        {
            StudentMainModel model = new StudentMainModel();
            model.Student = student;
            model.Academician = _database.FindAcademician(model.Student.CounselorMail);

            return View(model);
        }

        public IActionResult AcademicCalendar() // Akademik Takvim
        {
            return View();
        }

        public IActionResult ConsultantInformation() // Danışman Bilgileri
        {
            return View();
        }

        public IActionResult ReceivedLessons() // Alınan  Dersler
        {
            return View();
        }

        public IActionResult ExamSchedule() // Sınav Takvimi
        {
            return View();
        }

        public IActionResult InternshipInformation() // Staj Bilgileri
        {
            return View();
        }

        public IActionResult LessonEnrollment() // Ders Kaydı
        {
            return View();
        }

        public IActionResult NoteList() // Not Listesi
        {
            return View();
        }

        public IActionResult TranscriptScript() // Transkript Senaryosu
        {
            return View();
        }

        public IActionResult AbsenceStatus() // Devamsızlık Durumu
        {
            return View();
        }
    }
}
