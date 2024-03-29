﻿using System;
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

        public HistorialIntervencion crearHistorialIntervencion(Estado estado, DateTime fechaActual)
        {
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();

            historialIntervencion.estado = estado;
            historialIntervencion.fechaHoraDesde = DateTime.Today;

            return historialIntervencion;
        }
        public abstract void finalizar(Intervencion intervencion, List<float> kmLlegada, List<DateTime> fechaActual);
        public abstract bool esEnCurso();
        public abstract bool esConvocada();
        public abstract bool esPendiente();
        public abstract bool esCancelada();
        public abstract bool esFirmada();
        public abstract bool esFinalizada();
        public abstract bool esAbortada();
    }
}
