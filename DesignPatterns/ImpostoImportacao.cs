using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ImpostoImportacao : Imposto
    {
        public ImpostoImportacao(Imposto imposto) : base(imposto) { }

        public ImpostoImportacao() : base() { }
        
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.valor * 0.2) + CalculaProximoImposto(orcamento);
        }
    }
}
