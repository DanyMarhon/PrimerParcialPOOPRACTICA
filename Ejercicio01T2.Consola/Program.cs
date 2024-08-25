using Ejercicio01T2.Entidades;
using PrimerParcialPOO2024Tema1.Shared;

namespace Ejercicio01T2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cono cono = new Cono(3,5); 

            Console.WriteLine(cono.GetInfo());

            ConsoleExtensions.EsperarPresionDeTecla(" ");
        }
    }
}
