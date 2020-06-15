using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clases;
        private Profesor instructor;

        #region Constructor
        /// <summary>
        /// constructor por defecto
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.clases = clase;
            this.instructor = instructor;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Permite operar con la lista de alumnos pertenecientes a una jornada.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set
            {
                if (value != null)
                {
                    this.alumnos = value;
                }
            }
        }
        /// <summary>
        /// Permite operar con la Universidad.EClase perteneciente a una jornada.
        /// </summary>
        public Universidad.EClases Clase
        {
            get { return this.clases; }
            set
            {
                if (this.instructor == value)
                {
                    this.clases = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }
        /// <summary>
        /// Permite operar con el profesor perteneciente a una jornada. Se verifica
        /// que el profesor sea capas de impartir la clase de la jornada.
        /// </summary>
        public Profesor Instructor
        {
            get { return this.instructor; }
            set
            {
                if (value == this.clases)
                {
                    this.instructor = value;
                }
                else
                {
                    throw new SinProfesorException();
                }
            }
        }



        #endregion

        #region sobrecarga de operadores
        /// <summary>
        /// Verifica alumno si el mismo participa en clase de la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            if (a==j.clases)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// verifica si el alumno no participa en clase de la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a) 
        {
            return !(j == a);
        }
        /// <summary>
        /// Agrega un alumno a la clase
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a) 
        {
            foreach (Alumno item in j.Alumnos)
            {
                if (j!=a)
                {
                    j.Alumnos.Add(a);
                }
            }
            return j;
        }


        #endregion

        #region Metodos
        /// <summary>
        /// Guarda los datos de una jornada en txt , si no existe la ruta la crea
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            try
            {
                string ruta = System.IO.Directory.GetCurrentDirectory() + @"\Archivos";
                System.IO.Directory.CreateDirectory(ruta);

                Texto txt = new Texto();
               

                txt.Guardar((ruta + @"\Jornada.txt"), jornada.ToString());
                return true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// lee el txt guardado en la carpeta \Archivos DEL TP3 el archivo de la jornada y los retorna string
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            try
            {
                string jornada = "";
                Texto txt = new Texto();
                txt.Leer((System.IO.Directory.GetCurrentDirectory() + @"\Archivos\Jornada.txt"), out jornada);
                return jornada;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Muestra los datos de la jornada escolar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CLASE DE: {0} DIRIGIDA POR: {1}", this.Clase, this.Instructor);
            sb.AppendLine("ALUMNOS: ");
            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        #endregion

    }
}
