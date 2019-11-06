using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Finalizada : Estado
    {
        //capaz no 
        public int ID { get; set; }
        //retorno un estado para pasarselo al Historial nuevo, en patron dice void
        public override Estado crearProximoEstado()
        {
            return null;
        }

        public override HistorialIntervencion crearHistorialIntervencion()
        {
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();
            return historialIntervencion;
        }
        public override void finalizar(Intervencion intervencion, int kmLlegada, int kmSalida)
        {
        }

    }
}
