using Microsoft.Data.SqlClient;
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
    public partial class frmCiudad : Form
    {
        private Ciudad ciudad = new Ciudad();
        public frmCiudad()
        {
            InitializeComponent();
            this.gtvCiudad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvCiudad_CellClick);
        }

        private void btnInsertarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre de la ciudad no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombreCiudad.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la ciudad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evitar continuar si el campo está vacío
                }

                
                ciudad.EjecutarProcedimiento(
                    "INSERT",
                    null, // ID no necesario para INSERT
                    txtNombreCiudad.Text,
                    Convert.ToInt32(txtCodigoPostalCiudad.Text)
                );

                MessageBox.Show("Producto insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Recargar los productos después de la inserción
                CargarCiudad();
                // Limpiar los campos después de la operación
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarCiudad_Click(object sender, EventArgs e)
        {
            if (gtvCiudad.SelectedRows.Count > 0)
            {
                // Verificar que el nombre de la ciudad no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombreCiudad.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la ciudad.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evitar continuar si el campo está vacío
                }
                // Obtén el ID del producto de la fila seleccionada
                int idCiudad = Convert.ToInt32(gtvCiudad.SelectedRows[0].Cells["id_ciudad"].Value);

                // Llamar al método para actualizar
                ciudad.EjecutarProcedimiento(
                    "UPDATE",
                    idCiudad,  // ID necesario para actualizar
                   txtNombreCiudad.Text,
                   Convert.ToInt32(txtCodigoPostalCiudad.Text)
                );

                CargarCiudad();
                // Limpiar los campos después de la operación
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una ciudad para actualizar.");
            }
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (gtvCiudad.SelectedRows.Count > 0)
            {
                // Obtén el ID del producto de la fila seleccionada
                int idCiudad = Convert.ToInt32(gtvCiudad.SelectedRows[0].Cells["id_ciudad"].Value);

                // Llamar al método para eliminar el producto
                ciudad.EjecutarProcedimiento(
                    "DELETE",
                    idCiudad,  // ID necesario para eliminar
                    null,
                    null
                );
                MessageBox.Show("Ciudad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCiudad();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una ciudad para eliminar.");
            }
        }

        private void gtvCiudad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = gtvCiudad.Rows[e.RowIndex];

                // Cargar los valores en los TextBox
                txtNombreCiudad.Text = row.Cells["nombre_C"].Value.ToString();
                txtCodigoPostalCiudad.Text = row.Cells["codigo_postal"].Value.ToString();
            }
        }
        private void CargarCiudad()
        {
            // Llamamos al método ObtenerTodosLosProductos de la clase Producto
            DataTable dt = ciudad.ObtenerTodasLasCiudades();

            // Asignamos el DataTable al DataGridView
            gtvCiudad.DataSource = dt;
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            CargarCiudad();
        }
        // Método para verificar si la ciudad ya existe
       
        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            txtNombreCiudad.Clear();
            txtCodigoPostalCiudad.Clear();
        }
    }
}
