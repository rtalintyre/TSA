using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //build your ui here.
            return View();
        }
        
    }
}
