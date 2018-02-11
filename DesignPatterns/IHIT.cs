using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IHIT : TemplateMethodImposto
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.13) + 100);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return 0.01 * orcamento.ListaProduto.Count * orcamento.Valor;
        }

        protected override bool VerificaMaximaTaxacao(Orcamento orcamento)
        {
            foreach (var item in orcamento.ListaProduto)
            {
                foreach (var produto in orcamento.ListaProduto)
                {
                    if ((produto.NomeProduto.Equals(item.NomeProduto)) && (!produto.Equals(item))) return true;
                }
            }

            return false;
        }
    }
}
