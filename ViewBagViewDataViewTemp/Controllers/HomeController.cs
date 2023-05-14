using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewBagViewDataViewTemp.Models;

namespace ViewBagViewDataViewTemp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //ViewData

            var p = new Product
            {
                Id = 1,
                Name = "Product1",
                Price = 122
            };

            //ViewData["ProductName"] = p.Name;
            //ViewData["Name"] = "Name";
            //ViewData["Surname"] = "Surname";    
            //ViewData["Age"] = 20;

            //ViewBag


            //TempData
            ViewData["Name"] = "Name";
            ViewBag.Surname = "Surname";
            TempData["Age"] = 25;


            return RedirectToAction("About");
        }

        public IActionResult About() 
        {
            return View();
        }
    }
}
