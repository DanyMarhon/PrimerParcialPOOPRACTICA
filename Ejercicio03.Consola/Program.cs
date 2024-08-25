using Ejercicio03.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celsius celsius = new Celsius(30);
            Fahrenheit fahrenheit = new Fahrenheit(40);

            Console.WriteLine($"Celsius: {celsius.GetGrados()}°C");
            Console.WriteLine($"Fahrenheit: {fahrenheit.GetGrados()}°F");

            // Conversión explícita entre tipos
            Celsius celsiusConverted = (Celsius)fahrenheit;
            Fahrenheit fahrenheitConverted = (Fahrenheit)celsius;

            Console.WriteLine(
                $"Fahrenheit convertido a Celsius: {celsiusConverted.GetGrados()}°C");
            Console.WriteLine(
                $"Celsius convertido a Fahrenheit: {fahrenheitConverted.GetGrados()}°F");

            // Operaciones aritméticas
            Celsius sumaCelsius = celsius + celsiusConverted;
            Fahrenheit sumaFahrenheit = fahrenheit + fahrenheitConverted;

            Console.WriteLine($"Suma de Celsius: {sumaCelsius.GetGrados()}°C");
            Console.WriteLine($"Suma de Fahrenheit: {sumaFahrenheit.GetGrados()}°F");

            // Comparaciones
            Console.WriteLine(
                celsius == celsiusConverted 
                ? "Las temperaturas en Celsius son iguales." 
                : "Las temperaturas en Celsius no son iguales.");
            Console.WriteLine(
                fahrenheit == fahrenheitConverted
                ? "Las temperaturas en Fahrenheit son iguales." 
                : "Las temperaturas en Fahrenheit no son iguales.");

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
