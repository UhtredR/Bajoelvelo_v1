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

namespace Bajoelvelo_v1
{
    public partial class frmInicio : Form
    {
        private readonly SqlConnection cnx;

        public frmInicio()
        {
            InitializeComponent();
            cnx = Infraestructura.Conexion.Conectar();

        }

        private void siticoneCustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sBtnAcceder_Click(object sender, EventArgs e)
        {
            string Nombre, Contrasena;

            Nombre = stxtUsuario.Text;
            Contrasena = stxtPass.Text;

            try
            {
                string querry = "SELECT * FROM Usuario WHERE Nombre ='" + stxtUsuario.Text + "' AND Contrasena = '" + stxtPass.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, cnx);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    Nombre = stxtUsuario.Text;
                    Contrasena = stxtPass.Text;

                    frmMainmenu frmMenu = new frmMainmenu();
                    frmMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contrasena Invalido", "Error", MessageBoxButtons.OK);

                    stxtUsuario.Clear();
                    stxtPass.Clear();

                    stxtUsuario.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            finally
            {
                cnx.Close();
            }
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
    }
}
