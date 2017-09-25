using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Aaaaa", "bbbbbb", DateTime.Now);
            var clienteXml = ConversorDeXML.GeraXML(cliente);
            Console.WriteLine(clienteXml);
            Console.ReadKey();
        }
    }
}
