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
    public partial class frmUso : Form
    {
        private Uso uso = new Uso();
        private Producto producto = new Producto();
        private Material material = new Material();
        public frmUso()
        {
            InitializeComponent();

            // Asociar el evento CellClick para llenar los campos al seleccionar una fila
            this.gtvUso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvUso_CellClick);
        }


        private void btnInsertarUso_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos antes de insertar
                if (ValidarCampos())
                {
                    // Llamar al método de la clase Uso para insertar
                    uso.EjecutarProcedimiento(
                    "INSERT",
                    null, // ID no necesario para INSERT
                    Convert.ToInt32(cboProducto.SelectedValue), // ID de producto
                    Convert.ToInt32(cboMaterial.SelectedValue), // ID de material
                    Convert.ToDecimal(txtUso.Text) // Uso (decimal)
                );

                    MessageBox.Show("Uso insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar los datos después de la inserción
                    LimpiarCampos();
                    CargarUsos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarUso_Click(object sender, EventArgs e)
        {
            if (gtvUso.SelectedRows.Count > 0)
            {// Validar campos antes de actualizar
                if (ValidarCampos())
                {
                    // Obtén el ID del uso de la fila seleccionada
                    int idUso = Convert.ToInt32(gtvUso.SelectedRows[0].Cells["id_uso"].Value);

                // Llamar al método para actualizar
                uso.EjecutarProcedimiento(
                    "UPDATE",
                    idUso,  // ID necesario para actualizar
                    Convert.ToInt32(cboProducto.SelectedValue), // ID de producto
                    Convert.ToInt32(cboMaterial.SelectedValue), // ID de material
                    Convert.ToDecimal(txtUso.Text) // Uso (decimal)
                );
                    MessageBox.Show("Uso actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarUsos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un uso para actualizar.");
            }
        }

        private void btnEliminarUso_Click(object sender, EventArgs e)
        {
            if (gtvUso.SelectedRows.Count > 0)
            {
                // Obtén el ID del uso de la fila seleccionada
                int idUso = Convert.ToInt32(gtvUso.SelectedRows[0].Cells["id_uso"].Value);

                // Llamar al método para eliminar
                uso.EjecutarProcedimiento(
                    "DELETE",
                    idUso, // ID necesario para eliminar
                    null,  // Otros parámetros no necesarios para DELETE
                    null,
                    null
                );

                MessageBox.Show("Uso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarUsos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un uso para eliminar.");
            }
        }

        private void frmUso_Load(object sender, EventArgs e)
        {

            CargarUsos();
            CargarProductos();
            CargarMaterial();
        }
        private void CargarUsos()
        {
            // Llamamos al método ObtenerTodosLosUsos de la clase Uso
            DataTable dt = uso.ObtenerVistaUso();

            // Asignamos el DataTable al DataGridView
            gtvUso.DataSource = dt;
        }

        private void CargarProductos()
        {
            // Obtener los datos de la tabla Producto
            DataTable dt = producto.ObtenerTodosLosProductos();

            // Configurar el ComboBox para mostrar los nombres y seleccionar IDs
            cboProducto.DataSource = dt;
            cboProducto.DisplayMember = "nombre_P";  // Mostrar el nombre del producto
            cboProducto.ValueMember = "id_producto"; // Usar el ID como valor
        }

        private void CargarMaterial()
        {
            // Obtener los datos de la tabla EmpresaTSP
            DataTable dt = material.ObtenerTodosLosMateriales();

            // Configurar el ComboBox para mostrar los nombres y seleccionar IDs
            cboMaterial.DataSource = dt;
            cboMaterial.DisplayMember = "nombre_M";  // Mostrar el nombre de la empresa
            cboMaterial.ValueMember = "id_material"; // Usar el ID como valor
        }

        private void gtvUso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = gtvUso.Rows[e.RowIndex];

                // Cargar los valores en los TextBox y ComboBox
                txtUso.Text = row.Cells["uso"].Value.ToString();
            }
        }
        // Método para validar los campos
        private bool ValidarCampos()
        {
            // Validar que el uso sea un número válido
            if (!decimal.TryParse(txtUso.Text, out decimal uso) || uso <= 0)
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el uso (mayor a 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado un producto
            if (cboProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado un material
            if (cboMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un material.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Método para limpiar los campos después de una operación
        private void LimpiarCampos()
        {
            txtUso.Clear();
            cboProducto.SelectedIndex = -1; // Deseleccionar el producto
            cboMaterial.SelectedIndex = -1; // Deseleccionar el material
        }
    }
}
