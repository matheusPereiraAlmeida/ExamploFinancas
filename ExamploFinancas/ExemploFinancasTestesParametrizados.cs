using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ExamploFinancas
{
    [TestFixture]
    public class ExemploFinancasTestesParametrizados
    {
        [TestCase(1000, 12, 2, 1268.24)]
        [TestCase(11937.28, 24, 4, 30598.88)]
        [TestCase(15000, 36, 6, 122208.78)]
        public void TesteCalcularValorComJurosCompostos(double ValorEmprestimo, int NumMeses, double Taxa, double ValorEsperado)
        {
            double valorAPagar = ExemploFinancas.CalcularValorComJurosCompostos(ValorEmprestimo, NumMeses, Taxa);
            Assert.AreEqual(ValorEsperado, valorAPagar);
        }
    }
}
