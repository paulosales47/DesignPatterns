using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ISS : Imposto
    {
        public ISS(Imposto imposto) : base(imposto) {}

        public ISS() : base() { }
        
        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.valor * 0.06) + CalculaProximoImposto(orcamento);
        }
    }
}
