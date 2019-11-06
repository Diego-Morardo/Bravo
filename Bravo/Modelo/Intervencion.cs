
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
        public int nroCalle { get; set; }
        public DateTime fechaHotaSolicitud { get; set; }
        //Creo una clase Informante?
        public string nombreInformante { get; set; }
        public string apellidoInformante { get; set; }
        public string resumenSiniestroInformante { get; set; }
        public string resumenTrabajoEfectuado { get; set; }
        public int telefonoConectado { get; set; }
        public Estado estado { get; set; }
        public IList<Dotacion> dotaciones { get; set; }

        public void finalizar(Intervencion intervencion) {
            estado.finalizar(intervencion);
        }

    }
}
