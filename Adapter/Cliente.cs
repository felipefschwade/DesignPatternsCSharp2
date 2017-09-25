using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Cliente(string nome, string endereco, DateTime dataNasc)
        {
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNasc;
        }

        public Cliente()
        {

        }

    }
}
