using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using ViewBagViewDataViewTemp.DAL;
using ViewBagViewDataViewTemp.Models;

namespace ViewBagViewDataViewTemp.Controllers
{
   
    public class HomeController : Controller

        //constructor
    {
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration _confiq;

        public HomeController(AppDbContext appDbContext, IConfiguration confiq)
        {
            _appDbContext = appDbContext;
            _confiq = confiq;
        }

        public IActionResult Index()
        {
            List<Student> students = _appDbContext.Students.ToList();
            //Student student = _appDbContext.Students.FirstOrDefault(p=>p.Id==1);
            var name = _confiq.GetSection("name").Value;
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }
    }

    
}
