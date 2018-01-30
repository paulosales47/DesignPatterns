using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICPP : TemplateMethodImposto
    {
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor * 0.05;
        }

        protected override bool VerificaMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.valor > 500;
        }
    }
}
