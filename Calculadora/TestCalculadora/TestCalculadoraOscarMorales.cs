using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculadora;

namespace TestCalculadora
{
    [TestClass]
    public class TestCalculadoraOscarMorales
    {

        [TestMethod]
        public void Test_Suma()
        {
            //Arrange: incializar las variables
            int sumando1 = 3;
            int sumando2 = 5;
            //Act: ejecucion del metodo a probar
            int resultado = Calculadora.Calculadora.Suma(sumando1, sumando2);
            //Assert: compro8acion de los resultados
            Assert.AreEqual(8, resultado);
        }

        [TestMethod]
        public void Test_Resta()
        {
            //Arrange: incializar las variables
            int minuendo1 = 17;
            int sustraendo2 = 7;
            //Act: ejecucion del metodo a probar
            int resultado = Calculadora.Calculadora.Resta(minuendo1, sustraendo2);
            //Assert: comprobacion de los resultados
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Test_Multiplicacion()
        {
            //Arrange: incializar las variables
            int sumando1 = 10;
            int sumando2 = 5;
            //Act: ejecucion del metodo a probar
            int resultado = Calculadora.Calculadora.Multiplicacion(sumando1, sumando2);
            //Assert: comprobacion de los resultados
            Assert.AreEqual(50, resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Division()
        {
            //Arrange: inicializar las variables
            int dividendo = 120;
            int divisor = 0;
            //Act: ejecucion del metodo a probar
            double resultado = Calculadora.Calculadora.Division(dividendo, divisor);
            //Assert: comprobacion de los resultados
            Assert.AreEqual(60, resultado);
        }
    }
}
