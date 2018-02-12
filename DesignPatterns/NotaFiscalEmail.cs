using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class NotaFiscalEmail : IAcaoNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota fiscal enviada por e-mail");
        }
    }
}
