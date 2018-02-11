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

        private string titular;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        private int numeroConta;

        public int NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }

        private int agencia;

        public int Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }

        private DateTime dataAbertura;

        public DateTime DataAbertura
        {
            get { return dataAbertura; }
            set { dataAbertura = value; }
        }
    }
}
