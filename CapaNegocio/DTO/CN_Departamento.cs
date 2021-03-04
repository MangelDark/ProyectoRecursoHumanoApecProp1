using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Modelos;

namespace CapaNegocio.DTO
{
    public class CN_Departamento
    {
        private CD_Departamento objeto = new CD_Departamento();


        public DataTable Mostrar()
        {
            return objeto.Mostrar();
        }
        public  void Insertar(string nombre)
        {
            objeto.Insertar(nombre);
        }
        public void Editar(string id,string nombre)
        {
            objeto.Editar(Convert.ToInt32(id),nombre);
        }
        public void Eliminar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }
    }
}
