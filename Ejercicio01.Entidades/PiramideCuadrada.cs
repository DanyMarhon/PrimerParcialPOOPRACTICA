using PrimerParcialPOO2024Tema1.Shared;
using System.Runtime.CompilerServices;

namespace Ejercicio01.Entidades
{
    public class PiramideCuadrada
    {
        public int _lado { get; }
        public int _altura { get; }
        private double apotema { get; set; }

        public PiramideCuadrada(int lado, int altura)
        {
            if (altura <= 0 || lado <= 0)
            {
                throw new ArgumentException("Datos no validos");      
            }
            _lado = lado;
            _altura = altura;
            GetApotema();
        }

        public double GetApotema()=> Math.Sqrt(Math.Pow(_lado / 2.0, 2) + Math.Pow(_altura, 2));

        public double GetAreaTotal()=> Math.Pow(_lado, 2) + 2 * _lado * GetApotema();

        public double GetVolumen()=> (Math.Pow(_lado, 2) * _altura) / 3.0;

        public string GetInfo()
        {
            string message = 
                $"Datos de la pirámide cuadrada \n " +
                $"\t Lado = {_lado}\n" +
                $"\t Altura = {_altura}\n" +
                $"\t Apotema = {GetApotema()}\n" +
                $"\t Area = {GetAreaTotal()}\n" +
                $"\t Volumen = {GetVolumen()}\n";
            return message;
        }
    }
}
