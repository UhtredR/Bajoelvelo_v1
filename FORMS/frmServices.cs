using Bajoelvelo_v1.Clases_Func;
using Bajoelvelo_v1.FORMS;
using Bajoelvelo_v1.FORMS.SERV_FORMS;
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
    public partial class frmServices : Form
    {
        public frmServices()
        {
            InitializeComponent();
        }

        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            frmMainmenu frmMainmenu = new frmMainmenu();
            frmMainmenu.Show();
        }

        private void siticoneImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientes frmClientes = new frmClientes();
            frmClientes.Show();
        }

        private void siticoneImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventario frmInventario = new frmInventario();
            frmInventario.Show();
        }

        private void siticoneImageButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFactura frmFactura = new frmFactura();
            frmFactura.Show();
        }

        private void sBtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
