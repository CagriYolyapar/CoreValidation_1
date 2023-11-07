using CoreValidation_1.Models;
using CoreValidation_1.Models.ContextClasses;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreValidation_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        MyContext _db;

        public HomeController(ILogger<HomeController> logger,MyContext db)
        {
            _db = db;        
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}