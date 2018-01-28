using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double valor;
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
    }
}
