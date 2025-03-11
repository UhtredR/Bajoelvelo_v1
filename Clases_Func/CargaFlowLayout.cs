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
        public void CargarProductosFL( FlowLayoutPanel flowLayoutPanel, SqlConnection connection)
        {
            DataTable dtProductos = CargaDG_INV.ObtenerTodosLosProductos(connection);
            
            foreach( DataRow Fila in dtProductos.Rows )
            {

                Panel panelProductos = new Panel();
                panelProductos.Width = 150;
                panelProductos.Height = 180;
                panelProductos.BorderStyle = BorderStyle.FixedSingle;
                panelProductos.Margin = new Padding(5);


                PictureBox pbImagen = new PictureBox();
                pbImagen.Width = 150;
                pbImagen.Height = 100;
                pbImagen.Location = new System.Drawing.Point(10, 10);
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom;

                if (Fila["Imagen"] != DBNull.Value)
                {

                    if (System.IO.File.Exists(Fila["Imagen"].ToString()))
                    { 
                        
                        pbImagen.Image = Image.FromFile(Fila["Imagen"].ToString());

                    }

                    byte[] img = (byte[])Fila["Imagen"];

                    using (MemoryStream ms = new MemoryStream(img))
                    {
                        pbImagen.Image = Image.FromStream(ms);
                    }

                }

                Label lblNombre = new Label();
                lblNombre.Text = Fila["Nombre"].ToString();
                lblNombre.AutoSize = false;
                lblNombre.Width = 130;
                lblNombre.Height = 20;
                lblNombre.TextAlign = ContentAlignment.MiddleCenter;
                lblNombre.Location = new Point(10, 120);


                Label lblDisponibilidad = new Label();
                lblDisponibilidad.Text = "Disponible: "  + Fila["Stock"].ToString();
                lblDisponibilidad.AutoSize = false;
                lblDisponibilidad.Width = 130;
                lblDisponibilidad.Height = 20;
                lblDisponibilidad.TextAlign = ContentAlignment.MiddleCenter;
                lblDisponibilidad.Location = new Point(10, 140);


                if (Convert.ToInt32(Fila["Stock"]) >0 )
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
        }
    }
}
