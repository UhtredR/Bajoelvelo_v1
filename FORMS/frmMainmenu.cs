using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1
{
    public partial class frmMainmenu : Form
    {
        public frmMainmenu()
        {
            InitializeComponent();
        }

        private void sbtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Deseas cerrar el programa", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void frmMainmenu_Load(object sender, EventArgs e)
        {

        }

        private void sBtnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void sbtnCatalogo_Click(object sender, EventArgs e)
        {
            frmCatalogo frmCatalogo = new frmCatalogo();
            frmCatalogo.Show();

        }

        private void sbtnServicios_Click(object sender, EventArgs e)
        {
            frmServices frmServices = new frmServices();
            frmServices.Show();
        }

        private void sbtnAyuda_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.Show();
        }
    }
}
