using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICCC : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            double valor = orcamento.Valor;

            if (valor > 3000) return ((valor * 0.08) + 30);

            if (valor < 1000) return (valor * 0.05);

            return (valor * 0.07);
        }
        
    }
}
