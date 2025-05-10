using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NodoHistorial
    {
        public DateTime Timestamp { get; set; }
        public int NivelCongestion { get; set; }
        public string NombreInterseccion { get; set; } 
        public NodoHistorial Siguiente { get; set; }

        public NodoHistorial(DateTime timestamp, int nivel, string nombreInterseccion)
        {
            Timestamp = timestamp;
            NivelCongestion = nivel;
            NombreInterseccion = nombreInterseccion;
            Siguiente = null;
        }
    }
}
