using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var historico = new Historico();
            var contrato = new Contrato("Felipe", DateTime.Now, TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());
            contrato.Avanca();
            Console.WriteLine(contrato.Tipo);
            historico.Adiciona(contrato.SalvaEstado());
            contrato.Avanca();
            Console.WriteLine(contrato.Tipo);
            Console.WriteLine(historico.PegaHistorico(0).ContratoArmazenado.Tipo);
            Console.WriteLine(historico.PegaHistorico(1).ContratoArmazenado.Tipo);
            Console.WriteLine(historico.PegaHistorico(0).DataArmazenamento);
            Console.WriteLine(historico.PegaHistorico(1).DataArmazenamento);
            Console.ReadKey();
        }
    }
}
