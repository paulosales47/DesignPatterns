using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class RelatorioTemplate
    {
        public abstract string Cabecalho(Banco banco);

        public abstract string Rodape(Banco banco);

        public abstract string Corpo(List<Conta> listConta);

        public void ImprimeRelatorio(List<Conta> listConta, Banco banco)
        {
            var cabecalho = this.Cabecalho(banco);
            var corpo = this.Corpo(listConta);
            var rodape = this.Rodape(banco);

            var relatorio = string.Concat(cabecalho, Environment.NewLine, corpo, Environment.NewLine, rodape);

            Console.WriteLine(relatorio);
        }
    }
}
