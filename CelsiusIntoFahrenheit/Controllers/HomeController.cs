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

        /*        [HttpPost]
                public IActionResult ConvertCelsiusToFahrenheit(double celsius)
                {
                    double fahrenheit = convertingCToF(celsius);
                    ViewData["Result"] = $"{celsius}°C is equivalent to {fahrenheit}°F.";
                    return View("Convertor");
                }*/

        [HttpPost]
        public IActionResult ConvertCelsiusToFahrenheit(double celsius)
        {
            if (celsius < -1.7976931348623157e+308 || celsius > 1.7976931348623157e+308)
            {
                ViewData["Error"] = "The value you entered is outside the range of acceptable values. Please enter a number between -1.7976931348623157e+308 and 1.7976931348623157e+308.";
                return View("Convertor");
            }

            if((Double.IsPositiveInfinity(convertingCToF(celsius))) || Double.IsNegativeInfinity(convertingCToF(celsius))) { 
                
                ViewData["Error"] = "The value you entered is outside the range of acceptable values. Please enter a number between -1.7976931348623157e+308 and 1.7976931348623157e+308.";
                return View("Convertor");
            }
            else {

                double fahrenheit = convertingCToF(celsius);
                ViewData["Result"] = $"{celsius}°C is equivalent to {fahrenheit}°F.";
                return View("Convertor");
            }

        }



        private double convertingCToF(double celsius)
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