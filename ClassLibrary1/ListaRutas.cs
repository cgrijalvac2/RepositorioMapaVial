using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListaRutas
    {
        public NodoRuta Cabeza { get; set; }
        public NodoRuta Cola { get; set; }

        public void AgregarInterseccion(Interseccion interseccion)
        {
            NodoRuta nuevo = new NodoRuta(interseccion);

            if (Cabeza == null)
            {
                Cabeza = nuevo;
                Cola = nuevo;
            }
            else
            {
                nuevo.Anterior = Cola;
                Cola.Siguiente = nuevo;
                Cola = nuevo;
            }
        }

        public string ObtenerRuta()
        {
            string ruta = "";
            NodoRuta actual = Cabeza;
            bool primerElemento = true;

            while (actual != null)
            {
                if (!primerElemento)
                {
                    ruta += " -> ";
                }
                ruta += actual.Interseccion.Informacion.Nombre;
                actual = actual.Siguiente;
                primerElemento = false;
            }

            return ruta;
        }
    }
}
