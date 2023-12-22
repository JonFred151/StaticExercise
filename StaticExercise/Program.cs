using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(60);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"This is celsius {celsius}, This is {fahrenheit}.");
        }
    }
}