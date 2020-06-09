using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clases;
        private Profesor instructor;

        #region Propiedades
        
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { myVar = value; }
        }
        
        public Universidad.EClases Clase
        {
            get { return this.clases; }
            set { myVar = value; }
        }
       
        public Profesor Instructor
        {
            get { return this.instructor; }
            set { myVar = value; }
        }



        #endregion

    }
}
