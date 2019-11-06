using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Sesion
    {
        public int ID { get; set; }
        public Usuario usuario { get; set; }
        public DateTime horaDesde { get; set; }
        public DateTime horaHasta { get; set; }

    }
}
