using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Junio23.modelo
{
    public class UF
    {
        public string version { get; set; }
        public string autor { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string unidad_medida { get; set; }
        public List<Serie> serie { get; set; }
    }
}
