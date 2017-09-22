using InterpreterPattern.VisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Soma : IExpressao
    {
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public int Avalia()
        {
            return Esquerda.Avalia() + Direita.Avalia();
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSoma(this);
        }

    }
}
