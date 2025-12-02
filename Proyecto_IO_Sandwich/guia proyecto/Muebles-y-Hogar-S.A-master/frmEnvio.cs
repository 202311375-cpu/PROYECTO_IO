using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Muebleria_y_Hogar
{
    public partial class frmEnvio : Form
    {
        private Envio envio = new Envio();
        private Ciudad ciudad = new Ciudad();
        private Producto producto = new Producto();
        public frmEnvio()
        {
            InitializeComponent();
            // Asociar el evento CellClick
            this.gtvEnvio.CellClick += new DataGridViewCellEventHandler(this.gtvEnvio_CellClick);
        }

        private void btnInsertarEnvio_Click(object sender, EventArgs e)
        {
            try
            {// Validar los campos antes de insertar
                if (ValidarCampos())
                {
                    envio.EjecutarProcedimiento(
                    "INSERT",
                    null,
                    Convert.ToInt32(txtCantidadEnviar.Text),
                    Convert.ToInt32(cboProductos.SelectedValue),
                    Convert.ToInt32(cboCiudades.SelectedValue)
                );

                MessageBox.Show("Envío registrado correctamente.");
                    LimpiarCampos();
                    CargarEnvios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void gtvEnvio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gtvEnvio.Rows[e.RowIndex];
                txtCantidadEnviar.Text = row.Cells["cant_enviar"].Value.ToString();
            }
        }

        private void frmEnvio_Load(object sender, EventArgs e)
        {
            CargarEnvios();
            CargarCiudades();
            CargarProductos();
        }

        private void btnActualizarEnvio_Click(object sender, EventArgs e)
        {
            if (gtvEnvio.SelectedRows.Count > 0)
            {// Validar los campos antes de actualizar
                if (ValidarCampos())
                {
                        int idEnvio = Convert.ToInt32(gtvEnvio.SelectedRows[0].Cells["id_envio"].Value);

                    envio.EjecutarProcedimiento(
                        "UPDATE",
                        idEnvio,
                        Convert.ToInt32(txtCantidadEnviar.Text),
                        Convert.ToInt32(cboProductos.SelectedValue),
                        Convert.ToInt32(cboCiudades.SelectedValue)
                    );
                    MessageBox.Show("Envío actualizado correctamente.");
                    CargarEnvios();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un envío para actualizar.");
                }
            }
        }

        private void btnEliminarEnvio_Click(object sender, EventArgs e)
        {
            if (gtvEnvio.SelectedRows.Count > 0)
            {
                int idEnvio = Convert.ToInt32(gtvEnvio.SelectedRows[0].Cells["id_envio"].Value);

                envio.EjecutarProcedimiento("DELETE", idEnvio, null, null, null);
                MessageBox.Show("Envío eliminado correctamente.");
                LimpiarCampos();
                CargarEnvios();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un envío para eliminar.");
            }
        }
        private void CargarEnvios()
        {
            DataTable dt = envio.ObtenerVistaEnvio();
            gtvEnvio.DataSource = dt;
        }

        private void CargarCiudades()
        {
            DataTable dt = ciudad.ObtenerTodasLasCiudades();
            cboCiudades.DataSource = dt;
            cboCiudades.DisplayMember = "nombre_C";
            cboCiudades.ValueMember = "id_ciudad";
        }

        private void CargarProductos()
        {
            DataTable dt = producto.ObtenerTodosLosProductos();
            cboProductos.DataSource = dt;
            cboProductos.DisplayMember = "nombre_P";
            cboProductos.ValueMember = "id_producto";
        }
        // Método para validar los campos
        private bool ValidarCampos()
        {
            // Validar que la cantidad a enviar sea un número y esté dentro de un rango razonable
            if (!int.TryParse(txtCantidadEnviar.Text, out int cantidadEnviar) || cantidadEnviar <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida para enviar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado un producto
            if (cboProductos.SelectedValue == null || cboProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado una ciudad
            if (cboCiudades.SelectedValue == null || cboCiudades.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una ciudad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Método para limpiar los campos después de una operación
        private void LimpiarCampos()
        {
            txtCantidadEnviar.Clear();
            cboProductos.SelectedIndex = -1;
            cboCiudades.SelectedIndex = -1;
        }
    }
}
