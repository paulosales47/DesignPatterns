using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class FiltroBaixoValor : Filtro
    {
        public FiltroBaixoValor(Filtro filtro) : base(filtro) { }

        public FiltroBaixoValor() : base() { }

        public override bool VerificaCondicaoFiltro(Conta conta)
        {
            return (conta.Saldo < 100);
        }
    }
}
