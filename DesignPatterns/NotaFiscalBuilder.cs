﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscalBuilder
    {
        public NotaFiscalBuilder()
        {
            this.listaItem = new List<ItemDaNota>();
            this.data = DateTime.Now;
        }

        private string  razaoSocial { get; set; }
        
        private string cnpj { get; set; }
        
        private double valorBruto { get; set; }
        
        private double impostos { get; set; }
        
        private DateTime data { get; set; }
        
        private List<ItemDaNota> listaItem { get; set; }

        public string observacoes { get; private set; }

        public NotaFiscal Build()
        {
            return new NotaFiscal
                (
                     this.razaoSocial
                    , this.cnpj
                    , this.valorBruto
                    , this.impostos
                    , this.data
                    , this.observacoes
                    , this.listaItem
                );
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
