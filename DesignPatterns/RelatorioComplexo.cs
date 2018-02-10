using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RelatorioComplexo : RelatorioTemplate
    {
        public override string Cabecalho(Banco banco)
        {
            return string.Concat(
                                     "RELATÓRIO COMPLEXO"
                                    , Environment.NewLine
                                    , Environment.NewLine
                                    , banco.NomeBanco
                                    , " | ", banco.Endereco
                                    , " | ", banco.Telefone
                                    , Environment.NewLine
                                );
        }

        public override string Corpo(List<Conta> listConta)
        {
            string corpo = null;

            listConta.ForEach(conta =>
            {
                corpo += string.Concat(
                                          "Titular: "
                                        , conta.Titular
                                        , "| Agência: "
                                        , conta.Agencia
                                        , "| Numero da conta: "
                                        , conta.NumeroConta
                                        , "| Saldo: "
                                        , conta.Saldo.ToString("N2", new CultureInfo("pt-BR"))
                                        , Environment.NewLine

                                      );
            });

            return corpo;
        }

        public override string Rodape(Banco banco)
        {
            return string.Concat(banco.Email, " | ", banco.Data.ToShortDateString());
        }
    }
}

