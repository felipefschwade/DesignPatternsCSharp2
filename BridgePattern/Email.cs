using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Email : IMensagem
    {
        public IEnviador Enviador { get; set; }
        public string Cliente { get; private set; }

        public Email(string cliente)
        {
            Cliente = cliente;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Enviando Email para {0}", Cliente);
        }
    }
}
