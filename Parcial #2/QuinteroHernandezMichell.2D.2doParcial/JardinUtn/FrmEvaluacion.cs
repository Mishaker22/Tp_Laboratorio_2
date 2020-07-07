using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.Archivos;
using Entidades.Entidades;
using Entidades.Excepciones;
using Entidades.SQL;

namespace JardinUtn
{
    public delegate void CargarNotas();
    public delegate void CargarAlumnoEvaluado(Alumno a);
    public partial class FrmEvaluacion : Form
    {
        //public delegate void MostrarRecreo(bool obj);
        private Aula aula;
        private Alumno alumno;
        private Thread recreo;
        private Evaluacion evaluacion;
        private int nota2;
        private int nota1;
        private float notaFinal;
        private string observacion;
        private Docente docente;
        public event CargarNotas CargandoNotas;
        public event CargarAlumnoEvaluado CargarAlumnosLstb;

        public FrmEvaluacion()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Herramientas\fondo.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            aula = new Aula();
            evaluacion = new Evaluacion();
            recreo = new Thread(CicloRecreo);
            FrmAlumnos.ProximoAlumno += EvaluarAlumno;
            Evaluacion.docenteRandom += DoncenteEvaluandoAlumno;
            this.CargarAlumnosLstb += CargarAlumnosEvaluados;
            this.CargandoNotas += CargarNota;
            alumno = new Alumno();
        }

        private void FrmEvaluacion_Load(object sender, EventArgs e)
        {
            this.pbRecreo.Visible = false;
            this.recreo.Start();

            Listas.hilos.Add(recreo);
            
        }

        #region Hilo Recreo
        /// <summary>
        /// Crea un ciclo donde por 20 segundos desaparece la imagen y por 5 segundos enciente la imagen
        /// </summary>
        public void CicloRecreo()
        {
            while (true)
            {
                Thread.Sleep(20000);
                this.Invoke(new MethodInvoker(() => { this.lblTimer.Text = "¡En Recreo!"; }));
                this.Invoke(new MethodInvoker(() => { this.pbRecreo.Visible = true; }));
                Thread.Sleep(5000);
                this.Invoke(new MethodInvoker(() => { this.lblTimer.Text = "¡Termino El Recreo!"; }));
                this.Invoke(new MethodInvoker(() => { this.pbRecreo.Visible = false; }));
            }
        }

        #endregion

        #region Metodos Relacionados Con eventos
        public void CargarNota()
        {
            nota1 = evaluacion.Nota1;
            nota2 = evaluacion.Nota2;
            MostrarEnLabels(this.lblNotas1, nota1.ToString());
            MostrarEnLabels(this.lblNotas2, nota2.ToString());
            evaluacion.CalcularFinal(nota1, nota2);
            notaFinal = evaluacion.NotaFinal;
            MostrarEnLabels(this.lblNotaFinal, notaFinal.ToString());
            evaluacion.ObservacionFinal(evaluacion.NotaFinal);
            observacion = evaluacion.Observacion;
            MostrarEnLabels(this.lblObservaciones, evaluacion.Observacion);
        }
        public void MostrarEnLabels(Label label, string nota)
        {
            if (label.InvokeRequired)
            {
                label.BeginInvoke((MethodInvoker)delegate
                {
                    label.Text = nota;
                });
            }
            else
                label.Text = nota;
        }
        public void EvaluarAlumno(Alumno a)
        {
            
            this.CargarAulas();
            this.lblAlumEvaluado.Text = a.MostrarPersona();
            this.CargandoNotas();
            IndexadorDeNotas(a);
            a.NotaFinal = notaFinal;
            SerializarEvaluacion(a, this.notaFinal);
            CargarAlumnosEvaluados(a);
            this.alumno = a;
            Cronometro.Start();
        }
        public void DoncenteEvaluandoAlumno(Docente d)
        {
            docente = d;
            this.MostrarEnLabels(this.lblDocenteEvaluando, docente.MostrarPersona());
        }
        #endregion

        #region Cronometro

        /// <summary>
        /// Contero de segundos desde que empezo a evaluar
        /// </summary>
        int seg;
        int min;
        int hour;
        private void Cronometro_Tick(object sender, EventArgs e)
        {

            seg += 1;
            string segundos = seg.ToString();
            string minutos = min.ToString();
            string horas = hour.ToString();

            if (seg < 10) { segundos = "0" + seg.ToString(); }
            if (min < 10) { minutos = "0" + min.ToString(); }
            if (hour < 10) { horas = "0" + hour.ToString(); }

            if (seg == 60)
            {
                min += 1;
                seg = 0;
            }
            if (min == 60)
            {
                hour += 1;
                min = 0;
            }
            lblHora.Text = horas + ":" + minutos + ":" + segundos;
        }
        #endregion

        #region Metodos
        public void SerializarEvaluacion(Alumno a, float notaF)
        {

            Alumno alumno = new Alumno(a.Nombre, a.Apellido, a.Edad, a.Dni, a.Direccion, a.Id, a.Responsable, notaF);
            Listas.listaAlumnos.Add(alumno);
            string rutaDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaApro = @"SegundoParcialUtn\JardinUtn\Serializaciones\Aprobados";
            string rutaDespr = @"SegundoParcialUtn\JardinUtn\Serializaciones\Desaprobados";

            if (notaF >= 1 && notaF <= 3)
            {
                string ruta1 = System.IO.Path.Combine(rutaDoc, rutaDespr);
                if (!Directory.Exists(ruta1))
                {
                    System.IO.Directory.CreateDirectory(ruta1);
                }
                string rutaD = System.IO.Path.Combine(ruta1 + String.Format($@"\{a.Nombre}_{a.Apellido}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.xml"));
                Serializacion<Alumno>.SerializarAXml(alumno, rutaD);
            }
            else if (notaF >= 4 && notaF <= 10)
            {
                string ruta2 = System.IO.Path.Combine(rutaDoc, rutaApro);
                if (!Directory.Exists(ruta2))
                {
                    System.IO.Directory.CreateDirectory(ruta2);
                }
                string rutaA = System.IO.Path.Combine(ruta2 + String.Format($@"\{a.Nombre}_{a.Apellido}_{DateTime.Now.Day}_{DateTime.Now.Month}_{DateTime.Now.Year}.xml"));

                Serializacion<Alumno>.SerializarAXml(alumno, rutaA);
                
            }


        }
        /// <summary>
        /// llama al metodo insertar y los almacena en la base de datos, en la tabla de evaluaciones
        /// </summary>
        /// <param name="a"></param>
        public void IndexadorDeNotas(Alumno a)
        {
            //evaluacion = new Evaluacion(a.Id, docente.Id, aula.IdAula, nota1, nota2, notaFinal, observacion);
            EvaluacionDAO.InsertarEvaluaciones(a.Id, docente.Id, aula.IdAula, nota1, nota2, notaFinal, observacion);
        }
        /// <summary>
        /// Carga el combox con los contenidos de las aulas y elige random
        /// </summary>

        public void CargarAulas()
        {
            try
            {

                this.cmbSala.DataSource = null;
                this.cmbSala.Refresh();
                this.cmbSala.DataSource = aula.ListaAulas;
                this.cmbSala.DisplayMember = "Salita";

                Random random = new Random();

                if (this.aula.ListaAulas.Count >= 0)
                {
                    this.cmbSala.SelectedIndex = random.Next(0, 5);
                    aula.IdAula = this.cmbSala.SelectedIndex; ;
                }
            }
            catch (Exception ex)
            {

                throw new JardinException("No se pudieron cargar las aulas", ex);
            }
        }
        public Aula ProfesorAleatorio(List<Aula> lstAulas)
        {
            Random random = new Random();
            int index = random.Next(lstAulas.Count);

            return lstAulas[index];
        }
        #endregion

        public void CargarAlumnosEvaluados(Alumno a)
        {
            this.lstbAlumnosEvaluados.Items.Add(a);
        }
        private void FrmEvaluacion_FormClosing(object sender, FormClosingEventArgs e)
        {

            Cronometro.Stop();
            foreach (Thread item in Listas.hilos)
            {
                if (item.IsAlive)
                {
                    item.Abort();
                }
            }
        }
       
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.MostrarPersona() + "\nNota final es de: "+ alumno.NotaFinal.ToString());
        }
    }
}
