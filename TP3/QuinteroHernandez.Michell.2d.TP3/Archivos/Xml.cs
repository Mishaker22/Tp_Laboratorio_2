using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : class
    {
        /// <summary>
        /// Toma los datos y los guarda en xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Guardar(string archivo, T datos)
        {
            try
            {
                XmlSerializer xml1 = new XmlSerializer(typeof(T));
                using (StreamWriter writer = new StreamWriter(archivo))
                {
                    xml1.Serialize(writer, datos);
                    return true;
                }
      
            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// toma los datos de un xml y los lee y los devuelve en tipo T
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out T datos)
        {
            try
            {
                XmlSerializer xml1 = new XmlSerializer(typeof(T));
                using (TextReader reader = new StreamReader(archivo))
                {
                    datos = (T)xml1.Deserialize(reader);
                    return true;
                }

            }
            catch (Exception e)
            {

                throw new ArchivosException(e);
            }
        }
    }
}
