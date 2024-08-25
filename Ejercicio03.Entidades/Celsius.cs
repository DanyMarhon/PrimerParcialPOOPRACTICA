using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03.Entidades
{
    public class Celsius
    {
        private float grados;
        public float GetGrados() => grados;

        public Celsius(float grados = 5)
        {
            this.grados = grados;
        }

        public static implicit operator float(Celsius celsius)
        {
            return celsius.grados;
        }

        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return c1.grados == c2.grados;
        }

        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1.grados == c2.grados);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Celsius celsius)) return false;
            return this.Equals(celsius);
        }

        public override int GetHashCode()
        {
            return this.grados.GetHashCode();
        }

        public static explicit operator Celsius(Fahrenheit fa)
        {
            return new Celsius((fa.GetGrados() - 32) * 9 / 5);
        }

        public static bool operator == (Celsius c, Fahrenheit f)
            {
            return c ==(Celsius)f;
            }

        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == (Celsius)f);
        }

        public static Celsius operator + (Celsius c1, Celsius c2)
        {
            return new Celsius (c1.grados + c2.grados);
        }

        public static Celsius operator +(Celsius c1, Fahrenheit f)
        {
            return new Celsius(c1.grados + (Celsius)f);
        }
    }
}
