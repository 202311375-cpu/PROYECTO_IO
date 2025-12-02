using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Muebleria_y_Hogar
{
    internal class CostoEnvio
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerVistaCostoEnvio()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM VistaCostoEnvio"; // Suponiendo que tienes una vista para mostrar los datos

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

        public DataTable ObtenerTodosLosCostosEnvio()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_costoenvio, costoenvio, id_ciudad, id_empresa FROM COSTOENVIO";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los costos de envío: " + ex.Message);
                }
            }

            return dt;
        }

        public void EjecutarProcedimiento(string operacion, int? idCostoEnvio, decimal? costoEnvio, int? idCiudad, int? idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_CostoEnvio_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_costoenvio", SqlDbType.Int).Value = idCostoEnvio.HasValue ? (object)idCostoEnvio.Value : DBNull.Value;
                        command.Parameters.Add("@costoenvio", SqlDbType.Decimal).Value = costoEnvio.HasValue ? (object)costoEnvio.Value : DBNull.Value;
                        command.Parameters.Add("@id_ciudad", SqlDbType.Int).Value = idCiudad.HasValue ? (object)idCiudad.Value : DBNull.Value;
                        command.Parameters.Add("@id_empresa", SqlDbType.Int).Value = idEmpresa.HasValue ? (object)idEmpresa.Value : DBNull.Value;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado de COSTOENVIO: " + ex.Message);
                }
            }
        }
    }
}
