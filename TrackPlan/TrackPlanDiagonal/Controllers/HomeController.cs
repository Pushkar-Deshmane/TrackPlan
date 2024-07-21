using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrackPlanDiagonal.Models;

namespace TrackPlanDiagonal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return View();
            }
            return RedirectToAction("DisplayWord", new { word });
        }

        public IActionResult DisplayWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return RedirectToAction("Index");
            }
            ViewBag.Word = word;
            return View();
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
