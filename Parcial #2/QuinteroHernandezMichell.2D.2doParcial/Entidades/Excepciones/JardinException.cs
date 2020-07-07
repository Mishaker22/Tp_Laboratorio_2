using Entidades.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Interface;
using System.IO;
using System.Security.Permissions;

namespace Entidades.Excepciones
{
    public class JardinException : Exception, IArchivo
    {
        public JardinException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {
            Guardar();
        }
        public void Guardar()
        {


            try
            {
                string rutaDoc = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                string rutaAlt = @"SegundoParcialUtn\JardinUtn\Archivos";
                string ruta = Path.Combine(rutaDoc, rutaAlt);
                if (!Directory.Exists(ruta))
                {
                    System.IO.Directory.CreateDirectory(ruta);
                }
                //FileIOPermission filePermissions =new FileIOPermission(FileIOPermissionAccess.Write, @"C:\Program Files\");
                //filePermissions.Demand();
                using (StreamWriter writer = new StreamWriter(ruta + @"\log.txt", true))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine(DateTime.Now.ToString() + ":");
                    sb.AppendLine(this.Message);
                    Exception innerException = this.InnerException;
                    while (innerException != null)
                    {
                        sb.AppendLine(innerException.Message);
                        innerException = innerException.InnerException;
                    }
                    writer.Write(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar", ex);
            }
        }
    }
}
