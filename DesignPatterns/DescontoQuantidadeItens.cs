using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoQuantidadeItens : IDesconto
    {
        public IDesconto proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            if(orcamento.ListaProduto.Count > 5)
            {
                return (orcamento.Valor * 0.1);
            }

            return proximo.Desconto(orcamento);
        }
    }
}
