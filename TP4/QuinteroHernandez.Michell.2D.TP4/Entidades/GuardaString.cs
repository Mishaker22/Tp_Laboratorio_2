using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GuardaString
    {
        /// <summary>
        /// Guarda un archivo txt en el escritorio del pc de la informacion del paquete.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="archivo"></param>
        /// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            using(StreamWriter sw=new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+
                @"\" + archivo + ".txt", true))
            {
                sw.WriteLine(string.Format("{0} \n {1} ", DateTime.Now.ToString(), texto));
                return true;
            }
        }
    }
}
