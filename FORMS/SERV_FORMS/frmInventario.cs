using Bajoelvelo_v1.Clases_Func;
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
    public partial class frmInventario : Form
    {
        private readonly SqlConnection cnx;
        private readonly CargaDG_INV cargaDG_INV;
        private int idProductoSeleccionado;

        public frmInventario()
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
            cargaDG_INV = new CargaDG_INV();
            CargaProductos();
        }

        private void CargaProductos()
        {
            DataTable dataTable = cargaDG_INV.ObtenerTodosLosProductos(cnx);

            stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

            if (stabControlbtn1.SelectedTab.Controls["dgInventario"] is DataGridView dataGridView)
            {
                dataGridView.DataSource = dataTable;
            }
        }

        private void sbtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = stxtBuscar.Text.Trim();

            // Si el textbox está vacío, mostrar todos los productos
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Mostrando todos los productos...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargaProductos();
                return;
            }

            sbtnBuscar.Enabled = false;
            sbtnBuscar.Text = "Buscando...";

            try
            {

                DataTable dataTable = cargaDG_INV.BuscarProducto(cnx, filtro);

                stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

                
                if (stabControlbtn1.SelectedTab.Controls["dgInventario"] is DataGridView dataGridView)
                {
                    dataGridView.DataSource = dataTable;

                    
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaProductos();
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sbtnBuscar.Enabled = true;
                sbtnBuscar.Text = "Buscar";
            }
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            
        }

        private void sbtnEliminar_Click(object sender, EventArgs e)
        {
            if (stabControlbtn1.SelectedTab.Controls["dgInventario"] is DataGridView dataGridView && dataGridView.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID_Producto"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Producto WHERE ID_Producto = @ID", cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID", idProducto);
                        cnx.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cnx.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sbtnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = stxtNombre.Text.Trim();
            string descripcion = stxtDescripcion.Text.Trim();
            decimal precio;
            int stock;
            bool disponible = schkDisponible.Checked;

            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(stxtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(stxtStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool guardado = cargaDG_INV.GuardarProducto(cnx, nombre, descripcion, precio, stock, disponible);

            if (guardado)
            {
                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnNuevo_Click(object sender, EventArgs e)
        {
            stxtNombre.Clear();
            stxtDescripcion.Clear();
            stxtPrecio.Clear();
            stxtStock.Clear();
            schkDisponible.Checked = true;
            stxtNombre.Focus();
        }

        private void sbtnEditar_Click(object sender, EventArgs e)
        {
            if (dgInventario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(dgInventario.SelectedRows[0].Cells["ID_Producto"].Value);
            string nombre = stxtNombre.Text.Trim();
            string descripcion = stxtDescripcion.Text.Trim();
            decimal precio;
            int stock;
            bool disponible = schkDisponible.Checked;

            // Validaciones
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(stxtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(stxtStock.Text, out stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un stock válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de editar
            DialogResult result = MessageBox.Show("¿Deseas guardar los cambios en este producto?",
                                                  "Confirmar edición",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CargaDG_INV cargaDG_INV = new CargaDG_INV();
                bool editado = cargaDG_INV.EditarProducto(cnx, idProducto, nombre, descripcion, precio, stock, disponible);

                if (editado)
                {
                    MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgInventario.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgInventario.SelectedRows[0];

                // Obtener el ID del producto
                idProductoSeleccionado = Convert.ToInt32(filaSeleccionada.Cells["ID_Producto"].Value);

                // Cargar los datos en los TextBox
                stxtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                stxtDescripcion.Text = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                stxtPrecio.Text = filaSeleccionada.Cells["Precio_unitario"].Value.ToString();
                stxtStock.Text = filaSeleccionada.Cells["Stock"].Value.ToString();
                schkDisponible.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Disponible"].Value);
            }
        }
    }
}
