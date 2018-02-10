using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Imposto
    {
        public Imposto(Imposto imposto)
        {
            this.imposto = imposto;
        }

        public Imposto()
        {
            this.imposto = null;
        }

        protected Imposto imposto;

        public abstract double Calcula(Orcamento orcamento);

        public double CalculaProximoImposto(Orcamento orcamento)
        {
            return (imposto is null) ? 0 : this.imposto.Calcula(orcamento);
        }
    }
}
