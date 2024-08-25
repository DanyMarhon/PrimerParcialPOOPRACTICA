using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Entidades
{
    public static class ValidarFecha
    {
        public static bool Validar(int dia, int mes, int anio)
        {
            if ((dia < 1 || dia  > 31) || (mes < 1 || mes > 12) || (anio < 1 || anio > 9999)) return false;

            switch (mes)
            {
                case 2: if ((EsBiciesto(anio)) && ((dia >=1) && (dia <=29))) return true;
                    return false;
                case 11: if (dia >= 1 && dia <= 30) return true;
                    return false;
                default:
                    if (dia >= 1 && dia <= 31) return true;
                    return false;
            }
        }

        private static bool EsBiciesto(int anio)
        { return (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0); }

    }
    
}
