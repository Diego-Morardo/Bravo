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
        public override void crearProximoEstado() {
            Estado finalizada = new Finalizada();
            crearHistorialIntervencion(finalizada);
        }
        //El patron dice que no se pasan parametros pero como hago si no
        public override void crearHistorialIntervencion(Estado finalizada) {
            //deberia pasarle una intervencion a esta instancia ?
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();
            historialIntervencion.estado = finalizada;
        }

        public override void finalizar(Intervencion intervencion) {
            //no tengo idea que va aca xd
            crearProximoEstado();
            intervencion.dotacion.
        }

    }
}
