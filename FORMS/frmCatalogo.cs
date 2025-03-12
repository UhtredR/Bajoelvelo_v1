using Bajoelvelo_v1.Clases_Func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bajoelvelo_v1.FORMS.REP_FORMS;
using Siticone.Desktop.UI.WinForms;

namespace Bajoelvelo_v1
{
    public partial class frmCatalogo : Form
    {
        private readonly SqlConnection cnx;
        private Factura _factura;
        private DataTable _dtClientes;
        private DataTable _dtProductos;

        private int _idUsuarioActual;
        private int _idNegocioActual;


        public frmCatalogo(int idUsuario = 1, int idNegocio = 1)
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
            _idUsuarioActual = idUsuario;
            _idNegocioActual = idNegocio;

            _factura = new Factura(_idUsuarioActual, _idNegocioActual);

            ConfigurarControles();
            CargarDatos();
            CargarFlTabControl();

        }
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            CargaFlowLayout CargaFlowLayout = new CargaFlowLayout();
            CargaFlowLayout.CargarProductosFL(flProductos, cnx);
        }

        private void CargarFlTabControl()
        {


            TabPage tabPage = stabControlbtn1.TabPages[0];

            if (!tabPage.Controls.Contains(flProductos))
            { 
                tabPage.Controls.Add(flProductos);
            }

            flProductos.Dock = DockStyle.Fill;
            flProductos.AutoScroll = true;
            flProductos.BringToFront();

            CargaFlowLayout CargaFlowLayout = new CargaFlowLayout();
            CargaFlowLayout.CargarProductosFL(flProductos, cnx);


        }


        private void ConfigurarControles()
        {
            // Configurar DateTimePicker
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Value = DateTime.Now;

            // Configurar el grid de detalle de factura
            dgvDetalleFactura.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn colProducto = new DataGridViewTextBoxColumn();
            colProducto.DataPropertyName = "NombreProducto";
            colProducto.HeaderText = "Producto";
            colProducto.ReadOnly = true;
            colProducto.Width = 200;
            dgvDetalleFactura.Columns.Add(colProducto);

            DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
            colCantidad.DataPropertyName = "Cantidad";
            colCantidad.HeaderText = "Cantidad";
            colCantidad.ReadOnly = true;
            colCantidad.Width = 80;
            dgvDetalleFactura.Columns.Add(colCantidad);

            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.DataPropertyName = "PrecioUnitario";
            colPrecio.HeaderText = "Precio Unitario";
            colPrecio.ReadOnly = true;
            colPrecio.Width = 100;
            colPrecio.DefaultCellStyle.Format = "C2";
            dgvDetalleFactura.Columns.Add(colPrecio);

            DataGridViewTextBoxColumn colSubtotal = new DataGridViewTextBoxColumn();
            colSubtotal.DataPropertyName = "Subtotal";
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.ReadOnly = true;
            colSubtotal.Width = 100;
            colSubtotal.DefaultCellStyle.Format = "C2";
            dgvDetalleFactura.Columns.Add(colSubtotal);

            DataGridViewButtonColumn colEliminar = new DataGridViewButtonColumn();
            colEliminar.HeaderText = "Eliminar";
            colEliminar.Text = "X";
            colEliminar.UseColumnTextForButtonValue = true;
            colEliminar.Width = 70;
            dgvDetalleFactura.Columns.Add(colEliminar);

            // Configurar NumericUpDown
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 10;
            nudCantidad.Value = 1;
        }

        private void CargarDatos()
        {
            try
            {
                // Cargar clientes
                _dtClientes = _factura.ObtenerClientes();
                scmbCliente.DataSource = _dtClientes;
                scmbCliente.DisplayMember = "NombreCompleto";
                scmbCliente.ValueMember = "ID_Cliente";
                scmbCliente.SelectedIndex = -1;

                // Cargar productos
                _dtProductos = _factura.ObtenerProductos();
                scmbProducto.DataSource = _dtProductos;
                scmbProducto.DisplayMember = "Nombre";
                scmbProducto.ValueMember = "ID_Producto";
                scmbProducto.SelectedIndex = -1;

                // Inicializar DataGridView
                ActualizarDataGridView();
                ActualizarTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarDataGridView()
        {
            // Convertir la lista de DetalleFactura a un DataTable para mostrar en el grid
            DataTable dt = new DataTable();
            dt.Columns.Add("IdProducto", typeof(int));
            dt.Columns.Add("NombreProducto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("PrecioUnitario", typeof(decimal));
            dt.Columns.Add("Subtotal", typeof(decimal));

            foreach (var detalle in _factura.DetallesFacturas)
            {
                dt.Rows.Add(
                    detalle.IdProducto,
                    detalle.NombreProducto,
                    detalle.Cantidad,
                    detalle.PrecioUnitario,
                    detalle.Subtotal
                );
            }

            dgvDetalleFactura.DataSource = dt;
        }

        private void ActualizarTotales()
        {
            lblSubtotal.Text = _factura.Subtotal.ToString("C2");
            lblItbis.Text = _factura.Itbis.ToString("C2");
            lblTotal.Text = _factura.Total.ToString("C2");
        }


        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvDetalleFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDetalleFactura.Columns.Count - 1 && e.RowIndex >= 0)
            {
                // Eliminar el producto del detalle
                _factura.DetallesFacturas.RemoveAt(e.RowIndex);
                _factura.CalcularTotales();

                ActualizarDataGridView();
                ActualizarTotales();
            }
        }

        private void sbtnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (scmbProducto.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idProducto = Convert.ToInt32(scmbProducto.SelectedValue);
                string nombreProducto = scmbProducto.Text;
                int cantidad = Convert.ToInt32(nudCantidad.Value);

                // Obtener el precio y stock del producto seleccionado
                DataRow[] filas = _dtProductos.Select($"ID_Producto = {idProducto}");
                if (filas.Length == 0)
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal precioUnitario = Convert.ToDecimal(filas[0]["Precio_unitario"]);
                int stockDisponible = Convert.ToInt32(filas[0]["Stock"]);


                bool resultado = _factura.AgregarProducto(idProducto, nombreProducto, cantidad, precioUnitario, stockDisponible);


                if (!resultado)
                {
                    MessageBox.Show($"No hay suficiente stock disponible. Stock actual: {stockDisponible}",
                        "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ActualizarDataGridView();
                ActualizarTotales();

                // Limpiar selección
                scmbProducto.SelectedIndex = -1;
                nudCantidad.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnGuardarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                if (scmbCliente.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un cliente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_factura.DetallesFacturas.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar cliente y fecha
                _factura.IdCliente = Convert.ToInt32(scmbCliente.SelectedValue);
                _factura.Fecha = dtpFechaFactura.Value;

                // Guardar la factura
                int idFactura = _factura.GuardarFactura();

                MessageBox.Show($"Factura guardada correctamente. ID: {idFactura}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    // Generar el archivo PDF de la factura




                // Reiniciar el formulario para una nueva factura
                _factura = new Factura(_idUsuarioActual, _idNegocioActual);

                scmbCliente.SelectedIndex = -1;
                dtpFechaFactura.Value = DateTime.Now;
                ActualizarDataGridView();
                ActualizarTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnCancelar_Click(object sender, EventArgs e)
        {
            if (_factura.DetallesFacturas.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de cancelar la factura actual?",
                    "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _factura = new Factura(_idUsuarioActual, _idNegocioActual);

                    scmbCliente.SelectedIndex = -1;
                    dtpFechaFactura.Value = DateTime.Now;
                    ActualizarDataGridView();
                    ActualizarTotales();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void siticonePanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sBtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMainmenu frmMainmenu = new frmMainmenu();
            frmMainmenu.Show();
        }
    }
}

