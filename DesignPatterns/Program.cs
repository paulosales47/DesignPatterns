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
            var iccc = new ICCC();
            var orcamento = new Orcamento(5000);
            var calculadorDeImposto = new CalculadorDeImposto();

            double valorImposto = calculadorDeImposto.Calcula(orcamento, iccc);

            Console.WriteLine(valorImposto);

            Console.ReadKey();

        }
    }
}
