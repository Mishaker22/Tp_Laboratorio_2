using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;


namespace Clases_Instanciables
{ 
    public class Universidad
    {
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        #region constructores
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// deja operar con la lista de la universidad
        /// </summary>
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }
        /// <summary>
        /// deja operar con la lista de jornadas de la universidad
        /// </summary>
        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }
        /// <summary>
        /// deja operar con la lista de instructores de la universidad
        /// </summary>
        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        /// <summary>
        /// deja acceder la lista de jornadas perteneciente a universidad a partir de un indice.
        /// </summary>
        /// <param name="i">Indice</param>
        /// <returns>Retorna la Jornada en indice i. Si el indice es invalido retorna null</returns>
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.jornada.Count)
                {
                    return this.jornada[i];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
            }
        }


        #endregion

        #region Sobrecarga de Operadores
        /// <summary>
        /// valida si un alumjo esta incluido en la universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno item in g.Alumnos)
            {
                if (item==a)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// valida si no esta un alumno es una universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        /// <summary>
        /// valida si un profesor esta incluido en la universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor item in g.Instructores)
            {
                if (item.Equals(i))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// valida si un profesor no esta incluido en la universidad
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        /// <summary>
        /// retorna si esl profesor esta disponible para dictar la clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor item in u.Instructores)
            {
                if (item==clase)
                {
                    return item;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// retorna si el profesor no esta disponible para dictar la clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor itemProfesor in u.Instructores)
            {
                if (itemProfesor != clase)
                {
                    return itemProfesor;
                }
            }
            throw new SinProfesorException();
        }
        /// <summary>
        /// agrega a una jornada, un profesor disponible y alumjos disponibles, si no devuelve la universidad sin cambios
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada j1 = new Jornada(clase, (g == clase));
            for (int i = 0; i < g.Alumnos.Count; i++)
            {
                if (g.Alumnos[i] == clase)
                {
                    j1.Alumnos.Add(g.Alumnos[i]);
                }
            }
            g.Jornadas.Add(j1);
            return g;
        }
        /// <summary>
        /// Agrega un alumno a la universidad si no esta repetido
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Alumno a)
        {
            if (g!=a)
            {
                g.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return g;
        }
        /// <summary>
        /// Agrega un profesor a la universidad si no esta repetido
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad g, Profesor i)
        {
            if (g!=i)
            {
                g.Instructores.Add(i);
            }
            return g;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Toma los datos de la universidad y los guarda en xml
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static bool Guardar(Universidad uni)
        {
            try
            {
                string aux = System.IO.Directory.GetCurrentDirectory()+ @"\Archivos";
                System.IO.Directory.CreateDirectory(aux);
                Xml<Universidad> archivo = new Xml<Universidad>();
                archivo.Guardar((aux + @"\Universidad.xml"), uni);
                return true;
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Toma los datos de un xml de los datos de la universidad y los lee
        /// </summary>
        /// <returns></returns>
        public static Universidad Leer()
        {
            try
            {
                Universidad universidad = new Universidad();
                Xml<Universidad> archivo = new Xml<Universidad>();
                archivo.Leer((System.IO.Directory.GetCurrentDirectory() + @"\Archivos\Universidad.xml"), out universidad);
                return universidad;

            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// retorna los datos de la universidad
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA: ");
            foreach (Jornada item in this.Jornadas)
            {
                sb.AppendFormat("{0}", item.ToString());
                sb.AppendLine("<------------------------------------------------->");
            }
            return sb.ToString();
        }
        /// <summary>
        /// muestra los datos de la universidad
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }
        #endregion
    }
}
