using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Bajoelvelo_v1.Clases_Func
{
    public class CargaDG_FAC
    {
        public DataTable CargarDatos(SqlConnection connection, string query, Dictionary<string, object> parametros = null)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parametros != null)
                {
                    foreach (var param in parametros)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                }

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable BuscarFactura(SqlConnection connection, string filtro)
        {
            string query = @"SELECT f.ID_Factura, f.Fecha_factura AS Fecha, c.Nombre + ' ' + c.Apellido AS NombreCompleto,  df.Subtotal, df.Cantidad, df.Subtotal * df.Cantidad AS TotalProducto
                     FROM Factura f
                     JOIN Cliente c ON f.ID_Cliente = c.ID_Cliente
                     JOIN Detalle_Factura df ON f.ID_Factura = df.ID_Factura
                     WHERE c.Nombre + ' ' + c.Apellido LIKE @Filtro OR CAST(f.ID_Factura AS NVARCHAR) LIKE @Filtro";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        public DataTable ObtenerTodasLasFacturas(SqlConnection cnx)
        {
            string query = @" SELECT f.ID_Factura, f.Fecha_factura AS Fecha, c.Nombre + ' ' + c.Apellido AS NombreCompleto, df.Subtotal, df.Cantidad,df.Subtotal * df.Cantidad AS TotalProducto
                            FROM Factura f
                            JOIN  Cliente c ON f.ID_Cliente = c.ID_Cliente
                            JOIN Detalle_Factura df ON f.ID_Factura = df.ID_Factura";

            SqlDataAdapter adapter = new SqlDataAdapter(query, cnx);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

    }
}
