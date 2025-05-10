using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NodoString
    {
        public string Valor { get; set; }
        public NodoString Siguiente { get; set; }

        public NodoString(string valor)
        {
            Valor = valor;
            Siguiente = null;
        }
    }
}
