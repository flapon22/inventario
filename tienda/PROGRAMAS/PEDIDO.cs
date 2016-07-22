using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace tienda
{
    class PEDIDO
    {
         public PEDIDO ListarPedido()
         {
             conexion cnn = new conexion();
             SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
             SqlCommand cmd = new SqlCommand("SP_Insertar_Pedido", cn);
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
                    throw new Exception (ex.Message);
                }
                finally 
                {
                    cn.Dispose ();
                    cmd.Dispose ();
                }

            }

        public DataTable ListarCursos()
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Listar_Pedido", cn);
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
        public void agregar(string idpedido, string idcliente, Double cantidad)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Llenar_Pedido", cn);
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
    
    }
 }


    

