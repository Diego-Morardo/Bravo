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

        public Estado crearEstadoFinalizada()
        {
            Estado proximoEstado = new Finalizada();

            return proximoEstado;
        }

        public override HistorialIntervencion crearHistorialIntervencion(Estado estado, DateTime fechaActual)
        {
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();

            historialIntervencion.estado = estado;
            historialIntervencion.fechaHoraDesde = DateTime.Today;

            return historialIntervencion;
        }

        public override void finalizar(Intervencion intervencion, List<float> kmLlegada, List<DateTime> fechaActual)
        {

            //Se crea instancia de Finalizada
            Estado proximoEstado = crearEstadoFinalizada();

            //Se crea instancia del nuevo historial
            HistorialIntervencion historialIntervencion = crearHistorialIntervencion(proximoEstado, DateTime.Today);

            //Se setean kmLlegada y fechaLlegada para cada dotacion de la intervcion
            int i = 0;

            foreach (Dotacion dotacion in intervencion.dotaciones)
            {
                dotacion.setFechaLlegada(fechaActual[i]);
                dotacion.setKmUnidadLlegada(kmLlegada[i]);

                i++;
            }

            //Se agrega un nuevo historial a la lista de historiales de la intervencion
            intervencion.agregarHistorialIntervencion(historialIntervencion);

            intervencion.estadoActual = proximoEstado;
        }

        public override bool esEnCurso() => true;
        public override bool esCancelada() => false;
        public override bool esConvocada() => false;
        public override bool esFinalizada() => false;
        public override bool esPendiente() => false;
        public override bool esFirmada() => false;
        public override bool esAbortada() => false;

    }
}
