using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListaString
    {
        public NodoString Cabeza { get; private set; }
        public NodoString Cola { get; private set; }

        public void Agregar(string valor)
        {
            NodoString nuevo = new NodoString(valor);

            if (Cabeza == null)
            {
                Cabeza = nuevo;
                Cola = nuevo;
            }
            else
            {
                Cola.Siguiente = nuevo;
                Cola = nuevo;
            }
        }

        public void Recorrer(Action<string> accion)
        {
            NodoString actual = Cabeza;
            while (actual != null)
            {
                accion(actual.Valor);
                actual = actual.Siguiente;
            }
        }

    }

}
