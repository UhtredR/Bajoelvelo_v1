using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bajoelvelo_v1.Infraestructura
{
    public class Conexion
    {
        public static SqlConnection Conectar()
        {
            string cadenaConexion = "";
            SqlConnection cnx = new SqlConnection(cadenaConexion);
            return cnx;
        }
    }
}
