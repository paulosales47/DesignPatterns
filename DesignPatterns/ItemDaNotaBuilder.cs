using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ItemDaNotaBuilder
    {
        public ItemDaNotaBuilder WithValor(double valor)
        {
            this.valor = valor;
            return this;
        }

        public ItemDaNotaBuilder WithDescricao(string descricao)
        {
            this.descricao = descricao;
            return this;
        }

        public ItemDaNota Builder()
        {
            return new ItemDaNota
                (
                     this.descricao
                    , this.valor
                );
        }

        private string descricao { get; set; }

        private double valor { get; set; }



    }
}
