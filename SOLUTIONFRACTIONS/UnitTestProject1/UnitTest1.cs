using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructorDefault()
        {
            FRACIONES F = new FRACIONES();
            int numerador = F.Numerador;
            int denominador = F.Denominador;
            bool b = (numerador == 1) && (denominador == 1);
            Assert.AreEqual(true, b);

        }
        [TestMethod]
        public void TestSumarFraciones()
        {
            FRACIONES f1 = new FRACIONES(2,3);
            FRACIONES F2 = new FRACIONES(1, 3);
            FRACIONES NuevaFraccionExpected = new FRACIONES(3, 3);
            FRACIONES resultado = new FRACIONES();
            resultado.Sumar(f1, F2);

            bool b = (resultado.Numerador == 3) && (resultado.Denominador == 3);
                     
            Assert.AreEqual(true, b);
        }

        [TestMethod]
        public void TestDenominadorNoCero()
        {
            FRACIONES F = new FRACIONES();

            try
                {

                    F.Denominador = 0;
                
                }
            catch(DivideByZeroException O)

                {

                return; 
        }

            Assert.Fail();
        }

        [TestMethod]
        public void TestSumarCalc()
        {
            Calc c = new Calc();
            int valor1 = 10;
            int valor2 = 10;
            int resultado = c.sumar(valor1, valor2);
            Assert.AreEqual(20, resultado); 
        }
    }
}



