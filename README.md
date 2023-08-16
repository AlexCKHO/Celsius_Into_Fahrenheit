# Celsius to Fahrenheit Converter (ASP.NET MVC)

This web application allows users to convert temperatures from Celsius to Fahrenheit. Along with displaying the conversion result, it provides a visual representation using an interactive thermometer.

## Features

- **Celsius Input**: Users can input a value in Celsius.
- **Fahrenheit Result**: Upon conversion, the equivalent Fahrenheit value is displayed.
- **Formula Display**: The application displays the formula used for the conversion.
- **Interactive Thermometer**: A side visualization of a thermometer that updates based on the input temperature.
- **Error Handling**: Handles out-of-range inputs by displaying an appropriate error message.

## Technology Used

- **ASP.NET MVC Web App**

- **HTML**
  
- **CSS**
  
- **Bootstrap 4.5.2**

- **JavaScript**

- **MathJax 2.7.9**


## Structure

### Controller (`HomeController`)

1. **Index()**: Returns the default view.
2. **Convertor()**: Returns the converter view.
3. **ConvertCelsiusToFahrenheit()**: Takes the Celsius temperature as input, converts it to Fahrenheit, and returns the converter view with the result or an error message.
4. **Error()**: Returns an error view.

### View (`Convertor`)

1. **Form**: Input field for Celsius value and a conversion button.
2. **Error Display**: Shows an error message for out-of-range values.
3. **Result Display**: Displays the Fahrenheit equivalent and the conversion formula.
4. **Thermometer Visualization**: A dynamic thermometer that changes based on the input temperature.

## Installation & Usage

1. **Prerequisites**:
   - Ensure you have ASP.NET MVC set up on your machine.
   - Install necessary packages if prompted.

2. **Clone the Repository**:
   ```bash
   
   git clone [repository-url](https://github.com/AlexCKHO/Celsius_Into_Fahrenheit.git)
   
   ```

3. **Navigate to the Project Directory**:
    ```bash
    cd path-to-project-directory
    ```


4. **Run the Application**:
Use the in-built tools of ASP.NET MVC to build and run the project.

5. **Usage**:
- Navigate to the Convertor page.
- Enter a Celsius value in the input field.
- Click "Convert" to get the Fahrenheit equivalent.
- Check the thermometer visualization to see the temperature representation.

## Limitations

The application checks for overflow or underflow situations. It expects values to be between -9.9871840825684201e+306 and 9.9871840825684201e+306 for valid conversion. If outside this range, an error message is shown.
