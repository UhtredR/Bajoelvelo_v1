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

namespace Bajoelvelo_v1.FORMS
{
    public partial class frmAlmacen : Form
    {
        private readonly SqlConnection cnx;


        public frmAlmacen()
        {

            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
