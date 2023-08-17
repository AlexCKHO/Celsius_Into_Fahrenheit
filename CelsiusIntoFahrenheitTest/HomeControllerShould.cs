using CelsiusIntoFahrenheit.Controllers;
using Microsoft.AspNetCore.Mvc;


namespace CelsiusIntoFahrenheitTest
{
    [TestFixture]
    public class HomeControllerTests
    {
        private HomeController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new HomeController(null);
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_ValidInput_ReturnsViewWithModel()
        {
            double celsiusValue = 25.0;

            IActionResult result = _controller.ConvertCelsiusToFahrenheit(celsiusValue);

            Assert.IsInstanceOf<ViewResult>(result);

            var viewResult = result as ViewResult;
            Assert.AreEqual("Converter", viewResult.ViewName);

            Assert.AreEqual(celsiusValue, viewResult.ViewData["CelsiusTemperature"]);
            Assert.AreEqual(77.0, viewResult.ViewData["FahrenheitTemperature"]); // Expected value after rounding
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_Overflow_ReturnsViewWithErrorMessage()
        {
            double celsiusValue = double.MaxValue;

            IActionResult result = _controller.ConvertCelsiusToFahrenheit(celsiusValue);

            Assert.IsInstanceOf<ViewResult>(result);

            var viewResult = result as ViewResult;
            Assert.AreEqual("Converter", viewResult.ViewName);

            Assert.IsTrue(viewResult.ViewData.ContainsKey("Error"));
            Assert.AreEqual("The value you entered is outside the range of acceptable values. Please enter a number between -9.9871840825684201e+306 and 9.9871840825684201e+306.", viewResult.ViewData["Error"]);
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_Underflow_ReturnsViewWithErrorMessage()
        {
            double celsiusValue = double.MinValue;

            IActionResult result = _controller.ConvertCelsiusToFahrenheit(celsiusValue);

            Assert.IsInstanceOf<ViewResult>(result);

            var viewResult = result as ViewResult;
            Assert.AreEqual("Converter", viewResult.ViewName);

            Assert.IsTrue(viewResult.ViewData.ContainsKey("Error"));
            Assert.AreEqual("The value you entered is outside the range of acceptable values. Please enter a number between -9.9871840825684201e+306 and 9.9871840825684201e+306.", viewResult.ViewData["Error"]);
        }
    }
}
