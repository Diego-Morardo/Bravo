﻿namespace Bravo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnFinalizarIntervencion = new System.Windows.Forms.Button();
            this.txtKmLlegada = new System.Windows.Forms.TextBox();
            this.dtpFechaLlegada = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblKmLlegada = new System.Windows.Forms.Label();
            this.lblKmSalir = new System.Windows.Forms.Label();
            this.txtSalir = new System.Windows.Forms.TextBox();
            this.lblUM = new System.Windows.Forms.Label();
            this.txtUM = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervenciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDotaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnFinalizar.Location = new System.Drawing.Point(59, 381);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(380, 25);
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
            this.dgvIntervenciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIntervenciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvIntervenciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvIntervenciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIntervenciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvIntervenciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvIntervenciones.ColumnHeadersHeight = 60;
            this.dgvIntervenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIntervenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.ubicacion,
            this.siniestro});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervenciones.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvIntervenciones.EnableHeadersVisualStyles = false;
            this.dgvIntervenciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvIntervenciones.Location = new System.Drawing.Point(60, 149);
            this.dgvIntervenciones.Name = "dgvIntervenciones";
            this.dgvIntervenciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervenciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvIntervenciones.RowHeadersVisible = false;
            this.dgvIntervenciones.RowHeadersWidth = 30;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIntervenciones.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvIntervenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIntervenciones.Size = new System.Drawing.Size(383, 206);
            this.dgvIntervenciones.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Visible = false;
            // 
            // ubicacion
            // 
            this.ubicacion.HeaderText = "Ubicación";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            // 
            // siniestro
            // 
            this.siniestro.HeaderText = "Siniestro";
            this.siniestro.Name = "siniestro";
            this.siniestro.ReadOnly = true;
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
            this.dgvDotaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDotaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDotaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvDotaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDotaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDotaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDotaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvDotaciones.ColumnHeadersHeight = 60;
            this.dgvDotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDotaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaSalida,
            this.kmSalir,
            this.dominio});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDotaciones.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvDotaciones.EnableHeadersVisualStyles = false;
            this.dgvDotaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvDotaciones.Location = new System.Drawing.Point(274, 235);
            this.dgvDotaciones.Name = "dgvDotaciones";
            this.dgvDotaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDotaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgvDotaciones.RowHeadersVisible = false;
            this.dgvDotaciones.RowHeadersWidth = 100;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDotaciones.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvDotaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDotaciones.Size = new System.Drawing.Size(469, 237);
            this.dgvDotaciones.TabIndex = 18;
            this.dgvDotaciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDotaciones_CellMouseClick);
            // 
            // fechaSalida
            // 
            this.fechaSalida.HeaderText = "Fecha y Hora Salida";
            this.fechaSalida.Name = "fechaSalida";
            this.fechaSalida.ReadOnly = true;
            // 
            // kmSalir
            // 
            this.kmSalir.HeaderText = "Km al Salir";
            this.kmSalir.Name = "kmSalir";
            this.kmSalir.ReadOnly = true;
            // 
            // dominio
            // 
            this.dominio.HeaderText = "Unidad Móvil";
            this.dominio.Name = "dominio";
            this.dominio.ReadOnly = true;
            // 
            // lblDotaciones
            // 
            this.lblDotaciones.AutoSize = true;
            this.lblDotaciones.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDotaciones.ForeColor = System.Drawing.Color.White;
            this.lblDotaciones.Location = new System.Drawing.Point(53, 36);
            this.lblDotaciones.Name = "lblDotaciones";
            this.lblDotaciones.Size = new System.Drawing.Size(206, 40);
            this.lblDotaciones.TabIndex = 19;
            this.lblDotaciones.Text = "Dotaciones";
            // 
            // btnFinalizarIntervencion
            // 
            this.btnFinalizarIntervencion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnFinalizarIntervencion.FlatAppearance.BorderSize = 0;
            this.btnFinalizarIntervencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarIntervencion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarIntervencion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnFinalizarIntervencion.Location = new System.Drawing.Point(51, 393);
            this.btnFinalizarIntervencion.Name = "btnFinalizarIntervencion";
            this.btnFinalizarIntervencion.Size = new System.Drawing.Size(329, 25);
            this.btnFinalizarIntervencion.TabIndex = 20;
            this.btnFinalizarIntervencion.Text = "Finalizar Intervencion";
            this.btnFinalizarIntervencion.UseVisualStyleBackColor = false;
            this.btnFinalizarIntervencion.Click += new System.EventHandler(this.BtnFinalizarIntervencion_Click);
            // 
            // txtKmLlegada
            // 
            this.txtKmLlegada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtKmLlegada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKmLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmLlegada.ForeColor = System.Drawing.Color.White;
            this.txtKmLlegada.Location = new System.Drawing.Point(180, 295);
            this.txtKmLlegada.Name = "txtKmLlegada";
            this.txtKmLlegada.Size = new System.Drawing.Size(200, 23);
            this.txtKmLlegada.TabIndex = 21;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaLlegada.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dtpFechaLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLlegada.Location = new System.Drawing.Point(180, 331);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaLlegada.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFecha.Location = new System.Drawing.Point(47, 330);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(127, 21);
            this.lblFecha.TabIndex = 23;
            this.lblFecha.Text = "Fecha Llegada";
            // 
            // lblKmLlegada
            // 
            this.lblKmLlegada.AutoSize = true;
            this.lblKmLlegada.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmLlegada.ForeColor = System.Drawing.Color.DarkGray;
            this.lblKmLlegada.Location = new System.Drawing.Point(47, 295);
            this.lblKmLlegada.Name = "lblKmLlegada";
            this.lblKmLlegada.Size = new System.Drawing.Size(107, 21);
            this.lblKmLlegada.TabIndex = 24;
            this.lblKmLlegada.Text = "Km Al Volver";
            // 
            // lblKmSalir
            // 
            this.lblKmSalir.AutoSize = true;
            this.lblKmSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmSalir.ForeColor = System.Drawing.Color.DarkGray;
            this.lblKmSalir.Location = new System.Drawing.Point(48, 260);
            this.lblKmSalir.Name = "lblKmSalir";
            this.lblKmSalir.Size = new System.Drawing.Size(88, 21);
            this.lblKmSalir.TabIndex = 26;
            this.lblKmSalir.Text = "Km Al Salir";
            // 
            // txtSalir
            // 
            this.txtSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalir.ForeColor = System.Drawing.Color.White;
            this.txtSalir.Location = new System.Drawing.Point(181, 260);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.Size = new System.Drawing.Size(199, 23);
            this.txtSalir.TabIndex = 25;
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUM.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUM.Location = new System.Drawing.Point(48, 225);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(112, 21);
            this.lblUM.TabIndex = 28;
            this.lblUM.Text = "Unidad Movil";
            // 
            // txtUM
            // 
            this.txtUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txtUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUM.ForeColor = System.Drawing.Color.White;
            this.txtUM.Location = new System.Drawing.Point(181, 225);
            this.txtUM.Name = "txtUM";
            this.txtUM.Size = new System.Drawing.Size(199, 23);
            this.txtUM.TabIndex = 27;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCargar.Location = new System.Drawing.Point(51, 361);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(329, 25);
            this.btnCargar.TabIndex = 30;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // Intervenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.txtUM);
            this.Controls.Add(this.lblKmSalir);
            this.Controls.Add(this.txtSalir);
            this.Controls.Add(this.lblKmLlegada);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaLlegada);
            this.Controls.Add(this.txtKmLlegada);
            this.Controls.Add(this.btnFinalizarIntervencion);
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
        private System.Windows.Forms.Button btnFinalizarIntervencion;
        private System.Windows.Forms.TextBox txtKmLlegada;
        private System.Windows.Forms.DateTimePicker dtpFechaLlegada;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblKmLlegada;
        private System.Windows.Forms.Label lblKmSalir;
        private System.Windows.Forms.TextBox txtSalir;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.TextBox txtUM;
        private System.Windows.Forms.Button btnCargar;
    }
}