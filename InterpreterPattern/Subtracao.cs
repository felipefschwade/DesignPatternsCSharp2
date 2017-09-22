using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterPattern.VisitorPattern;

namespace InterpreterPattern
{
    public class Subtracao : IExpressao
    {
        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }

        public int Avalia()
        {
            return Esquerda.Avalia() - Direita.Avalia();
        }
    }
}
