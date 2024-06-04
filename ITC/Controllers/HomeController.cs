using ITC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITC.Controllers
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

        public IActionResult Aboutus()
        {
            return View();
        }

        public IActionResult computerlaptop()
        {
            return View();
        }

        public IActionResult freecourses()
        {
            return View();
        }

        public IActionResult services()
        {
            return View();
        }

        public IActionResult onsitecourses()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
