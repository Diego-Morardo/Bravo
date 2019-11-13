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
    public partial class Intervenciones : Form
    {
        Intervencion intervencion = new Intervencion();

        string nomRol;
        List<float> kms;
        List<DateTime> fechas;
        List<Intervencion> inters;
        GestorFinalizarIntervención GestorFinalizarIntervención;

        public Intervenciones(string rol)
        {
            InitializeComponent();
            nomRol = rol;
            kms = new List<float>();
            fechas = new List<DateTime>();

            GestorFinalizarIntervención = new GestorFinalizarIntervención();
            inters = GestorFinalizarIntervención.obtenerIntervencionesEnCurso();
        }

        private void Intervenciones_Load(object sender, EventArgs e)
        {
            dgvDotaciones.Visible = false;
            lblDotaciones.Visible = false;
            btnFinalizarIntervencion.Visible = false;
            lblFecha.Visible = false;
            lblKmLlegada.Visible = false;
            txtKmLlegada.Visible = false;
            dtpFechaLlegada.Visible = false;
            lblKmSalir.Visible = false;
            txtSalir.Visible = false;
            lblUM.Visible = false;
            txtUM.Visible = false;

            btnCargar.Visible = false;

            txtSalir.Enabled = false;
            txtUM.Enabled = false;

            cargarGrillaIntervenciones();            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            var seleccionada = dgvIntervenciones.SelectedRows;
            if (seleccionada.Count == 0 || seleccionada.Count > 1)
            {
                MessageBox.Show("Debe seleccionar una unica intervención");
                return;
            }

            var id = int.Parse(dgvIntervenciones.CurrentRow.Cells[0].Value.ToString());

            foreach (Intervencion inter in inters)
            {
                if (inter.ID == id)
                {
                    intervencion = inter;
                }
            }

            foreach (Dotacion dota in intervencion.dotaciones)
            {
                var fila = new string[] {
                    dota.ID.ToString(),
                    dota.fechaSalida.ToString(),
                    dota.kmUnidadSalida.ToString(),
                    dota.unidadMovil.ToString(),
                };

                dgvDotaciones.Rows.Add(fila);
            }

            dgvDotaciones.Visible = true;
            dgvDotaciones.Left = 80; 
            dgvDotaciones.Top = 149;
            lblDotaciones.Visible = true;
            lblDotaciones.Left = 80;
            lblDotaciones.Top = 50;

            lblIntervencion.Visible = false;
            lblSelec.Visible = false;
            dgvIntervenciones.Visible = false;
            btnFinalizar.Visible = false;

            btnFinalizarIntervencion.Visible = true;
            lblFecha.Visible = true;
            lblKmLlegada.Visible = true;
            txtKmLlegada.Visible = true;
            dtpFechaLlegada.Visible = true;

            lblKmSalir.Visible = true;
            txtSalir.Visible = true;
            lblUM.Visible = true;
            txtUM.Visible = true;

            btnCargar.Visible = true;
        }

        private void cargarGrillaIntervenciones()
        {
          foreach (Intervencion inter in inters)
            {
                var fila = new string[] {
                    inter.ID.ToString(),
                    inter.fechaHotaSolicitud.ToString(),
                    inter.calle.ToString(),
                    inter.resumenSiniestroInformante.ToString()
                };

                dgvIntervenciones.Rows.Add(fila);                
            }           
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            Dotacion dotacion = new Dotacion();

            var id = int.Parse(dgvDotaciones.CurrentRow.Cells[0].Value.ToString());

            foreach (Dotacion dota in intervencion.dotaciones)
            {
                if (dota.ID == id)
                {
                    dotacion = dota;
                }
            }

            var kmLlegada = float.Parse(txtKmLlegada.Text.ToString());
            var kmSalida = dotacion.kmUnidadSalida;

            if(GestorFinalizarIntervención.validarKilometraje(kmLlegada, kmSalida))
            {
                kms.Add(kmLlegada);
                fechas.Add(dtpFechaLlegada.Value);

                MessageBox.Show("Datos cargados con exito");
            }
            else
            {
                MessageBox.Show("Kilometraje de llegada debe ser mayor a kilometraje de salida");
                return;
            }

            txtKmLlegada.Text = "";
            txtSalir.Text = "";
            txtUM.Text = "";
        }

        private void BtnFinalizarIntervencion_Click(object sender, EventArgs e)
        {
            if(kms.Count() < 3)
            {
                MessageBox.Show("Faltan dotaciones por actualizar. \nPor favor, ingrese los datos solicitados.");
                return;
            }

            //GestorFinalizarIntervención.registrarFinalizacion(intervencion, kms, fechas);
            intervencion.finalizar(intervencion, kms, fechas);

            MessageBox.Show("Intervencion finalizada con exito. \n\nNuevo Estado: " + intervencion.estadoActual.ToString()) ;

            this.Close();
        }

        private void DgvDotaciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var kmsalir = dgvDotaciones.CurrentRow.Cells[2].Value.ToString();
            var um = dgvDotaciones.CurrentRow.Cells[3].Value.ToString();

            txtSalir.Text = kmsalir;
            txtUM.Text = um;
        }
    }
}
