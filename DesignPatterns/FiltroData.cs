using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class FiltroData : Filtro
    {
        public FiltroData(Filtro filtro) : base(filtro) { }

        public FiltroData() : base() { }

        public override bool VerificaCondicaoFiltro(Conta conta)
        {
            return (conta.DataAbertura.Year.Equals(DateTime.Now.Year) && conta.DataAbertura.Month.Equals(DateTime.Now.Month));
        }
    }
} 
