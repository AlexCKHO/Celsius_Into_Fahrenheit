// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function setThermometerTemperature(celsiusTemp) {

    let tempVal = document.getElementById("temp-val");
    let tempFill = document.getElementById("temp-fill");
    let tempF = nearest10th(CToF(celsiusTemp));

    tempVal.setAttribute("data-c", celsiusTemp);
    tempVal.setAttribute("data-f", tempF);

    let scaleY = 0,
        scaleYMax = 0.995;
    let minTempC = -53,
        maxTempC = 70;


    scaleY += ((celsiusTemp - minTempC) / (Math.abs(minTempC) + maxTempC)) * 1.0907555;

    if (scaleY > scaleYMax)
        scaleY = scaleYMax;
    else if (scaleY < 0)
        scaleY = 0;

    tempFill.style.transform = `scaleY(${scaleY})`;
    tempVal.title = `${celsiusTemp}°C, ${tempF}°F`;
}



// Convert Celsius to Fahrenheit
function CToF(celsius) {
    return (celsius * 9 / 5) + 32;
}

// Round to the nearest 10th
function nearest10th(n) {
    return Math.round(n * 10) / 10;
}