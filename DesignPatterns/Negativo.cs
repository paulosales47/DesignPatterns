using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Negativo : IEstadoConta
    {
        public void Deposito(Conta conta, double valor)
        {
            conta.Saldo += (valor * 0.95);
        }

        public void Positivo(Conta conta)
        {
            conta.Status = new Positivo();
        }

        public void Saque(Conta conta, double valor)
        {
            throw new Exception("Não é possível realizar saques em contas negativadas");
        }

        void IEstadoConta.Negativo(Conta conta)
        {
            throw new Exception("A conta já está negativada");
        }
    }
}
