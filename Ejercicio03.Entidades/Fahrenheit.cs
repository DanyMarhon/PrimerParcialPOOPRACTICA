namespace Ejercicio03.Entidades
{
    public class Fahrenheit
    {
        private float grados;
        public float GetGrados() => grados;

        public Fahrenheit(float grados = 5)
        {
            this.grados = grados;
        }

        public static implicit operator float(Fahrenheit fahrenheit)
        {
            return fahrenheit.grados;
        }

        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return f1.grados == f2.grados;
        }

        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1.grados == f2.grados);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Fahrenheit fahrenheit)) return false;
            return this.Equals(fahrenheit);
        }

        public override int GetHashCode()
        {
            return this.grados.GetHashCode();
        }

        public static explicit operator Fahrenheit(Celsius ce)
        {
            return new Fahrenheit(ce.GetGrados() * (9 / 5) + 32);
        }

        public static bool operator ==(Fahrenheit f, Celsius c)
        {
            return f == (Fahrenheit)c;
        }

        public static bool operator !=(Fahrenheit f, Celsius c)
        {
            return !(f == (Fahrenheit)c);
        }

        public static Fahrenheit operator +(Fahrenheit f1, Fahrenheit f2)
        {
            return new Fahrenheit(f1.grados + f2.grados);
        }

        public static Fahrenheit operator +(Fahrenheit f1, Celsius c)
        {
            return new Fahrenheit(f1.grados + (Fahrenheit)c);
        }
    }
}
