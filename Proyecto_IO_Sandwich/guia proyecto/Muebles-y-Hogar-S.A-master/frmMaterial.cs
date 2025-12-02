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
    public partial class frmMaterial : Form
    {
        // Instancia de la clase Producto
        private Material producto = new Material();
        public frmMaterial()
        {
            InitializeComponent();

            this.gtvMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvMaterial_CellClick);
        }

        private void btnInsertarMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    // Convertir los valores de texto a los tipos correspondientes
                    float costoUnitario = float.Parse(txtCostoUnitarioMaterial.Text);
                int cantidadDisponible = int.Parse(txtCantidadDisponibleMaterial.Text);

                // Llamar al método de la clase Producto para insertar
                producto.EjecutarProcedimiento(
                    "INSERT",
                    null, // ID no necesario para INSERT
                    txtNombreMaterial.Text,
                    costoUnitario, // Usar el valor convertido
                    cantidadDisponible // Usar el valor convertido
                );

                    MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar los productos después de la inserción
                    LimpiarCampos();
                    CargarMaterial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarMaterial_Click(object sender, EventArgs e)
        {
            if (gtvMaterial.SelectedRows.Count > 0)
            { // Validar campos antes de actualizar
                if (ValidarCampos())
                {
                    // Obtén el ID del producto de la fila seleccionada
                    int idMaterial = Convert.ToInt32(gtvMaterial.SelectedRows[0].Cells["id_material"].Value);

                float costoUnitario = float.Parse(txtCostoUnitarioMaterial.Text);
                int cantidadDisponible = int.Parse(txtCantidadDisponibleMaterial.Text);

                // Llamar al método para actualizar
                producto.EjecutarProcedimiento(
                    "UPDATE",
                    idMaterial,  // ID necesario para actualizar
                    txtNombreMaterial.Text,
                    costoUnitario, // Usar el valor convertido
                    cantidadDisponible // Usar el valor convertido
                );

                    CargarMaterial();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un material para actualizar.");
            }
        }

        private void btnEliminarMaterial_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (gtvMaterial.SelectedRows.Count > 0)
            {
                // Obtén el ID del producto de la fila seleccionada
                int idMaterial = Convert.ToInt32(gtvMaterial.SelectedRows[0].Cells["id_material"].Value);

                // Llamar al método para eliminar el producto
                producto.EjecutarProcedimiento(
                    "DELETE",
                    idMaterial,  // ID necesario para eliminar
                    null,        // Aquí pasas null para los otros parámetros
                    null,
                    0
                );
                CargarMaterial();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un material para eliminar.");
            }
        }

        private void gtvMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = gtvMaterial.Rows[e.RowIndex];

                // Cargar los valores en los TextBox
                txtNombreMaterial.Text = row.Cells["nombre_M"].Value.ToString();
                txtCostoUnitarioMaterial.Text = row.Cells["costo_unit"].Value.ToString();
                txtCantidadDisponibleMaterial.Text = row.Cells["cant_disponible"].Value.ToString();
            }
        }
        private void CargarMaterial()
        {
            // Llamamos al método ObtenerTodosLosProductos de la clase Producto
            DataTable dt = producto.ObtenerTodosLosMateriales();

            // Asignamos el DataTable al DataGridView
            gtvMaterial.DataSource = dt;
        }

        private void frmMaterial_Load(object sender, EventArgs e)
        {
            CargarMaterial();
        }
        private bool ValidarCampos()
        {
            // Validar que el nombre del material no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreMaterial.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del material.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el costo unitario sea un número válido
            if (!float.TryParse(txtCostoUnitarioMaterial.Text, out float costoUnitario) || costoUnitario <= 0)
            {
                MessageBox.Show("Por favor, ingrese un costo unitario válido (mayor a 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que la cantidad disponible sea un número válido
            if (!int.TryParse(txtCantidadDisponibleMaterial.Text, out int cantidadDisponible) || cantidadDisponible < 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad disponible válida (mayor o igual a 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Método para limpiar los campos después de una operación
        private void LimpiarCampos()
        {
            txtNombreMaterial.Clear();
            txtCostoUnitarioMaterial.Clear();
            txtCantidadDisponibleMaterial.Clear();
        }
    }
}
