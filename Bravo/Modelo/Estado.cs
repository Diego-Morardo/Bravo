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

    }
}
