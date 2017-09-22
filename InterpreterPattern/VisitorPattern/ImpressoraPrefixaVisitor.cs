using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.VisitorPattern
{
    public class ImpressoraPrefixaVisitor : IVisitor
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("/ (");
            divisao.Esquerda.Aceita(this);
            Console.Write(") (");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("* (");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(") (");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Nume);
        }

        public void ImprimeRaiz(RaizQuadarada raiz)
        {
            throw new NotImplementedException();
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("+ (");
            soma.Esquerda.Aceita(this);
            Console.Write(") (");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("-(");
            subtracao.Esquerda.Aceita(this);
            Console.Write(") (");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
