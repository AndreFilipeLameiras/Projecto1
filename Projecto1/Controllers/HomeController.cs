using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projecto1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                //Guardar a resposta
                Repository.AddResponse(response);
                return View("ThankYou", response);
            }
            else
            {
                //there are avlidations error
                return View();
            }
        }


        public IActionResult GuestList()
        {
            return View(Repository.Responses);
        }

        public IActionResult PeopleComingParty()
        {
            return View(Repository.Responses.Where(g => g.WillAttend == true));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
