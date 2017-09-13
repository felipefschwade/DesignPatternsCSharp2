using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Estado
    {
        public Contrato ContratoArmazenado { get; set; }
        public DateTime DataArmazenamento { get; set; }

        public Estado(Contrato contrato)
        {
            ContratoArmazenado = contrato;
            DataArmazenamento = DateTime.Now;
        }
    }
}
