using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Conta
    {
        private double saldo;

        public double Saldo
        {
            set { saldo = value; }
            get { return saldo; }
        }

    }
}
