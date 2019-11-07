using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    abstract class Estado
    {
        public int ID { get; set; }
        public string ambito { get; set; }
        public string descripcion { get; set; }
        public string nombre { get; set; }
        //me parece que tiene que devolver un estado para setearle la intervencion
        //public abstract Estado crearProximoEstado();

        public abstract HistorialIntervencion crearHistorialIntervencion();
        //segun el patron este metodo se define recien en Finalizada, pero como lo llamo desde el form si no me reconoce estado.finalizar() ?
        public abstract void finalizar(Intervencion intervencion, int kmLlegada, int kmSalida);

    }
}
