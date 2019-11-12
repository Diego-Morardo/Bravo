using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Bombero
    {
        private int ID { get; set; }
        private Intervencion intervencion { get; set; }
        private bool activo { get; set; }
        private string nombre { get; set; }
        private string apellido { get; set; }
        
        private string calle { get; set; }
        private int nroCalle { get; set; }
        private int dni { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private string mail { get; set; }
        private int telefono { get; set; }
        private Rol rol { get; set; }


    }
}
