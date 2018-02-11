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
            status.AplicaDescontoExtra(this);
        }
    }
}
