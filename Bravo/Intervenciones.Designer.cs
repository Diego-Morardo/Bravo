namespace Bravo
{
    partial class Intervenciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblIntervencion = new System.Windows.Forms.Label();
            this.dgvIntervenciones = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siniestro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSelec = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dgvDotaciones = new System.Windows.Forms.DataGridView();
            this.fechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmSalir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDotaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Black;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(59, 404);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(380, 32);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // lblIntervencion
            // 
            this.lblIntervencion.AutoSize = true;
            this.lblIntervencion.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervencion.ForeColor = System.Drawing.Color.White;
            this.lblIntervencion.Location = new System.Drawing.Point(52, 36);
            this.lblIntervencion.Name = "lblIntervencion";
            this.lblIntervencion.Size = new System.Drawing.Size(435, 40);
            this.lblIntervencion.TabIndex = 7;
            this.lblIntervencion.Text = "Intervenciones en curso...";
            // 
            // dgvIntervenciones
            // 
            this.dgvIntervenciones.AllowUserToAddRows = false;
            this.dgvIntervenciones.AllowUserToDeleteRows = false;
            this.dgvIntervenciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIntervenciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIntervenciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvIntervenciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntervenciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvIntervenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.ubicacion,
            this.siniestro});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervenciones.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvIntervenciones.EnableHeadersVisualStyles = false;
            this.dgvIntervenciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvIntervenciones.Location = new System.Drawing.Point(60, 149);
            this.dgvIntervenciones.Name = "dgvIntervenciones";
            this.dgvIntervenciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervenciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvIntervenciones.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIntervenciones.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvIntervenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervenciones.Size = new System.Drawing.Size(383, 237);
            this.dgvIntervenciones.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            this.fecha.Width = 56;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicación";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            this.ubicacion.Width = 109;
            // 
            // siniestro
            // 
            this.siniestro.HeaderText = "Siniestro";
            this.siniestro.Name = "siniestro";
            this.siniestro.ReadOnly = true;
            this.siniestro.Width = 103;
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelec.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSelec.Location = new System.Drawing.Point(56, 92);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(362, 21);
            this.lblSelec.TabIndex = 10;
            this.lblSelec.Text = "Seleccione la intervención que desee finalizar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(0, -2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // dgvDotaciones
            // 
            this.dgvDotaciones.AllowUserToAddRows = false;
            this.dgvDotaciones.AllowUserToDeleteRows = false;
            this.dgvDotaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDotaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDotaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvDotaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDotaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDotaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDotaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaSalida,
            this.kmSalir,
            this.dominio});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDotaciones.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDotaciones.EnableHeadersVisualStyles = false;
            this.dgvDotaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvDotaciones.Location = new System.Drawing.Point(310, 199);
            this.dgvDotaciones.Name = "dgvDotaciones";
            this.dgvDotaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDotaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDotaciones.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDotaciones.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDotaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDotaciones.Size = new System.Drawing.Size(469, 237);
            this.dgvDotaciones.TabIndex = 18;
            // 
            // fechaSalida
            // 
            this.fechaSalida.HeaderText = "Fecha y Hora Salida";
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.ReadOnly = true;
            this.fechaSalida.Width = 193;
            // 
            // kmSalir
            // 
            this.kmSalir.HeaderText = "Km al Salir";
            this.kmSalir.Name = "kmSalir";
            this.kmSalir.ReadOnly = true;
            this.kmSalir.Width = 120;
            // 
            // dominio
            // 
            this.dominio.HeaderText = "Unidad Móvil";
            this.dominio.Name = "dominio";
            this.dominio.ReadOnly = true;
            this.dominio.Width = 136;
            // 
            // lblDotaciones
            // 
            this.lblDotaciones.AutoSize = true;
            this.lblDotaciones.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotaciones.ForeColor = System.Drawing.Color.White;
            this.lblDotaciones.Location = new System.Drawing.Point(303, 149);
            this.lblDotaciones.Name = "lblDotaciones";
            this.lblDotaciones.Size = new System.Drawing.Size(206, 40);
            this.lblDotaciones.TabIndex = 19;
            this.lblDotaciones.Text = "Dotaciones";
            // 
            // Intervenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.lblDotaciones);
            this.Controls.Add(this.dgvDotaciones);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblSelec);
            this.Controls.Add(this.dgvIntervenciones);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblIntervencion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Intervenciones";
            this.Text = "Intervenciones";
            this.Load += new System.EventHandler(this.Intervenciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblIntervencion;
        private System.Windows.Forms.DataGridView dgvIntervenciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn siniestro;
        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvDotaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dominio;
        private System.Windows.Forms.Label lblDotaciones;
    }
}