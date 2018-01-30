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

            #region Aula 2
            //var orcamento = new Orcamento(30);
            //orcamento.AdicionaItem(new Item("LAPIS", 10));
            //orcamento.AdicionaItem(new Item("CANETA", 20));

            //double desconto = new CalculadorDeDescontos().Calcula(orcamento);

            //Console.WriteLine(desconto);

            //Console.ReadKey();
            #endregion

            Imposto icpp = new ICPP();
            Imposto ikcv = new IKCV();
            Imposto ihit = new IHIT();

            var orcamento = new Orcamento(600);
            
            Console.WriteLine(icpp.Calcula(orcamento));
            Console.WriteLine(ikcv.Calcula(orcamento));

            orcamento.AdicionaItem(new Item("Carro", 45000));
            Console.WriteLine(ikcv.Calcula(orcamento));

            Console.WriteLine(ihit.Calcula(orcamento));
            orcamento.AdicionaItem(new Item("Carro", 30000));
            Console.WriteLine(ihit.Calcula(orcamento));

            Console.ReadKey();
        }
    }
}
