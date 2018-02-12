using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscalMutiplicador : IAcaoNota
    {
        private int _fator;

        public int Fator
        {
            get { return _fator; }
        }

        public NotaFiscalMutiplicador(int Fator)
        {
            this._fator = Fator;
        }
        
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Valor bruto mutiplicado pelo fator: "+notaFiscal.ValorBruto * _fator);
        }
    }
}
