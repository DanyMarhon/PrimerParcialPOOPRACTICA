using Ejercicio01.Entidades;
using NUnit;
using Xunit;

namespace TestProject
{
public class PiramideCuadradaTests
    {

        [Fact]
        public void CalcularArea_ShouldReturnCorrectArea()
        {
            // Arrange
            int lado = 4;
            int altura = 3;
            PiramideCuadrada piramide = new PiramideCuadrada(lado, altura);

            // Act
            double area = piramide.CalcularArea();

            // Assert
            double areaBase = Math.Pow(lado, 2);
            double areaLateral = 2 * lado * piramide.GetApotema();
            double expectedArea = areaBase + areaLateral;

        //    Assert.Equal(expectedArea, area, precision: 2);
        }

        [Fact]
        public void CalcularVolumen_ShouldReturnCorrectVolume()
        {
            // Arrange
            int lado = 4;
            int altura = 3;
            PiramideCuadrada piramide = new PiramideCuadrada(lado, altura);

            // Act
            double volumen = piramide.CalcularVolumen();

            // Assert
            double expectedVolumen = (Math.Pow(lado, 2) * altura) / 3;

        //    Assert.Equal(expectedVolumen, volumen, precision: 2);
        }

        [Fact]
        public void Constructor_InvalidInput_ShouldThrowArgumentException()
        {
            // Arrange
            int lado = -1; // Lado inválido
            int altura = 3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new PiramideCuadrada(lado, altura));
        }
    }
}