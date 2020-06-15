using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region constructores
        
        public Profesor():base()
        {
            
        }
        static Profesor()
        {
            Profesor.random = new Random();
        }
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// muestra y retorna las clases del dia del profesor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// retorna todos los datos del docente en cadena
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            
            return sb.ToString();
        }
        /// <summary>
        /// muestra en publico todos los datos del docente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos() ;
        }
        /// <summary>
        /// Genera y agrega dos clases del dia a un profesor.
        /// </summary>
        private void _randomClases()
        {
            Universidad.EClases aux;
            while (this.clasesDelDia.Count <2)
            {
                aux = (Universidad.EClases)Profesor.random.Next(1, 4);
                this.clasesDelDia.Enqueue(aux);
            }
            
        }

        #endregion

        #region SobreCargaOperadores
        /// <summary>
        /// Verifica si el profesor participa en la clase indicada.
        /// </summary>
        /// <param name="i">Profesor.</param>
        /// <param name="clase">Clase.</param>
        /// <returns>True si el profesor participa, false caso contrario.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
           
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Verifica si el profesor no participa en la clase indicada.
        /// </summary>
        /// <param name="i">Profesor.</param>
        /// <param name="clase">Clase</param>
        /// <returns>True si el profesor no participa en la clase, false caso contrario.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        /// <summary>
        /// Verifica si un objeto es de tipo Profesor, caso que lo sea verifica si
        /// es igual al profesor que se usa para llamar al metodo.
        /// </summary>
        /// <param name="obj">Objeto a verificar.</param>
        /// <returns>True si son iguales, false caso contrario.</returns>
        public override bool Equals(object obj)
        {
            if (obj is Profesor)
            {
                return base.Equals(obj);
            }
            return false;
        }
        #endregion


    }
}
