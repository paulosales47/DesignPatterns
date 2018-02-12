using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscalBuilder
    {
        public NotaFiscalBuilder(List<IAcaoNota> listaAcao)
        {
            this.listaItem = new List<ItemDaNota>();
            this.listaAcao = listaAcao;
            this.data = DateTime.Now;
        }

        private string razaoSocial { get; set; }

        private string cnpj { get; set; }

        private double valorBruto { get; set; }

        private double impostos { get; set; }

        private DateTime data { get; set; }

        private List<ItemDaNota> listaItem { get; set; }

        private string observacoes { get; set; }

        private List<IAcaoNota> listaAcao { get; set; }

        public NotaFiscal Build()
        {
            var notaFiscal =  new NotaFiscal
                (
                     this.razaoSocial
                    , this.cnpj
                    , this.valorBruto
                    , this.impostos
                    , this.data
                    , this.observacoes
                    , this.listaItem
                );

            this.ExecutaListaAcao(notaFiscal);

            return notaFiscal;
        }

        public void AddAcaoNota(IAcaoNota acaoNota)
        {
            this.listaAcao.Add(acaoNota);
        }

        private void ExecutaListaAcao(NotaFiscal notaFiscal)
        {
            this.listaAcao.ForEach(acao => {
                acao.Executa(notaFiscal);
            });
        }

        public NotaFiscalBuilder With(ItemDaNota item)
        {
            this.listaItem.Add(item);
            this.valorBruto += item.Valor;
            this.impostos += (item.Valor * 0.05);
            return this;
        }

        public NotaFiscalBuilder WithData(DateTime data)
        {
            this.data = data;
            return this;
        }

        public NotaFiscalBuilder WithCNPJ(string cnpj)
        {
            this.cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder WithEmpresa(string razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            return this;
        }
        
        public NotaFiscalBuilder WithObservacoes(string observacoes)
        {
            this.observacoes = observacoes;
            return this;
        }
    }
}
