using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Modelos;

namespace CapaNegocio.DTO
{
    public class CN_Idioma
    {
        private CD_Idioma objeto = new CD_Idioma();


        public DataTable MostrarIdioma()
        {
            return objeto.Mostrar();
        }
        public  void InsertarIdioma(string nombre,string pais, string estatus)
        {
            objeto.Insertar(nombre,pais,Convert.ToInt32(estatus));
        }
        public void EditarIdioma(string id,string nombre,string pais, string estatus)
        {
            objeto.Editar(Convert.ToInt32(id),nombre, pais, Convert.ToInt32(estatus));
        }
        public void ElimarIdioma(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }
    }
}
