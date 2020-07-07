using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades.Excepciones;


namespace Entidades.SQL
{
    public enum BDAcciones
    {
        UPDATE,
        DELETE,
        INSERT
    }
    public abstract class  ConexionSQL
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;
        // protected static AccionesDB ultimaAccion;

        static ConexionSQL()
        {
            ConexionSQL.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            ConexionSQL.comando = new SqlCommand();
            ConexionSQL.comando.Connection = ConexionSQL.conexion;
        }

        protected static SqlConnection Conexion
        {
            get
            {
                return ConexionSQL.conexion;
            }
        }

        protected static SqlCommand Comando
        {
            get
            {
                return ConexionSQL.comando;
            }
        }

        protected static void Ejecutar()
        {
            try
            {
                ConexionSQL.Conexion.Open();
                ConexionSQL.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error en la base de datos.", ex);
            }
            finally
            {
                if (ConexionSQL.Conexion.State == System.Data.ConnectionState.Open)
                {
                    ConexionSQL.Conexion.Close();
                }
            }
        }
    }
}
