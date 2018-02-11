using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class IKCV : TemplateMethodImposto
    {
        public IKCV(Imposto imposto) : base(imposto) { }

        public IKCV() : base() { }
        
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.1) + CalculaProximoImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.06) + CalculaProximoImposto(orcamento);
        }

        protected override bool VerificaMaximaTaxacao(Orcamento orcamento)
        {
            return ((orcamento.Valor > 500) && VerificaPrecoItem(orcamento));
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
