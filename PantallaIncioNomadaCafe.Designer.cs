namespace Nomdad_Cafe
{
    partial class PantallaInicio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btniniciarpantallainicio = new Nomdad_Cafe.botonredondo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nomdad_Cafe.Properties.Resources.LOGO__Y_NOMBRE_nhhhhhhhh1;
            this.pictureBox1.Location = new System.Drawing.Point(175, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1028, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btniniciarpantallainicio
            // 
            this.btniniciarpantallainicio.BackColor = System.Drawing.Color.Black;
            this.btniniciarpantallainicio.BorderRadius = 70;
            this.btniniciarpantallainicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btniniciarpantallainicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btniniciarpantallainicio.Font = new System.Drawing.Font("Elephant", 44F);
            this.btniniciarpantallainicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(170)))), ((int)(((byte)(144)))));
            this.btniniciarpantallainicio.Location = new System.Drawing.Point(443, 600);
            this.btniniciarpantallainicio.Name = "btniniciarpantallainicio";
            this.btniniciarpantallainicio.Size = new System.Drawing.Size(525, 152);
            this.btniniciarpantallainicio.TabIndex = 6;
            this.btniniciarpantallainicio.Text = "INICIAR";
            this.btniniciarpantallainicio.UseVisualStyleBackColor = false;
            this.btniniciarpantallainicio.Click += new System.EventHandler(this.btncancelar1_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(170)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1376, 845);
            this.Controls.Add(this.btniniciarpantallainicio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Inicio";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private botonredondo btniniciarpantallainicio;
    }
}

