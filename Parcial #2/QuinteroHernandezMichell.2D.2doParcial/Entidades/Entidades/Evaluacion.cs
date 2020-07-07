using Entidades.SQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Entidades
{
    public delegate void DocenteEvaluando(Docente Docente);
    public class Evaluacion
    {
        #region Atributos
        public event Action alumnosListCambiados;
        public static event DocenteEvaluando docenteRandom;
        private List<Alumno> idAlumno;
        private List<Docente> idDocente;
        private int idEvaluacion;
        private Aula idAula;
        private Random random;
        private int nota1;
        private int nota2;
        private float notaFinal;
        private string observacion;
        private int idDocentes;
        private int idAlumnos;
        private int idAulas;
        #endregion

        #region Propiedades
        private Alumno alumno;

        public Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }

        public int IdAlumnos
        {
            get { return this.idAlumnos; }
            set { this.idAlumnos = value; }
        }
        public int IdDocentes
        {
            get { return this.idDocentes; }
            set { this.idDocentes = value; }
        }
        public int IdAulas
        {
            get { return this.idAulas; }
            set { this.idAulas = value; }
        }
        public string Observacion
        {
            get
            {
                return this.observacion;
            }
            set { observacion = value; }
        }


        public float NotaFinal
        {
            get
            {
                return this.notaFinal;
            }
            set { notaFinal = value; }
        }


        public int Nota2
        {
            get
            {
                
                return this.nota2 = (int)random.Next(1, 10);
            }
            set { nota2 = value; }
        }


        public int Nota1

        {
            get
            {
                
                return this.nota1 = (int)random.Next(1, 10);
            }
            set { nota1 = value; }
        }
        
        public Aula IdAula
        {
            get { return idAula; }
            set { idAula = value; }
        }



        public int IdEvaluacion
        {
            get { return idEvaluacion; }
            set { idEvaluacion = value; }
        }


        public List<Docente> ListaIdDocente
        {
            get { return idDocente; }
            set { idDocente = value; }
        }


        public List<Alumno> ListaIdAlumno
        {
            get { return idAlumno; }
            set
            {
                idAlumno = value;
                this.alumnosListCambiados();
            }
        }
        #endregion

        #region Constructores
        public Evaluacion()
        {
            random = new Random();
            this.idAlumno = AlumnosDAO.SelectAll();
            AlumnosDAO.CambioAlumno += ActualizarListaAlumnos;
            this.idDocente = new List<Docente>();
        }
        public Evaluacion(Alumno a, float notaF)
        {
            this.Alumno = a;
            this.NotaFinal = notaF;
        }

        public Evaluacion(int idAlumnos, int idDocentes, int idAulas, int nota1, int nota2, float nFinal, string observacion)
        {
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.NotaFinal = nFinal;
            this.Observacion = observacion;
            this.IdAlumnos = idAlumnos;
            this.IdDocentes = idDocentes;
            this.IdAulas = idAulas;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Suma las notas y calcula el promedio final
        /// </summary>
        /// <param name="nota1"></param>
        /// <param name="nota2"></param>
        /// <returns></returns>
        public float CalcularFinal(int nota1, int nota2)
        {
            
            return this.notaFinal=(float)(nota1+nota2)/2;
        }
        /// <summary>
        /// Segun la nota Final, tira un mensaje de motivacion
        /// </summary>
        /// <param name="notaFinal"></param>
        /// <returns></returns>
        public string ObservacionFinal(float notaFinal)
        {
            this.observacion = "¡A ESTUDIAR!";

            if (notaFinal >= 1 && notaFinal <=3)
            {
                this.observacion = " ¡PODRIA MEJORAR!";
            }
            else if (notaFinal >= 4 && notaFinal <= 5)
            {
                this.observacion = " ¡APROBADO!";
            }
            else if (notaFinal >= 6 && notaFinal <= 10)
            {
                this.observacion = " ¡PROMOCIONA!";
            }
            return this.observacion;
        }
        /// <summary>
        /// Lanza un docente random a calificar al alumno
        /// </summary>
        /// <param name="lstDocentes"></param>
        /// <returns></returns>
        public Docente ProfesorAleatorio(List<Docente> lstDocentes)
        {
            int index = random.Next(lstDocentes.Count);
            Evaluacion.docenteRandom(lstDocentes[index]);
            return lstDocentes[index];
        }
        /// <summary>
        /// muestra el docente random
        /// </summary>
        /// <returns></returns>
        public string MostrarDocenteRandom()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Evaluado por: {0} ", this.ProfesorAleatorio(this.ListaIdDocente).MostrarPersona());
            
            return sb.ToString();
        }
        /// <summary>
        /// actualiza la lista con la lista de la base de datos
        /// </summary>
        /// <param name="bd"></param>
        public void ActualizarListaAlumnos(BDAcciones bd)
        {
            this.ListaIdAlumno = AlumnosDAO.SelectAll();
        }
        #endregion
    }
}
