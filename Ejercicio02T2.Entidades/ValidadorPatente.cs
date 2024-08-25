using System.Text.RegularExpressions;

namespace Ejercicio02T2.Entidades
{

    public static class ValidadorPatente
    {
        private static string formato1 = @"^[A-Z]{3} \d{3}$";   // AAA NNN
        private static string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$"; // AA NNN AA
        private static string messageNueva = " posee el formato nuevo";
        private static string messageVieja= " posee el formato viejo";

        public static bool Validar(string patente)
        {
            // Definir los patrones de los dos formatos de patentes
            

            // Validar contra los patrones utilizando Regex
            return (Regex.IsMatch(patente, ValidadorPatente.formato1) || Regex.IsMatch(patente, formato2)); 
        }

        public static string InformarPatente(string patente)
        {
            
            if (Regex.IsMatch(patente, formato1)) return $"La patente {patente} {messageVieja}";
            if (Regex.IsMatch(patente, formato2)) return $"La patente {patente} {messageNueva}";
            else { return $"El número {patente} no corresponde a una patente"; }
        }
    }

}
