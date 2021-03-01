using CapaDato.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTO
{
   public class CN_ExperienciaLaboral
    {
        private CD_ExperienciaLaboral objeto = new CD_ExperienciaLaboral();


        public DataTable Mostrar()
        {
            return objeto.Mostrar();
        }
        public void Insertar(string id_Candidato,string puesto, string desde, string hasta)
        {
            objeto.Insertar(Convert.ToInt32(id_Candidato), puesto,Convert.ToDateTime(desde).Date, Convert.ToDateTime(hasta).Date);
        }
        public void Editar(string id,string IdCandidato, string puesto, string desde, string hasta)
        {
            objeto.Editar(Convert.ToInt32(id), Convert.ToInt32(IdCandidato), puesto, Convert.ToDateTime(desde).Date, Convert.ToDateTime(hasta).Date);
        }
        public void Elimiar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }

    }
}
