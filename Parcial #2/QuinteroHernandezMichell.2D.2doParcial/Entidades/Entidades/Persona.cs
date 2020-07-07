using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int edad;
        private string direccion;
        private int id;

        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        
        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        #endregion

        #region Constructor
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad, int dni, string direccion, int id) :this()
        {         
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
            this.Dni = dni;
            this.Direccion = direccion;
            this.Id = id;
        }
        #endregion

        /// <summary>
        /// muestro los datos de las Personas
        /// </summary>
        /// <returns></returns>
        public  virtual string  MostrarPersona()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("Id: {0}, {1}, {2}",this.Id.ToString(),this.Nombre, this.Apellido);
      
            return sb.ToString();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID: {0} Nombre: {1}, {2}, {3}, {4}, {5}", this.Id, this.Nombre, this.Apellido, this.Edad, this.Dni, this.Direccion);
            return sb.ToString();
        }
    }
}
