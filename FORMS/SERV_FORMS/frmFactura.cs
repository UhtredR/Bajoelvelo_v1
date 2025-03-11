using Bajoelvelo_v1.Clases_Func;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1.FORMS.SERV_FORMS
{
    public partial class frmFactura : Form
    {

        private readonly SqlConnection cnx;
        private readonly CargaDG_FAC cargaDG_FAC;

        public frmFactura()
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
            cargaDG_FAC = new CargaDG_FAC();
            CargaFacturas();
        }


        private void CargaFacturas()
        {
            
            DataTable dataTable = cargaDG_FAC.ObtenerTodasLasFacturas(cnx);

            
            if (dgFacturas is DataGridView dataGridView) 
            {
                dataGridView.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Error: No se encontró el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarFactura(int idFactura)
        {
            using (SqlConnection connection = Infraestructura.Conexion.Conectar()) // Usando tu conexión
            {
                string queryDetalles = "DELETE FROM Detalle_Factura WHERE ID_Factura = @ID_Factura";
                string queryFactura = "DELETE FROM Factura WHERE ID_Factura = @ID_Factura";

                using (SqlCommand cmdDetalles = new SqlCommand(queryDetalles, connection))
                using (SqlCommand cmdFactura = new SqlCommand(queryFactura, connection))
                {
                    cmdDetalles.Parameters.AddWithValue("@ID_Factura", idFactura);
                    cmdFactura.Parameters.AddWithValue("@ID_Factura", idFactura);

                    connection.Open();
                    cmdDetalles.ExecuteNonQuery();  // Elimina los detalles primero
                    cmdFactura.ExecuteNonQuery();   // Luego elimina la factura
                    connection.Close();
                }
            }
        }



        private void sbtnBuscar_Click_1(object sender, EventArgs e)
        {
            string filtro = stxtBuscar.Text.Trim();

            // Si el textbox está vacío, mostrar todas las facturas
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Mostrando todas las facturas...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargaFacturas(); // Función para cargar todas las facturas
                return;
            }

            sbtnBuscar.Enabled = false;
            sbtnBuscar.Text = "Buscando...";

            try
            {
                // Llamar a la función que busca facturas (asegurarte de que esta función esté implementada)
                DataTable dataTable = cargaDG_FAC.BuscarFactura(cnx, filtro); // Ajusta según la lógica que necesites

                // Verificar que el DataGridView existe y mostrar los resultados
                if (dgFacturas is DataGridView dataGridView) // Asegúrate de que dgFacturas es el DataGridView donde mostrar los resultados
                {
                    dataGridView.DataSource = dataTable;

                    // Si no se encontraron resultados, mostrar un mensaje
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaFacturas(); // Recargar todas las facturas si no hay resultados
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar facturas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sbtnBuscar.Enabled = true;
                sbtnBuscar.Text = "Buscar";
            }
        }

        private void sbtnImprimir_Click_1(object sender, EventArgs e)
        {
            if (dgFacturas.Rows.Count > 0)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Facturas");

                    // Agregar encabezados, omitiendo el ID_Factura
                    for (int i = 1; i < dgFacturas.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i).Value = dgFacturas.Columns[i].HeaderText;
                    }

                    // Agregar filas de datos, omitiendo el ID_Factura
                    for (int i = 0; i < dgFacturas.Rows.Count; i++)
                    {
                        for (int j = 1; j < dgFacturas.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j).Value = dgFacturas.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Ajustar columnas al contenido
                    worksheet.Columns().AdjustToContents();

                    // Guardar el archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        FileName = "Facturas.xlsx",
                        Filter = "Excel Files|*.xlsx",
                        Title = "Guardar como"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Exportación a Excel completada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void sbtnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgFacturas.SelectedCells.Count > 0) // Verifica si hay una celda seleccionada
            {
                int rowIndex = dgFacturas.SelectedCells[0].RowIndex; // Obtener la fila de la celda seleccionada
                int idFactura = Convert.ToInt32(dgFacturas.Rows[rowIndex].Cells["ID_Factura"].Value);

                DialogResult result = MessageBox.Show("¿Seguro que deseas eliminar esta factura?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    EliminarFactura(idFactura); // Llamar la función con la conexión ya configurada
                    MessageBox.Show("Factura eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaFacturas();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una celda de la factura para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
