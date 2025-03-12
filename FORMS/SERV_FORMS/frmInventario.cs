using Bajoelvelo_v1.Clases_Func;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        private string rutaImagen = null;

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

            
            byte[] imagenBytes = cargaDG_INV.ConvertirImagen(rutaImagen);

            bool guardado = cargaDG_INV.GuardarProducto(cnx, nombre, descripcion, precio, stock, disponible, imagenBytes);

            if (guardado)
            {
                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            stxtNombre.Clear();
            stxtDescripcion.Clear();
            stxtPrecio.Clear();
            stxtStock.Clear();
            schkDisponible.Checked = true;
            spbProducto.Image = null; 
            rutaImagen = null;
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

            // Convertir la imagen si el usuario seleccionó una nueva
            byte[] imagenBytes = null;
            if (rutaImagen != null)
            {
                imagenBytes = cargaDG_INV.ConvertirImagen(rutaImagen);
            }

            // Confirmación antes de editar
            DialogResult result = MessageBox.Show("¿Deseas guardar los cambios en este producto?",
                                                  "Confirmar edición",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CargaDG_INV cargaDG_INV = new CargaDG_INV();
                bool editado = cargaDG_INV.EditarProducto(cnx, idProducto, nombre, descripcion, precio, stock, disponible, imagenBytes);

                if (editado)
                {
                    MessageBox.Show("Producto editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    spbProducto.Image = null;
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

                // Cargar la imagen en el PictureBox (si existe)
                if (filaSeleccionada.Cells["Imagen"].Value != DBNull.Value)
                {
                    byte[] imagenBytes = (byte[])filaSeleccionada.Cells["Imagen"].Value;
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        spbProducto.Image = Image.FromStream(ms); // Cargar la imagen en el PictureBox
                    }
                }
                else
                {
                    spbProducto.Image = null; // Limpiar el PictureBox si no hay imagen
                }
            }
        }

        private void sbtnSeleccionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = ofd.FileName; 
                    spbProducto.Image = Image.FromFile(rutaImagen); 
                }
            }
        }

        private void sbtnImprimir_Click(object sender, EventArgs e)
        {
            if (stabControlbtn1.SelectedTab.Controls["dgInventario"] is DataGridView dataGridView)
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Productos");

                    // Agregar encabezados, omitiendo el ID_Producto
                    for (int i = 1; i < dataGridView.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i).Value = dataGridView.Columns[i].HeaderText;
                    }

                    // Agregar filas de datos, omitiendo el ID_Producto
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 1; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j).Value = dataGridView.Rows[i].Cells[j].Value?.ToString();
                        }
                    }

                    // Ajustar columnas al contenido
                    worksheet.Columns().AdjustToContents();

                    // Guardar el archivo
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        FileName = "Inventario.xlsx",
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

        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServices frmServices = new frmServices();
            frmServices.Show();
        }
    }
}
