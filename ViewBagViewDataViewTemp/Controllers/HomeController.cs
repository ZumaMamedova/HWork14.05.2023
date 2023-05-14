using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewBagViewDataViewTemp.Models;

namespace ViewBagViewDataViewTemp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About() 
        {
            return View();
        }
    }
}
