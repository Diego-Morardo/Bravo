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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnCargarDatos = new System.Windows.Forms.Button();
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
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizar.Location = new System.Drawing.Point(59, 390);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIntervenciones.ColumnHeadersHeight = 60;
            this.dgvIntervenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvIntervenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.ubicacion,
            this.siniestro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIntervenciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIntervenciones.EnableHeadersVisualStyles = false;
            this.dgvIntervenciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvIntervenciones.Location = new System.Drawing.Point(60, 149);
            this.dgvIntervenciones.Name = "dgvIntervenciones";
            this.dgvIntervenciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIntervenciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIntervenciones.RowHeadersVisible = false;
            this.dgvIntervenciones.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvIntervenciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDotaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDotaciones.ColumnHeadersHeight = 60;
            this.dgvDotaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDotaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaSalida,
            this.kmSalir,
            this.dominio});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDotaciones.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDotaciones.EnableHeadersVisualStyles = false;
            this.dgvDotaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgvDotaciones.Location = new System.Drawing.Point(274, 235);
            this.dgvDotaciones.Name = "dgvDotaciones";
            this.dgvDotaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDotaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDotaciones.RowHeadersVisible = false;
            this.dgvDotaciones.RowHeadersWidth = 100;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDotaciones.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDotaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDotaciones.Size = new System.Drawing.Size(469, 237);
            this.dgvDotaciones.TabIndex = 18;
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
            this.btnFinalizarIntervencion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarIntervencion.ForeColor = System.Drawing.Color.Black;
            this.btnFinalizarIntervencion.Location = new System.Drawing.Point(60, 421);
            this.btnFinalizarIntervencion.Name = "btnFinalizarIntervencion";
            this.btnFinalizarIntervencion.Size = new System.Drawing.Size(329, 25);
            this.btnFinalizarIntervencion.TabIndex = 20;
            this.btnFinalizarIntervencion.Text = "Finalizar Intervencion";
            this.btnFinalizarIntervencion.UseVisualStyleBackColor = false;
            this.btnFinalizarIntervencion.Click += new System.EventHandler(this.BtnFinalizarIntervencion_Click);
            // 
            // txtKmLlegada
            // 
            this.txtKmLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmLlegada.Location = new System.Drawing.Point(188, 295);
            this.txtKmLlegada.Name = "txtKmLlegada";
            this.txtKmLlegada.Size = new System.Drawing.Size(200, 23);
            this.txtKmLlegada.TabIndex = 21;
            // 
            // dtpFechaLlegada
            // 
            this.dtpFechaLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaLlegada.Location = new System.Drawing.Point(188, 331);
            this.dtpFechaLlegada.Name = "dtpFechaLlegada";
            this.dtpFechaLlegada.Size = new System.Drawing.Size(200, 23);
            this.dtpFechaLlegada.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DarkGray;
            this.lblFecha.Location = new System.Drawing.Point(55, 330);
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
            this.lblKmLlegada.Location = new System.Drawing.Point(55, 295);
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
            this.lblKmSalir.Location = new System.Drawing.Point(56, 260);
            this.lblKmSalir.Name = "lblKmSalir";
            this.lblKmSalir.Size = new System.Drawing.Size(88, 21);
            this.lblKmSalir.TabIndex = 26;
            this.lblKmSalir.Text = "Km Al Salir";
            // 
            // txtSalir
            // 
            this.txtSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalir.Location = new System.Drawing.Point(189, 260);
            this.txtSalir.Name = "txtSalir";
            this.txtSalir.ReadOnly = true;
            this.txtSalir.Size = new System.Drawing.Size(200, 23);
            this.txtSalir.TabIndex = 25;
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUM.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUM.Location = new System.Drawing.Point(56, 225);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(112, 21);
            this.lblUM.TabIndex = 28;
            this.lblUM.Text = "Unidad Movil";
            // 
            // txtUM
            // 
            this.txtUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUM.Location = new System.Drawing.Point(189, 225);
            this.txtUM.Name = "txtUM";
            this.txtUM.ReadOnly = true;
            this.txtUM.Size = new System.Drawing.Size(200, 23);
            this.txtUM.TabIndex = 27;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.ForeColor = System.Drawing.Color.Black;
            this.btnCargarDatos.Location = new System.Drawing.Point(482, 220);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(158, 25);
            this.btnCargarDatos.TabIndex = 29;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.BtnCargarDatos_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.Black;
            this.btnCargar.Location = new System.Drawing.Point(59, 361);
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
            this.Controls.Add(this.btnCargarDatos);
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
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnCargar;
    }
}