using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamploFinancas
{
    public static class ExemploFinancas
    {
        public static double CalcularValorComJurosCompostos(double ValorEmprestimo, int NumMeses, double Taxa)
        {
            return Math.Round( ValorEmprestimo * Math.Pow((100 + Taxa) / 100, NumMeses), 2);
        }
    }
}
