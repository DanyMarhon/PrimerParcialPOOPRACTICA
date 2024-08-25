using Ejercicio02.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidarFecha.Validar(2, 10, 1997));
            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
