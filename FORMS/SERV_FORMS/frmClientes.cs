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
            CargaClientes();
        }

        private void CargaClientes()
        {
            DataTable dataTable = cargaDG.ObtenerTodosLosClientes(cnx);

            stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
            {
                dataGridView.DataSource = dataTable;
            }
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

        private void sbtnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = stxtBuscar.Text.Trim(); 

            // Si el textbox está vacío, mostrar todos los clientes
            if (string.IsNullOrEmpty(filtro))
            {
                MessageBox.Show("Mostrando todos los clientes...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargaClientes(); 
                return;
            }

            sbtnBuscar.Enabled = false;
            sbtnBuscar.Text = "Buscando...";

            try
            {
                DataTable dataTable = cargaDG.BuscarCliente(cnx, filtro);

                stabControlbtn1.SelectedTab = stabControlbtn1.TabPages["tpageConsultas"];

                if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView)
                {
                    dataGridView.DataSource = dataTable;

                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaClientes(); // Si no hay resultados, muestra todos los clientes
                    }
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sbtnBuscar.Enabled = true;
                sbtnBuscar.Text = "Buscar";
            }

        }

        private void sbtnEliminar_Click(object sender, EventArgs e)
        {
            if (stabControlbtn1.SelectedTab.Controls["dgClientes"] is DataGridView dataGridView && dataGridView.SelectedRows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["ID_Cliente"].Value);

                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE ID_Cliente = @ID", cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID", idCliente);
                        cnx.Open(); 
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cnx.Close(); 

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un cliente para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
