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
        public Home()
        {
            InitializeComponent();
            Home home = this;
            diseño();
            timer1.Enabled = true;
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

        private void BtnIntervenciones_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(subMenuIntervencion);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void cargarDGV()
        {
            //dgvIntervenciones.Rows.Cells
        }
    }
}
