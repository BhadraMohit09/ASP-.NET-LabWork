using Microsoft.AspNetCore.Mvc;
using ProjectAdminPanel_MAB.Models;
using System.Diagnostics;

namespace ProjectAdminPanel_MAB.Controllers
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

        public IActionResult ChartsApexCharts()
        {
            return View();
        }

        public IActionResult ChartsChartJS()
        {
            return View();
        }

        public IActionResult ChartsECharts()
        {
            return View();
        }

        public IActionResult ComponentAccordian() {
            return View();
        }

        public IActionResult ComponentAlerts() {
            return View();
        }

        public IActionResult ComponentBadges()
        {
            return View();
        }

        public IActionResult ComponentBreadCrumbs()
        {
            return View();
        }

        public IActionResult ComponentButtons()
        {
            return View();
        }

        public IActionResult ComponentCards()
        {
            return View();
        }

        public IActionResult ComponentCarousel()
        {
            return View();
        }

        public IActionResult ComponentListGroup()
        {
            return View();
        }

        public IActionResult ComponentModal()
        {
            return View();
        }

        public IActionResult ComponentPagination()
        {
            return View();
        }

        public IActionResult ComponentProgress()
        {
            return View();
        }

        public IActionResult ComponentSpinners()
        {
            return View();
        }

        public IActionResult ComponentTabs()
        {
            return View();
        }

        public IActionResult ComponentToolTips()
        {
            return View();
        }

        public IActionResult FormEditors()
        {
            return View();
        }

        public IActionResult FormElements()
        {
            return View();
        }

        public IActionResult FormLayout()
        {
            return View();
        }

        public IActionResult FormValidation()
        {
            return View();
        }

        public IActionResult IconsBootstrap()
        {
            return View();
        }

        public IActionResult IconBoxIcons()
        {
            return View();
        }

        public IActionResult IconsRemix()
        {
            return View();
        }

        public IActionResult PagesBlank()
        {
            return View();
        }

        public IActionResult PagesContact()
        {
            return View();
        }

        public IActionResult PagesError404()
        {
            return View();
        }

        public IActionResult PagesFAQ()
        {
            return View();
        }

        public IActionResult PagesLogin()
        {
            return View();
        }

        public IActionResult PagesRegister()
        {
            return View();
        }

        public IActionResult TablesData()
        {
            return View();
        }

        public IActionResult TablesGeneral()
        {
            return View();
        }

        public IActionResult UserProfile()
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
