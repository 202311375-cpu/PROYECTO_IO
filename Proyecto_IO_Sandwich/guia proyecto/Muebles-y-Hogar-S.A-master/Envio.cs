using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace Proyecto_Muebleria_y_Hogar
{
    internal class Envio
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerVistaEnvio()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM VistaEnvio"; // Suponiendo que tienes una vista para mostrar los datos

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
        public DataTable ObtenerTodosLosEnvios()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_envio, cant_enviar, id_producto, id_ciudad FROM ENVIO";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los envíos: " + ex.Message);
                }
            }

            return dt;
        }

        public void EjecutarProcedimiento(string operacion, int? idEnvio, int? cantEnviar, int? idProducto, int? idCiudad)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Envio_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_envio", SqlDbType.Int).Value = idEnvio.HasValue ? (object)idEnvio.Value : DBNull.Value;
                        command.Parameters.Add("@cant_enviar", SqlDbType.Int).Value = cantEnviar.HasValue ? (object)cantEnviar.Value : DBNull.Value;
                        command.Parameters.Add("@id_producto", SqlDbType.Int).Value = idProducto.HasValue ? (object)idProducto.Value : DBNull.Value;
                        command.Parameters.Add("@id_ciudad", SqlDbType.Int).Value = idCiudad.HasValue ? (object)idCiudad.Value : DBNull.Value;
                        

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado de ENVIO: " + ex.Message);
                }
            }
        }
    }
}
