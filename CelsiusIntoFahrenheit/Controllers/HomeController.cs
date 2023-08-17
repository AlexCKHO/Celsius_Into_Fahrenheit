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

        public IActionResult Converter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = convertingCToF(celsius);

            // Check if the calculated Fahrenheit value is overflow or underflow

            if ((Double.IsPositiveInfinity(fahrenheit)) || Double.IsNegativeInfinity(fahrenheit))
            {

                ViewData["Error"] = "The value you entered is outside the range of acceptable values. " +
                    "Please enter a number between -9.9871840825684201e+306 and 9.9871840825684201e+306.";

            }
            else
            {

                ViewData["CelsiusTemperature"] = celsius;

                ViewData["FahrenheitTemperature"] = fahrenheit;
            }

            return View("Converter");
        }



        private double convertingCToF(double celsius)
        {
            return Math.Round(((celsius * 9.0 / 5.0) + 32.0), 5);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}