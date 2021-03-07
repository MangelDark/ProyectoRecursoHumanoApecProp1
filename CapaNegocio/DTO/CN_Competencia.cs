using CapaDato.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTO
{
   public class CN_Competencia
    {
        private CD_Competencia objeto = new CD_Competencia();


        public DataTable Mostrar()
        {
            return objeto.Mostrar();
        }
        public void Insertar(string desc_competencia, string estatus_competencia)
        {
            objeto.Insertar(desc_competencia,Convert.ToInt32(estatus_competencia));
        }
        public void Editar(string id, string desc_competencia, string estatus_competencia)
        {
            objeto.Editar(Convert.ToInt32(id), desc_competencia, Convert.ToInt32(estatus_competencia));
        }
        public void Elimiar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }

    }
}
