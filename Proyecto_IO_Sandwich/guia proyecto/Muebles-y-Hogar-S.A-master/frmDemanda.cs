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
    public partial class frmDemanda : Form
    {
        private Demanda demanda = new Demanda();
        private Ciudad ciudad = new Ciudad();
        private Producto producto = new Producto();
        public frmDemanda()
        {
            InitializeComponent();


            // Asociar el evento CellClick para llenar los campos al seleccionar una fila
            this.gtvDemanda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvDemanda_CellClick);
        }

        private void btnInsertarDemanda_Click(object sender, EventArgs e)
        {

            try
            {
                // Validaciones antes de insertar
                if (string.IsNullOrWhiteSpace(txtCantidadDemandada.Text) || !int.TryParse(txtCantidadDemandada.Text, out int cantidadDemandada) || cantidadDemandada <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad demandada válida (número positivo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboCiudades.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una ciudad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboProductos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Llamar al método de la clase Demanda para insertar
                demanda.EjecutarProcedimiento(
                    "INSERT",
                    null, // ID no necesario para INSERT
                    Convert.ToInt32(txtCantidadDemandada.Text),
                    Convert.ToInt32(cboCiudades.SelectedValue), // Obtener ID de ciudad seleccionado
                    Convert.ToInt32(cboProductos.SelectedValue) // Obtener ID de producto seleccionado
                );

                MessageBox.Show("Demanda insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de la inserción
                LimpiarCampos();

                // Recargar los datos después de la inserción
                CargarDemandas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarDemanda_Click(object sender, EventArgs e)
        {
            if (gtvDemanda.SelectedRows.Count > 0)
            {
                // Validaciones antes de actualizar
                if (string.IsNullOrWhiteSpace(txtCantidadDemandada.Text) || !int.TryParse(txtCantidadDemandada.Text, out int cantidadDemandada) || cantidadDemandada <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una cantidad demandada válida (número positivo).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboCiudades.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una ciudad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboProductos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Obtén el ID de la demanda de la fila seleccionada
                int idDemanda = Convert.ToInt32(gtvDemanda.SelectedRows[0].Cells["id_demanda"].Value);

                // Llamar al método para actualizar
                demanda.EjecutarProcedimiento(
                    "UPDATE",
                    idDemanda, // ID necesario para actualizar
                    Convert.ToInt32(txtCantidadDemandada.Text),
                    Convert.ToInt32(cboCiudades.SelectedValue),
                    Convert.ToInt32(cboProductos.SelectedValue)
                );

                MessageBox.Show("Demanda actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de la actualización
                LimpiarCampos();

                CargarDemandas();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una demanda para actualizar.");
            }
        }

        private void btnEliminarDemanda_Click(object sender, EventArgs e)
        {
            if (gtvDemanda.SelectedRows.Count > 0)
            {
                // Obtén el ID de la demanda de la fila seleccionada
                int idDemanda = Convert.ToInt32(gtvDemanda.SelectedRows[0].Cells["id_demanda"].Value);

                demanda.EjecutarProcedimiento("DELETE", idDemanda, null, null, null);

                MessageBox.Show("Demanda eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDemandas();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una demanda para eliminar.");
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtCantidadDemandada.Clear(); // Limpiar la cantidad demandada
            cboCiudades.SelectedIndex = -1; // Limpiar la selección de la ciudad
            cboProductos.SelectedIndex = -1; // Limpiar la selección del producto
        }
        private void CargarDemandas()
        {
            // Llamar al método para obtener los datos desde la vista
            DataTable dt = demanda.ObtenerVistaDemanda();

            // Asignar los datos al DataGridView
            gtvDemanda.DataSource = dt;
        }
        private void gtvDemanda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                DataGridViewRow row = gtvDemanda.Rows[e.RowIndex];
                txtCantidadDemandada.Text = row.Cells["cantidad_demandada"].Value.ToString();
            }
        }

        private void frmDemanda_Load(object sender, EventArgs e)
        {
            CargarDemandas();
            CargarCiudades();
            CargarProductos();
        }
        private void CargarCiudades()
        {
            // Obtener los datos de la tabla Ciudad
            DataTable dt = ciudad.ObtenerTodasLasCiudades();

            // Configurar el ComboBox para mostrar los nombres y seleccionar IDs
            cboCiudades.DataSource = dt;
            cboCiudades.DisplayMember = "nombre_C";  // Mostrar el nombre de la ciudad
            cboCiudades.ValueMember = "id_ciudad"; // Usar el ID como valor
        }
        private void CargarProductos()
        {
            // Obtener los datos de la tabla Producto
            DataTable dt = producto.ObtenerTodosLosProductos();

            // Configurar el ComboBox para mostrar los nombres y seleccionar IDs
            cboProductos.DataSource = dt;
            cboProductos.DisplayMember = "nombre_P";  // Mostrar el nombre del producto
            cboProductos.ValueMember = "id_producto"; // Usar el ID como valor
        }
    }
}
