using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {


            OffenceModel offence = new OffenceModel()
            {
                nom = "lachheb",
                prenom = "Ahmedd"
            };
            return View(offence);



        }
    }
}
