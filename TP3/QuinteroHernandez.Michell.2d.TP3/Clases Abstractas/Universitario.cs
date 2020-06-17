using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        #region operadores
        /// <summary>
        /// Get / Set del legajo
        /// </summary>
        public int Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        #endregion

        #region Constructores
        public Universitario():base()
        {

        }
        
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this.Legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra datos de universitario
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Legajo: " + this.legajo);
            

            return sb.ToString();
        }
        /// <summary>
        /// Indica en cuales clases participa el universitario
        /// </summary>
        /// <returns></returns>
        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas de operadores
        /// <summary>
        /// El objeto sera equivalente, si es del tipo Universitario y si el Dni o Legajo son iguales.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Universitario) && this == (Universitario)obj);
        }
        
        /// <summary>
        /// Compara que el 2 universitarios no sean el mismo, comparando por dni o legajo
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            if (pg1.GetType() == pg2.GetType() && (pg1.DNI==pg2.DNI || pg1.legajo == pg2.legajo))//poner punto
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Invoca a la sobrecarga de Universitario == Universitario e invierte
        /// el resultado.
        /// </summary>
        /// <param name="pg1">Primer universitario.</param>
        /// <param name="pg2">Segundo universitario.</param>
        /// <returns>true si no tienen el mismo Legajo ni DNI.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        #endregion

    }
}
