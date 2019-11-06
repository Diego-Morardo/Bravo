using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Dotacion
    {
        public int ID { get; set; }
        public Intervencion intervencion { get; set; }
        public UnidadMovil unidadMovil { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegada { get; set; }
        public int kmUnidadSalida { get; set; }
        public int kmUnidadLlegada { get; set; }
    }
}
