using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Archivos;
using Entidades.SQL;

namespace JardinUtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Directory.Exists(@"\Documentos\SegundoParcialUtn\JardinUtn\Docentes");
            //string ruta = Environment.SpecialFolder.MyDocuments + @"\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml";
            //Xml<Docente>.DeserializarXml(ruta);
            //DocenteDAO.Insertar(Xml<Docente>.DeserializarXml(ruta));
        }
    }
}
