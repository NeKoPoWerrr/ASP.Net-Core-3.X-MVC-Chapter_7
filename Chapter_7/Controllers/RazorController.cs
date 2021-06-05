using Chapter_7.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_7.Controllers
{
    public class RazorController : Controller
    {
        public IActionResult InheritsRazorPage()
        {
            AuthorViewModel author = new AuthorViewModel { Name = "聖殿祭司" };
            return View(author);
        }
        public IActionResult RazorFunctions()
        {
            return View();
        }
        public IActionResult RazorStatement()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
