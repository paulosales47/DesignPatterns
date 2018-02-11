using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class EmAprovacao : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor *= 0.95;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Status = new Aprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Status = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Status = new Reprovado();
        }
    }
}
