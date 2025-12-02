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
    public partial class frmCapacidadEnvio : Form
    {
        private CapacidadEnvio capacidadEnvio = new CapacidadEnvio();
        private Producto producto = new Producto();
        private EmpresaTSP empresa = new EmpresaTSP();

        public frmCapacidadEnvio()
        {
            InitializeComponent();
            // Asociar el evento CellClick para llenar los campos al seleccionar una fila
            this.gtvCapacidadEnvio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gtvCapacidadEnvio_CellClick);
        }

        private void btnInsertarCapacidadEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtCapacidadEnvio.Text))
                {
                    MessageBox.Show("Por favor, ingrese una capacidad de envío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();  // Limpiar campos en caso de error
                    return;
                }

                if (cboProductos.SelectedIndex == -1 || cboEmpresas.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un producto y una empresa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();  // Limpiar campos en caso de error
                    return;
                }

                // Verificación de que el valor de capacidad de envío sea un número válido
                int capacidadEnvioValor;
                if (!int.TryParse(txtCapacidadEnvio.Text, out capacidadEnvioValor))
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido para la capacidad de envío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LimpiarCampos();  // Limpiar campos en caso de error
                    return;
                }

                

                // Llamar al método de la clase CapacidadEnvio para insertar
                capacidadEnvio.EjecutarProcedimiento(
                    "INSERT",
                    null,  // ID no necesario para INSERT
                    Convert.ToInt32(txtCapacidadEnvio.Text),
                    Convert.ToInt32(cboProductos.SelectedValue), // Obtener ID de producto
                    Convert.ToInt32(cboEmpresas.SelectedValue)  // Obtener ID de empresa
                );

                MessageBox.Show("Capacidad de envío insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar los datos después de la inserción
                CargarCapacidadesEnvio();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCampos();  // Limpiar campos en caso de error
            }
        }

        private void btnActualizarCapacidadEnvio_Click(object sender, EventArgs e)
        {

            if (gtvCapacidadEnvio.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el ID de la capacidad de envío de la fila seleccionada
                    int idCapacidadEnvio = Convert.ToInt32(gtvCapacidadEnvio.SelectedRows[0].Cells["id_capacidad_envio"].Value);

                    // Validación de campos vacíos
                    if (string.IsNullOrWhiteSpace(txtCapacidadEnvio.Text))
                    {
                        MessageBox.Show("Por favor, ingrese una capacidad de envío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCampos();  // Limpiar campos en caso de error
                        return;
                    }

                    if (cboProductos.SelectedIndex == -1 || cboEmpresas.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, seleccione un producto y una empresa.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCampos();  // Limpiar campos en caso de error
                        return;
                    }

                    // Verificación de que el valor de capacidad de envío sea un número válido
                    int capacidadEnvioValor;
                    if (!int.TryParse(txtCapacidadEnvio.Text, out capacidadEnvioValor))
                    {
                        MessageBox.Show("Por favor, ingrese un valor numérico válido para la capacidad de envío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCampos();  // Limpiar campos en caso de error
                        return;
                    }

                   

                    // Llamar al método para actualizar
                    capacidadEnvio.EjecutarProcedimiento(
                        "UPDATE",
                        idCapacidadEnvio, // ID necesario para actualizar
                        Convert.ToInt32(txtCapacidadEnvio.Text),
                        Convert.ToInt32(cboProductos.SelectedValue),
                        Convert.ToInt32(cboEmpresas.SelectedValue)
                    );

                    MessageBox.Show("Capacidad de envío actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCapacidadesEnvio();
                }
                catch (Exception ex)
                {
                        MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LimpiarCampos();  // Limpiar campos en caso de error
                
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una capacidad de envío para actualizar.");
            }
        }

        private void btnEliminarCapacidadEnvio_Click(object sender, EventArgs e)
        {
            if (gtvCapacidadEnvio.SelectedRows.Count > 0)
            {
                // Obtener el ID de la capacidad de envío de la fila seleccionada
                int idCapacidadEnvio = Convert.ToInt32(gtvCapacidadEnvio.SelectedRows[0].Cells["id_capacidad_envio"].Value);

                capacidadEnvio.EjecutarProcedimiento("DELETE", idCapacidadEnvio, null, null, null);

                MessageBox.Show("Capacidad de envío eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCapacidadesEnvio();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una capacidad de envío para eliminar.");
            }
        }

        private void gtvCapacidadEnvio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar si se ha seleccionado una fila
            {
                DataGridViewRow row = gtvCapacidadEnvio.Rows[e.RowIndex];
                txtCapacidadEnvio.Text = row.Cells["capacidad_env"].Value.ToString();
            }
        }

        private void frmCapacidadEnvio_Load(object sender, EventArgs e)
        {
            CargarCapacidadesEnvio();
            CargarProductos();
            CargarEmpresas();
        }
        private void CargarCapacidadesEnvio()
        {
            // Obtener los datos de la tabla CapacidadEnvio
            DataTable dt = capacidadEnvio.ObtenerVistaCapacidadEnvio();

            // Asignar los datos al DataGridView
            gtvCapacidadEnvio.DataSource = dt;
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
            txtCapacidadEnvio.Clear();       // Limpiar el campo de capacidad de envío
            cboEmpresas.SelectedIndex = -1; // Limpiar la selección de la ciudad
            cboProductos.SelectedIndex = -1; // Limpiar la selección de la empresa
        }


    }
}
