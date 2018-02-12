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

            #region Aula 4

            //var imposto = new ISS(new ICMS(new ICPP(new ImpostoImportacao())));
            //var orcamento = new Orcamento(1000);

            //Console.WriteLine(imposto.Calcula(orcamento));

            /////////////////////////////////////////////////////////////////////////

            //var listConta = new List<Conta>();
            //var random = new Random();

            //for (int i = 0; i < 30; i++)
            //{
            //    var conta = new Conta
            //    {
            //        Agencia = random.Next(1000, 9999)
            //        ,
            //        NumeroConta = random.Next(10000, 99999)
            //        ,
            //        Saldo = random.Next(-100000, 600000)
            //        ,
            //        Titular = $"Usuario - {i}"
            //        ,
            //        DataAbertura = new DateTime(random.Next(2015,2019), random.Next(1,12), random.Next(1,29)) 

            //    };

            //    listConta.Add(conta);
            //}


            //var filtros = (new FiltroAltoValor(new FiltroData()));

            //var contaFiltradas = filtros.Filtra(listConta);

            //contaFiltradas.ForEach(conta =>
            //{
            //    Console.WriteLine("Titular: " + conta.Titular + " | Saldo: " + conta.Saldo + " | Data Abertura: " + conta.DataAbertura.ToShortDateString());
            //});

            #endregion Aula 4

            #region Aula 5

            //try
            //{
            //    var orcamento = new Orcamento(1000);
            //    Console.WriteLine(orcamento.Valor);

            //    orcamento.AplicaDescontoExtra();
            //    Console.WriteLine(orcamento.Valor);

            //    orcamento.Aprova();
            //    orcamento.AplicaDescontoExtra();
            //    Console.WriteLine(orcamento.Valor);

            //    orcamento.Finaliza();
            //    orcamento.AplicaDescontoExtra();

            //}catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ///////////////////////////////////////////////////
            //try
            //{
            //    var conta = new Conta(-1000);
            //    Console.WriteLine(conta.Status);
            //    conta.Deposito(5000);
            //    Console.WriteLine(conta.Status);
            //    conta.Deposito(5000);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion Aula 5

            #region Aula 6

            //NotaFiscal notaFiscal = new NotaFiscalBuilder()
            //    .WithCNPJ("123456789")
            //    .WithEmpresa("Alura")
            //    .WithObservacoes("Teste")
            //    .With(new ItemDaNotaBuilder()
            //                    .WithDescricao("Carro")
            //                    .WithValor(45000)
            //                    .Builder())
            //    .With(new ItemDaNotaBuilder()
            //                    .WithDescricao("Moto")
            //                    .WithValor(12000)
            //                    .Builder())
            //    .Build();

            #endregion Aula 6

            #region Aula 7


            var listaAcao = new List<IAcaoNota>
            {
                 new NotaFiscalEmail()
                ,new NotaFiscalDAO()
                ,new NotaFiscalMutiplicador(10)
            };
            
            NotaFiscal notaFiscal = new NotaFiscalBuilder(listaAcao)
                .WithCNPJ("123456789")
                .WithEmpresa("Alura")
                .WithObservacoes("Teste")
                .With(new ItemDaNotaBuilder()
                                .WithDescricao("Carro")
                                .WithValor(45000)
                                .Builder())
                .With(new ItemDaNotaBuilder()
                                .WithDescricao("Moto")
                                .WithValor(12000)
                                .Builder())
                .Build();

            #endregion Aula 7



            Console.ReadKey();
        }

    }
    
}




