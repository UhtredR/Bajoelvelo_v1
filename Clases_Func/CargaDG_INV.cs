using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1.Clases_Func
{
    public class CargaDG_INV
    {
        public DataTable CargarDatos(SqlConnection connection, string query)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public DataTable BuscarProducto(SqlConnection connection, string filtro)
        {
            string query = "SELECT ID_Producto, Nombre, Descripcion, Precio_unitario, Stock, Disponible FROM Producto WHERE Nombre LIKE @Filtro OR Descripcion LIKE @Filtro";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Aquí se usa el filtro proporcionado para buscar en Nombre y Descripción
                command.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
        public DataTable ObtenerTodosLosProductos(SqlConnection connection)
        {
            
            string query = "SELECT ID_Producto, Nombre, Descripcion, Precio_unitario, Stock, Disponible, Imagen FROM Producto";

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
              
                return dataTable;
            }
        }

        public bool GuardarProducto(SqlConnection connection, string nombre, string descripcion, decimal precioUnitario, int stock, bool disponible, byte[] imagen)
        {
            string query = "INSERT INTO Producto (Nombre, Descripcion, Precio_unitario, Stock, Disponible, Imagen) " +
                           "VALUES (@Nombre, @Descripcion, @Precio_unitario, @Stock, @Disponible, @Imagen)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Precio_unitario", precioUnitario);
                command.Parameters.AddWithValue("@Stock", stock);
                command.Parameters.AddWithValue("@Disponible", disponible);
                command.Parameters.AddWithValue("@Imagen", (object)imagen ?? DBNull.Value); 

                try
                {
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public bool EditarProducto(SqlConnection connection, int idProducto, string nombre, string descripcion, decimal precio, int stock, bool disponible, byte[] imagenBytes)
        {
            string query = "UPDATE Producto SET Nombre = @Nombre, Descripcion = @Descripcion, Precio_unitario = @Precio, Stock = @Stock, Disponible = @Disponible" +
               (imagenBytes != null ? ", Imagen = @Imagen" : "") +
               " WHERE ID_Producto = @ID_Producto";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Producto", idProducto);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Descripcion", descripcion);
                command.Parameters.AddWithValue("@Precio", precio);
                command.Parameters.AddWithValue("@Stock", stock);
                command.Parameters.AddWithValue("@Disponible", disponible);

               
                if (imagenBytes != null)
                {
                    command.Parameters.AddWithValue("@Imagen", imagenBytes);
                }

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

       public byte[] ConvertirImagen(string rutaImagen)
        {

            if (rutaImagen == null) return null;

            using (FileStream fs = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    return br.ReadBytes((int)fs.Length);
                }
            }

        }

    }
}
