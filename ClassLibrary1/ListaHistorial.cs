using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListaHistorial
    {
        private NodoHistorial cabeza;

        public void AgregarRegistro(DateTime timestamp, int nivel, string nombreInterseccion)
        {
            NodoHistorial nuevo = new NodoHistorial(timestamp, nivel, nombreInterseccion);

            if (cabeza == null)
            {
                cabeza = nuevo;
            }
            else
            {
                NodoHistorial actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        public ListaString ObtenerHistorial()
        {
            ListaString historial = new ListaString();
            NodoHistorial actual = cabeza;

            while (actual != null)
            {
                historial.Agregar($"{actual.Timestamp}: {actual.NombreInterseccion} - Congestión {actual.NivelCongestion}");
                actual = actual.Siguiente;
            }

            return historial;
        }
    }
}
