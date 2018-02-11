using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public abstract class Filtro
    {
        protected Filtro filtro;

        public Filtro(Filtro filtro)
        {
            this.filtro = filtro;
        }
        
        public Filtro()
        {
            this.filtro = null;
        }

        
        public abstract bool VerificaCondicaoFiltro(Conta conta);
        
        public List<Conta> Filtra(List<Conta> listaConta)
        {
            var listaContaFiltrada = new List<Conta>();

            foreach (var conta in listaConta)
            {
                if (VerificaCondicaoFiltro(conta))
                {
                    listaContaFiltrada.Add(conta);
                }
            }

            return JuntaListaProximoFiltro(listaConta, listaContaFiltrada);
        }

        private List<Conta> VerificaProximoFiltro(List<Conta> listaConta)
        {
            return (this.filtro is null) ?  null : filtro.Filtra(listaConta);
        }

        private List<Conta> JuntaListaProximoFiltro(List<Conta> listaConta, List<Conta> listaContaFiltrada)
        {
            var listaContaProximoFiltro = VerificaProximoFiltro(listaConta);
            var listaContaRetorno = listaContaFiltrada;
            bool duplicado = false;

            if (! (listaContaProximoFiltro is null))
            {
                foreach (var contaProximoFiltro in listaContaProximoFiltro)
                {
                    duplicado = false;

                    foreach (var contaFiltrada in listaContaFiltrada)
                    {
                        if (contaFiltrada.Equals(contaProximoFiltro))
                        {
                            duplicado = true;
                        }
                    }

                    if (!duplicado)
                        listaContaRetorno.Add(contaProximoFiltro);
                }
            }

            return listaContaRetorno;
        }
        
    }
}
