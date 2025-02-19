using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
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

        public void OcultarMenu(Panel spanelMenu, SiticoneButton sbtnMenu, PictureBox pictureBox1)
        {
            if (spanelMenu.Width > 200)
            {
                spanelMenu.Width = 100;
                pictureBox1.Visible = false;
                sbtnMenu.Dock = DockStyle.Top;
                foreach (Button mbutton in spanelMenu.Controls.OfType<Button>())
                {
                    mbutton.Text = "";
                    mbutton.ImageAlign = ContentAlignment.MiddleCenter;
                    mbutton.Padding = new Padding(0);
                }
            }
            else
            {
                spanelMenu.Width = 230;
                pictureBox1.Visible = true;
                sbtnMenu.Dock = DockStyle.None;
                foreach (Button mbutton in spanelMenu.Controls.OfType<Button>())
                {
                    mbutton.Text = "     "+ mbutton.Tag.ToString();
                    mbutton.ImageAlign = ContentAlignment.MiddleCenter;
                    mbutton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
    }
}
