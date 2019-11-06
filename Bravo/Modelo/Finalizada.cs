using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Finalizada : Estado
    {
        public int ID { get; set; }

        public override void crearProximoEstado() {
            Estado finalizida = new Finalizada(); 
        }

        public override void crearHistorialIntervencion() {
            //deberia pasarle una intervencion a esta instancia
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();
        }

        public override void finalizar(Intervencion intervencion) {
            //no tengo idea que va aca xd
        }

    }
}
