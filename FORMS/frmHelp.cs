using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();

        }



        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainmenu frmMainmenu = new frmMainmenu();
            frmMainmenu.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            

            slblSoporte.Text = "<p><strong>Para contactar al soporte técnico, por favor, envíe un correo a:</strong></p>" +
        "<p>📧 <strong>soporte@bajoelvelo.com</strong></p>" +
        "<p><strong>Incluya los siguientes detalles para que podamos ayudarle de manera más eficiente:</strong></p>" +
        "<ul>" +
        "<li>Descripción detallada del problema.</li>" +
        "<li>Pantalla o sección del sistema donde ocurrió el inconveniente.</li>" +
        "<li>Captura de pantalla o mensaje de error (si aplica).</li>" +
        "</ul>" +
        "<p><strong>Nuestro equipo de soporte estará encantado de asistirle lo antes posible.</strong></p>";



        }

        private void sbtnEmail_Click(object sender, EventArgs e)
        {
            string destinatario = "soporte@bajoelvelo.com";
            string asunto = Uri.EscapeDataString("Asunto del correo");
            string cuerpo = Uri.EscapeDataString("Hola, este es un mensaje predefinido.");

            string url = $"https://mail.google.com/mail/?view=cm&fs=1&to={destinatario}&su={asunto}&body={cuerpo}";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "chrome.exe", // Lanza Google Chrome
                    Arguments = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Gmail en Chrome: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sbtnWhatsapp_Click(object sender, EventArgs e)
        {
            Process.Start("https://wa.me/8090000000");
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/UhtredR/Bajoelvelo_v1");
        }
    }
}
