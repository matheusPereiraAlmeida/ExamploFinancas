using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamploFinancas
{
    [TestFixture]
    public class ExamploFinancas
    {
        [Test]
        public void Teste01JurosCompostos()
        {
            double valorAPagar = ExemploFinancas.CalcularValorComJurosCompostos(1000, 12, 2);
            Assert.AreEqual(1268.24, valorAPagar);
        }

        [Test]
        public void Teste02JurosCompostos()
        {
            double valorAPagar = ExemploFinancas.CalcularValorComJurosCompostos(11937.28, 24, 4);
            Assert.AreEqual(30598.88, valorAPagar);
        }

        [Test]
        public void Teste03JurosCompostos()
        {
            double valorAPagar = ExemploFinancas.CalcularValorComJurosCompostos(15000, 36, 6);
            Assert.AreEqual(122208.78, valorAPagar);
        }
    }
}
