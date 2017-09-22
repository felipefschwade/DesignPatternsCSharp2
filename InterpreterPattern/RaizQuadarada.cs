using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterpreterPattern.VisitorPattern;

namespace InterpreterPattern
{
    public class RaizQuadarada : IExpressao
    {
        public RaizQuadarada(IExpressao e)
        {
            Exp = e;
        }

        public IExpressao Exp { get; private set; }

        public void Aceita(IVisitor visitor)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            return (int) Math.Sqrt(Exp.Avalia());
        }
    }
}
