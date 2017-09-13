using System.Collections.Generic;

namespace MementoPattern
{
    public class Historico
    {
        public IList<Estado> Estados = new List<Estado>();

        public Estado PegaHistorico(int index)
        {
            return Estados[index];
        }

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }

    }
}
