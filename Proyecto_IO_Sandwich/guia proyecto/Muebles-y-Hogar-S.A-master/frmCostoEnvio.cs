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
    public partial class frmCostoEnvio : Form
    {
        private CostoEnvio costoEnvio = new CostoEnvio();
        private Ciudad ciudad = new Ciudad();
        private EmpresaTSP empresa = new EmpresaTSP();
        public frmCostoEnvio()
        {
            InitializeComponent();
            this.gtvCostoEnvio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvCostoEnvio_CellClick);
        }

        private void btnInsertarCostoEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones antes de realizar la inserción
                if (string.IsNullOrWhiteSpace(txtCostoEnvio.Text))
                {
                    MessageBox.Show("Por favor, ingrese el costo de envío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evita continuar si el campo está vacío
                }

                decimal costoEnvioValue;
                if (!decimal.TryParse(txtCostoEnvio.Text, out costoEnvioValue) || costoEnvioValue <= 0)
                {
                    MessageBox.Show("El costo de envío debe ser un valor numérico mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evita continuar si el valor no es un número válido
                }

                if (cboCiudades.SelectedValue == null || cboEmpresas.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una ciudad y una empresa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evita continuar si no se seleccionan ciudad o empresa
                }

                // Llamar al método de la clase CostoEnvio para insertar
                costoEnvio.EjecutarProcedimiento(
                    "INSERT",
                    null,  // ID no necesario para INSERT
                    Convert.ToDecimal(txtCostoEnvio.Text),
                    Convert.ToInt32(cboCiudades.SelectedValue), // Obtener ID de ciudad
                    Convert.ToInt32(cboEmpresas.SelectedValue)  // Obtener ID de empresa
                );

                MessageBox.Show("Costo de envío insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                // Recargar los datos después de la inserción
                CargarCostoEnvios();
                // Limpiar campos después de la inserción
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarCostoEnvio_Click(object sender, EventArgs e)
        {
            if (gtvCostoEnvio.SelectedRows.Count > 0)
            {
                // Validaciones antes de realizar la actualización
                if (string.IsNullOrWhiteSpace(txtCostoEnvio.Text))
                {
                    MessageBox.Show("Por favor, ingrese el costo de envío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evita continuar si el campo está vacío
                }

                decimal costoEnvioValue;
                if (!decimal.TryParse(txtCostoEnvio.Text, out costoEnvioValue) || costoEnvioValue <= 0)
                {
                    MessageBox.Show("El costo de envío debe ser un valor numérico mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evita continuar si el valor no es un número válido
                }

                if (cboCiudades.SelectedValue == null || cboEmpresas.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione una ciudad y una empresa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Evita continuar si no se seleccionan ciudad o empresa
                }

                // Obtener el ID del costo de envío de la fila seleccionada
                int idCostoEnvio = Convert.ToInt32(gtvCostoEnvio.SelectedRows[0].Cells["id_costoenvio"].Value);

                // Llamar al método para actualizar
                costoEnvio.EjecutarProcedimiento(
                    "UPDATE",
                    idCostoEnvio, // ID necesario para actualizar
                    Convert.ToDecimal(txtCostoEnvio.Text),
                    Convert.ToInt32(cboCiudades.SelectedValue),
                    Convert.ToInt32(cboEmpresas.SelectedValue)
                );

                MessageBox.Show("Costo de envío actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos después de la inserción
                LimpiarCampos();
                CargarCostoEnvios();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un costo de envío para actualizar.");
            }
        }

        private void btnEliminarCostoEnvio_Click(object sender, EventArgs e)
        {
            if (gtvCostoEnvio.SelectedRows.Count > 0)
            {
                // Obtener el ID del costo de envío de la fila seleccionada
                int idCostoEnvio = Convert.ToInt32(gtvCostoEnvio.SelectedRows[0].Cells["id_costoenvio"].Value);

                costoEnvio.EjecutarProcedimiento("DELETE", idCostoEnvio, null, null, null);

                MessageBox.Show("Costo de envío eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCostoEnvios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un costo de envío para eliminar.");
            }
        }

        private void frmCostoEnvio_Load(object sender, EventArgs e)
        {
            CargarCostoEnvios();
            CargarCiudades();
            CargarEmpresas();
        }
        private void CargarCostoEnvios()
        {
            // Obtener los datos de la tabla CostoEnvio
            DataTable dt = costoEnvio.ObtenerVistaCostoEnvio();

            // Asignar los datos al DataGridView
            gtvCostoEnvio.DataSource = dt;
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

        private void CargarEmpresas()
        {
            // Obtener los datos de la tabla EmpresaTSP
            DataTable dt = empresa.ObtenerTodasLasEmpresasTransporte();

            // Configurar el ComboBox para mostrar los nombres y seleccionar IDs
            cboEmpresas.DataSource = dt;
            cboEmpresas.DisplayMember = "nombre_E";  // Mostrar el nombre de la empresa
            cboEmpresas.ValueMember = "id_empresa"; // Usar el ID como valor
        }
        private void LimpiarCampos()
        {
            // Limpiar los campos del formulario
            txtCostoEnvio.Clear(); // Limpiar el TextBox del costo de envío
            cboCiudades.SelectedIndex = -1; // Limpiar la selección de la ciudad
            cboEmpresas.SelectedIndex = -1; // Limpiar la selección de la empresa
        }

        private void gtvCostoEnvio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                DataGridViewRow row = gtvCostoEnvio.Rows[e.RowIndex];
                txtCostoEnvio.Text = row.Cells["costoenvio"].Value.ToString();
            }
        }
    }
}
