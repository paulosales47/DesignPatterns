using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IKCV : TemplateMethodImposto
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.1;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.06;
        }

        protected override bool VerificaMaximaTaxacao(Orcamento orcamento)
        {
            return ((orcamento.valor > 500) && VerificaPrecoItem(orcamento));
        }

        public bool VerificaPrecoItem(Orcamento orcamento)
        {
            foreach (var item in orcamento.ListaProduto)
            {
                if (item.ValorProduto > 100) return true;
            }
            
            return false;
        }
    }
}
