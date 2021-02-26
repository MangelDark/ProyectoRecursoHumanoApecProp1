using CapaDato.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTO
{
   public class CN_Capacitancion
    {

        private CD_Capacitacion objeto = new CD_Capacitacion();


        public DataTable Mostrar()
        {
            return objeto.Mostrar();
        }
        public void Insertar(string descripcion, string nivelCapacitacion, string fechaDesde, string fechaHasta, string institucionCapacitacion)
        {
            objeto.Insertar(descripcion,Convert.ToChar(nivelCapacitacion),Convert.ToDateTime(fechaDesde).Date, Convert.ToDateTime(fechaHasta).Date,institucionCapacitacion);
        }
        public void Editar(string id, string descripcion, string nivelCapacitacion, string fechaDesde, string fechaHasta, string institucionCapacitacion)
        {
            objeto.Editar(Convert.ToInt32(id), descripcion, Convert.ToChar(nivelCapacitacion), Convert.ToDateTime(fechaDesde).Date, Convert.ToDateTime(fechaHasta).Date, institucionCapacitacion);
        }
        public void Elimiar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }

    }
}
