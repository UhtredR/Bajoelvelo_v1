using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bajoelvelo_v1.Clases_Func
{
    public class FormFuncs
    {
       private Form formf;

        public FormFuncs(Form form)
        {
            this.formf = form;
        }

        public void cerrarForm()
        {
            formf.Close();
        }

        public void minimizarForm()
        {
            formf.WindowState = FormWindowState.Minimized;
        }

        public void maximizarForm()
        {
            if (formf.WindowState == FormWindowState.Maximized)
                formf.WindowState = FormWindowState.Normal;

            else
                formf.WindowState = FormWindowState.Maximized;
        }
    }
}
