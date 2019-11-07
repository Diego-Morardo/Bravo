namespace Bravo
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.subMenuUM = new System.Windows.Forms.Panel();
            this.btnUM = new System.Windows.Forms.Button();
            this.subMenuIntervencion = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnIntervenciones = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbIntervenciones = new System.Windows.Forms.PictureBox();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSesion = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.subMenuIntervencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntervenciones)).BeginInit();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.subMenuUM);
            this.panelMenu.Controls.Add(this.btnUM);
            this.panelMenu.Controls.Add(this.subMenuIntervencion);
            this.panelMenu.Controls.Add(this.btnIntervenciones);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 498);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 421);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(193, 50);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // subMenuUM
            // 
            this.subMenuUM.BackColor = System.Drawing.Color.Transparent;
            this.subMenuUM.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUM.Location = new System.Drawing.Point(0, 380);
            this.subMenuUM.Name = "subMenuUM";
            this.subMenuUM.Size = new System.Drawing.Size(193, 41);
            this.subMenuUM.TabIndex = 4;
            // 
            // btnUM
            // 
            this.btnUM.BackColor = System.Drawing.Color.Transparent;
            this.btnUM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUM.FlatAppearance.BorderSize = 0;
            this.btnUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUM.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUM.Location = new System.Drawing.Point(0, 330);
            this.btnUM.Name = "btnUM";
            this.btnUM.Size = new System.Drawing.Size(193, 50);
            this.btnUM.TabIndex = 3;
            this.btnUM.Text = "Unidades Móviles";
            this.btnUM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUM.UseVisualStyleBackColor = false;
            // 
            // subMenuIntervencion
            // 
            this.subMenuIntervencion.BackColor = System.Drawing.Color.Transparent;
            this.subMenuIntervencion.Controls.Add(this.btnFinalizar);
            this.subMenuIntervencion.Controls.Add(this.btnNueva);
            this.subMenuIntervencion.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuIntervencion.Location = new System.Drawing.Point(0, 246);
            this.subMenuIntervencion.Name = "subMenuIntervencion";
            this.subMenuIntervencion.Size = new System.Drawing.Size(193, 84);
            this.subMenuIntervencion.TabIndex = 2;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(0, 35);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnFinalizar.Size = new System.Drawing.Size(193, 35);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnNueva
            // 
            this.btnNueva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.Location = new System.Drawing.Point(0, 0);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNueva.Size = new System.Drawing.Size(193, 35);
            this.btnNueva.TabIndex = 0;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNueva.UseVisualStyleBackColor = true;
            // 
            // btnIntervenciones
            // 
            this.btnIntervenciones.BackColor = System.Drawing.Color.Transparent;
            this.btnIntervenciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIntervenciones.FlatAppearance.BorderSize = 0;
            this.btnIntervenciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntervenciones.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntervenciones.Location = new System.Drawing.Point(0, 196);
            this.btnIntervenciones.Name = "btnIntervenciones";
            this.btnIntervenciones.Size = new System.Drawing.Size(193, 50);
            this.btnIntervenciones.TabIndex = 1;
            this.btnIntervenciones.Text = "Bomberos";
            this.btnIntervenciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntervenciones.UseVisualStyleBackColor = false;
            this.btnIntervenciones.Click += new System.EventHandler(this.BtnIntervenciones_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 196);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelForms
            // 
            this.panelForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelForms.Controls.Add(this.pictureBox1);
            this.panelForms.Controls.Add(this.pictureBox4);
            this.panelForms.Controls.Add(this.pbIntervenciones);
            this.panelForms.Controls.Add(this.panelUsuario);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForms.Location = new System.Drawing.Point(193, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1092, 498);
            this.panelForms.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(428, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(286, 184);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pbIntervenciones
            // 
            this.pbIntervenciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIntervenciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIntervenciones.Image = ((System.Drawing.Image)(resources.GetObject("pbIntervenciones.Image")));
            this.pbIntervenciones.Location = new System.Drawing.Point(80, 33);
            this.pbIntervenciones.Name = "pbIntervenciones";
            this.pbIntervenciones.Size = new System.Drawing.Size(283, 184);
            this.pbIntervenciones.TabIndex = 8;
            this.pbIntervenciones.TabStop = false;
            this.pbIntervenciones.Click += new System.EventHandler(this.PbIntervenciones_Click);
            // 
            // panelUsuario
            // 
            this.panelUsuario.Controls.Add(this.lblSesion);
            this.panelUsuario.Controls.Add(this.lblRol);
            this.panelUsuario.Controls.Add(this.lblHora);
            this.panelUsuario.Controls.Add(this.lblFecha);
            this.panelUsuario.Controls.Add(this.lblNombreUsuario);
            this.panelUsuario.Controls.Add(this.pbUsuario);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUsuario.Location = new System.Drawing.Point(0, 408);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(1092, 90);
            this.panelUsuario.TabIndex = 1;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(78, 35);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(89, 21);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "RolUsuario";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(955, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(84, 37);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "hora";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(870, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "fecha";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(78, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(129, 21);
            this.lblNombreUsuario.TabIndex = 1;
            this.lblNombreUsuario.Text = "NombreUsuario";
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUsuario.BackgroundImage")));
            this.pbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbUsuario.Location = new System.Drawing.Point(6, 19);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(61, 50);
            this.pbUsuario.TabIndex = 0;
            this.pbUsuario.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(770, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSesion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.ForeColor = System.Drawing.Color.White;
            this.lblSesion.Location = new System.Drawing.Point(78, 61);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(110, 21);
            this.lblSesion.TabIndex = 5;
            this.lblSesion.Text = "Cerrar Sesion";
            this.lblSesion.Click += new System.EventHandler(this.LblSesion_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 498);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Bravo";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.subMenuIntervencion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntervenciones)).EndInit();
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIntervenciones;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel subMenuUM;
        private System.Windows.Forms.Button btnUM;
        private System.Windows.Forms.Panel subMenuIntervencion;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.PictureBox pbIntervenciones;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSesion;
    }
}

