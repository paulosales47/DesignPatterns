using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class XML : IFormato
    {
        public IFormato proximo { get; set; }

        public XML(IFormato formato)
        {
            this.proximo = formato;
        }

        public string ConverteConta(Conta conta, Formato formato)
        {
            if (Formato.XML.Equals(formato))
            {
                return "XML CONTA";
            }

            return GetProximo(conta, formato);
        }

        public string GetProximo(Conta conta, Formato formato)
        {
            if(this.proximo == null) return null;
            
            return this.proximo.ConverteConta(conta, formato);
        }
    }
}
