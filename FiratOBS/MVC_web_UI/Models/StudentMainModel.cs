using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace MVC_web_UI.Models
{
    public class StudentMainModel
    {
        public Student Student { get; set; }
        public Academician Academician { get; set; }
    }
}
