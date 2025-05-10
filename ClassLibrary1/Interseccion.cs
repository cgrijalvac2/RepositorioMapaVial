using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Interseccion
    {
        public InformacionInterseccion Informacion { get; set; }
        public Interseccion? Norte { get; set; }
        public Interseccion? Sur { get; set; }
        public Interseccion? Este { get; set; }
        public Interseccion? Oeste { get; set; }

        //METODO CONTRUCTOR
        public Interseccion(InformacionInterseccion informacion)
        {
            Informacion = informacion;
            Norte = null;
            Sur = null;
            Este = null;
            Oeste = null;
        }
    }
}
