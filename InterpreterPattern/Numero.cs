using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Numero : IExpressao
    {
        public Numero(int numero)
        {
            Nume = numero;
        }

        public int Nume { get; set; }

        public int Avalia()
        {
            return Nume;
        }
    }
}
