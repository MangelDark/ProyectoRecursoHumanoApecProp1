using CapaDato.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTO
{
   public class CN_Candidato
    {

        private CD_Candidato objeto = new CD_Candidato();


        public DataTable Mostrar()
        {
            return objeto.Mostrar();
        }
        public void Insertar(string cedula, string nombre, string puestoAspira)
        {
            objeto.Insertar(cedula, nombre, puestoAspira);
        }
        public void Editar(string id, string cedula, string nombre, string puestoAspira)
        {
            objeto.Editar(Convert.ToInt32(id), cedula,nombre,puestoAspira);
        }
        public void Elimiar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }

    }
}
