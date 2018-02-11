using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {
        private double valor;
        private IList<Item> listaProduto;

        public IList<Item> ListaProduto
        {
            get { return listaProduto; }
            set { listaProduto = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        
        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.listaProduto = new List<Item>();
            this.status = new EmAprovacao();
        }

        public void AdicionaItem(Item item)
        {
            this.listaProduto.Add(item);
        }

        private IEstadoOrcamento status;

        public IEstadoOrcamento Status
        {
            get { return status; }
            set { status = value; }
        }

        private bool descontoAplicado;

        public bool DescontoAplicado
        {
            get { return descontoAplicado; }
        }



        public void Aprova()
        {
            status.Aprova(this);
        }

        public void Reprova()
        {
            status.Reprova(this);
        }

        public void Finaliza()
        {
            status.Finaliza(this);
        }

        public void AplicaDescontoExtra()
        {
            if (this.descontoAplicado)
            {
                throw new Exception("Desconto já aplicado");
            }

            status.AplicaDescontoExtra(this);
            this.descontoAplicado = true;
        }
    }
}
