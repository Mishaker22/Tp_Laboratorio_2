using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrackingIdRepetidoException:Exception
    {
        /// <summary>
        /// se lanza una excepcion en caso de que el id sea repetido
        /// </summary>
        /// <param name="mensaje"></param>
        public TrackingIdRepetidoException(string mensaje):base(mensaje)
        {

        }
        /// <summary>
        /// se lanza una excepcion en caso de que el id sea repetido
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public TrackingIdRepetidoException(string mensaje, Exception inner):base(mensaje,inner)
        {

        }
    }
}
