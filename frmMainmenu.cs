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
            this.Close();
        }

        private void frmMainmenu_Load(object sender, EventArgs e)
        {

        }

        private void sBtnMinimizar_Click(object sender, EventArgs e)
        {

        }
    }
}
