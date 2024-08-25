using Ejercicio04.Entidades;

public class RepositorioNumerosArmstrong
{
    private int _cantidad;
    private NumeroArmstrong[] _numeros;

    public int Cantidad => _cantidad;

    public RepositorioNumerosArmstrong(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser mayor que 0.");

        _cantidad = cantidad;
        _numeros = new NumeroArmstrong[cantidad];
    }

    public RepositorioNumerosArmstrong() : this(5) { }

    private bool EstaCompleto() => _numeros.All(n => n != null);

    private bool EstaVacio() => _numeros.All(n => n == null);

    private bool YaExiste(NumeroArmstrong numero) => _numeros.Contains(numero);

    public (bool, string) AgregarNumero(NumeroArmstrong numero)
    {
        if (EstaCompleto())
            return (false, "El repositorio está lleno.");

        if (YaExiste(numero))
            return (false, "El número ya existe en el repositorio.");

        for (int i = 0; i < _numeros.Length; i++)
        {
            if (_numeros[i] == null)
            {
                _numeros[i] = numero;
                return (true, "Número agregado correctamente.");
            }
        }
        return (false, "No se pudo agregar el número.");
    }

    public (bool, string) QuitarNumero(NumeroArmstrong numero)
    {
        for (int i = 0; i < _numeros.Length; i++)
        {
            if (_numeros[i] == numero)
            {
                _numeros[i] = null;
                return (true, "Número eliminado correctamente.");
            }
        }
        return (false, "Número no encontrado en el repositorio.");
    }

    public NumeroArmstrong ObtenerNumero(int indice)
    {
        if (indice < 0 || indice >= _numeros.Length)
            throw new IndexOutOfRangeException("Índice fuera de rango.");

        return _numeros[indice];
    }

    public string ObtenerTodosLosNumeros()
    {
        if (EstaVacio())
            return "No hay elementos almacenados todavía.";

        return string.Join("\n", _numeros.Select(n => n != null ? n.ToString() : "Elemento nulo"));
    }

    public (bool, int) ContieneNumero(NumeroArmstrong numero)
    {
        for (int i = 0; i < _numeros.Length; i++)
        {
            if (_numeros[i] == numero)
            {
                return (true, i);
            }
        }
        return (false, -1);
    }

    public static implicit operator int(RepositorioNumerosArmstrong repositorio)
    {
        return repositorio._numeros.Where(n => n != null && n.EsValido()).Sum(n => n.Valor);
    }
}