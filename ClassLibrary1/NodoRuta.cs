using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NodoRuta
    {
        public Interseccion Interseccion { get; set; }
        public NodoRuta Anterior { get; set; }
        public NodoRuta Siguiente { get; set; }

        public NodoRuta(Interseccion interseccion)
        {
            Interseccion = interseccion;
            Anterior = null;
            Siguiente = null;
        }
    }
}
