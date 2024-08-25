using Ejercicio02T2.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio02T2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la patente:");
            string patente = Console.ReadLine();
            Console.WriteLine(ValidadorPatente.InformarPatente(patente));
            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
