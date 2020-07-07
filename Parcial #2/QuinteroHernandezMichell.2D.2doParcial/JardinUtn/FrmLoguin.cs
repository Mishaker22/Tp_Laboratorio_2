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
using Entidades.Entidades;
using System.Threading;

namespace JardinUtn
{
    public partial class FrmLoguin : Form
    {
        
        public FrmLoguin()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Herramientas\d1.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "Admin" && tbContraseña.Text == "*******")
            {
                FrmAlumnos ventana = new FrmAlumnos();
                FrmEvaluacion ventana1 = new FrmEvaluacion();
                ventana1.Show();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, Los campos contraseña y usario no pueden estar vacios.");
            }
        }

        private void FrmLoguin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
