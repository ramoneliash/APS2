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
    }
}
