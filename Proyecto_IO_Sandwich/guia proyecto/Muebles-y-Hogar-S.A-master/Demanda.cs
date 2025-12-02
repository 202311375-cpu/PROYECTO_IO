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
    internal class Demanda
    {

        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public DataTable ObtenerVistaDemanda()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM VistaDemanda";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnn"].ConnectionString))
            {
                connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable ObtenerTodasLasDemandas()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_demanda, cantidad_demandada, id_ciudad, id_producto FROM DEMANDA";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las demandas: " + ex.Message);
                }
            }

            return dt;
        }

        public void EjecutarProcedimiento(string operacion, int? idDemanda, int? cantidadDemandada, int? idCiudad, int? idProducto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_Demanda_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_demanda", SqlDbType.Int).Value = idDemanda.HasValue ? (object)idDemanda.Value : DBNull.Value;
                        command.Parameters.Add("@cantidad_demandada", SqlDbType.Int).Value = cantidadDemandada.HasValue ? (object)cantidadDemandada.Value : DBNull.Value;
                        command.Parameters.Add("@id_ciudad", SqlDbType.Int).Value = idCiudad.HasValue ? (object)idCiudad.Value : DBNull.Value;
                        command.Parameters.Add("@id_producto", SqlDbType.Int).Value = idProducto.HasValue ? (object)idProducto.Value : DBNull.Value;

                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado de DEMANDA: " + ex.Message);
                }
            }
        }
    }
}
