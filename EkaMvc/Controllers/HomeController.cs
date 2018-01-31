using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EkaMvc.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EkaMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowMore()
        {
            return Content("Kaikki toimii!");
        }

        [HttpGet]
        public IActionResult Students(string nimi, string osoite)
        {
            ViewData["osoite"] = "Opistotie";
            ViewBag.hidden_data = "jotain";

            List<string> _list = new List<string> {
                "Kalle", "Ville", "Heikki", "Matti", "Jaska", "Osakri"
            };

            ViewData["students"] = _list;
            ViewData["opiskelijat"] = new SelectList(_list, "Jaska");

            //return View("Users");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
