using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyWebsite.Controllers
{
    public class HomeController : Controller
    {
        // An ASP.NET Action ia a public method in a controller
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Email"] = "noreply@cptc.edu";
            return View();
        }
    }
}