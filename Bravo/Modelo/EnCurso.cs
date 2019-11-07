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

        public Estado crearEstadoFinalizada() {
            Estado proximoEstado = new Finalizada();
            return proximoEstado;
        }

        public override HistorialIntervencion crearHistorialIntervencion()
        {
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();
            return historialIntervencion;
        }
        public override void finalizar(Intervencion intervencion, int kmLlegada, int kmSalida)
        {
            //llamo a los otros metodos ,que no se si esta bien desde aca o de donde, que crean el estado e Historial y lo setean

            //Se crea instancia de Finalizada
            Estado proximoEstado = crearEstadoFinalizada();

            //Se crea instancia del nuevo historial seteando estado y fechaActual
            HistorialIntervencion historialIntervencion = crearHistorialIntervencion();
            historialIntervencion.estado = proximoEstado;
            historialIntervencion.intervencion = intervencion;
            historialIntervencion.fechaHoraDesde = DateTime.Today;

            //realiza la carga de datos provistos por el usuario de las dotaciones
            foreach (Dotacion dotacion in intervencion.dotaciones) {
                dotacion.intervencion = intervencion;
                dotacion.kmUnidadLlegada = kmLlegada;
                dotacion.kmUnidadSalida = kmSalida;
            }
        }
    }
}
