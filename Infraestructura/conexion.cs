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
            string cadenaConexion = "Data Source=DESKTOP-1II6R26\\SQLEXPRESS04;Initial Catalog=bajoelvelo;Integrated Security=True;";
            SqlConnection cnx = new SqlConnection(cadenaConexion);
            return cnx;
        }
    }
}
