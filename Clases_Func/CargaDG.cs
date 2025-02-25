using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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

        public void CargarClientes(TabControl stabControlbtn1, SqlConnection cnx, CargaDG cargaDG)
        {
            string query = "SELECT Nombre, Apellido, Direccion, Telefono FROM Cliente";
            DataTable dataTable = cargaDG.CargarDatos(cnx, query);

            stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
            {
                dataGridView.DataSource = dataTable;
            }
        }
    }

}
