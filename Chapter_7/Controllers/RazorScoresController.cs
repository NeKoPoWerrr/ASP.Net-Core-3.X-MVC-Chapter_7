using Chapter_7.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_7.Controllers
{
    public class RazorScoresController : Controller
    {
        protected List<Student> students = new List<Student>
        {
            new Student {Id=1, Name="Joy", Chinese=88,English=95 ,Math=71},
            new Student {Id=12, Name="Mary", Chinese=92,English=82 ,Math=60},
            new Student {Id=23, Name="Cathy", Chinese=98,English=91 ,Math=94},
            new Student {Id=34, Name="John", Chinese=63,English=85 ,Math=55},
            new Student {Id=45, Name="David", Chinese=59,English=77 ,Math=82},
        };

        public IActionResult ScoresRazor()
        {
            students.ForEach(s => s.Total = s.Chinese + s.Math + s.English);
            var topid = students.OrderByDescending(s => s.Total)
                .Select(s => s.Id)
                .FirstOrDefault();
            ViewData["Topid"] = topid;
            return View(students);
        }
        public IActionResult Scores()
        {
            return View(students);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
