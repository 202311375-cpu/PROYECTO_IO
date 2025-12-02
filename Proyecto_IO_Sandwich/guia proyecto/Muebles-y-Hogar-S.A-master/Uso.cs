using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Muebleria_y_Hogar
{
    internal class Uso
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerVistaUso()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM VistaUso"; // Suponiendo que tienes una vista para mostrar los datos

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerTodosLosUsos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_uso, id_producto, id_material, uso FROM USO";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los registros de USO: " + ex.Message);
                }
            }

            return dt;
        }

        public void EjecutarProcedimiento(string operacion, int? idUso, int? idProducto, int? idMaterial, decimal? uso)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Uso_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_uso", SqlDbType.Int).Value = idUso.HasValue ? (object)idUso.Value : DBNull.Value;
                        command.Parameters.Add("@id_producto", SqlDbType.Int).Value = idProducto.HasValue ? (object)idProducto.Value : DBNull.Value;
                        command.Parameters.Add("@id_material", SqlDbType.Int).Value = idMaterial.HasValue ? (object)idMaterial.Value : DBNull.Value;
                        command.Parameters.Add("@uso", SqlDbType.Decimal).Value = uso.HasValue ? (object)uso.Value : DBNull.Value;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado de USO: " + ex.Message);
                }
            }
        }
    }
}
