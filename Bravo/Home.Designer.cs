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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.subMenuIntervencion = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnIntervenciones = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelForms = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.subMenuIntervencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.subMenuIntervencion);
            this.panelMenu.Controls.Add(this.btnIntervenciones);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 484);
            this.panelMenu.TabIndex = 0;
            // 
            // subMenuIntervencion
            // 
            this.subMenuIntervencion.BackColor = System.Drawing.Color.Transparent;
            this.subMenuIntervencion.Controls.Add(this.btnFinalizar);
            this.subMenuIntervencion.Controls.Add(this.btnNueva);
            this.subMenuIntervencion.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuIntervencion.Location = new System.Drawing.Point(0, 246);
            this.subMenuIntervencion.Name = "subMenuIntervencion";
            this.subMenuIntervencion.Size = new System.Drawing.Size(193, 100);
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
            this.btnIntervenciones.Text = "Intervenciones";
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
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelForms.Location = new System.Drawing.Point(193, 0);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(607, 484);
            this.panelForms.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(212, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Bravo";
            this.panelMenu.ResumeLayout(false);
            this.subMenuIntervencion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIntervenciones;
        private System.Windows.Forms.Panel subMenuIntervencion;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnNueva;
    }
}

