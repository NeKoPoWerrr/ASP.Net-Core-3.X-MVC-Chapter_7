using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_7.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult SimpleCard()
        {
            return View();
        }
    }
}
