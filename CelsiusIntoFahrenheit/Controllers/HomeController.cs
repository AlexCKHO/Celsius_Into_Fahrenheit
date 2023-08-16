using CelsiusIntoFahrenheit.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CelsiusIntoFahrenheit.Controllers
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

        public IActionResult Convertor()
        {
            return View();
        }

        public double convertingCToF(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}