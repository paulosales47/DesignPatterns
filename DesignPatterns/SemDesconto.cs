using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SemDesconto : IDesconto
    {
        public IDesconto proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
