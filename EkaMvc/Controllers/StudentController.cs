using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EkaMvc.Models;
using EkaMvc.Extensions;

namespace EkaMvc.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Otsikko = "Ihan oma idenx";

            UserViewModel v = new UserViewModel();
            v.Nimi = "Tallessa sessiossa";
            HttpContext.
                .Set<UserViewModel>("data", v);
            
            return View(v);
        }

        [HttpPost]
        public IActionResult Index(UserViewModel m)
        {
            var d = HttpContext.
.Get<UserViewModel>("data") as UserViewModel;

            if ( d != null )
            {

            }
            ViewBag.Nimi = m.Nimi;
            return View(m);
        }

        public IActionResult Users()
        {
            var lista = new List<UserViewModel>();
            lista.Add(new UserViewModel {Id=10, Nimi="Kalle", Osoite="teku" });
            lista.Add(new UserViewModel { Id = 11, Nimi = "Ville", Osoite = "liku" });
            lista.Add(new UserViewModel { Id = 12, Nimi = "Heikki", Osoite = "sabu" });


            return View(lista);
        }

    }
}