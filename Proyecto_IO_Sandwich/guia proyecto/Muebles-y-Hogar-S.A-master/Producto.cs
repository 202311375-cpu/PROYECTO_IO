using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using Microsoft.Data.SqlClient; // Usar este espacio de nombres
using System.Threading.Tasks;

namespace Proyecto_Muebleria_y_Hogar
{
    internal class Producto
    {
        // Leer la cadena de conexión desde App.config
        string connectionString = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public DataTable ObtenerTodosLosProductos()
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT  id_producto, nombre_P, tipo, precio_venta FROM PRODUCTO";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.Fill(dt); // Rellenamos el DataTable con los productos
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener los productos: " + ex.Message);
                }
            }

            return dt; // Devuelve el DataTable con los productos
        }

        public void EjecutarProcedimiento(string operacion, int? id, string? nombre, string? tipo, decimal? ganancia)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Intentamos abrir la conexión


                    using (SqlCommand command = new SqlCommand("sp_Producto_CRUD", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Operacion", SqlDbType.NVarChar).Value = operacion;
                        command.Parameters.Add("@id_producto", SqlDbType.Int).Value = (id.HasValue ? (object)id.Value : DBNull.Value);
                        command.Parameters.Add("@nombre_P", SqlDbType.NVarChar).Value = nombre ?? (object)DBNull.Value;
                        command.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipo ?? (object)DBNull.Value;
                        command.Parameters.Add("@precio_venta", SqlDbType.Decimal).Value = ganancia.HasValue ? (object)ganancia.Value : DBNull.Value;
                        // Ejecutamos el procedimiento almacenado
                        command.ExecuteNonQuery();
                        MessageBox.Show($"Operación '{operacion}' ejecutada con éxito.");
                    }
                }
                catch (Exception ex)
                {
                    // Excepciones generales
                    MessageBox.Show("Error al ejecutar el procedimiento almacenado: " + ex.Message);
                }
            }
        }
    }
}
