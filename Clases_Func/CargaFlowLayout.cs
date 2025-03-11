using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Siticone.Desktop.UI.WinForms;

namespace Bajoelvelo_v1.Clases_Func
{

    public class CargaFlowLayout
    {
        CargaDG_INV CargaDG_INV = new CargaDG_INV();

        public void CargarProductosFL(FlowLayoutPanel flowLayoutPanel, SqlConnection connection)
        {
            // Configuración básica del FlowLayoutPanel
            flowLayoutPanel.WrapContents = true;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

            // Importante: Esta propiedad distribuye el espacio uniformemente
            flowLayoutPanel.Padding = new Padding(0);

            // Asegúrate que el alignment del FlowLayoutPanel está centrado
            flowLayoutPanel.HorizontalScroll.Enabled = false; // Ayuda con la disposición

            // Ajustar el ancho de los paneles de productos para una mejor distribución
            int anchoPanelBase = 150;
            int alturaPanelBase = 180;
            int espaciadoPanel = 10; // Espaciado entre paneles

            // Obtener los datos
            DataTable dtProductos = CargaDG_INV.ObtenerTodosLosProductos(connection);

            // Calcular cuántos elementos caben por fila
            int anchoDisponible = flowLayoutPanel.ClientSize.Width;
            int anchoPanelTotal = anchoPanelBase + espaciadoPanel;
            int panelesEnFila = Math.Max(1, anchoDisponible / anchoPanelTotal);

            // Calcular espacio sobrante y dividirlo entre los espacios entre paneles
            int espacioSobrante = anchoDisponible - (panelesEnFila * anchoPanelBase);
            int nuevoPadding = Math.Max(5, espacioSobrante / (panelesEnFila + 1));

            // Configurar el FlowLayoutPanel con paddings uniformes
            flowLayoutPanel.Padding = new Padding(nuevoPadding, 10, nuevoPadding, 10);

            // Crear los paneles de productos con márgenes ajustados
            foreach (DataRow Fila in dtProductos.Rows)
            {
                Panel panelProductos = new Panel();
                panelProductos.Width = anchoPanelBase;
                panelProductos.Height = alturaPanelBase;
                panelProductos.BorderStyle = BorderStyle.FixedSingle;

                // Usar márgenes uniformes que ayudan con el centrado
                panelProductos.Margin = new Padding(
                    (espacioSobrante / (panelesEnFila + 1)) / 2, // izquierda
                    5, // arriba
                    (espacioSobrante / (panelesEnFila + 1)) / 2, // derecha
                    5  // abajo
                );

                PictureBox pbImagen = new PictureBox();
                pbImagen.Width = anchoPanelBase - 20; // Ajustado para quedar dentro del panel
                pbImagen.Height = 100;
                pbImagen.Location = new System.Drawing.Point(10, 10);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;

                // Corregir el manejo de imágenes
                if (Fila["Imagen"] != DBNull.Value)
                {
                    string imagePath = Fila["Imagen"].ToString();
                    if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    {
                        pbImagen.Image = Image.FromFile(imagePath);
                    }
                    else if (Fila["Imagen"] is byte[])
                    {
                        byte[] img = (byte[])Fila["Imagen"];
                        using (MemoryStream ms = new MemoryStream(img))
                        {
                            pbImagen.Image = Image.FromStream(ms);
                        }
                    }
                }

                Label lblNombre = new Label();
                lblNombre.Text = Fila["Nombre"].ToString();
                lblNombre.AutoSize = false;
                lblNombre.Width = anchoPanelBase - 20;
                lblNombre.Height = 20;
                lblNombre.TextAlign = ContentAlignment.MiddleCenter;
                lblNombre.Location = new Point(10, 120);

                Label lblDisponibilidad = new Label();
                lblDisponibilidad.Text = "Disponible: " + Fila["Stock"].ToString();
                lblDisponibilidad.AutoSize = false;
                lblDisponibilidad.Width = anchoPanelBase - 20;
                lblDisponibilidad.Height = 20;
                lblDisponibilidad.TextAlign = ContentAlignment.MiddleCenter;
                lblDisponibilidad.Location = new Point(10, 140);

                if (Convert.ToInt32(Fila["Stock"]) > 0)
                {
                    lblDisponibilidad.ForeColor = Color.Green;
                }
                else
                {
                    lblDisponibilidad.ForeColor = Color.Red;
                }

                panelProductos.Controls.Add(pbImagen);
                panelProductos.Controls.Add(lblNombre);
                panelProductos.Controls.Add(lblDisponibilidad);
                panelProductos.Tag = Fila["ID_Producto"].ToString();

                panelProductos.Click += (sender, e) =>
                {
                    string idProducto = ((Panel)sender).Tag.ToString();
                    MessageBox.Show("ID Producto: " + idProducto);
                };

                flowLayoutPanel.Controls.Add(panelProductos);
            }

            // Registrar evento para mantener el centrado cuando cambia el tamaño
            flowLayoutPanel.SizeChanged += (sender, e) => AjustarCentradoDeFilas(flowLayoutPanel);
        }

        private void AjustarCentradoDeFilas(FlowLayoutPanel flowLayoutPanel)
        {
            // Solo recalcular si hay elementos
            if (flowLayoutPanel.Controls.Count == 0) return;

            // Recalcular los márgenes para centrar cuando cambia el tamaño
            int anchoPanelBase = 150;
            int anchoDisponible = flowLayoutPanel.ClientSize.Width;
            int anchoPanelTotal = anchoPanelBase + 10; // ancho + espaciado típico
            int panelesEnFila = Math.Max(1, anchoDisponible / anchoPanelTotal);

            int espacioSobrante = anchoDisponible - (panelesEnFila * anchoPanelBase);
            int nuevoPadding = Math.Max(5, espacioSobrante / (panelesEnFila + 1));

            // Actualizar padding y márgenes
            flowLayoutPanel.Padding = new Padding(nuevoPadding, 10, nuevoPadding, 10);

            foreach (Control control in flowLayoutPanel.Controls)
            {
                if (control is Panel panelProducto && panelProducto.Height > 0)
                {
                    panelProducto.Margin = new Padding(
                        (espacioSobrante / (panelesEnFila + 1)) / 2,
                        5,
                        (espacioSobrante / (panelesEnFila + 1)) / 2,
                        5
                    );
                }
            }

            // Forzar recálculo del layout
            flowLayoutPanel.PerformLayout();
        }
    }
}
