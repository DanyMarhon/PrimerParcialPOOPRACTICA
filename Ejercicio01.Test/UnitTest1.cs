using Ejercicio01.Entidades;

namespace Ejercicio01.Test;

[TestClass]
public class PiramideCuadradaTests
{
    [TestMethod]
    public void GetApotema_CalcularTest()
    {
        // Arrange
        var piramide = new PiramideCuadrada(6, 12); // Lado = 6, Altura = 12
        double apotemaCorrecta = 12.36931687685298;

        // Act
        double apotemaActual = piramide.GetApotema();

        // Assert
        Assert.AreEqual(apotemaCorrecta, apotemaActual, 1e-5);
    }

    [TestMethod]
    public void GetAreaTotal_CalcularTest()
    {
        // Arrange
        var piramide = new PiramideCuadrada(6, 12); // Lado = 6, Altura = 12
        double areaTotalCorrecta = 184.43180252223578;

        // Act
        double areaTotalActual = piramide.GetAreaTotal();

        // Assert
        Assert.AreEqual(areaTotalCorrecta, areaTotalActual, 1e-5);
    }

    [TestMethod]
    public void GetVolumen_CalcularTest()
    {
        // Arrange
        var piramide = new PiramideCuadrada(6, 12); // Lado = 6, Altura = 12
        double volumenCorrecto = 144.0;

        // Act
        double volumenActual = piramide.GetVolumen();

        // Assert
        Assert.AreEqual(volumenCorrecto, volumenActual, 1e-5);
    }
}