using Microsoft.AspNetCore.Authorization;
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

        
        public IActionResult Tickets()
        {
            /*Data*/
            var chartData = new
            {
                Labels = new[] { "Courses Completed", "Resources Completed", "Sessions Completed", "Quizzes Completed" },
                Values = new[] { 20, 15, 30, 10 }
            };

            return View(chartData);
        }

        public IActionResult Plan()
        {
            return View();
        }

        public IActionResult Explore()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Stay()
        {
            return View();
        }

        public IActionResult Book()
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
