namespace Ejercicio01T2.Entidades
{
    public class Cono
    {
        private int _radio { get; }
        private int _altura { get; }

        public Cono(int radio, int altura)
        {
            if (altura <= 0 || radio <= 0)
            {
                throw new ArgumentException("Datos no validos");
            }
            _radio = radio;
            _altura = altura;
            GetGeneratriz();
        }

        public double GetGeneratriz()=> Math.Sqrt(Math.Pow(_altura, 2) + Math.Pow(_radio, 2));

        public double GetAreaTotal() => (Math.PI * Math.Pow(_radio, 2)) + (Math.PI * _radio * GetGeneratriz());

        // Método para calcular el volumen
        public double GetVolumen() => (Math.PI * Math.Pow(_radio, 2) * _altura) / 3;

        public string GetInfo()
        {
            string message =
                $"Datos del cono \n " +
                $"\t Radio = {_radio}\n" +
                $"\t Altura = {_altura}\n" +
                $"\t Generatriz = {GetGeneratriz()}\n" +
                $"\t Area = {GetAreaTotal()}\n" +
                $"\t Volumen = {GetVolumen()}\n";
            return message;
        }
    }
}
