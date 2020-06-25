using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        #region contructor
        static PaqueteDAO()
        {
            conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            comando = new SqlCommand();
        }
        #endregion
    }
}
