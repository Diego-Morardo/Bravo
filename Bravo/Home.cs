using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bravo.Modelo;

namespace Bravo
{
    public partial class Home : Form
    {
        string nomUser, nomRol;

        public Home(string user, string rol)
        {
            InitializeComponent();
            Home home = this;
            timer1.Enabled = true;
            nomUser = user;
            nomRol = rol;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = nomUser;
            lblRol.Text = nomRol;
            pbIntervenciones.ContextMenuStrip = menu;
        }

        public Form formActivo = null;
        public void abrirForm(Form form)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForms.Controls.Add(form);
            panelForms.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void PbIntervenciones_Click(object sender, EventArgs e)
        {
            Intervenciones intervenciones = new Intervenciones(nomRol);
            abrirForm(intervenciones);
        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void LblSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Close();
        }

        private void LblSesion_MouseHover(object sender, EventArgs e)
        {
            lblSesion.ForeColor = Color.FromArgb(230, 52, 52);
        }

        private void LblSesion_MouseLeave(object sender, EventArgs e)
        {
            lblSesion.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void cargarDGV()
        {
            //dgvIntervenciones.Rows.Cells
        }

        

        
    }
}
