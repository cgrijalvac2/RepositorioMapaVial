using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ConexionBD
    {
        private string cadenaConexion = "Server=CRISTEL\\SQLEXPRESS; DataBase=MapaVial3;Integrated Security=True;";

        public SqlConnection Conectar()
        {
            return new SqlConnection(cadenaConexion);
        }

        public DataTable ObtenerFlujoVehiculos()
        {
            DataTable dt = new DataTable();

            using (var conexion = Conectar())
            {
                conexion.Open();
                string query = @"
            SELECT 
                InterseccionOrigen + ' a ' + InterseccionDestino AS Ruta,
                CantidadVehiculos,
                TiempoPromedioCruce
            FROM FlujoVehiculos
            WHERE InterseccionOrigen = 'Centro'";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ObtenerCongestiones()
        {
            DataTable dt = new DataTable();

            using (var conexion = Conectar())
            {
                conexion.Open();
                string query = @"
            SELECT 
                NombreInterseccion,
                CantidadVehiculos
            FROM Congestiones
            ORDER BY CantidadVehiculos DESC";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }
    }
}
