using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    public class AulaDAO : ConexionSQL
    {
        /// <summary>
        /// Selecciona todos los datos de la base de datos y los almacena en la lista de aulas
        /// </summary>
        /// <returns></returns>
        public static List<Aula> SelectAll()
        {
            List<Aula> listAulas = new List<Aula>();

            try
            {
                AulaDAO.Comando.CommandText = "SELECT * FROM dbo.Aulas";

                AulaDAO.Conexion.Open();
                SqlDataReader sqlReader = AulaDAO.Comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["idAula"]);
                    string salita = sqlReader["Salita"].ToString();

                    Aula sala = new Aula(id, salita);
                    listAulas.Add(sala);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de obtener las aulas de la base de datos", ex);
            }
            finally
            {
                if (AulaDAO.Conexion.State == System.Data.ConnectionState.Open)
                {
                    AulaDAO.Conexion.Close();
                }
            }
            return listAulas;
        }
    }
}
