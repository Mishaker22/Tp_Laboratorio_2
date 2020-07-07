using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.SQL
{
    public class DocenteDAO:ConexionSQL
    {
        
        public static void InsertarDocente(Docente d)
        {

            string comando = string.Format("INSERT INTO dbo.Docentes(idDocente,Nombre,Apellido,Edad,Sexo,Dni,Direccion,Email) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",d.Id, d.Nombre, d.Apellido, d.Edad, d.Sexo, d.Dni, d.Direccion, d.Email);
            DocenteDAO.Comando.CommandText = comando;
            DocenteDAO.Comando.Parameters.Clear();

            DocenteDAO.Ejecutar();
        }
        public static int DocenteRegistrado(int id)
        {
            int cont = 0;
            try
            {
                DocenteDAO.Comando.CommandText = "SELECT * FROM dbo.Docentes WHERE idDocente ="+id+"";
                DocenteDAO.Conexion.Open();

                SqlDataReader sqlReader = DocenteDAO.Comando.ExecuteReader();
                while (sqlReader.Read())
                {
                    cont++;
                }
                return cont;
            }
            catch (Exception ex )
            {

                throw new Exception("Error al conectarse", ex);
            }
            finally
            {
                if (DocenteDAO.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DocenteDAO.Conexion.Close();
                }
            }
        }
        
    }
}
