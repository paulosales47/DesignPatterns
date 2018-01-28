using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aula 1
            //var iccc = new ICCC();
            //var orcamento = new Orcamento(5000);
            //var calculadorDeImposto = new CalculadorDeImposto();

            //double valorImposto = calculadorDeImposto.Calcula(orcamento, iccc);

            //Console.WriteLine(valorImposto);

            //Console.ReadKey();
            #endregion 

            var orcamento = new Orcamento(30);
            orcamento.AdicionaItem(new Item("LAPIS", 10));
            orcamento.AdicionaItem(new Item("CANETA", 20));
            
            double desconto = new CalculadorDeDescontos().Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.ReadKey();







        }
    }
}
