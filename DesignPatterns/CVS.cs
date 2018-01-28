using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class CVS : IFormato
    {
        public IFormato proximo { get; set; }

        public CVS(IFormato formato)
        {
            this.proximo = formato;
        }

        public string ConverteConta(Conta conta, Formato formato)
        {
            if (Formato.CVS.Equals(formato))
            {
                return "CVS CONTA";
            }

            return GetProximo(conta, formato);
        }

        public string GetProximo(Conta conta, Formato formato)
        {
            if (this.proximo == null) return null;

            return this.proximo.ConverteConta(conta, formato);
        }
    }
}
