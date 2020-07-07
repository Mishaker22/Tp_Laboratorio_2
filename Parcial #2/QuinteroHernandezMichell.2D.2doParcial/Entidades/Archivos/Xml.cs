using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public static class Xml
    {
        /// <summary>
        /// Deserializa el contenido del XML Docente, y lo guarda en una Variable docente
        /// </summary>
        /// <param name="archivo"></param>
        /// <returns></returns>
        /// 

        public static T DeserializarXml<T>(string archivo)
        {
            T objeto = default(T);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                FileStream fs = File.Open(archivo, FileMode.Open);
                objeto = (T)serializer.Deserialize(fs);
                fs.Close();
                fs.Dispose();
            }
            catch (Exception )
            {
                throw new JardinException("Ocurrió un error al tratar de deserializar el archivo XML.");
            }
                return objeto;

            #region errores
            //Docente docente;
            //try
            //{
            //    using (XmlTextReader reader = new XmlTextReader(archivo))
            //    {
            //        XmlSerializer serializer = new XmlSerializer(typeof(Docente));
            //        docente = (Docente)serializer.Deserialize(reader);
            //    }
            //}
            //catch (Exception)
            //{
            //    throw new JardinException("Ocurrió un error al tratar de deserializar el archivo XML.");
            //}


            //return docente;
            #endregion
        }
    }
}
