using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public interface IFormato
    {
        IFormato proximo { get; set; }

        string ConverteConta(Conta conta, Formato formato);

        string GetProximo(Conta conta, Formato formato);

    }
}
