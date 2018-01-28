using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Arrojado : Investimento
    {
        public double RealizaInvestimento(Conta conta)
        {
            int porcentagem = new Random().Next(-1, 101);
            double valor = conta.Saldo;

            if (porcentagem > 50) return (valor * 0.006);

            if (porcentagem < 20) return (valor * 0.05);

            return (valor * 0.03);

        }
    }
}
