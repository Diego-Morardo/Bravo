using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class HistorialIntervencion
    {
        public int ID { get; set; }
        public Intervencion intervencion { get; set; }
        public Estado estado { get; set; }
        public DateTime fechaHoraDesde { get; set; }

    }
}
