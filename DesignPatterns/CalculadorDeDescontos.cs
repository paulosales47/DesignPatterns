using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CalculadorDeDescontos
    {

        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoQuantidadeItens();
            IDesconto d2 = new DescontoValorCompra();
            IDesconto d3 = new DescontoVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.proximo = d2;
            d2.proximo = d3;
            d3.proximo = d4;
            
            return d1.Desconto(orcamento);
        }
    }
}
