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
    internal class EmpresaTSP
    {
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public DataTable ObtenerTodasLasEmpresasTransporte()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_empresa, nombre_E, ET,ruc,direccion FROM EMPRESATSP";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt); // Rellenamos el DataTable con los datos de las empresas
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener las empresas de transporte: " + ex.Message);
                }
            }

            return dt; // Devuelve el DataTable con las empresas
        }
        public void EjecutarProcedimiento(string operacion, int? idEmpresa, string nombre, bool? et,long ruc,string direccion)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_EmpresaTSP_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_empresa", SqlDbType.Int).Value = idEmpresa.HasValue ? (object)idEmpresa.Value : DBNull.Value;
                        command.Parameters.Add("@nombre_E", SqlDbType.NVarChar).Value = nombre ?? (object)DBNull.Value;
                        command.Parameters.Add("@ET", SqlDbType.Bit).Value = et.HasValue ? (object)et.Value : DBNull.Value;
                        command.Parameters.Add("@ruc", SqlDbType.BigInt).Value = ruc;
                        command.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion ?? (object)DBNull.Value;

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
