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
        public void Insertar(string cedula, string nombre, string puestoAspira,string candidato,string salario)
        {
            objeto.Insertar(cedula, nombre, puestoAspira,Convert.ToInt32(candidato),Convert.ToDecimal(salario));
        }
        public void Editar(string id, string cedula, string nombre, string puestoAspira, string candidato, string salario)
        {
            objeto.Editar(Convert.ToInt32(id), cedula,nombre, puestoAspira,Convert.ToInt32(candidato), Convert.ToDecimal(salario));
        }
        public void Elimiar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }

    }
}
