﻿namespace MainCorreo
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbPaquetes = new System.Windows.Forms.GroupBox();
            this.lsbEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lsbEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lsbEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.grbPaquete = new System.Windows.Forms.GroupBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.mtbTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.grbPaquetes.SuspendLayout();
            this.grbPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPaquetes
            // 
            this.grbPaquetes.Controls.Add(this.lsbEstadoEntregado);
            this.grbPaquetes.Controls.Add(this.lsbEstadoEnViaje);
            this.grbPaquetes.Controls.Add(this.lsbEstadoIngresado);
            this.grbPaquetes.Controls.Add(this.lblEstadoEntregado);
            this.grbPaquetes.Controls.Add(this.lblEstadoEnViaje);
            this.grbPaquetes.Controls.Add(this.lblEstadoIngresado);
            this.grbPaquetes.Location = new System.Drawing.Point(12, 12);
            this.grbPaquetes.Name = "grbPaquetes";
            this.grbPaquetes.Size = new System.Drawing.Size(776, 313);
            this.grbPaquetes.TabIndex = 1;
            this.grbPaquetes.TabStop = false;
            this.grbPaquetes.Text = "Estados Paquetes";
            // 
            // lsbEstadoEntregado
            // 
            this.lsbEstadoEntregado.FormattingEnabled = true;
            this.lsbEstadoEntregado.Location = new System.Drawing.Point(513, 69);
            this.lsbEstadoEntregado.Name = "lsbEstadoEntregado";
            this.lsbEstadoEntregado.Size = new System.Drawing.Size(232, 238);
            this.lsbEstadoEntregado.TabIndex = 5;
            // 
            // lsbEstadoEnViaje
            // 
            this.lsbEstadoEnViaje.FormattingEnabled = true;
            this.lsbEstadoEnViaje.Location = new System.Drawing.Point(262, 69);
            this.lsbEstadoEnViaje.Name = "lsbEstadoEnViaje";
            this.lsbEstadoEnViaje.Size = new System.Drawing.Size(232, 238);
            this.lsbEstadoEnViaje.TabIndex = 4;
            // 
            // lsbEstadoIngresado
            // 
            this.lsbEstadoIngresado.FormattingEnabled = true;
            this.lsbEstadoIngresado.Location = new System.Drawing.Point(6, 69);
            this.lsbEstadoIngresado.Name = "lsbEstadoIngresado";
            this.lsbEstadoIngresado.Size = new System.Drawing.Size(232, 238);
            this.lsbEstadoIngresado.TabIndex = 3;
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(529, 53);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 2;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(278, 53);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 1;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(21, 53);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 0;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Enabled = false;
            this.rtbMostrar.Location = new System.Drawing.Point(12, 331);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.Size = new System.Drawing.Size(474, 110);
            this.rtbMostrar.TabIndex = 3;
            this.rtbMostrar.Text = "";
            // 
            // grbPaquete
            // 
            this.grbPaquete.Controls.Add(this.btnMostrarTodos);
            this.grbPaquete.Controls.Add(this.btnAgregar);
            this.grbPaquete.Controls.Add(this.tbDireccion);
            this.grbPaquete.Controls.Add(this.label1);
            this.grbPaquete.Controls.Add(this.lblTrackingID);
            this.grbPaquete.Controls.Add(this.mtbTrackingID);
            this.grbPaquete.Location = new System.Drawing.Point(492, 331);
            this.grbPaquete.Name = "grbPaquete";
            this.grbPaquete.Size = new System.Drawing.Size(296, 110);
            this.grbPaquete.TabIndex = 4;
            this.grbPaquete.TabStop = false;
            this.grbPaquete.Text = "Paquete";
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(186, 71);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(104, 33);
            this.btnMostrarTodos.TabIndex = 10;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(186, 25);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 33);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(9, 78);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(171, 20);
            this.tbDireccion.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Direccion";
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(6, 16);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 6;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // mtbTrackingID
            // 
            this.mtbTrackingID.Location = new System.Drawing.Point(9, 32);
            this.mtbTrackingID.Mask = "000-000-0000";
            this.mtbTrackingID.Name = "mtbTrackingID";
            this.mtbTrackingID.Size = new System.Drawing.Size(171, 20);
            this.mtbTrackingID.TabIndex = 0;
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbPaquete);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.grbPaquetes);
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Michell.QuinteroHernandez.2D";
            this.grbPaquetes.ResumeLayout(false);
            this.grbPaquetes.PerformLayout();
            this.grbPaquete.ResumeLayout(false);
            this.grbPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPaquetes;
        private System.Windows.Forms.ListBox lsbEstadoEntregado;
        private System.Windows.Forms.ListBox lsbEstadoEnViaje;
        private System.Windows.Forms.ListBox lsbEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.GroupBox grbPaquete;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.MaskedTextBox mtbTrackingID;
    }
}
