using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;
using System;

namespace Test_Unitarios
{
    [TestClass]
    public class Test_StringExtendido
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibePalabras_DeberiaRetornarLaCantidad() //Given_When_then
        {
            //ARRANGE
            string texto = "Aguante Banfield carajo";
            int expected = 3; //Esta normalizado que la variable expected sea el resultado esperado

            //ACT
            int actual = texto.ContarPalabras(); //Otro nombre estandarizado para el valor real

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ContarPalabras_CuandoRecibeStringVacio_DeberiaLanzarArgumentException()
        {
            //ARRANGE
            string cadena = string.Empty;

            //ACT
            int actual = cadena.ContarPalabras();

            //ASSERT esta incorporado en la etiqueta de ExpectedException
        }

        [TestMethod]
        public void ContarPalabras_RecibePalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            //ARRANGE
            string cadena = "Aguante-Banfield-carajo";
            int expected = 3;

            //ACT
            int actual = cadena.ContarPalabras();

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
}
