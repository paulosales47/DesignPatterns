using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IEstadoConta
    {
        void Deposito(Conta conta, double valor);
        void Saque(Conta conta, double valor);

        void Positivo(Conta conta);
        void Negativo(Conta conta);
    }
}
