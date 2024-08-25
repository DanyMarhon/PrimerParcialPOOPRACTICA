using Ejercicio01.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PiramideCuadrada piramide = new PiramideCuadrada(6,12);

            Console.WriteLine(piramide.GetInfo());

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
