using System;
using temp_converter.Models;


class Program
{
    static void Main()
    {
        var converter = new Converter();

        Console.WriteLine("Conversor de temperaturas. °F / °C");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit.");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius.");
        Console.Write("Elija una opción: ");
        var input = Console.ReadLine();


        if (input == "1")
        {
            Console.Write("Ingrese la temp en Celcius: ");
            var inputCelsius = Console.ReadLine();

            if (float.TryParse(inputCelsius, out float result))
            {
                float res = converter.ConvertToFar(result);
                Console.WriteLine($"La temperatura de Celsius a Fahrenheit es: {res:F1}°F");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
        else if (input == "2")
        {
            Console.Write("Ingrese la temp en Fahrenheit: ");
            var inputFahrenheit = Console.ReadLine();

            if (float.TryParse(inputFahrenheit, out float result))
            {
                float res = converter.ConvertToCel(result);
                Console.WriteLine($"La temperatura de Fahrenheit a Celsius es: {res:F1}°C");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida.");
        }
    }
}