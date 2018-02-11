using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Finalizado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é permitido aplicar descontos em orçamentos já finalizados");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não é permitido alterar o estadao em orçamentos já finalizados");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("O orçamento já se encontra finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não é permitido alterar o estadao em orçamentos já finalizados");
        }
    }
}
