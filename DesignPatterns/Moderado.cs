using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Moderado : Investimento
    {
        public double RealizaInvestimento(Conta conta)
        {
            bool escolhido = new Random().Next(-1, 2) > 1;
            double valor = conta.Saldo;

            if (escolhido) return (valor * 0.025);

            return (valor * 0.007);
        }
    }
}
