using Syncfusion.Windows.Forms.Interop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1.Clases_Func
{
    public class CargaDG
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

        public DataTable BuscarCliente(SqlConnection connection, string filtro)
        {
            string query = "SELECT Nombre, Apellido, Direccion, Telefono FROM Cliente WHERE Nombre LIKE @Filtro OR Apellido LIKE @Filtro";

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

        public void CargarClientes(TabControl stabControlbtn1, SqlConnection cnx, CargaDG cargaDG)
        {
            string query = "SELECT ID_Cliente, Nombre, Apellido, Direccion, Telefono FROM Cliente"; 

            DataTable dataTable = cargaDG.CargarDatos(cnx, query);

            stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
            {
                dataGridView.DataSource = dataTable;
                dataGridView.Columns["ID_Cliente"].Visible = false;
            }
        }

        public DataTable ObtenerTodosLosClientes(SqlConnection connection)
        {
            string query = "SELECT ID_Cliente, Nombre, Apellido, Direccion, Telefono FROM Cliente"; 

            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public bool GuardarCliente(SqlConnection connection, string nombre, string apellido, string direccion, string telefono)
        {
            string query = "INSERT INTO Cliente (Nombre, Apellido, Direccion, Telefono) VALUES (@Nombre, @Apellido, @Direccion, @Telefono)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Telefono", telefono);


                try
                {
                    connection.Open();
                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch(Exception ex)
                { 
                    MessageBox.Show("Error al guardar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool EditarCliente(SqlConnection connection, int idCliente, string nombre, string apellido, string direccion, string telefono)
        {
            string query = "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono WHERE ID_Cliente = @ID_Cliente";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_Cliente", idCliente);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Direccion", direccion);
                command.Parameters.AddWithValue("@Telefono", telefono);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0; // Retorna true si se actualizó el cliente
            }

        }


    }

}
