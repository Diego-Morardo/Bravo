
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Intervencion
    {
        public int ID { get; set; }
        public string calle { get; set; }
        public DateTime fechaHotaSolicitud { get; set; }
        public string nombreInformante { get; set; }
        public string apellidoInformante { get; set; }
        public string resumenSiniestroInformante { get; set; }
        public string resumenTrabajoEfectuado { get; set; }
        public int telefonoConectado { get; set; }
        public Estado estadoActual { get; set; }
        public List<HistorialIntervencion> historiales { get; set; }
        public List<Dotacion> dotaciones { get; set; }



        public void finalizar(Intervencion intervencion, List<float> km, List<DateTime> fechaActual)
        {
            estadoActual.finalizar(intervencion, km, fechaActual);
        }

        public void agregarHistorialIntervencion(HistorialIntervencion historial)
        {
            historiales = new List<HistorialIntervencion>();
            historiales.Add(historial);
        }

  
    }
}
