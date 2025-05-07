namespace Nomdad_Cafe
{
    partial class PantallaDesicion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDesicion = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelardesicion = new Nomdad_Cafe.botonredondo();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textboxtotaldesicion = new System.Windows.Forms.TextBox();
            this.textboxsubtotaldesicion = new System.Windows.Forms.TextBox();
            this.textboxivadesicion = new System.Windows.Forms.TextBox();
            this.logominimalista = new System.Windows.Forms.PictureBox();
            this.labelnomadacafe2 = new System.Windows.Forms.Label();
            this.btnterminarordendesicion = new System.Windows.Forms.Button();
            this.btnagregardesicion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logominimalista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.dataGridViewDesicion);
            this.panel1.Controls.Add(this.btncancelardesicion);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textboxtotaldesicion);
            this.panel1.Controls.Add(this.textboxsubtotaldesicion);
            this.panel1.Controls.Add(this.textboxivadesicion);
            this.panel1.Controls.Add(this.logominimalista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 845);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewDesicion
            // 
            this.dataGridViewDesicion.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.dataGridViewDesicion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDesicion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.dataGridViewDesicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDesicion.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDesicion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDesicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesicion.ColumnHeadersVisible = false;
            this.dataGridViewDesicion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Producto,
            this.Precio});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDesicion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDesicion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.dataGridViewDesicion.Location = new System.Drawing.Point(3, 140);
            this.dataGridViewDesicion.Name = "dataGridViewDesicion";
            this.dataGridViewDesicion.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDesicion.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDesicion.RowHeadersVisible = false;
            this.dataGridViewDesicion.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.dataGridViewDesicion.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDesicion.RowTemplate.Height = 24;
            this.dataGridViewDesicion.Size = new System.Drawing.Size(337, 431);
            this.dataGridViewDesicion.TabIndex = 41;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Producto
            // 
            this.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btncancelardesicion
            // 
            this.btncancelardesicion.BackColor = System.Drawing.Color.Black;
            this.btncancelardesicion.BorderRadius = 60;
            this.btncancelardesicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelardesicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelardesicion.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelardesicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.btncancelardesicion.Location = new System.Drawing.Point(43, 745);
            this.btncancelardesicion.Name = "btncancelardesicion";
            this.btncancelardesicion.Size = new System.Drawing.Size(258, 74);
            this.btncancelardesicion.TabIndex = 40;
            this.btncancelardesicion.Text = "CANCELAR";
            this.btncancelardesicion.UseVisualStyleBackColor = false;
            this.btncancelardesicion.Click += new System.EventHandler(this.btncancelar1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.textBox2.Location = new System.Drawing.Point(12, 680);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 38);
            this.textBox2.TabIndex = 38;
            this.textBox2.Text = "TOTAL";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.textBox5.Location = new System.Drawing.Point(12, 592);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 38);
            this.textBox5.TabIndex = 37;
            this.textBox5.Text = "SUBTOTAL";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.textBox6.Location = new System.Drawing.Point(12, 636);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(186, 38);
            this.textBox6.TabIndex = 36;
            this.textBox6.Text = "IVA";
            // 
            // textboxtotaldesicion
            // 
            this.textboxtotaldesicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.textboxtotaldesicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxtotaldesicion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxtotaldesicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.textboxtotaldesicion.Location = new System.Drawing.Point(145, 680);
            this.textboxtotaldesicion.Multiline = true;
            this.textboxtotaldesicion.Name = "textboxtotaldesicion";
            this.textboxtotaldesicion.Size = new System.Drawing.Size(186, 38);
            this.textboxtotaldesicion.TabIndex = 35;
            this.textboxtotaldesicion.Text = "$0";
            this.textboxtotaldesicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textboxsubtotaldesicion
            // 
            this.textboxsubtotaldesicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.textboxsubtotaldesicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxsubtotaldesicion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxsubtotaldesicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.textboxsubtotaldesicion.Location = new System.Drawing.Point(145, 592);
            this.textboxsubtotaldesicion.Multiline = true;
            this.textboxsubtotaldesicion.Name = "textboxsubtotaldesicion";
            this.textboxsubtotaldesicion.Size = new System.Drawing.Size(186, 38);
            this.textboxsubtotaldesicion.TabIndex = 34;
            this.textboxsubtotaldesicion.Text = "$0";
            this.textboxsubtotaldesicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textboxivadesicion
            // 
            this.textboxivadesicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.textboxivadesicion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxivadesicion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxivadesicion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(223)))));
            this.textboxivadesicion.Location = new System.Drawing.Point(145, 636);
            this.textboxivadesicion.Multiline = true;
            this.textboxivadesicion.Name = "textboxivadesicion";
            this.textboxivadesicion.Size = new System.Drawing.Size(186, 38);
            this.textboxivadesicion.TabIndex = 33;
            this.textboxivadesicion.Text = "$0";
            this.textboxivadesicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // logominimalista
            // 
            this.logominimalista.Image = global::Nomdad_Cafe.Properties.Resources.LOGO_MINIMALISTA_2;
            this.logominimalista.Location = new System.Drawing.Point(113, 12);
            this.logominimalista.Name = "logominimalista";
            this.logominimalista.Size = new System.Drawing.Size(114, 114);
            this.logominimalista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logominimalista.TabIndex = 30;
            this.logominimalista.TabStop = false;
            // 
            // labelnomadacafe2
            // 
            this.labelnomadacafe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelnomadacafe2.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 66F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomadacafe2.Location = new System.Drawing.Point(376, 12);
            this.labelnomadacafe2.Name = "labelnomadacafe2";
            this.labelnomadacafe2.Size = new System.Drawing.Size(601, 114);
            this.labelnomadacafe2.TabIndex = 19;
            this.labelnomadacafe2.Text = "N O M A D A   C A F E";
            // 
            // btnterminarordendesicion
            // 
            this.btnterminarordendesicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnterminarordendesicion.FlatAppearance.BorderSize = 0;
            this.btnterminarordendesicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnterminarordendesicion.Image = global::Nomdad_Cafe.Properties.Resources.terminar_pedido;
            this.btnterminarordendesicion.Location = new System.Drawing.Point(889, 223);
            this.btnterminarordendesicion.Name = "btnterminarordendesicion";
            this.btnterminarordendesicion.Size = new System.Drawing.Size(368, 475);
            this.btnterminarordendesicion.TabIndex = 21;
            this.btnterminarordendesicion.UseVisualStyleBackColor = true;
            this.btnterminarordendesicion.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnagregardesicion
            // 
            this.btnagregardesicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregardesicion.FlatAppearance.BorderSize = 0;
            this.btnagregardesicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregardesicion.Image = global::Nomdad_Cafe.Properties.Resources.Agregar_mas;
            this.btnagregardesicion.Location = new System.Drawing.Point(514, 206);
            this.btnagregardesicion.Name = "btnagregardesicion";
            this.btnagregardesicion.Size = new System.Drawing.Size(307, 475);
            this.btnagregardesicion.TabIndex = 20;
            this.btnagregardesicion.UseVisualStyleBackColor = true;
            this.btnagregardesicion.Click += new System.EventHandler(this.button1_Click);
            // 
            // PantallaDesicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(170)))), ((int)(((byte)(144)))));
            this.ClientSize = new System.Drawing.Size(1376, 845);
            this.Controls.Add(this.btnterminarordendesicion);
            this.Controls.Add(this.btnagregardesicion);
            this.Controls.Add(this.labelnomadacafe2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PantallaDesicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Desicion";
            this.Load += new System.EventHandler(this.PantallaDesicion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logominimalista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textboxtotaldesicion;
        private System.Windows.Forms.TextBox textboxsubtotaldesicion;
        private System.Windows.Forms.TextBox textboxivadesicion;
        private System.Windows.Forms.PictureBox logominimalista;
        private System.Windows.Forms.Label labelnomadacafe2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private botonredondo btncancelardesicion;
        private System.Windows.Forms.Button btnagregardesicion;
        private System.Windows.Forms.Button btnterminarordendesicion;
        private System.Windows.Forms.DataGridView dataGridViewDesicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}