using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using T1_Sanchez_JuanManuel.Models;

namespace T1_Sanchez_JuanManuel.Controllers
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

        public IActionResult Nike()
        {
            return View();
        }

        public IActionResult Adidas()
        {
            return View();
        }

        public IActionResult Umbro()
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
