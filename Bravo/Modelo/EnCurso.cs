using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class EnCurso : Estado
    {
        public int ID { get; set; }

        public override void crearProximoEstado()
        {
            //vacio
        }

        public override void crearHistorialIntervencion(Estado estado)
        {
            //vacio
        }

        public override void finalizar(Intervencion intervencion)
        {
            //vacio
        }
    }
}
