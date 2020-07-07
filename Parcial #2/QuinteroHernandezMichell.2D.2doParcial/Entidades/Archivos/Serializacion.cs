using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public static class Serializacion<T> where T : class, new()
    {
        public static void SerializarABinario(T objeto, string ruta)
        {
            FileStream fs = null;

            try
            {
                fs = new FileStream(ruta, FileMode.Create);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fs, objeto);
            }
            catch (Exception ex)
            {
                throw new JardinException("Ocurrió un error al tratar de serializar el archivo a binario.", ex);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        /// <summary>
        /// Serializa un objeto a formato XML.
        /// </summary>
        /// <param name="objeto">Objeto a serializar.</param>
        /// <param name="ruta">Ruta donde se creará el archivo de serialización.</param>
        public static void SerializarAXml(T objeto, string ruta)
        {
            XmlTextWriter wr = null;
            try
            {
                wr = new XmlTextWriter(ruta, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(wr, objeto);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (DirectoryNotFoundException ex )
            {
                throw new JardinException("No se pudo localizar el directorio.", ex);
            }
            catch (Exception ex)
            {
                throw new JardinException("¡No se pudo Serializar!", ex);
            }
            finally
            {
                if (wr != null)
                {
                    wr.Close();
                }
            }
        }
        public static T DeserializarBinario(string ruta)
        {
            FileStream fs = null;
            T objeto = default(T);

            try
            {
                BinaryFormatter reader = new BinaryFormatter();
                fs = new FileStream(ruta, FileMode.Open);
                objeto = (T)reader.Deserialize(fs);
            }
            catch (Exception ex)
            {
                throw new JardinException("No se pudo deserializar el archivo binario.", ex);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            return objeto;
        }

        /// <summary>
        /// Deserializa el archivo a tipo generico
        /// </summary>
        /// <param name="ruta">Ruta del archivo a deserializar.</param>
        /// <returns></returns>
        public static T DeserializarXml(string ruta)
        {
            XmlTextReader rd = null;
            T objeto = default(T);
            try
            {
                rd = new XmlTextReader(ruta);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                objeto = (T)serializer.Deserialize(rd);
            }
            catch (Exception ex)
            {
                throw new JardinException("No se pudo deserializar.", ex);
            }
            finally
            {
                if (rd != null)
                {
                    rd.Close();
                }
            }

            return objeto;
        }
    }
}
