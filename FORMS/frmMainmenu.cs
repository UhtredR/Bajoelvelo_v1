using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace Bajoelvelo_v1
{
    public partial class frmMainmenu : Form
    {
        private readonly SqlConnection cnx;

        public frmMainmenu()
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
            this.Padding = new Padding(0, 0, SystemInformation.VerticalScrollBarWidth, 0);
            this.BackColor = Color.FromArgb(240, 240, 240);
        }

        [DllImport("user32.DLL")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Clases_Func.FormFuncs formFuncs;
        


        private void sbtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                                           "Confirmar",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    
                    if (cnx != null && cnx.State == ConnectionState.Open)
                    {
                        cnx.Close();
                    }

                    // Ocultar el formulario actual (menú principal)
                    this.Hide();

                    // Mostrar el formulario de inicio de sesión
                    frmInicio frmLogin = new frmInicio(); // Asegúrate de usar el nombre correcto de tu form de login
                    frmLogin.Show();

                    // Cerrar completamente este formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cerrar sesión: " + ex.Message, "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmMainmenu_Load(object sender, EventArgs e)
        {

        }

        private void sBtnMinimizar_Click(object sender, EventArgs e)
        {
            formFuncs = new Clases_Func.FormFuncs(this);
            formFuncs.minimizarForm();
        }

        private void sbtnCatalogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCatalogo catalogo = new frmCatalogo();
            catalogo.Show();

        }

        private void sbtnServicios_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServices frmServices = new frmServices();
            frmServices.Show();
        }

        private void sbtnAyuda_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
        }

        private void sBtnMaximizar_Click(object sender, EventArgs e)
        {
            formFuncs = new Clases_Func.FormFuncs(this);
            formFuncs.maximizarForm();
        }

        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            formFuncs = new Clases_Func.FormFuncs(this);
            formFuncs.cerrarForm();
        }

        private void spanelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmMainmenu_Resize(object sender, EventArgs e)
        {
           
        }

        private void sBtnMenu_Click(object sender, EventArgs e)
        {
            formFuncs = new Clases_Func.FormFuncs(this);
        }

        private void sbtnAyuda_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();

        }

        private void spanelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
