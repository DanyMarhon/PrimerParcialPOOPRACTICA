namespace Ejercicio04.Entidades
{
    public class NumeroArmstrong
    {
        public int Valor { get; set; }

        public NumeroArmstrong(int valor)
        {
            Valor = valor;

        }
        public bool EsValido()
        {
            int suma = 0;
            int temp = Valor;
            int n = Valor.ToString().Length;
            while (temp > 0)
            {
                int digito = temp % 10;
                suma += (int)Math.Pow(digito, n);
                temp /= 10;
            }
            return suma == Valor;
        }

        public override string ToString()
        {
            return $"{Valor}";
        }

        public static bool operator ==(NumeroArmstrong a1, NumeroArmstrong a2)
        {
            if (ReferenceEquals(a1, a2)) // Si ambos son el mismo objeto o ambos son null
                return true;

            if (a1 is null || a2 is null) // Si uno es null y el otro no
                return false;

            return a1.Valor == a2.Valor;
        }

        public static bool operator !=(NumeroArmstrong a1, NumeroArmstrong a2)
        {
            return !(a1 == a2); // Utiliza la sobrecarga de ==
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is NumeroArmstrong arn)) return false;
            return this == arn;
        }

        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }
    }
}
