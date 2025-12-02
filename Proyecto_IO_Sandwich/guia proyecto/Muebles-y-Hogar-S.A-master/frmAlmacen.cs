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
    public partial class frmAlmacen : Form
    {
        private Almacen almacen = new Almacen();
        public frmAlmacen()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            // Cargar los almacenes cuando la ventana se cargue
            CargarAlmacenes();
        }

        private void btnInsertarAlmacen_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos antes de insertar
                if (ValidarCampos())
                {
                    // Llamar al método de la clase Almacen para insertar
                    almacen.EjecutarOperacion(
                        "INSERT",
                        null,  // ID no necesario para INSERT
                        txtNombreAlmacen.Text,
                        int.Parse(txtCapacidad.Text),
                        Convert.ToDecimal(txtCostoAlquiler.Text),
                        null
                    );

                    MessageBox.Show("Almacén insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar los almacenes después de la inserción
                    LimpiarCampos();
                    CargarAlmacenes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarAlmacen_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (gtvAlmacen.SelectedRows.Count > 0)
            {
                // Validar campos antes de actualizar
                if (ValidarCampos())
                {
                    // Obtener el ID del almacén de la fila seleccionada
                    int idAlmacen = Convert.ToInt32(gtvAlmacen.SelectedRows[0].Cells["id_almacen"].Value);

                    // Llamar al método para actualizar
                    almacen.EjecutarOperacion(
                        "UPDATE",
                        idAlmacen,  // ID necesario para actualizar
                        txtNombreAlmacen.Text,
                        int.Parse(txtCapacidad.Text),
                        Convert.ToDecimal(txtCostoAlquiler.Text),
                        null
                    );

                    MessageBox.Show("Almacén actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarAlmacenes();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un almacén para actualizar.");
            }
        }

        private void btnEliminarAlmacen_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila
            if (gtvAlmacen.SelectedRows.Count > 0)
            {
                // Obtener el ID del almacén de la fila seleccionada
                int idAlmacen = Convert.ToInt32(gtvAlmacen.SelectedRows[0].Cells["id_almacen"].Value);

                // Llamar al método para eliminar el almacén
                almacen.EjecutarOperacion(
                    "DELETE",
                    idAlmacen,
                    null,
                    null,
                    null,
                    null
                );

                MessageBox.Show("Almacén eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarAlmacenes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un almacén para eliminar.");
            }
        }
        private void CargarAlmacenes()
        {
            // Llamamos al método ObtenerTodosLosAlmacenes de la clase Almacen
            DataTable dt = almacen.ObtenerTodosLosAlmacenes();

            // Asignamos el DataTable al DataGridView
            gtvAlmacen.DataSource = dt;
        }
        private bool ValidarCampos()
        {
            // Validar que el nombre del almacén no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreAlmacen.Text))
            {
                MessageBox.Show("El nombre del almacén es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que la capacidad sea un número positivo
            if (!int.TryParse(txtCapacidad.Text, out int capacidad) || capacidad <= 0)
            {
                MessageBox.Show("La capacidad debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que el costo de alquiler sea un número positivo
            if (!decimal.TryParse(txtCostoAlquiler.Text, out decimal costoAlquiler) || costoAlquiler <= 0)
            {
                MessageBox.Show("El costo de alquiler debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            txtNombreAlmacen.Clear();
            txtCapacidad.Clear();
            txtCostoAlquiler.Clear();
        }

        private void gtvAlmacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = gtvAlmacen.Rows[e.RowIndex];

                // Cargar los valores en los TextBox
                txtNombreAlmacen.Text = row.Cells["nombre"].Value.ToString();
                txtCapacidad.Text = row.Cells["capacidad"].Value.ToString();
                txtCostoAlquiler.Text = row.Cells["costo_alqa"].Value.ToString();
            }
        }
    }
}
