using InterpreterPattern.VisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var esquerda = new Soma(new Numero(7), new Numero(9));
            var direita = new Subtracao(new Numero(13), new Numero(12));
            var divisao = new Multiplicacao(esquerda, direita);
            Console.WriteLine(divisao.Avalia());
            var impressora = new ImpressoraPrefixaVisitor();
            divisao.Aceita(impressora);
            Console.ReadKey();
        }
    }
}
