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

            #region Aula 3

            //Imposto icpp = new ICPP();
            //Imposto ikcv = new IKCV();
            //Imposto ihit = new IHIT();

            //var orcamento = new Orcamento(600);

            //Console.WriteLine(icpp.Calcula(orcamento));
            //Console.WriteLine(ikcv.Calcula(orcamento));

            //orcamento.AdicionaItem(new Item("Carro", 45000));
            //Console.WriteLine(ikcv.Calcula(orcamento));

            //Console.WriteLine(ihit.Calcula(orcamento));
            //orcamento.AdicionaItem(new Item("Carro", 30000));
            //Console.WriteLine(ihit.Calcula(orcamento));

            //var banco = new Banco
            //{
            //    NomeBanco = "Banco do Brasil"
            //    ,
            //    Email = "contato@bb.com.br"
            //    ,
            //    Endereco = "Praça Cândido Dias Castejon - Centro - São José dos Campos - São Paulo"
            //    ,
            //    Data = DateTime.Now
            //    ,
            //    Telefone = "(12) 3907-4545"
            //};

            //var listConta = new List<Conta>();
            //var random = new Random();

            //for (int i = 0; i < 30; i++)
            //{
            //    var conta = new Conta
            //    {
            //        Agencia = random.Next(1000,9999)
            //        ,
            //        NumeroConta = random.Next(10000, 99999)
            //        ,
            //        Saldo = random.NextDouble() * 1000
            //        ,
            //        Titular = $"Usuario - {i}"

            //    };

            //    listConta.Add(conta);
            //}

            //var relatorioSimples = new RelatorioSimples();
            //var relatorioComplexo = new RelatorioComplexo();

            //relatorioSimples.ImprimeRelatorio(listConta, banco);

            //Console.ReadKey();
            //Console.Clear();

            //relatorioComplexo.ImprimeRelatorio(listConta, banco);

            #endregion Aula3

            #region Aula4

            //var imposto = new ISS(new ICMS(new ICPP(new ImpostoImportacao())));
            //var orcamento = new Orcamento(1000);

            //Console.WriteLine(imposto.Calcula(orcamento));
            



            #endregion Aula 4

            Console.ReadKey();
        }
    }
}


