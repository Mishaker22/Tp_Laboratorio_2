namespace JardinUtn
{
    partial class FrmAlumnos
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
            this.lstbListaAlumnos = new System.Windows.Forms.ListBox();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblDocentes = new System.Windows.Forms.Label();
            this.rtbProximo = new System.Windows.Forms.RichTextBox();
            this.lblProximoAlum = new System.Windows.Forms.Label();
            this.lvDocentes = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbListaAlumnos
            // 
            this.lstbListaAlumnos.FormattingEnabled = true;
            this.lstbListaAlumnos.Location = new System.Drawing.Point(12, 57);
            this.lstbListaAlumnos.Name = "lstbListaAlumnos";
            this.lstbListaAlumnos.Size = new System.Drawing.Size(293, 251);
            this.lstbListaAlumnos.TabIndex = 0;
            this.lstbListaAlumnos.SelectedIndexChanged += new System.EventHandler(this.lstbListaAlumnos_SelectedIndexChanged);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.BackColor = System.Drawing.Color.Transparent;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.Location = new System.Drawing.Point(12, 41);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(109, 13);
            this.lblAlumnos.TabIndex = 2;
            this.lblAlumnos.Text = "Lista De Alumnos:";
            // 
            // lblDocentes
            // 
            this.lblDocentes.AutoSize = true;
            this.lblDocentes.BackColor = System.Drawing.Color.Transparent;
            this.lblDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocentes.Location = new System.Drawing.Point(321, 171);
            this.lblDocentes.Name = "lblDocentes";
            this.lblDocentes.Size = new System.Drawing.Size(65, 13);
            this.lblDocentes.TabIndex = 3;
            this.lblDocentes.Text = "Docentes:";
            // 
            // rtbProximo
            // 
            this.rtbProximo.Location = new System.Drawing.Point(420, 57);
            this.rtbProximo.Name = "rtbProximo";
            this.rtbProximo.Size = new System.Drawing.Size(197, 67);
            this.rtbProximo.TabIndex = 4;
            this.rtbProximo.Text = "";
            // 
            // lblProximoAlum
            // 
            this.lblProximoAlum.AutoSize = true;
            this.lblProximoAlum.BackColor = System.Drawing.Color.Transparent;
            this.lblProximoAlum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProximoAlum.Location = new System.Drawing.Point(417, 41);
            this.lblProximoAlum.Name = "lblProximoAlum";
            this.lblProximoAlum.Size = new System.Drawing.Size(122, 13);
            this.lblProximoAlum.TabIndex = 5;
            this.lblProximoAlum.Text = "Alumno Por Evaluar:";
            // 
            // lvDocentes
            // 
            this.lvDocentes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Edad,
            this.Sexo,
            this.Dni,
            this.Direccion,
            this.Email});
            this.lvDocentes.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDocentes.HideSelection = false;
            this.lvDocentes.Location = new System.Drawing.Point(324, 187);
            this.lvDocentes.Name = "lvDocentes";
            this.lvDocentes.Size = new System.Drawing.Size(293, 121);
            this.lvDocentes.TabIndex = 0;
            this.lvDocentes.UseCompatibleStateImageBehavior = false;
            this.lvDocentes.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            // 
            // Dni
            // 
            this.Dni.Text = "Dni";
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(542, 143);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 29);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Comenzar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 325);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lvDocentes);
            this.Controls.Add(this.lblProximoAlum);
            this.Controls.Add(this.rtbProximo);
            this.Controls.Add(this.lblDocentes);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.lstbListaAlumnos);
            this.MaximumSize = new System.Drawing.Size(641, 364);
            this.MinimumSize = new System.Drawing.Size(641, 364);
            this.Name = "FrmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sala de Espera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlumnos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbListaAlumnos;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblDocentes;
        private System.Windows.Forms.RichTextBox rtbProximo;
        private System.Windows.Forms.Label lblProximoAlum;
        private System.Windows.Forms.ListView lvDocentes;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Edad;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Dni;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.Button btnStart;
    }
}