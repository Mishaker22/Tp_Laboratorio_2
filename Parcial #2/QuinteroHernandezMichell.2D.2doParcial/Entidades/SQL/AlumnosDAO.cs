using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.SQL
{
    /// <summary>
    /// Selecciona todos los datos de la base de datos y los almacena en la lista alumnos
    /// </summary>
    public class AlumnosDAO:ConexionSQL
    {
        public delegate void AlumnoDelegate( BDAcciones accion);
        public static event AlumnoDelegate CambioAlumno;
        public static List<Alumno> SelectAll()
        {
            List<Alumno> listAlumno = new List<Alumno>();

            try
            {
                AlumnosDAO.Comando.CommandText = "SELECT * FROM dbo.Alumnos";

                AlumnosDAO.Conexion.Open();
                SqlDataReader sqlReader = AlumnosDAO.Comando.ExecuteReader();

                while (sqlReader.Read())
                {
                    int id = Convert.ToInt32(sqlReader["idAlumnos"]);
                    string nombre = sqlReader["Nombre"].ToString();
                    string apellido = sqlReader["Apellido"].ToString();
                    int edad = Convert.ToInt32(sqlReader["Edad"]);
                    int dni = Convert.ToInt32(sqlReader["Dni"]);
                    string direccion = sqlReader["Direccion"].ToString();
                    int responsable = Convert.ToInt32(sqlReader["Responsable"]);

                    Alumno alumno = new Alumno(nombre,apellido,edad,dni,direccion,id,responsable);
                    listAlumno.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (AlumnosDAO.Conexion.State == System.Data.ConnectionState.Open)
                {
                    AlumnosDAO.Conexion.Close();
                }
            }

            return listAlumno;
        }
       /// <summary>
       /// Elimina un item de la base de datos
       /// </summary>
       /// <param name="a"></param>
        public static void Delete(Alumno a)
        {
            string cmd = string.Format("DELETE FROM dbo.Alumnos WHERE codigo = '{0}'", a.Id);
            AlumnosDAO.Comando.Parameters.Clear();
            AlumnosDAO.Comando.CommandText = cmd;
            AlumnosDAO.Ejecutar();
            
            CambioAlumno.Invoke(BDAcciones.INSERT);
        }
    }
}
