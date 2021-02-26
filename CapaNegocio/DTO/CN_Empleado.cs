using CapaDato.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.DTO
{
   public class CN_Empleado
    {
        private CD_Empleado objeto = new CD_Empleado();


        public DataTable Mostrar()
        {
            return objeto.Mostrar();
        }
        public void Insertar(string cedula, string nombre, string id_departamento, string id_puesto, string salario_empleado, string fecha_ingreso_empleado, string estatus)
        {
            objeto.Insertar(cedula,nombre,Convert.ToInt32(id_departamento),Convert.ToInt32(id_puesto),Convert.ToDouble(salario_empleado),Convert.ToDateTime(fecha_ingreso_empleado).Date,Convert.ToInt32(estatus));
        }
        public void Editar(string id, string cedula, string nombre, string id_departamento, string id_puesto, string salario_empleado, string fecha_ingreso_empleado, string estatus)
        {
            objeto.Editar(Convert.ToInt32(id),cedula, nombre, Convert.ToInt32(id_departamento), Convert.ToInt32(id_puesto), Convert.ToDouble(salario_empleado), Convert.ToDateTime(fecha_ingreso_empleado).Date, Convert.ToInt32(estatus));
        }
        public void Elimiar(string id)
        {
            objeto.Eliminar(Convert.ToInt32(id));
        }

    }
}
