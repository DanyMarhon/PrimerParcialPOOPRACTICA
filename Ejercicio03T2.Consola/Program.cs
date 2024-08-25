using Ejercicio03T2.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio03T2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilometros kilometros = new Kilometros(1);
            Millas millas = new Millas(1);

            Console.WriteLine($"Kilometros: {kilometros.GetDistancia()} KM");
            Console.WriteLine($"Millas: {millas.GetDistancia()} MI");

            // Conversión explícita entre tipos
            Kilometros kilometrosConverted = (Kilometros)millas;
            Millas millasConverted = (Millas)kilometros;

            Console.WriteLine(
                $"Millas convertido a Kilometros: {kilometrosConverted.GetDistancia()} KM");
            Console.WriteLine(
                $"Kilometros convertido a Millas: {millasConverted.GetDistancia()} MI");

            // Operaciones aritméticas
            Kilometros sumaKilometros = kilometros + kilometrosConverted;
            Millas sumaMillas = millas + millasConverted;

            Console.WriteLine($"Suma de Kilometros: {sumaKilometros.GetDistancia()} KM");
            Console.WriteLine($"Suma de Millas: {sumaMillas.GetDistancia()} MI");

            // Comparaciones
            Console.WriteLine(
                kilometros == kilometrosConverted
                ? "Las distancias en kilómetros son iguales."
                : "Las distancias en kilómetros no son iguales.");
            Console.WriteLine(
                millas == millasConverted
                ? "Las distancias en millas son iguales."
                : "Las distancias en millas no son iguales.");

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
