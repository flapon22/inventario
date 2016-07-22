using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace tiendazapatos
{
    class detalle
    {
        public DataTable listarclt()
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Maestro_Pedido",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ta = new DataTable();
                da.Fill(ta);
                return (ta);
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

        public DataTable listaprodu()
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Maestro_IDproductopedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable ta = new DataTable();
                da.Fill(ta);
                return (ta);
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

        public void agregarpedido(string idpedido, string idcliente, int cantidad)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Insertar_Pedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpedido", idpedido);
            cmd.Parameters.AddWithValue("@idcliente", idcliente);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

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

        public void modificarpedido(string idpedido, string idcliente, int cantidad)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Modificar_Pedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpedido", idpedido);
            cmd.Parameters.AddWithValue("@idcliente", idcliente);
            cmd.Parameters.AddWithValue("@cantidad", cantidad);

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

         public void agregarproped(string idpedido, string idproducto)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Ingresar_ProductoPedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpedido", idpedido);
            cmd.Parameters.AddWithValue("@idproducto", idproducto);

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

         public void modificarproped(string idpedido, string idproducto)
         {
             conexion cnn = new conexion();
             SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
             SqlCommand cmd = new SqlCommand("SP_Modificar_ProductoPedido", cn);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@idpedido", idpedido);
             cmd.Parameters.AddWithValue("@idproducto", idproducto);

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
