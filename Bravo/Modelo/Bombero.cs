using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Bombero
    {
        public int ID { get; set; }
        public Intervencion intervencion { get; set; }
        public bool activo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        //Hace falta crear una clase dom
        public string calle { get; set; }
        public int nroCalle { get; set; }
        public int dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public Rol rol { get; set; }


    }
}
