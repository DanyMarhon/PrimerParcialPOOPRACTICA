namespace Ejercicio03T2.Entidades
{
    public class Kilometros
    {
        private float distancia;
        public float GetDistancia() => distancia;

        public Kilometros(float distancia = 100)
        {
            this.distancia = distancia;
        }

        public static implicit operator float(Kilometros distancia)
        {
            return distancia.distancia;
        }

        public static bool operator == (Kilometros k1, Kilometros k2)
        {
            return k1.distancia == k2.distancia;
        }

        public static bool operator != (Kilometros k1, Kilometros k2)
        {
            return !(k1.distancia == k2.distancia);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Kilometros kilometros)) return false;
            return this.Equals(kilometros);
        }

        public override int GetHashCode()
        {
            return this.distancia.GetHashCode();
        }

        public static explicit operator Kilometros(Millas m1)
        {
            return new Kilometros((m1.GetDistancia()) * 1.6093f);
        }   

        public static bool operator ==(Kilometros c, Millas m1)
        {
            return c == (Millas)m1;
        }

        public static bool operator !=(Kilometros k1, Millas m1)
        {
            return !(k1 == (Millas)m1);
        }

        public static Kilometros operator +(Kilometros k1, Kilometros k2)
        {
            return new Kilometros(k1.distancia + k2.distancia);
        }

        public static Kilometros operator +(Kilometros k1, Millas m1)
        {
            return new Kilometros(k1.distancia + (Kilometros)m1);
        }
    }
}
