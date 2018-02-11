using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Aprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor *= 0.98;
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já se encontra aprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Status = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é possível reprovar um orçamento já aprovado");
        }
    }
}
