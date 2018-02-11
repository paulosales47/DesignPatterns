using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class DescontoVendaCasada : IDesconto
    {
        public IDesconto proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            var listaItem = orcamento.ListaProduto;
            
            bool vendaCasada = this.ExistsItem("LAPIS", listaItem) && this.ExistsItem("CANETA", listaItem);

            if (vendaCasada)
            {
                return (orcamento.Valor * 0.05);
            }

            return proximo.Desconto(orcamento);
        }

        public bool ExistsItem(string nomeItem, IList<Item> lItem)
        {
            var lista = lItem.ToList();
                
            int index = lista.FindIndex(item => item.NomeProduto.Equals(nomeItem));

            return (index != -1);
        }
    }
}
