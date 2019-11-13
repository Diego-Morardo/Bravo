using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo.Modelo
{
    class Dotacion
    {
        public int ID { get; set; }
        public string unidadMovil { get; set; }
        public DateTime fechaSalida { get; set; }
        public DateTime fechaLlegada { get; set; }
        public float kmUnidadSalida { get; set; }
        public float kmUnidadLlegada { get; set; } 
        
        public void setKmUnidadLlegada(float km)
        {
            kmUnidadLlegada = km;
        }

        public void setKmUnidadSalida(float km)
        {
            kmUnidadSalida = km;
        }

        public void setFechaLlegada(DateTime fecha)
        {
            fechaLlegada = fecha;
        }

        public void setFechaSalida(DateTime fecha)
        {
            fechaSalida = fecha;
        }
    }
}
