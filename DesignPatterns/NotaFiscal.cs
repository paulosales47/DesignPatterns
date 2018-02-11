using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscal
    {
        private string razaoSocial;

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        private string cnpj;

        public string CNPj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        private double valorBruto;

        public double ValorBruto
        {
            get { return valorBruto; }
            set { valorBruto = value; }
        }

        private double impostos;

        public double Impostos
        {
            get { return impostos; }
            set { impostos = value; }
        }

        private DateTime dataEmissao;

        public DateTime DataEmissao
        {
            get { return dataEmissao; }
            set { dataEmissao = value; }
        }

        private string observacoes;

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }

        private List<ItemDaNota> listaItem;

        public List<ItemDaNota> ListaItem
        {
            get { return listaItem; }
            set { listaItem = value; }
        }

        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double impostos, DateTime dataEmissao, string observacoes, List<ItemDaNota> listaItem)
        {
            this.razaoSocial = razaoSocial;
            this.cnpj = cnpj;
            this.valorBruto = valorBruto;
            this.impostos = impostos;
            this.dataEmissao = dataEmissao;
            this.observacoes = observacoes;
            this.listaItem = listaItem;
        }
    }
}
