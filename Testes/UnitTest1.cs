using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesUnitario_BLL;

namespace Testes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveFazerAumentoSalarioTI()
        {
            Calculo c = new Calculo();
            Funcionario f = new Funcionario("Daniel",1500,Cargo.DesenvolvedorFrontEnd);
            var temp = c.CalcularAumento(f);
            Assert.AreEqual(f.Salario *= 1.05, temp);
        }
    }
}
