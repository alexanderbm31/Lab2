using System;
using App2.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App2.Test
{
    [TestClass]
    public class UnitTest1
    {
        double resultadoEsperado;
        double resultadoObtenido;

        [TestMethod]
        public void TestSuma()
        {
            Calculos calculos = new Calculos();
            resultadoEsperado = 10;
            resultadoObtenido = calculos.Suma(3, 7);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
