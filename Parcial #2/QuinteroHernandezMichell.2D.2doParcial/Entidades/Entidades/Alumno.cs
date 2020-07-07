using Entidades.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Alumno:Persona
    {
        

        private int responsable;
        private float notaFinal;
        #region Propiedades
       
        
        public int Responsable
        {
            get { return this.responsable; }
            set { this.responsable = value; }
        }
        public float NotaFinal
        {
            get { return this.notaFinal; }
            set { this.notaFinal = value; }
        }
        #endregion

        #region Constructor
        public Alumno():base()
        {
            
        }
        public Alumno(string nombre, string apellido, int edad, int dni, string direccion, int id, int responsable) :base(nombre,apellido,edad,dni,direccion,id)
        {
             this.Responsable = responsable;
        }
        public Alumno(string nombre, string apellido, int edad, int dni, string direccion, int id, int responsable,float notaFinal) : this(nombre, apellido, edad, dni, direccion, id,responsable)
        {
            this.NotaFinal = notaFinal;
        }

        #endregion

        #region Metodos


        public override string MostrarPersona()
        {
            return base.MostrarPersona();
        }

        public override string ToString()
        {
            return base.ToString()+", "+this.Responsable;
        }
        #endregion
    }
}
