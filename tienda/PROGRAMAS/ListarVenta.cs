using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace tiendazapatos
{
    class ListarVenta
    {
        public DataTable listarclt()
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_IdPedido", cn);
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

        public DataTable listavend()
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("Maestro_VentaVendedor", cn);
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

        public void agregarventa(string codfactura, string codvendedor, Double montocredito, Double montocontado, Double montototal, string fecha)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Ingresar_Venta", cn);
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

        public void modificarventa(string codfactura, string codvendedor, Double montocredito, Double montocontado, Double montototal, string fecha)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Modificar_Venta", cn);
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
        public void agregarventped(string codfactura, string idpedido)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Ingresar_Ventapedio", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codfactura", codfactura);
            cmd.Parameters.AddWithValue("@idpedido", idpedido);


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

        public void modificarventped(string codfactura, string idpedido)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Modificar_ventapedido", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codfactura", codfactura);
            cmd.Parameters.AddWithValue("@idpedido", idpedido);


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
