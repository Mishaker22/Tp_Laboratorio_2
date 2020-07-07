using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente:Persona
    {
        private string sexo;
        private string email;

        #region Propiedades
        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
       
        #endregion

        #region Constructor
        public Docente():base()
        {

        }
        public Docente(string nombre, string apellido, int edad,int dni, string direccion,int id, string sexo, string email):base(nombre,apellido,edad,dni,direccion,id)
        {           
            this.Sexo = sexo;
            this.Email = email;
        }
        #endregion

        public static bool operator==(Docente d1, Docente d2)
        {
            return (d1.Id == d2.Id);
        }
        public static bool operator !=(Docente d1, Docente d2)
        {
            return !(d1 == d2);
        }

    }
}
