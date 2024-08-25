using Ejercicio04.Datos;
using Ejercicio04.Entidades;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioNumeros repositorio = new RepositorioNumeros();

            while (true)
            {
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar Número Armstrong");
                Console.WriteLine("2. Quitar Número Armstrong");
                Console.WriteLine("3. Mostrar Números");
                Console.WriteLine("4. Buscar Número Armstrong");
                Console.WriteLine("5. Mostrar Suma de Números Armstrong");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese un número: ");
                        if (int.TryParse(Console.ReadLine(), out int valor))
                        {
                            NumeroArmstrong numero = new NumeroArmstrong(valor);
                            var (agregado, mensaje) = repositorio.Agregar(numero);
                            Console.WriteLine(mensaje);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "2":
                        Console.Write("Ingrese un número: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            NumeroArmstrong numero = new NumeroArmstrong(valor);
                            var (quitado, mensaje) = repositorio.Quitar(numero);
                            Console.WriteLine(mensaje);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "3":
                        Console.WriteLine(repositorio.MostrarNumeros());
                        break;

                    case "4":
                        Console.Write("Ingrese un número: ");
                        if (int.TryParse(Console.ReadLine(), out valor))
                        {
                            NumeroArmstrong numero = new NumeroArmstrong(valor);
                            var (encontrado, posicion) = repositorio.EncontrarNúmero(numero);
                            if (encontrado)
                            {
                                Console.WriteLine($"Número encontrado en la posición {posicion}.");
                            }
                            else
                            {
                                Console.WriteLine("Número no encontrado.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "5":
                        int suma = repositorio;
                        Console.WriteLine($"La suma de los números Armstrong es: {suma}");
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}

