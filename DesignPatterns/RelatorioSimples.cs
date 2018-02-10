using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class RelatorioSimples : RelatorioTemplate
    {
        public override string Cabecalho(Banco banco)
        {
            return string.Concat(
                                      "RELATÓRIO SIMPLES"
                                    , Environment.NewLine
                                    , Environment.NewLine
                                    , banco.NomeBanco
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
                                        , "| Saldo: "
                                        , conta.Saldo.ToString("N2", new CultureInfo("pt-BR"))
                                        , Environment.NewLine
                                      );
            });

            return corpo;
        }

        public override string Rodape(Banco banco)
        {
            return banco.Telefone;
        }
    }
}
