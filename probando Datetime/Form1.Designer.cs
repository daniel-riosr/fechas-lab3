namespace probando_Datetime
{
    partial class Form1
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
            this.lblproxEndul = new System.Windows.Forms.Label();
            this.btnProximaEndulzada = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaActual = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.frecuencia = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.frecuencia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblproxEndul
            // 
            this.lblproxEndul.AutoSize = true;
            this.lblproxEndul.Location = new System.Drawing.Point(436, 227);
            this.lblproxEndul.Name = "lblproxEndul";
            this.lblproxEndul.Size = new System.Drawing.Size(0, 13);
            this.lblproxEndul.TabIndex = 0;
            // 
            // btnProximaEndulzada
            // 
            this.btnProximaEndulzada.Location = new System.Drawing.Point(497, 329);
            this.btnProximaEndulzada.Name = "btnProximaEndulzada";
            this.btnProximaEndulzada.Size = new System.Drawing.Size(155, 54);
            this.btnProximaEndulzada.TabIndex = 1;
            this.btnProximaEndulzada.Text = "proxima endulzada ";
            this.btnProximaEndulzada.UseVisualStyleBackColor = true;
            this.btnProximaEndulzada.Click += new System.EventHandler(this.btnProximaEndulzada_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(34, 41);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(212, 26);
            this.lblFechaInicio.TabIndex = 4;
            this.lblFechaInicio.Text = "porfavor ingrese la fecha de inicio del juego\r\nen el formato dd/mm/yy\r\n";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(263, 41);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(243, 26);
            this.lblFechaFin.TabIndex = 5;
            this.lblFechaFin.Text = "porfavor ingrese la fecha de finalizacion del juego \r\nen el formato dd/mm/yy\r\n";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.Location = new System.Drawing.Point(532, 41);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(256, 13);
            this.lblFrecuencia.TabIndex = 6;
            this.lblFrecuencia.Text = "porfavor ingrese la frecuencia de endulzadas en dias";
            // 
            // fechaInicio
            // 
            this.fechaInicio.CustomFormat = "dd/MM/yyyy";
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaInicio.Location = new System.Drawing.Point(37, 85);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(200, 20);
            this.fechaInicio.TabIndex = 8;
            // 
            // fechaFin
            // 
            this.fechaFin.CustomFormat = "dd/MM/yyyy";
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaFin.Location = new System.Drawing.Point(266, 85);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(200, 20);
            this.fechaFin.TabIndex = 9;
            // 
            // fechaActual
            // 
            this.fechaActual.CustomFormat = "dd/MM/yyyy";
            this.fechaActual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaActual.Location = new System.Drawing.Point(28, 232);
            this.fechaActual.Name = "fechaActual";
            this.fechaActual.Size = new System.Drawing.Size(200, 20);
            this.fechaActual.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "porfavor ingrese la fecha de hoy \r\npara calcular cuantos dias faltan \r\npara la pr" +
    "oxima endulzada\r\n\r\n";
            // 
            // frecuencia
            // 
            this.frecuencia.Location = new System.Drawing.Point(584, 85);
            this.frecuencia.Name = "frecuencia";
            this.frecuencia.Size = new System.Drawing.Size(139, 20);
            this.frecuencia.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frecuencia);
            this.Controls.Add(this.fechaActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.lblFrecuencia);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.btnProximaEndulzada);
            this.Controls.Add(this.lblproxEndul);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frecuencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblproxEndul;
        private System.Windows.Forms.Button btnProximaEndulzada;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFrecuencia;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown frecuencia;
    }
}

