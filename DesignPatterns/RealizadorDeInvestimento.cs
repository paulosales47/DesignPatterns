using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RealizadorDeInvestimento
    {
        public void Investe(Conta conta, Investimento investimento)
        {
            double retornoInvestimento = investimento.RealizaInvestimento(conta);

            conta.Saldo = retornoInvestimento * 0.75;
        }

    }
}
