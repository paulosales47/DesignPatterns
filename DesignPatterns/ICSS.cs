﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ICSS : Imposto
    {
        public ICSS(Imposto imposto) : base(imposto) { }
        
        public ICSS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.06) + CalculaProximoImposto(orcamento);
        }
    }
}
