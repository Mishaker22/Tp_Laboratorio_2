namespace JardinUtn
{
    partial class FrmEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAlum = new System.Windows.Forms.Label();
            this.lblAlumEvaluado = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.lblNotas1 = new System.Windows.Forms.Label();
            this.lblNotas2 = new System.Windows.Forms.Label();
            this.lblNotaFinal = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblSalita = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lstbAlumnosEvaluados = new System.Windows.Forms.ListBox();
            this.pbRecreo = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.Cronometro = new System.Windows.Forms.Timer(this.components);
            this.lblTDocente = new System.Windows.Forms.Label();
            this.lblDocenteEvaluando = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbRecreo)).BeginInit();
            this.Mostrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlum
            // 
            this.lblAlum.AutoSize = true;
            this.lblAlum.BackColor = System.Drawing.Color.Transparent;
            this.lblAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlum.Location = new System.Drawing.Point(12, 18);
            this.lblAlum.Name = "lblAlum";
            this.lblAlum.Size = new System.Drawing.Size(59, 15);
            this.lblAlum.TabIndex = 0;
            this.lblAlum.Text = "Alumno:";
            // 
            // lblAlumEvaluado
            // 
            this.lblAlumEvaluado.AutoSize = true;
            this.lblAlumEvaluado.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumEvaluado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumEvaluado.Location = new System.Drawing.Point(12, 38);
            this.lblAlumEvaluado.Name = "lblAlumEvaluado";
            this.lblAlumEvaluado.Size = new System.Drawing.Size(11, 15);
            this.lblAlumEvaluado.TabIndex = 1;
            this.lblAlumEvaluado.Text = "-";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.BackColor = System.Drawing.Color.Transparent;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(12, 93);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(96, 15);
            this.lblNota1.TabIndex = 2;
            this.lblNota1.Text = "Primera Nota:";
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.BackColor = System.Drawing.Color.Transparent;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(6, 142);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(102, 15);
            this.lblNota2.TabIndex = 3;
            this.lblNota2.Text = "Segunda Nota:";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.BackColor = System.Drawing.Color.Transparent;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(31, 192);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(77, 15);
            this.lblNota3.TabIndex = 4;
            this.lblNota3.Text = "Nota Final:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(18, 243);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(90, 15);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Observacion:";
            // 
            // cmbSala
            // 
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(154, 38);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 21);
            this.cmbSala.TabIndex = 6;
            // 
            // lblNotas1
            // 
            this.lblNotas1.AutoSize = true;
            this.lblNotas1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas1.Location = new System.Drawing.Point(114, 93);
            this.lblNotas1.Name = "lblNotas1";
            this.lblNotas1.Size = new System.Drawing.Size(11, 15);
            this.lblNotas1.TabIndex = 7;
            this.lblNotas1.Text = "-";
            // 
            // lblNotas2
            // 
            this.lblNotas2.AutoSize = true;
            this.lblNotas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas2.Location = new System.Drawing.Point(114, 142);
            this.lblNotas2.Name = "lblNotas2";
            this.lblNotas2.Size = new System.Drawing.Size(11, 15);
            this.lblNotas2.TabIndex = 8;
            this.lblNotas2.Text = "-";
            // 
            // lblNotaFinal
            // 
            this.lblNotaFinal.AutoSize = true;
            this.lblNotaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaFinal.Location = new System.Drawing.Point(114, 192);
            this.lblNotaFinal.Name = "lblNotaFinal";
            this.lblNotaFinal.Size = new System.Drawing.Size(11, 15);
            this.lblNotaFinal.TabIndex = 9;
            this.lblNotaFinal.Text = "-";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.Location = new System.Drawing.Point(114, 243);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(11, 15);
            this.lblObservaciones.TabIndex = 10;
            this.lblObservaciones.Text = "-";
            // 
            // lblSalita
            // 
            this.lblSalita.AutoSize = true;
            this.lblSalita.BackColor = System.Drawing.Color.Transparent;
            this.lblSalita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalita.Location = new System.Drawing.Point(151, 20);
            this.lblSalita.Name = "lblSalita";
            this.lblSalita.Size = new System.Drawing.Size(48, 15);
            this.lblSalita.TabIndex = 11;
            this.lblSalita.Text = "Salita:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(346, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 15);
            this.lblHora.TabIndex = 12;
            this.lblHora.Text = "00:00:00";
            // 
            // lstbAlumnosEvaluados
            // 
            this.lstbAlumnosEvaluados.FormattingEnabled = true;
            this.lstbAlumnosEvaluados.Location = new System.Drawing.Point(5, 287);
            this.lstbAlumnosEvaluados.Name = "lstbAlumnosEvaluados";
            this.lstbAlumnosEvaluados.Size = new System.Drawing.Size(396, 69);
            this.lstbAlumnosEvaluados.TabIndex = 13;
            this.lstbAlumnosEvaluados.SelectedIndexChanged += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // pbRecreo
            // 
            this.pbRecreo.Image = global::JardinUtn.Properties.Resources.recreo;
            this.pbRecreo.Location = new System.Drawing.Point(222, 109);
            this.pbRecreo.Name = "pbRecreo";
            this.pbRecreo.Size = new System.Drawing.Size(179, 149);
            this.pbRecreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRecreo.TabIndex = 14;
            this.pbRecreo.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Location = new System.Drawing.Point(219, 93);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(58, 13);
            this.lblTimer.TabIndex = 15;
            this.lblTimer.Text = "Evaluando";
            // 
            // Cronometro
            // 
            this.Cronometro.Interval = 1000;
            this.Cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // lblTDocente
            // 
            this.lblTDocente.AutoSize = true;
            this.lblTDocente.BackColor = System.Drawing.Color.Transparent;
            this.lblTDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDocente.Location = new System.Drawing.Point(12, 53);
            this.lblTDocente.Name = "lblTDocente";
            this.lblTDocente.Size = new System.Drawing.Size(64, 15);
            this.lblTDocente.TabIndex = 16;
            this.lblTDocente.Text = "Docente:";
            // 
            // lblDocenteEvaluando
            // 
            this.lblDocenteEvaluando.AutoSize = true;
            this.lblDocenteEvaluando.BackColor = System.Drawing.Color.Transparent;
            this.lblDocenteEvaluando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteEvaluando.Location = new System.Drawing.Point(12, 76);
            this.lblDocenteEvaluando.Name = "lblDocenteEvaluando";
            this.lblDocenteEvaluando.Size = new System.Drawing.Size(11, 15);
            this.lblDocenteEvaluando.TabIndex = 17;
            this.lblDocenteEvaluando.Text = "-";
            // 
            // Mostrar
            // 
            this.Mostrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // FrmEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 361);
            this.Controls.Add(this.lblDocenteEvaluando);
            this.Controls.Add(this.lblTDocente);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pbRecreo);
            this.Controls.Add(this.lstbAlumnosEvaluados);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblSalita);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.lblNotaFinal);
            this.Controls.Add(this.lblNotas2);
            this.Controls.Add(this.lblNotas1);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.lblAlumEvaluado);
            this.Controls.Add(this.lblAlum);
            this.MaximumSize = new System.Drawing.Size(429, 400);
            this.MinimumSize = new System.Drawing.Size(429, 400);
            this.Name = "FrmEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvaluacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEvaluacion_FormClosing);
            this.Load += new System.EventHandler(this.FrmEvaluacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRecreo)).EndInit();
            this.Mostrar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlum;
        private System.Windows.Forms.Label lblAlumEvaluado;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.Label lblNotas1;
        private System.Windows.Forms.Label lblNotas2;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblSalita;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ListBox lstbAlumnosEvaluados;
        private System.Windows.Forms.PictureBox pbRecreo;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer Cronometro;
        private System.Windows.Forms.Label lblTDocente;
        private System.Windows.Forms.Label lblDocenteEvaluando;
        private System.Windows.Forms.ContextMenuStrip Mostrar;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}