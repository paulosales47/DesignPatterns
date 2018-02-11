using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class FiltroAltoValor : Filtro
    {
        public FiltroAltoValor(Filtro filtro) : base(filtro) { }

        public FiltroAltoValor() : base() { }

        public override bool VerificaCondicaoFiltro(Conta conta)
        {
            return (conta.Saldo > 500000);
        }
    }
}
