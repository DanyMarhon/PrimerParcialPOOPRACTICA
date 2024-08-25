using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03T2.Entidades
{
    public class Millas
    {
        private float distancia;
        public float GetDistancia() => distancia;

        public Millas(float distancia = 100)
        {
            this.distancia = distancia;
        }

        public static implicit operator float(Millas distancia)
        {
            return distancia.distancia;
        }

        public static bool operator ==(Millas m1, Millas m2)
        {
            return m1.distancia == m2.distancia;
        }

        public static bool operator !=(Millas m1, Millas m2)
        {
            return !(m1.distancia == m2.distancia);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Millas millas)) return false;
            return this.Equals(millas);
        }

        public override int GetHashCode()
        {
            return this.distancia.GetHashCode();
        }

        public static explicit operator Millas(Kilometros k1)
        {
            return new Millas((k1.GetDistancia()) * 0.621371f);
        }

        public static bool operator ==(Millas m1, Kilometros k1)
        {
            return m1 == (Millas)k1;
        }

        public static bool operator !=(Millas m1, Kilometros k1)
        {
            return !(m1 == (Millas)k1);
        }

        public static Millas operator +(Millas m1, Millas m2)
        {
            return new Millas(m1.distancia + m1.distancia);
        }

        public static Millas operator +(Millas m1, Kilometros k1)
        {
            return new Millas(m1.distancia + (Millas)k1);
        }
    }
}
