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
    public partial class frmClientes : Form
    {
        private readonly SqlConnection cnx;
        private CargaDG cargaDG;
        private int? idClienteSeleccionado = null;

        public frmClientes()
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
            cargaDG = new CargaDG();
            CargaClientes();
        }

        private void CargaClientes()
        {
            DataTable dataTable = cargaDG.ObtenerTodosLosClientes(cnx);

            stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
            {
                dataGridView.DataSource = dataTable;
            }
        }

        private void sBtnMinimizar_Click(object sender, EventArgs e)
        {
            FormFuncs formFuncs = new FormFuncs(this);
            formFuncs.minimizarForm();
        }

        private void sBtnMaximizar_Click(object sender, EventArgs e)
        {
            FormFuncs formFuncs = new FormFuncs(this);
            formFuncs.maximizarForm();
        }

        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            FormFuncs formFuncs = new FormFuncs(this);
            formFuncs.cerrarForm();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargaDG.CargarClientes(stabControlbtn1, cnx, cargaDG);
        }

        private void sbtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = stxtBuscar.Text.Trim(); 

            // Si el textbox está vacío, mostrar todos los clientes
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Mostrando todos los clientes...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargaClientes(); 
                return;
            }

            sbtnBuscar.Enabled = false;
            sbtnBuscar.Text = "Buscando...";

            try
            {
                DataTable dataTable = cargaDG.BuscarCliente(cnx, filtro);

                stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

                if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
                {
                    dataGridView.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaClientes(); // Si no hay resultados, muestra todos los clientes
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sbtnBuscar.Enabled = true;
                sbtnBuscar.Text = "Buscar";
            }

        }

        private void sbtnEliminar_Click(object sender, EventArgs e)
        {
            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView && dataGridView.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID_Cliente"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE ID_Cliente = @ID", cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID", idCliente);
                        cnx.Open(); 
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cnx.Close(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbtnImprimir_Click(object sender, EventArgs e)
        {
            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Clientes");

                    // Agregar encabezados, omitiendo el ID_Cliente
                    for (int i = 1; i < dataGridView.Columns.Count; i++) 
                    {
                        worksheet.Cell(1, i).Value = dataGridView.Columns[i].HeaderText;
                    }

                    // Agregar filas de datos, omitiendo el ID_Cliente
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView.Columns.Count; j++) 
                        {
                            worksheet.Cell(i + 2, j).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                   
                    worksheet.Columns().AdjustToContents();

                    
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        FileName = "Clientes.xlsx",
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

        private void sbtnGuardar_Click(object sender, EventArgs e)
        {
            
            string nombre = stxtNombre.Text.Trim();
            string apellido = stxtApellido.Text.Trim();
            string direccion = stxtDireccion.Text.Trim();
            string telefono = stxtTelefono.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(direccion)
                || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            CargaDG cargaDG = new CargaDG();

            if (cargaDG.GuardarCliente(cnx, nombre, apellido, direccion, telefono))
            { 
                MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargaClientes();
            }

        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void sbtnEditar_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Direccion = @Direccion, Telefono = @Telefono WHERE ID_Cliente = @ID", cnx))
            {
                cmd.Parameters.AddWithValue("@Nombre", stxtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", stxtApellido.Text);
                cmd.Parameters.AddWithValue("@Direccion", stxtDireccion.Text);
                cmd.Parameters.AddWithValue("@Telefono", stxtTelefono.Text);
                cmd.Parameters.AddWithValue("@ID", idClienteSeleccionado);

                // Verificar si la conexión está cerrada antes de abrirla
                if (cnx.State == ConnectionState.Closed)
                {
                    cnx.Open();
                }

                int rowsAffected = cmd.ExecuteNonQuery();
                cnx.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaClientes(); 
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgClientes.SelectedRows[0];

                // Obtener el ID del cliente
                idClienteSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["ID_Cliente"].Value);

                // Cargar los datos en los TextBox
                stxtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                stxtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                stxtDireccion.Text = filaSeleccionada.Cells["Direccion"].Value.ToString();
                stxtTelefono.Text = filaSeleccionada.Cells["Telefono"].Value.ToString();
            }
        }

        private void sbtnNuevo_Click(object sender, EventArgs e)
        {
            stxtNombre.Clear();
            stxtApellido.Clear();
            stxtDireccion.Clear();
            stxtTelefono.Clear();
        }
    }
}
