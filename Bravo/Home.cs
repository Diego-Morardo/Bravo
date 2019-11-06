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
        }

        public void diseño()
        {
            subMenuIntervencion.Visible = false;
        }

        private void esconderSubMenu()
        {
            if (subMenuIntervencion.Visible == true)
                subMenuIntervencion.Visible = false;
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
    }
}
