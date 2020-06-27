using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        #region contructor
        /// <summary>
        /// inicializamos la conexion, y los comandos y los conectamos entre si.
        /// </summary>
        static PaqueteDAO()
        {
            PaqueteDAO.conexion = new SqlConnection(Properties.Settings.Default.Conexion);
            PaqueteDAO.comando = new SqlCommand();
            PaqueteDAO.comando.CommandType = CommandType.Text;
            PaqueteDAO.comando.Connection = conexion;
        }
        #endregion

        #region Metodo Insertar
        /// <summary>
        /// Inserta un paquete a la base de datos
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool Insertar(Paquete p)
        {
            string comando=string.Format("INSERT INTO Paquetes(direccionEntrega,trackingID,alumno) VALUES('{0}','{1}','Michell Quintero Hernandez')", p.DireccionEntrega, p.TrackingID);
            try
            {
                PaqueteDAO.comando.CommandText = comando;
                PaqueteDAO.conexion.Open();
                PaqueteDAO.comando.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                PaqueteDAO.conexion.Close();
            }

        }
        #endregion
    }
}
