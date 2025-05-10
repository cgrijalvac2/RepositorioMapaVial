using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{
    public class InformacionInterseccion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Point Ubicacion {  get; set; }
        public int VehiculosEnEspera {  get; set; }
        public string EstadoSemaforo { get; set; } // "rojo", "verde", "amarillo"
        public double TiempoPromedioTransito { get; set; }
        public int VehiculosHaciaNorte { get; set; }
        public int VehiculosHaciaSur { get; set; }
        public int VehiculosHaciaEste { get; set; }
        public int VehiculosHaciaOeste { get; set; }

        //CONSTRUCTOR 
        public InformacionInterseccion(int id, string nombre, Point ubicacion)
        {
            Id = id;
            Nombre= nombre;
            Ubicacion = ubicacion;
            VehiculosEnEspera = 0;
            EstadoSemaforo = "Rojo";
            TiempoPromedioTransito = 1.0;
        }

        public string ObtenerMovimientos()
        {
            return $"N: {VehiculosHaciaNorte}, S: {VehiculosHaciaSur}, E: {VehiculosHaciaEste}, O: {VehiculosHaciaOeste}";
        }
    }

}
