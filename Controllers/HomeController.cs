using Microsoft.AspNetCore.Mvc;
using OS_GJ_Tutoring.Models;
using System.Diagnostics;

namespace OS_GJ_Tutoring.Controllers
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

        /*Added new razor view pages*/
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Discussion_Forum()
        {
            return View();
        }

        public IActionResult Quizzes()
        {
            return View();
        }

        public IActionResult Resources()
        {
            return View();
        }

        public IActionResult Sessions()
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
