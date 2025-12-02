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
    public partial class frmEmpresaTransporte : Form
    {
        private EmpresaTSP empresaTSP = new EmpresaTSP();
        public frmEmpresaTransporte()
        {
            InitializeComponent();
        }

        private void btnInsertarmpresaTSP_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos antes de insertar
                if (ValidarCampos())
                {
                    // Convertir el RUC a long
                    if (!long.TryParse(txtRucET.Text, out long ruc))
                    {
                        MessageBox.Show("El RUC debe ser un número válido de 11 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Llamar al método de la clase Producto para insertar
                    empresaTSP.EjecutarProcedimiento(
                        "INSERT",
                        null, // ID no necesario para INSERT
                        txtNombreEmpresaTransporte.Text, null, ruc, txtDirecciónET.Text
                    );

                    MessageBox.Show("Empresa de transporte insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Recargar los productos después de la inserción
                    LimpiarCampos();
                    CargarEmpresaTSP();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnActualizarmpresaTSP_Click(object sender, EventArgs e)
        {
            if (gtvmpresaTSP.SelectedRows.Count > 0)
            {
                // Validar campos antes de actualizar
                if (ValidarCampos())
                {
                        // Obtén el ID del producto de la fila seleccionada
                        int idEmpresaTSP = Convert.ToInt32(gtvmpresaTSP.SelectedRows[0].Cells["id_empresa"].Value);
                    // Convertir el RUC a long
                    if (!long.TryParse(txtRucET.Text, out long ruc))
                    {
                        MessageBox.Show("El RUC debe ser un número válido de 11 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    // Llamar al método para actualizar
                    empresaTSP.EjecutarProcedimiento(
                        "UPDATE",
                        idEmpresaTSP,  // ID necesario para actualizar
                        txtNombreEmpresaTransporte.Text,null, ruc,  txtDirecciónET.Text
                    );
                    MessageBox.Show("Empresa de transporte actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarEmpresaTSP();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una empresa para actualizar.");
            }
        }

        private void btnEliminarmpresaTSP_Click(object sender, EventArgs e)
        {
            // Verifica que haya una fila seleccionada
            if (gtvmpresaTSP.SelectedRows.Count > 0)
            {
                // Obtén el ID del producto de la fila seleccionada
                int idEmpresaTSP = Convert.ToInt32(gtvmpresaTSP.SelectedRows[0].Cells["id_empresa"].Value);

                // Convertir el RUC a long
                if (!long.TryParse(txtRucET.Text, out long ruc))
                {
                    MessageBox.Show("El RUC debe ser un número válido de 11 dígitos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamar al método para eliminar el producto
                empresaTSP.EjecutarProcedimiento(
                    "DELETE",
                    idEmpresaTSP,
                    txtNombreEmpresaTransporte.Text,
                    null, ruc, txtDirecciónET.Text
                );
                MessageBox.Show("Empresa de transporte eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarEmpresaTSP();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una empresa para eliminar.");
            }
        }

        private void frmEmpresaTransporte_Load(object sender, EventArgs e)
        {
            CargarEmpresaTSP();
        }

        private void gtvmpresaTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                // Obtener la fila seleccionada
                DataGridViewRow row = gtvmpresaTSP.Rows[e.RowIndex];

                // Cargar los valores en los TextBox
                txtNombreEmpresaTransporte.Text = row.Cells["nombre_E"].Value.ToString();
                txtRucET.Text = row.Cells["ruc"].Value.ToString();
                txtDirecciónET.Text = row.Cells["direccion"].Value.ToString();

            }
        }
        private void CargarEmpresaTSP()
        {
            // Llamamos al método ObtenerTodosLosProductos de la clase Producto
            DataTable dt = empresaTSP.ObtenerTodasLasEmpresasTransporte();

            // Asignamos el DataTable al DataGridView
            gtvmpresaTSP.DataSource = dt;
        }
        // Método para validar los campos
        private bool ValidarCampos()
        {
            // Validar que el nombre de la empresa no esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreEmpresaTransporte.Text))
            {
                MessageBox.Show("El nombre de la empresa es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Validación del RUC: asegurarse de que sea un número de 11 dígitos
            if (txtRucET.Text.Length != 11 || !long.TryParse(txtRucET.Text, out long ruc))
            {
                MessageBox.Show("El RUC debe ser un número válido de 11 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que la dirección no esté vacía
            if (string.IsNullOrWhiteSpace(txtDirecciónET.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Método para limpiar los campos después de una operación
        private void LimpiarCampos()
        {
            txtNombreEmpresaTransporte.Clear();
            txtRucET.Clear();
            txtDirecciónET.Clear();
        }
    }
}
