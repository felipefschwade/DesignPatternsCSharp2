using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class Piano
    {
        public void Toca(IList<INota> notas)
        {
            foreach (var nota in notas)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
