using Assignment1_0733.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment1_0733.Controllers
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
            MobileAccess access = new MobileAccess();
            var Mobile = access.GetMobile();
            return View(Mobile);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult laptop()
        {
            LaptopAccess access = new LaptopAccess();
            var Laptop = access.GetLaptop();
            return View(Laptop);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}