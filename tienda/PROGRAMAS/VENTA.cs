using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace tienda
{
    class VENTA
    {
           public VENTA ListarPedido()
         {
             conexion cnn = new conexion();
             SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
             SqlCommand cmd = new SqlCommand("SP_Insertar_Venta", cn);
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
            SqlCommand cmd = new SqlCommand("SP_Listar_Venta", cn);
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
        public void agregar(string codfactura, string codvendedor, Double montocredito, Double montocontado, Double montototal,int fecha)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Llenar_Venta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codfactura", codfactura);
            cmd.Parameters.AddWithValue("@codvendedor", codvendedor);
            cmd.Parameters.AddWithValue("@montocredito", montocredito);
            cmd.Parameters.AddWithValue("@montocontado", montocontado);
            cmd.Parameters.AddWithValue("@montototal", montototal);
            cmd.Parameters.AddWithValue("@fecha", fecha);

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
    

