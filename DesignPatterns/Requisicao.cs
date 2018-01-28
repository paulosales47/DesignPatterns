using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Requisicao
    {
        private Formato formato;

        public Formato Formato
        {
            get { return formato; }
            set { formato = value; }
        }

        public Requisicao(Formato formato)
        {
            this.formato = formato;
        }
        
        public string RequisicaoConta(Conta conta)
        {
            IFormato f3 = new PORCENTO(null);
            IFormato f2 = new XML(f3);
            IFormato f1 = new CVS(f2);


            return f1.ConverteConta(conta, formato);
        }
    }
}
