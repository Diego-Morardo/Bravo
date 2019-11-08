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
        List<Dotacion> dotas;

        public Intervenciones(string rol)
        {
            InitializeComponent();
            nomRol = rol;
            kms = new List<float>();
            fechas = new List<DateTime>();
            inters = new List<Intervencion>();
            dotas = new List<Dotacion>();
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
            btnCargarDatos.Visible = false;

            cargarGrillas();

            
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
                MessageBox.Show("Debe seleccionar una unica fila");
                return;
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
            btnCargarDatos.Visible = true;
        }

        private void cargarGrillas()
        {

            Dotacion dota1 = new Dotacion()
            {
                fechaSalida = DateTime.Today,
                kmUnidadSalida = 10548,
                unidadMovil = "AB 123 CD"
            };

            Dotacion dota2 = new Dotacion()
            {
                fechaSalida = DateTime.Today,
                kmUnidadSalida = 6546,
                unidadMovil = "AB 535 GF"
            };

            Dotacion dota3 = new Dotacion()
            {
                fechaSalida = DateTime.Today,
                kmUnidadSalida = 15480,
                unidadMovil = "CR 654 FT"
            };

            
            dotas.Add(dota1);
            dotas.Add(dota2);
            dotas.Add(dota3);

            EnCurso enCurso = new EnCurso();

            Intervencion inter1 = new Intervencion()
            {
                calle = "calle 51",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Incendio",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            Intervencion inter2 = new Intervencion()
            {
                calle = "calle 61",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Accidente de transito",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            Intervencion inter3 = new Intervencion()
            {
                calle = "calle 38",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Gatito en el arbol",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            Intervencion inter4 = new Intervencion()
            {
                calle = "calle 12",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Personas atrapadas en ascensor",
                dotaciones = dotas,
                estadoActual = enCurso
            };
 
            Intervencion inter5 = new Intervencion()
            {
                calle = "New York",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Esta aterrizando una nave de Thanos",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            Intervencion inter6 = new Intervencion()
            {
                calle = "Barrio Jardin",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Accidente de transito",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            Intervencion inter7 = new Intervencion()
            {
                calle = "Av. Simpre Viva",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Incendio",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            Intervencion inter8 = new Intervencion()
            {
                calle = "Nueva Cordoba",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Fuga de gas",
                dotaciones = dotas,
                estadoActual = enCurso
            };

            inters.Add(inter1);
            inters.Add(inter2);
            inters.Add(inter3);
            inters.Add(inter4);
            inters.Add(inter5);
            inters.Add(inter6);
            inters.Add(inter7);
            inters.Add(inter8);

            foreach (Intervencion inter in inters)
            {

                var fila = new string[] {
                    inter.fechaHotaSolicitud.ToString(),
                    inter.calle.ToString(),
                    inter.resumenSiniestroInformante.ToString()
                };

                dgvIntervenciones.Rows.Add(fila);
            }

            foreach (Dotacion dota in dotas)
            {

                var fila = new string[] {
                    dota.fechaSalida.ToString(),
                    dota.kmUnidadSalida.ToString(),
                    dota.unidadMovil.ToString(),
                };

                dgvDotaciones.Rows.Add(fila);
            }
        }

        

        private void BtnCargarDatos_Click(object sender, EventArgs e)
        {
            var kmsalir = dgvDotaciones.CurrentRow.Cells[1].Value.ToString();
            var um = dgvDotaciones.CurrentRow.Cells[2].Value.ToString();

            txtSalir.Text = kmsalir;
            txtUM.Text = um;
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            var km = float.Parse(txtKmLlegada.Text.ToString());
            kms.Add(km);
            fechas.Add(dtpFechaLlegada.Value);
        }

        private void BtnFinalizarIntervencion_Click(object sender, EventArgs e)
        {
            var seleccionada = dgvIntervenciones.SelectedRows;

            foreach (DataGridViewRow fila in seleccionada)
            {
                intervencion.calle = fila.Cells[1].Value.ToString();
                intervencion.resumenSiniestroInformante = fila.Cells[2].Value.ToString();
                intervencion.estadoActual = new EnCurso();
                intervencion.dotaciones = dotas;
            }

            intervencion.finalizar(intervencion, kms, fechas);
        }
    }
}
