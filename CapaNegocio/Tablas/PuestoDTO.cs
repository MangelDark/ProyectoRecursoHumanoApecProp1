using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Tablas
{
   public class PuestoDTO
    {
        public int Id { get;  set; }
        public string Nombre { get;  set; }
        public double MaximoSalario { get;  set; }
        public double MinimoSalario { get;  set; }
        public int Estatus { get;  set; }
    }
}
