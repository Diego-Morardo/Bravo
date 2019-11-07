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
    public partial class Intervenciones : Form
    {
        public Intervenciones()
        {
            InitializeComponent();
        }

        private void Intervenciones_Load(object sender, EventArgs e)
        {
            dgvDotaciones.Visible = false;
            lblDotaciones.Visible = false;
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            dgvDotaciones.Visible = true;
            dgvDotaciones.Left = 60; 
            dgvDotaciones.Top = 149;
            lblDotaciones.Visible = true;
            lblDotaciones.Left = 52;
            lblDotaciones.Top = 36;

            lblIntervencion.Visible = false;
            lblSelec.Visible = false;
            dgvIntervenciones.Visible = false;
            btnFinalizar.Visible = false;
        }

        
    }
}
