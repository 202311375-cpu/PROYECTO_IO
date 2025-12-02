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
    public partial class frmProducto : Form
    {
        // Instancia de la clase Producto
        private Producto producto = new Producto();
        public frmProducto()
        {
            InitializeComponent();
            
            this.gtvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvProductos_CellClick);

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {// Validar campos antes de insertar
                if (ValidarCampos())
                {
                    // Llamar al método de la clase Producto para insertar
                    producto.EjecutarProcedimiento(
                    "INSERT",
                    null, // ID no necesario para INSERT
                    txtNombreProducto.Text,
                    txtTipoProducto.Text,
                    Convert.ToDecimal(txtPrecioProducto.Text)
                );

                    MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar los productos después de la inserción
                    LimpiarCampos();
                    CargarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (gtvProductos.SelectedRows.Count > 0)
            {
                // Validar campos antes de actualizar
                if (ValidarCampos())
                {
                    // Obtén el ID del producto de la fila seleccionada
                    int idProducto = Convert.ToInt32(gtvProductos.SelectedRows[0].Cells["id_producto"].Value);

                // Llamar al método para actualizar
                producto.EjecutarProcedimiento(
                    "UPDATE",
                    idProducto,  // ID necesario para actualizar
                    txtNombreProducto.Text,
                    txtTipoProducto.Text,
                    Convert.ToDecimal(txtPrecioProducto.Text) // Asegúrate de que la ganancia sea un número válido
                );

                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para actualizar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (gtvProductos.SelectedRows.Count > 0)
            {
                // Obtén el ID del producto de la fila seleccionada
                int idProducto = Convert.ToInt32(gtvProductos.SelectedRows[0].Cells["id_producto"].Value);

                // Llamar al método para eliminar el producto
                producto.EjecutarProcedimiento(
                    "DELETE",
                    idProducto,  // ID necesario para eliminar
                    null,        // Aquí pasas null para los otros parámetros
                    null,
                    0
                );
                CargarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }
        private void CargarProductos()
        {
            // Llamamos al método ObtenerTodosLosProductos de la clase Producto
            DataTable dt = producto.ObtenerTodosLosProductos();

            // Asignamos el DataTable al DataGridView
            gtvProductos.DataSource = dt;
        }
        private void gtvProductos_CellClick(object? sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = gtvProductos.Rows[e.RowIndex];

                // Cargar los valores en los TextBox
                txtNombreProducto.Text = row.Cells["nombre_P"].Value.ToString();
                txtTipoProducto.Text = row.Cells["tipo"].Value.ToString();
                txtPrecioProducto.Text = row.Cells["precio_venta"].Value.ToString();
            }

        }

        private void gtvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }
        // Método para validar los campos
        private bool ValidarCampos()
        {
            // Validar que el nombre del producto no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el tipo del producto no esté vacío
            if (string.IsNullOrWhiteSpace(txtTipoProducto.Text))
            {
                MessageBox.Show("Por favor, ingrese el tipo del producto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el precio sea un número válido y mayor a 0
            if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido (mayor a 0).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Método para limpiar los campos después de una operación
        private void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtTipoProducto.Clear();
            txtPrecioProducto.Clear();
        }
    }
}
