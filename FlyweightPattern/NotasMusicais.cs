using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class NotasMusicais
    {
        public IDictionary<string, INota> Notas =
            new Dictionary<string, INota>() {
                { "do", new Do() } ,
                { "re", new Re() } ,
                { "mi", new Mi() },
                { "fa", new Fa() },
                { "sol", new Sol() },
                { "la", new La() },
                { "si", new Si() }
            };

        public INota Pega(string nomeNota)
        {
            return Notas[nomeNota];
        }

    }
}
