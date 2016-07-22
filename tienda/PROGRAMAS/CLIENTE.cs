using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace tiendazapatos
{
    public class CLIENTE
    {
        public void agregarcliente(string  idcliente, string  nombre, string  apellido, string  direccion, string telefono)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("PS_Ingresar_Cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente",idcliente);
            cmd.Parameters.AddWithValue ("@nombre",nombre);
            cmd.Parameters.AddWithValue ("@apellido",apellido);
            cmd.Parameters.AddWithValue ("@direccion",direccion);
            cmd.Parameters.AddWithValue ("@telefono",telefono);

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

        public void modificarcliente(string idcliente, string nombre, string apellido, string direccion, string telefono)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Modificar_Cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idcliente", idcliente);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@apellido", apellido);
            cmd.Parameters.AddWithValue("@direccion", direccion);
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
