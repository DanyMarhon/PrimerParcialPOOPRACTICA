using System.Globalization;

namespace Ejercicio02.Entidades
{
    public static class ValidadorFecha
    {
        private static bool EsBisiesto(int anio)
        {
            return (anio % 4 == 0 && anio % 100 != 0) || (anio % 400 == 0);
        }

        public static bool Validar(int dia, int mes, int anio)
        {
            // Validar año, mes y día en un rango básico
            if (anio < 1 || anio > 9999 || mes < 1 || mes > 12 || dia < 1 || dia > 31)
            {
                return false;
            }

            // Validar los días según el mes
            if (mes == 2)
            {
                // Febrero tiene 29 días en años bisiestos, y 28 en los demás
                if (EsBisiesto(anio))
                {
                    if (dia > 29) return false;
                }
                else
                {
                    if (dia > 28) return false;
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                // Abril, junio, septiembre y noviembre tienen 30 días
                if (dia > 30) return false;
            }

            // Verificar la fecha con TryParseExact para confirmarla como válida
            string fechaString = $"{dia:00}/{mes:00}/{anio:0000}";
            if (!DateTime.TryParseExact(fechaString, "dd/MM/yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                return false;
            }

            return true; // Si todas las validaciones pasaron, la fecha es válida
        }
    }
}