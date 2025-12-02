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
    internal class CapacidadEnvio
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerVistaCapacidadEnvio()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM VistaCapacidadEnvio"; // Suponiendo que tienes una vista para mostrar los datos

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


        public DataTable ObtenerTodasLasCapacidadesEnvio()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_capacidad_envio, capacidad_env, id_producto, id_empresa FROM CAPACIDADENVIO";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las capacidades de envío: " + ex.Message);
                }
            }

            return dt;
        }

        public void EjecutarProcedimiento(string operacion, int? idCapacidadEnvio, int? capacidadEnvio, int? idProducto, int? idEmpresa)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_CapacidadEnvio_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_capacidad_envio", SqlDbType.Int).Value = idCapacidadEnvio.HasValue ? (object)idCapacidadEnvio.Value : DBNull.Value;
                        command.Parameters.Add("@capacidad_env", SqlDbType.Int).Value = capacidadEnvio.HasValue ? (object)capacidadEnvio.Value : DBNull.Value;
                        command.Parameters.Add("@id_producto", SqlDbType.Int).Value = idProducto.HasValue ? (object)idProducto.Value : DBNull.Value;
                        command.Parameters.Add("@id_empresa", SqlDbType.Int).Value = idEmpresa.HasValue ? (object)idEmpresa.Value : DBNull.Value;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado de CAPACIDADENVIO: " + ex.Message);
                }
            }
        }
    }
}
