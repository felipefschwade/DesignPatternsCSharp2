using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class RaizQuadarada : IExpressao
    {
        public RaizQuadarada(IExpressao e)
        {
            Exp = e;
        }

        public IExpressao Exp { get; private set; }

        public int Avalia()
        {
            return (int) Math.Sqrt(Exp.Avalia());
        }
    }
}
