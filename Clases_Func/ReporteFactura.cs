using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Bajoelvelo_v1.Clases_Func
{
    
    public class ReporteFactura
    {

        private int IdFactura;
        private ReportViewer reportViewer;
        private SqlConnection cnx;



        public ReporteFactura(int idFactura, ReportViewer reportViewer)
        {
            IdFactura = idFactura;
            this.reportViewer = reportViewer;
            cnx = Infraestructura.Conexion.Conectar();
        }

        public void GenerarReporte()
        {
            try
            {
                // Obtener los datos
                DataSet dsFactura = ObtenerDatosFactura();

                if (dsFactura.Tables["DatosFactura"].Rows.Count == 0)
                {
                    throw new Exception("No se encontraron datos para la factura especificada");
                }

                // Configurar el origen de datos para el ReportViewer
                ReportDataSource rdsFactura = new ReportDataSource("DatosFactura", dsFactura.Tables["DatosFactura"]);
                ReportDataSource rdsDetalles = new ReportDataSource("DetallesFactura", dsFactura.Tables["DetallesFactura"]);
                ReportDataSource rdsTotales = new ReportDataSource("Totales", dsFactura.Tables["Totales"]);

                // Limpiar orígenes de datos previos
                reportViewer.LocalReport.DataSources.Clear();

                // Agregar los orígenes de datos
                reportViewer.LocalReport.DataSources.Add(rdsFactura);
                reportViewer.LocalReport.DataSources.Add(rdsDetalles);
                reportViewer.LocalReport.DataSources.Add(rdsTotales);

                // Configurar la ruta del reporte
                reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\Reportes\\ReporteFactura.rdlc";

                // Actualizar el reporte
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte de factura: " + ex.Message);
            }
        }

        private DataSet ObtenerDatosFactura()
        {
            DataSet ds = new DataSet();

            try
            {
                cnx.Open();

                // Consulta para obtener datos de la factura
                string queryFactura = @"
                    SELECT 
                        F.ID_Factura, F.Fecha_factura, 
                        C.Nombre + ' ' + C.Apellido AS NombreCliente,
                        C.Direccion, C.Telefono, C.RNC,
                        U.Nombre + ' ' + U.Apellido AS NombreUsuario,
                        N.Nombre AS NombreNegocio,
                        N.Direccion AS DireccionNegocio,
                        N.Telefono AS TelefonoNegocio,
                        N.RNC AS RNCNegocio
                    FROM Factura F
                    INNER JOIN Cliente C ON F.ID_Cliente = C.ID_Cliente
                    INNER JOIN Usuario U ON F.ID_Usuario = U.ID_Usuario
                    INNER JOIN Negocio N ON F.ID_Negocio = N.ID_Negocio
                    WHERE F.ID_Factura = @idFactura";

                SqlCommand cmdFactura = new SqlCommand(queryFactura, cnx);
                cmdFactura.Parameters.AddWithValue("@idFactura", IdFactura);

                SqlDataAdapter adapterFactura = new SqlDataAdapter(cmdFactura);
                adapterFactura.Fill(ds, "DatosFactura");

                // Consulta para obtener los detalles de la factura
                string queryDetalles = @"
                    SELECT 
                        DF.ID_Detalle_Factura,
                        P.Nombre AS NombreProducto,
                        DF.Cantidad, 
                        P.Precio_unitario,
                        DF.Subtotal
                    FROM Detalle_Factura DF
                    INNER JOIN Producto P ON DF.ID_Producto = P.ID_Producto
                    WHERE DF.ID_Factura = @idFactura";

                SqlCommand cmdDetalles = new SqlCommand(queryDetalles, cnx);
                cmdDetalles.Parameters.AddWithValue("@idFactura", IdFactura);

                SqlDataAdapter adapterDetalles = new SqlDataAdapter(cmdDetalles);
                adapterDetalles.Fill(ds, "DetallesFactura");

                // Calcular y agregar totales
                if (ds.Tables["DatosFactura"].Rows.Count > 0)
                {
                    DataTable dtTotales = new DataTable("Totales");
                    dtTotales.Columns.Add("Subtotal", typeof(decimal));
                    dtTotales.Columns.Add("ITBIS", typeof(decimal));
                    dtTotales.Columns.Add("Total", typeof(decimal));

                    decimal subtotal = 0;
                    foreach (DataRow row in ds.Tables["DetallesFactura"].Rows)
                    {
                        subtotal += Convert.ToDecimal(row["Subtotal"]);
                    }

                    decimal itbis = subtotal * 0.18m;
                    decimal total = subtotal + itbis;

                    DataRow rowTotal = dtTotales.NewRow();
                    rowTotal["Subtotal"] = subtotal;
                    rowTotal["ITBIS"] = itbis;
                    rowTotal["Total"] = total;
                    dtTotales.Rows.Add(rowTotal);

                    ds.Tables.Add(dtTotales);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de la factura: " + ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                    cnx.Close();
            }

            return ds;
        }

        public void ExportarAPDF()
        {
            try
            {
                // Generar el reporte primero
                GenerarReporte();

                // Configurar el SaveFileDialog
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveDialog.Title = "Guardar Factura como PDF";
                saveDialog.FileName = $"Factura_{IdFactura}.pdf";
                saveDialog.DefaultExt = "pdf";
                saveDialog.AddExtension = true;

                // Mostrar el diálogo y procesar si el usuario selecciona una ubicación
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveDialog.FileName;

                    string deviceInfo = @"<DeviceInfo>
                                    <OutputFormat>PDF</OutputFormat>
                                    <PageWidth>8.5in</PageWidth>
                                    <PageHeight>11in</PageHeight>
                                    <MarginTop>0.5in</MarginTop>
                                    <MarginLeft>0.5in</MarginLeft>
                                    <MarginRight>0.5in</MarginRight>
                                    <MarginBottom>0.5in</MarginBottom>
                                </DeviceInfo>";

                    Warning[] warnings;
                    string[] streamIds;
                    string mimeType = string.Empty;
                    string encoding = string.Empty;
                    string extension = string.Empty;

                    byte[] bytes = reportViewer.LocalReport.Render(
                        "PDF", deviceInfo, out mimeType, out encoding, out extension,
                        out streamIds, out warnings);

                    using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    MessageBox.Show("El reporte se ha exportado correctamente a PDF", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar el reporte a PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }


}

