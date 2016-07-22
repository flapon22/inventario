using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace tiendazapatos
{
    public class VENDEDOR
    {
        public void agregarvendedor(string codvendedor, string nombre, string apellido, string sexo, string telefono)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Insertar_Vendedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codvendedor", codvendedor);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@telefono", telefono);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Dispose();
                cmd.Dispose();
            }
        }

        public void modificarvendedor(string codvendedor, string nombre, string apellido, string sexo, string telefono)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Modificar_Vendedor", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codvendedor", codvendedor);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@sexo", sexo);
            cmd.Parameters.AddWithValue("@telefono", telefono);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Dispose();
                cmd.Dispose();
            }
        }
    }
}
