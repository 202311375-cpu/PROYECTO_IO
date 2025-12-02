using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Muebleria_y_Hogar
{
    internal class Ciudad
    {
        // Leer la cadena de conexión desde App.config
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerTodasLasCiudades()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_ciudad, nombre_C, codigo_postal FROM CIUDAD";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener las ciudades: " + ex.Message);
                }
            }

            return dt;
        }
       
        public void EjecutarProcedimiento(string operacion, int? id, string? nombre, int? codigoPost)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Ciudad_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_ciudad ", SqlDbType.Int).Value = id.HasValue ? (object)id.Value : DBNull.Value;
                        command.Parameters.Add("@nombre_C", SqlDbType.NVarChar).Value = nombre ?? (object)DBNull.Value;
                        command.Parameters.Add("@codigo_postal", SqlDbType.Int).Value = codigoPost ?? (object)DBNull.Value;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }
        }

    }
}
