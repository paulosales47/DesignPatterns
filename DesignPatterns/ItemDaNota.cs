using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class ItemDaNota
    {
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        private double valor;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }


    }
}
