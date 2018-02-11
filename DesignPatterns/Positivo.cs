using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Positivo : IEstadoConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += (valor * 0.98);
        }

        public void Negativo(Conta conta)
        {
            conta.Status = new Negativo();
        }

        public void Saque(Conta conta, double valor)
        {
            conta.Saldo -= valor;
        }

        void IEstadoConta.Positivo(Conta conta)
        {
            throw new Exception("A conta já está positiva");
        }
    }
}
