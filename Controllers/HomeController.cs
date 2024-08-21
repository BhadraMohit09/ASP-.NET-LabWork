using Microsoft.AspNetCore.Mvc;
using ProjectASP.NET_MAB.Models;
using System.Diagnostics;

namespace ProjectASP.NET_MAB.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Trainers()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }

        public IActionResult Events()
        {
            return View();
        }

        public IActionResult CourseDetails() {
         
            return View();
        
        }

        public IActionResult GetStarted()
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
