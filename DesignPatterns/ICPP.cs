using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICPP : TemplateMethodImposto
    {
        public ICPP(Imposto imposto) : base(imposto) { }
        
        public ICPP() : base() { }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculaProximoImposto(orcamento);
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculaProximoImposto(orcamento);
        }

        protected override bool VerificaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }
    }
}
