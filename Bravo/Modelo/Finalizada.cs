﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Finalizada : Estado
    {
        public int ID { get; set; }

        public override HistorialIntervencion crearHistorialIntervencion(Estado estado, DateTime fechaActual)
        {
            HistorialIntervencion historialIntervencion = new HistorialIntervencion();
            return historialIntervencion;
        }
        public override void finalizar(Intervencion intervencion, List<float> kmLlegada, List<DateTime> fechaActual)
        {
        }

    }
}
