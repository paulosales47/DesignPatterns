using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Banco
    {
        private string nomeBanco;

        public string NomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private DateTime data;


        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
    }

}
