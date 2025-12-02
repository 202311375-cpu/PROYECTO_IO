using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient; // Usar este espacio de nombres

namespace Proyecto_Muebleria_y_Hogar
{
    internal class Material
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerTodosLosMateriales()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_material, nombre_M, costo_unit, cant_disponible FROM MATERIAL";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los materiales: " + ex.Message);
                }
            }

            return dt;
        }

        public void EjecutarProcedimiento(string operacion, int? id, string? nombre, float? costoUnit, int? cantidad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Material_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_material", SqlDbType.Int).Value = id.HasValue ? (object)id.Value : DBNull.Value;
                        command.Parameters.Add("@nombre_M", SqlDbType.NVarChar).Value = nombre ?? (object)DBNull.Value;
                        command.Parameters.Add("@costo_unit", SqlDbType.Float).Value = costoUnit.HasValue ? (object)costoUnit.Value : DBNull.Value;
                        command.Parameters.Add("@cant_disponible", SqlDbType.Int).Value = cantidad.HasValue ? (object)cantidad.Value : DBNull.Value;

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
