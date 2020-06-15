using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException:Exception
    {
        /// <summary>
        /// excepcion que indica que el alumno esta repetido
        /// </summary>
        public AlumnoRepetidoException():base("Alumno Repetido")
        {

        }
    }
}
