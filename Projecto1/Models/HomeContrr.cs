using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto1.Models
{
    public class HomeContrr : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
