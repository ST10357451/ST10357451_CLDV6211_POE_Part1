using Microsoft.AspNetCore.Mvc;
using ST10357451_CLDV6211_POE_Part1.Models;
using System.Diagnostics;

namespace ST10357451_CLDV6211_POE_Part1.Controllers
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

        private readonly List<Models.WorkPage> _works;
        public IActionResult WorkPage(List<Models.WorkPage> works)
        {
            works = _works;

            works = new List<Models.WorkPage>
            {
                new Models.WorkPage{ CraftID = 001, Name = "John Doe", Category = "Wood-work", Price = 699.99, ImageURL = "images/Wood_work.jpg"},
                new Models.WorkPage{ CraftID = 002, Name = "Jane Doe", Category = "crochet", Price = 99.00, ImageURL = "images/crochet.jpeg"},
                new Models.WorkPage{ CraftID = 003, Name = "Joan Doe", Category = "3D-Printing", Price = 1050.00, ImageURL = "images/3D_Print.jpeg"}
            };

            return View(works);
        }

        public IActionResult Privacy()
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
