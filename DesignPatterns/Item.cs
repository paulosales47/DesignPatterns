using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Item
    {
        private string nomeProduto;

        private double valorProduto;

        public Item(string nomeProduto, double valorProduto)
        {
            this.nomeProduto = nomeProduto;
            this.valorProduto = valorProduto;
        }

        public double ValorProduto
        {
            get { return valorProduto; }
            set { valorProduto = value; }
        }
        
        public string NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
    }
}
