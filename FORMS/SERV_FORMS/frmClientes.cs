using Bajoelvelo_v1.Clases_Func;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1.FORMS.SERV_FORMS
{
    public partial class frmClientes : Form
    {
        private readonly SqlConnection cnx;
        private CargaDG cargaDG;

        public frmClientes()
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
            cargaDG = new CargaDG();
        }

        

        private void sBtnMinimizar_Click(object sender, EventArgs e)
        {
            FormFuncs formFuncs = new FormFuncs(this);
            formFuncs.minimizarForm();
        }

        private void sBtnMaximizar_Click(object sender, EventArgs e)
        {
            FormFuncs formFuncs = new FormFuncs(this);
            formFuncs.maximizarForm();
        }

        private void sBtnCerrar_Click(object sender, EventArgs e)
        {
            FormFuncs formFuncs = new FormFuncs(this);
            formFuncs.cerrarForm();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargaDG.CargarClientes(stabControlbtn1, cnx, cargaDG);
        }
    }
}
