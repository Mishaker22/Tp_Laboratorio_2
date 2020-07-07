using System;
using System.IO;
using Entidades;
using Entidades.Archivos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SerializadorBinario()
        {
            Alumno alumno = new Alumno("Michell","Quintero",23,1234567,"Bernal",22,28);
            string rutaAux= (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest");
            if (!Directory.Exists(rutaAux))
            {
                Directory.CreateDirectory(rutaAux);
            }           
            string ruta = Path.Combine(rutaAux, String.Format(@"TestBinario.bin"));
            Serializacion<Alumno>.SerializarABinario(alumno,ruta);
            bool rutabin = File.Exists((ruta));
            Assert.IsTrue(rutabin);
        }
        [TestMethod]
        public void SerializadorXML()
        {
            Alumno alumno = new Alumno("Daniel", "Quintero", 49, 12345678, "Florida", 12, 48);
            string rutaAux = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest");
            if (!Directory.Exists(rutaAux))
            {
                Directory.CreateDirectory(rutaAux);
            }
            string ruta = Path.Combine(rutaAux, String.Format(@"TestXml.XML"));
            Serializacion<Alumno>.SerializarAXml(alumno, ruta);
            bool rutaxml = File.Exists(ruta);

            Assert.IsTrue(rutaxml);
        }
        [TestMethod]
        public void DeserializadorXML()
        {
            
            string rutaAux = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest");
            string ruta = Path.Combine(rutaAux, String.Format(@"TestXml.XML"));
            Serializacion<Alumno>.DeserializarXml(ruta);
            bool rutaxml = File.Exists(ruta);

            Assert.IsTrue(rutaxml);
        }
        [TestMethod]
        public void DeserializadorBinario()
        {

            string rutaAux = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SegundoParcialUtn\JardinUtn\UnitTest");
            string ruta = Path.Combine(rutaAux, String.Format(@"TestBinario.bin"));
            Serializacion<Alumno>.DeserializarBinario(ruta);
            bool rutaxml = File.Exists(ruta);

            Assert.IsTrue(rutaxml);
        }
    }
}
