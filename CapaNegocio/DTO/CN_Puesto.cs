using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato.Modelos;

namespace CapaNegocio.DTO
{
   public  class CN_Puesto
    {

        private CD_Puesto objeto = new CD_Puesto();
             
        public DataTable MostrarPuesto()
        {
            return objeto.Mostar();
        }
        public void InsertarPuesto(string nombre, string sueldoMaximo, string sueldoMinimo,string nivel, string estatus)
        {
            objeto.Insertar(nombre, Convert.ToDouble(sueldoMaximo), Convert.ToDouble(sueldoMinimo),Convert.ToInt32(nivel), Convert.ToInt32(estatus));
        }
        public void EditarPuesto(string id, string nombre, string sueldoMaximo, string sueldoMinimo, string nivelRiesgo, string estatus)
        {
            objeto.Editar(Convert.ToInt32(id), nombre, Convert.ToDouble(sueldoMaximo), Convert.ToDouble(sueldoMinimo),Convert.ToInt32(nivelRiesgo), Convert.ToInt32(estatus));
        }
        public void ElimiarPuesto(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }


    }
}
