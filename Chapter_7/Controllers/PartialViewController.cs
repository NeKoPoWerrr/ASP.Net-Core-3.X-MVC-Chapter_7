using Chapter_7.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter_7.Controllers
{
    public class PartialViewController : Controller
    {
        public List<Card> cards { get; } = new List<Card>
        {
            new Card { Name = "Elon Musk", Brief="特斯拉創辦人 伊隆·馬斯克", Photo="555.jpg", WikiUrl="https://goo.gl/46xeXx" },
            new Card { Name = "Mark Zuckerberg", Brief="Facebook創辦人 馬克·祖伯克", Photo="555.jpg", WikiUrl="https://goo.gl/BktGGA" },
            new Card { Name = "Steve Jobs", Brief="蘋果創辦人 史提夫·賈伯斯", Photo="555.jpg", WikiUrl="https://goo.gl/nAiX0y" },
            new Card { Name = "Vader", Brief="帝國元帥  維達", Photo="555.jpg", WikiUrl="https://en.wikipedia.org/wiki/Darth_Vader" },
            new Card { Name = "Darth Mual", Brief="星際大戰 達斯摩", Photo="555.jpg", WikiUrl="https://goo.gl/5obLhX"},
            new Card { Name = "White Twilek", Brief="星際大戰 女絕地武士Twilek", Photo="555.jpg", WikiUrl="https://goo.gl/reKzAu" },
            new Card { Name = "Obiwan", Brief="星際大戰 歐比旺Obiwan", Photo="555.jpg", WikiUrl="http://bit.ly/33gxdgt" },
            new Card { Name = "Merkel", Brief="德國總理 梅克爾", Photo="555.jpg", WikiUrl="http://bit.ly/33huSlv" }
        };
        public IActionResult PassViewData2PartialView()
        {
            ViewData["Movie"] = "Avengers";
            ViewData["Song"] = "When the party is over";
            return View();
        }
        public IActionResult CardList()
        {
            return View(cards);
        }
        public IActionResult SimpleCard()
        {
            return View();
        }
    }
}
