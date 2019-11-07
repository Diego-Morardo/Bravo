using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bravo
{
    public partial class Home : Form
    {
        string nomUser, nomRol;

        public Home(string user, string rol)
        {
            InitializeComponent();
            Home home = this;
            diseño();
            timer1.Enabled = true;
            nomUser = user;
            nomRol = rol;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = nomUser;
            lblRol.Text = nomRol;
        }

        public void diseño()
        {
            subMenuIntervencion.Visible = false;
            subMenuUM.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (subMenuIntervencion.Visible == true)
                subMenuIntervencion.Visible = false;
            if (subMenuUM.Visible == true)
                subMenuUM.Visible = false;
        }

        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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
            Intervenciones intervenciones = new Intervenciones();
            abrirForm(intervenciones);
        }

        private void BtnIntervenciones_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuIntervencion);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void LblSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void cargarDGV()
        {
            //dgvIntervenciones.Rows.Cells
        }

        
    }
}
