using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        private Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
        }
        /// <summary>
        /// Mostrara la informacion que guardo en el txt del escritorio.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemento"></param>
        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if (elemento != null)
            {
                rtbMostrar.Text = elemento.MostrarDatos(elemento);
                elemento.MostrarDatos(elemento).Guardar("Correos");
            }
        }
        /// <summary>
        /// Mostrara todos los correos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }
        /// <summary>
        /// mostrara unicamente el correo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
        /// <summary>
        /// Actualiza los paquetes, limpiando cada lista cada vez que se vaya corriendo el paquete
        /// </summary>
        private void ActualizarEstados()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();
            foreach (Paquete p in correo.Paquetes)
            {
                switch (p.Estado)
                {
                    case EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(p);
                        break;
                    case EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(p);
                        break;
                    case EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(p);
                        break;
                }
            }
        }
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
            if (sender is Exception)
            {
                MessageBox.Show("Lo Sentimos, Se produjo un error al conectarse con la base de datos. \n Por favor, revise su conexion.");
            }

        }
        /// <summary>
        /// Agregara un paquete a la lista, mostrara una excepcion si este esta repetido y la actualiza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Paquete unPaquete = new Paquete(this.tbDireccion.Text, this.mtbTrackingID.Text);
                unPaquete.InformaEstado += paq_InformaEstado;
                this.correo += unPaquete;
            }
            catch (TrackingIdRepetidoException ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.ActualizarEstados();
        }
        /// <summary>
        /// cuando se cierre el formulario. cerrara todos los hilos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            correo.FinEntregas();
        }


    }
}
