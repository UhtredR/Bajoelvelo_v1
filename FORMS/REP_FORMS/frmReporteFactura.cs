using Bajoelvelo_v1.Clases_Func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1.FORMS.REP_FORMS
{
    public partial class frmReporteFactura : Form
    {

        private int IdFactura;

        public frmReporteFactura()
        {
            InitializeComponent();
            this.IdFactura = IdFactura;
        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
            try
            {
                // Asegúrate de que reportViewer1 está en tu formulario
                ReporteFactura reporte = new ReporteFactura(IdFactura, reportViewer1);
                reporte.GenerarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
                this.Close();
            }

        }

        private void sbtnExportarFactura_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo PDF|*.pdf";
            saveDialog.Title = "Guardar reporte de factura";
            saveDialog.FileName = "Factura_" + IdFactura.ToString();

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ReporteFactura reporte = new ReporteFactura(IdFactura, reportViewer1);
                reporte.ExportarAPDF();
            }
        }
    }
}
