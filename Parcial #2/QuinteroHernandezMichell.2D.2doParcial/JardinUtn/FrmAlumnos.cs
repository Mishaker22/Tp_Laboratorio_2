using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Archivos;
using Entidades.SQL;
using System.Threading;
using Entidades.Entidades;

namespace JardinUtn
{
    public delegate void EvaluarAlumno(Alumno alumno);
    
    public partial class FrmAlumnos : Form
    {
        private Evaluacion evaluacion;
        private  Alumno alumnoSelect;
        public static event EvaluarAlumno ProximoAlumno;
        private const int EVALUAR = 8000;
        

        public FrmAlumnos()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Herramientas\fondo.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            evaluacion = new Evaluacion();
            this.evaluacion.alumnosListCambiados += ActualizarListaAlumnos;

        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            
            this.CargarDocentes();
            evaluacion.ListaIdDocente = Listas.listaDocentes;
            this.EnlistarDocentes();
            this.ActualizarListaAlumnos();
        }
        /// <summary>
        /// Carga los docentes deserializados en una lista de docentes y al tambien llama al metodo insertar 
        /// para guardar los datos en la base de datos
        /// </summary>
        public void CargarDocentes()
        {
            string misDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaRelativa = @"SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml";
            string rutaDelArchivo = System.IO.Path.Combine(misDocumentos, rutaRelativa);
            Listas.listaDocentes = (List<Docente>)XmlDocentes.DeserializarXml<List<Docente>>(rutaDelArchivo);

            foreach (Docente item in Listas.listaDocentes)
            {

                if (DocenteDAO.DocenteRegistrado(item.Id) == 0)
                {
                    DocenteDAO.InsertarDocente(item);
                }
            }

            #region Pruebas
            //aux = (List<Docente>)XmlDocentes.Deserializar<List<Docente>>("docente.xml");
            //List<Docente> aux = new List<Docente>();
            //Directory.GetFiles(rutaDelArchivo);
            //Directory.Exists(rutaDelArchivo);
            //XmlDocentes<Docente>.DeserializarXml(rutaDelArchivo);
            //Directory.Exists(@"\Users\miche\OneDrive\Documentos\SegundoParcialUtn\JardinUtn\Docentes");
            //string ruta = Environment.SpecialFolder.MyDocuments + @"\SegundoParcialUtn\JardinUtn\Docentes\Docentes.xml";
            //XmlDocentes<Docente>.DeserializarXml(@"C:\Users\miche\OneDrive\Documentos\SegundoParcialUtn\JardinUtn\Docentes");
            //DocenteDAO.Insertar(XmlDocentes<Docente>.DeserializarXml(ruta));
            #endregion
        }
        /// <summary>
        /// En lista los docentes en el listview
        /// </summary>
        public void EnlistarDocentes()
        {
            foreach (Docente item in Listas.listaDocentes)
            {
                ListViewItem ite = new ListViewItem();
                ite = lvDocentes.Items.Add(item.Id.ToString());
                ite.SubItems.Add(item.Nombre);
                ite.SubItems.Add(item.Apellido);
                ite.SubItems.Add(item.Edad.ToString());
                ite.SubItems.Add(item.Sexo);
                ite.SubItems.Add(item.Dni.ToString());
                ite.SubItems.Add(item.Direccion);
                ite.SubItems.Add(item.Email);
            }
        }
        /// <summary>
        /// Actualiza constantemente los items de la lista de alumnos
        /// </summary>
        public void ActualizarListaAlumnos()
        {
            try
            {
                //this.rtbProximo.Text = this.evaluacion.MostrarDocenteRandom();
                this.lstbListaAlumnos.DataSource = null;
                this.lstbListaAlumnos.Refresh();
                this.lstbListaAlumnos.DataSource = this.evaluacion.ListaIdAlumno;


                if (this.evaluacion.ListaIdAlumno.Count>0)
                {
                    this.lstbListaAlumnos.SelectedIndex = 0;
                    this.ActualizarAlumnoSeleccionado();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("", ex);
            }
        }
        /// <summary>
        /// actualiza el alumno que esta siendo seleccionado por el listbox y lo muestra en el ritchtextbox
        /// </summary>
        private void ActualizarAlumnoSeleccionado()
        {
            try
            {
                this.alumnoSelect = (Alumno)this.lstbListaAlumnos.SelectedValue;
                
                if (alumnoSelect != null)
                {
                    this.rtbProximo.Text = "Siguiente Alumno a ser evaluado:\n "+this.alumnoSelect.MostrarPersona() + "\n" 
                        + this.evaluacion.MostrarDocenteRandom();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
                //this.ManejarExcepciones(ex);
            }
        }
        /// <summary>
        /// Evento que cada vez que esta siendo seleccionado llama al metodo actualizaralumnoseleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbListaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ActualizarAlumnoSeleccionado();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Thread bucle = new Thread(Next);
            Listas.hilos.Add(bucle);

            if (Listas.hilos[0].IsAlive)
            {
                Listas.hilos[0] = new Thread(Next);
                Listas.hilos[0].Start();
            }
        }
        /// <summary>
        /// cada 8 segundos pasa otro alumno a evaluar
        /// </summary>
        private void Next()
        {
            if (this.lstbListaAlumnos.Items.Count>0)
            {
                while (true)
                {
                    for (int i = 0; i < 29; i++)
                    {

                        this.Invoke(new MethodInvoker(() => { FrmAlumnos.ProximoAlumno((Alumno)this.lstbListaAlumnos.SelectedItem); }));
                        Thread.Sleep(EVALUAR);
                        this.Invoke(new MethodInvoker(() => { this.lstbListaAlumnos.SelectedIndex++; }));                       
                    }
                }
            }
        }
       
       
        private void FrmAlumnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Thread item in Listas.hilos)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }
    }
}
