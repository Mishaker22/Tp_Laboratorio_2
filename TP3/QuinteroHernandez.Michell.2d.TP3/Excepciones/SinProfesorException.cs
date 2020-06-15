using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException:Exception
    {
        /// <summary>
        /// excepcion que indica que no hay un docente para la clase
        /// </summary>
        public SinProfesorException():base("No hay un docente para la clase")
        {

        }
    }
}
