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

        private IEstadoConta status;

        public IEstadoConta Status
        {
            get { return status; }
            set { status = value; }
        }

        public void Saque(double valor)
        {
            this.status.Saque(this, valor);
            VerificaStatus();
        }

        public void Deposito(double valor)
        {
            this.status.Deposito(this, valor);
            VerificaStatus();
        }

        public Conta(double saldo)
        {
            if (saldo > 0)
                this.status = new Positivo();
            else
                this.status = new Negativo();
        }

        public Conta()
        {}

        private void VerificaStatus()
        {
            bool contaPositiva = this.status.GetType() == typeof(Positivo);

            if (this.saldo < 0 && contaPositiva)
                this.status.Negativo(this);
            else if(!contaPositiva)
                this.status.Positivo(this);
        }
    }
}
