using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Reprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é permitido aplicar descontos em orçamentos reprovados");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é permitido aprovar orçamentos já reprovados");
        }

        public void Finaliza(Orcamento orcamento)
        {
           orcamento.Status = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("O orçamento já se encontra reprovado");
        }
    }
}
