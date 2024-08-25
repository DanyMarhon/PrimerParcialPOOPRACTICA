using Ejercicio04.Entidades;

namespace Ejercicio04.Datos
{
    public class RepositorioNumeros
    {
        private NumeroArmstrong[]? numeros;
        private int cantidad;
        public int GetCantidad() => cantidad;

        public RepositorioNumeros()
        {
            cantidad = 5;
        }
        // Metodo del profe que no anda
        //public RepositorioNumeros() : this(5)
        //{
           
        //}

        public RepositorioNumeros(int Cantidad)
        {
            if (Cantidad >= 0)
            {
                cantidad = Cantidad;
                numeros = new NumeroArmstrong[Cantidad];
            }
            throw new ArgumentException("Cantidad no valida");
        }

        private bool EstaVacio() => numeros!.All(n => n is null);
        private bool EstaLleno() => numeros!.All(n => !(n is null));
        private bool Existe(NumeroArmstrong nBuscado) => numeros!.Any(n => n == nBuscado);

        public (bool, string) Agregar(NumeroArmstrong nAgregar)
        {
            if (EstaLleno()) { return (false, "No hay capacidad de almacenamiento"); };
            if (!nAgregar.EsValido()) { return (false, "Número Armstrong no válido"); };
            if (Existe(nAgregar)) { return (false, "Número Armstrong ya existe"); };
            for (int i = 0; i <= numeros!.Length; i++)
            {
                if (numeros[i] is null)
                {
                    numeros[i] = nAgregar;
                    return (true, $"Número agregado en la posición {i}");
                }
            }
            return (false, "Joder, no se pudo agregar");
        }

        public (bool, string) Quitar(NumeroArmstrong nQuitar)
        {
            if (EstaVacio()) { return (false, "No hay nada en el almacenamiento"); };
            if (!Existe(nQuitar)) { return (false, "Número Armstrong no existe"); };

            for (int i = 0; i <= numeros!.Length; i++)
            {
                if (numeros[i].Equals(nQuitar))
                {
                    numeros[i] = null;
                    return (true, $"Número quitado de la posición {i}");
                }
            }
            return (false, "Joder, no se pudo quitar");
        }

        public NumeroArmstrong? BuscarNumero(int index)
        {
            if (index < 0 || index > cantidad - 1)
            {
                throw new ArgumentOutOfRangeException("Índice fuera del rango permitido");
            }
            return numeros![index];
        }

        public string MostrarNumeros()
        {
            string resultado = string.Empty;
            if (EstaVacio()) { resultado = "No hay números todavía"; }
            else
            {
                for (int i = 0; i < numeros!.Length; i++)
                {
                    resultado += numeros[i] is null ? "Número nulo" : numeros[i].ToString;
                    resultado += " \n ";
                }
            }
            return resultado;
        }

        public (bool, int) EncontrarNúmero(NumeroArmstrong n)
        {
            if (EstaVacio() || !Existe(n)) { return (false, -1); }
            for (int i = 0; i < numeros!.Length; i++)
            {
                if (n.Equals(numeros[i]))
                { return (true, i); }
            }
            return (false, -1);
        }

        public static implicit operator int (RepositorioNumeros repo)
        {
            if (repo.EstaVacio()) return 0;
            return repo.numeros!.Sum(x => x.Valor);
        }
    }
}
