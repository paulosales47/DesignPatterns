using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoValorCompra : IDesconto
    {
        public IDesconto proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            double valorCompra = orcamento.valor;
            
            if (valorCompra > 500) return (valorCompra * 0.07);

            return proximo.Desconto(orcamento);
        }
    }
}
