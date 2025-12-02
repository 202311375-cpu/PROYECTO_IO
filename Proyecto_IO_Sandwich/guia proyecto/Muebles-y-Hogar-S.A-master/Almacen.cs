using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;

namespace Proyecto_Muebleria_y_Hogar
{
    class Almacen
    {
        // Leer la cadena de conexión desde App.config
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        // Obtener todos los almacenes
        public DataTable ObtenerTodosLosAlmacenes()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Consulta para obtener todos los almacenes
                    string query = "SELECT id_almacen, nombre, capacidad, costo_alqa, A FROM ALMACEN";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt); // Rellenamos el DataTable con los datos de los almacenes
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los almacenes: " + ex.Message);
                }
            }

            return dt; // Devuelve el DataTable con los almacenes
        }

        // Ejecutar operaciones CRUD
        public void EjecutarOperacion(string operacion, int? id_almacen, string? nombre, int? capacidad, decimal? costo_alqa, bool? A)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Almacen_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_almacen", SqlDbType.Int).Value = id_almacen.HasValue ? (object)id_almacen.Value : DBNull.Value;
                        command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre ?? (object)DBNull.Value;
                        command.Parameters.Add("@capacidad", SqlDbType.Int).Value = capacidad ?? (object)DBNull.Value;
                        command.Parameters.Add("@costo_alqa", SqlDbType.Decimal).Value = costo_alqa ?? (object)DBNull.Value;
                        command.Parameters.Add("@A", SqlDbType.Bit).Value = A.HasValue ? (object)A.Value : DBNull.Value;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la operación: " + ex.Message);
                }
            }
        }
    }
}
