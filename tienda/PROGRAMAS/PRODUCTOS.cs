using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace tiendazapatos
{
    public class PRODUCTOS
    {
        public void ingresarproductos(string idproducto, string marca, string talla, double precio)
        {

          conexion cnn = new conexion();
          SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
          SqlCommand cmd = new SqlCommand("SP_Insertar_Producto", cn);
          cmd.CommandType = CommandType.StoredProcedure;
          cmd.Parameters.AddWithValue("@idproducto", idproducto);
          cmd.Parameters.AddWithValue("@marca", marca);
          cmd.Parameters.AddWithValue("@talla", talla);
          cmd.Parameters.AddWithValue("@precio", precio);
         
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

        public void modificarproducto(string idproducto, string marca, string talla, double precio)
        {
            conexion cnn = new conexion();
            SqlConnection cn = new SqlConnection(cnn.Establecer_conexion());
            SqlCommand cmd = new SqlCommand("SP_Modificar_Producto", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idproducto", idproducto);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.Parameters.AddWithValue("@talla", talla);
            cmd.Parameters.AddWithValue("@precio", precio);

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

