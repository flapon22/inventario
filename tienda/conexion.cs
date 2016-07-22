using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace tiendazapatos
{
    public class conexion
    {
        public string Establecer_conexion()
        {
            try
            {
                return
                    ConfigurationManager.ConnectionStrings["tienda.Properties.Settings.TIENDAZAPATOSConnectionString"].ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
