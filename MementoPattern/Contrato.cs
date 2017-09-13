using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class Contrato
    {
        public string Cliente { get; set; }
        public DateTime Data { get; set; }
        public TipoContrato Tipo { get; set; }

        public Contrato(string cliente, DateTime data, TipoContrato tipo)
        {
            Cliente = cliente;
            Data = data;
            Tipo = tipo;
        }

        public void Avanca()
        {
            if (Tipo == TipoContrato.Novo) Tipo = TipoContrato.EmAdamento;
            else if (Tipo == TipoContrato.EmAdamento) Tipo = TipoContrato.Acertado;
            else if (Tipo == TipoContrato.Acertado) Tipo = TipoContrato.Concluido;
        }

        public Estado SalvaEstado()
        {
            return new Estado(new Contrato(Cliente, Data, Tipo));
        }
    }
}
