using Ejercicio02T2.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio02T2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEjemplo patente nueva:  ");
            string patente = "AR 123 GG";
            Console.WriteLine(ValidadorPatente.InformarPatente(patente));

            Console.Write("\nEjemplo patente vieja:  ");
            string patente2 = "ARG 123";
            Console.WriteLine(ValidadorPatente.InformarPatente(patente2));

            Console.Write("\nEjemplo patente invalida:  ");
            string patente3 = "Joder123";
            Console.WriteLine(ValidadorPatente.InformarPatente(patente3));

            Console.Write("\nRealiza una prueba \n");
            Console.Write("Ingrese la patente:  ");
            string patente4 = Console.ReadLine()!;
            Console.WriteLine(ValidadorPatente.InformarPatente(patente4));
            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
