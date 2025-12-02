using OfficeOpenXml;
using System.Data;
using System.Diagnostics;

namespace Proyecto_Muebleria_y_Hogar
{
    public partial class frmResultado : Form
    {
        public frmResultado()
        {
            InitializeComponent();

            // Establecer el contexto de licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Para uso no comercial
            // Si estás usando EPPlus con licencia comercial, usa la siguiente línea:
            // ExcelPackage.LicenseContext = LicenseContext.Commercial;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadExcel_Click(object sender, EventArgs e)
        {
            // Crear un diálogo para seleccionar el archivo de Excel
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*",
                Title = "Seleccione el archivo de Excel"
            };

            // Mostrar el diálogo y procesar si el usuario selecciona un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Llamar a la función que carga el archivo de Excel
                    DataTable excelData = CargarDatosDesdeExcel(filePath);

                    // Mostrar los datos en el DataGridView
                    dataGridViewExcel.DataSource = excelData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private DataTable CargarDatosDesdeExcel(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(filePath)))
            {
                // Obtener la primera hoja del archivo Excel
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                if (worksheet == null)
                {
                    throw new Exception("El archivo Excel no contiene ninguna hoja.");
                }

                // Leer encabezados (primera fila)
                for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                {
                    string columnName = worksheet.Cells[1, col].Text;
                    if (string.IsNullOrWhiteSpace(columnName))
                    {
                        columnName = "Columna " + col;
                    }
                    dataTable.Columns.Add(columnName);
                }

                // Leer datos (desde la segunda fila)
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int col = 1; col <= worksheet.Dimension.End.Column; col++)
                    {
                        dataRow[col - 1] = worksheet.Cells[row, col].Text;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        private void btnModifyExcel_Click(object sender, EventArgs e)
        {
            // Verificar si hay un archivo cargado en el DataGridView
            if (dataGridViewExcel.DataSource != null)
            {
                // Solicitar al usuario la ubicación del archivo Excel para guardarlo
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Archivos de Excel (*.xlsx)|*.xlsx|Todos los archivos (*.*)|*.*",
                    Title = "Guardar archivo Excel"
                };

                // Si el usuario selecciona un lugar para guardar el archivo
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        // Guardar los cambios en el archivo Excel
                        GuardarDatosEnExcel(filePath);

                        // Confirmación de éxito
                        MessageBox.Show("Datos guardados exitosamente en Excel.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        // Mostrar error si algo falla
                        MessageBox.Show("Error al guardar el archivo Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para modificar. Cargue un archivo primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GuardarDatosEnExcel(string filePath)
        {
            // Crear un paquete de Excel para guardar los datos
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                // Verificar si el archivo Excel ya tiene una hoja
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Count > 0 ? package.Workbook.Worksheets[0] : package.Workbook.Worksheets.Add("Sheet1");

                // Escribir los encabezados de las columnas en la primera fila
                for (int col = 0; col < dataGridViewExcel.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1].Value = dataGridViewExcel.Columns[col].HeaderText;
                }

                // Escribir los datos en el archivo Excel
                for (int row = 0; row < dataGridViewExcel.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridViewExcel.Columns.Count; col++)
                    {
                        // Asegurarse de que no se escriban celdas vacías
                        if (dataGridViewExcel.Rows[row].Cells[col].Value != null)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewExcel.Rows[row].Cells[col].Value.ToString();
                        }
                    }
                }

                // Guardar los cambios en el archivo
                package.Save();
            }
        }

        // Ejecutar LINGO y capturar los resultados
        private void btnRunLingo_Click(object sender, EventArgs e)
        {
            try
            {
                string modelPath = @"C:\Users\User\Downloads\Problema Empresa MUEBLERIA Y HOGAR SA.lg4"; // Ruta a tu archivo .lg4
                string lingoPath = @"C:\LINGO64_21\Lingo64_21.exe"; // Ruta a lingo.exe

                Process lingoProcess = new Process();
                lingoProcess.StartInfo.FileName = lingoPath;
                lingoProcess.StartInfo.Arguments = "\"" + modelPath + "\""; // Ruta del archivo .lg4 entre comillas
                lingoProcess.StartInfo.RedirectStandardOutput = true; // Captura la salida estándar (resultados)
                lingoProcess.StartInfo.UseShellExecute = false; // No usar el shell
                lingoProcess.StartInfo.CreateNoWindow = true; // No mostrar la ventana de LINGO

                // Para capturar la salida de LINGO
                string output = "";

                lingoProcess.OutputDataReceived += (sender, args) =>
                {
                    if (args.Data != null)
                    {
                        output += args.Data + Environment.NewLine; // Almacenar los resultados
                    }
                };

                lingoProcess.Start();
                lingoProcess.BeginOutputReadLine(); // Comenzar a leer la salida
                lingoProcess.WaitForExit(); // Esperar a que LINGO termine de ejecutarse

                // Mostrar los resultados en el DataGridView o RichTextBox
                dataGridViewResultados.DataSource = ParseLingoResults(output); // Aquí ParseLingoResults es una función que procesa la salida y la convierte en un formato adecuado para mostrar

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar LINGO: " + ex.Message);
            }
        }

        // Función para analizar los resultados de la optimización de LINGO
        private object ParseLingoResults(string output)
        {
            // Aquí puedes parsear la salida de LINGO para presentarla en un formato adecuado
            // Este ejemplo solo muestra la salida como texto, puedes adaptarlo a tu formato preferido

            return new[] { new { Resultado = output } }; // Muestra toda la salida como un solo campo en el DataGridView
        }

        private void DisplayResultsInDataGridView(string[] resultLines)
        {
            // Limpiar DataGridView antes de mostrar los nuevos resultados
            dataGridViewResultados.Rows.Clear();
            dataGridViewResultados.Columns.Clear();

            // Asumir que los resultados están en formato de filas y columnas (por ejemplo, separados por espacios o comas)
            // Puedes modificar esta parte para que coincida con el formato real de la salida de LINGO.

            // Crear las columnas del DataGridView
            dataGridViewResultados.Columns.Add("Variable", "Variable");
            dataGridViewResultados.Columns.Add("Valor", "Valor");

            // Procesar las líneas del archivo de resultados y agregar las filas al DataGridView
            foreach (var line in resultLines)
            {
                // Aquí asumimos que los resultados están en el formato "Variable = Valor"
                // Puedes cambiar esta lógica según el formato de salida de LINGO
                var result = line.Split('=');

                if (result.Length == 2)
                {
                    // Limpiar espacios adicionales y agregar la fila al DataGridView
                    string variable = result[0].Trim();
                    string value = result[1].Trim();

                    dataGridViewResultados.Rows.Add(variable, value);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
