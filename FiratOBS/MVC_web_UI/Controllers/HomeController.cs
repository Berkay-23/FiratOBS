using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_web_UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DataAccess;
using Entities;
using Business;

namespace MVC_web_UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginProcess _login = new LoginProcess();
        private readonly FirebaseDB _database = new FirebaseDB();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (user.Password != null && user.UserName != null)
            {
                Exception exception;

                if (user.UserType == "student")
                {
                    exception  = _login.FindStudent(user);

                    if (exception.Message.Equals("Student not found"))
                    {
                        ViewBag.Message = "Student not found";
                    }
                    else if (exception.Message.Equals("Student wrong password"))
                    {
                        ViewBag.Message = "Student wrong password";
                    }
                    else
                    {
                        Student student = _database.FindStudents(user.UserName);
                        return RedirectToAction("StudentMain","Student",student);
                    }
                }
                else
                {
                    exception =  _login.FindAcademician(user);

                    if (exception.Message.Equals("Academician not found"))
                    {
                        ViewBag.Message = "Academician not found";
                    }
                    else if (exception.Message.Equals("Academician wrong password"))
                    {
                        ViewBag.Message = "Academician wrong password";
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
                ViewBag.Message = "Password not entered";
            }

            return View();
        }

        [HttpGet]
        public IActionResult StudentList()
        {
            return View(_database.ListStudents());
        }

        [HttpGet]
        public IActionResult Detail(string number)
        {
            return View(_database.FindStudents(number));
        }

        [HttpGet]
        public IActionResult Edit(string number)
        {
            return View(_database.FindStudents(number));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
