using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
  public  class CD_Empleado
    {
        private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "MostrarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar(string cedula,string nombre,int id_departamento, int id_puesto, double salario_empleado,DateTime fecha_ingreso_empleado, int estatus)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "InsertarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cedula_empleado", cedula);
            comando.Parameters.AddWithValue("@nombre_empleado", nombre);
            comando.Parameters.AddWithValue("@id_departamento", id_departamento);
            comando.Parameters.AddWithValue("@id_puesto", id_puesto);
            comando.Parameters.AddWithValue("@salario_empleado", salario_empleado);
            comando.Parameters.AddWithValue("@fecha_ingreso_empleado", fecha_ingreso_empleado);
            comando.Parameters.AddWithValue("@estatus_empleado", estatus);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id,string cedula, string nombre, int id_departamento, int id_puesto, double salario_empleado, DateTime fecha_ingreso_empleado, int estatus)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EditarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@cedula_empleado", cedula);
            comando.Parameters.AddWithValue("@nombre_empleado", nombre);
            comando.Parameters.AddWithValue("@id_departamento", id_departamento);
            comando.Parameters.AddWithValue("@id_puesto", id_puesto);
            comando.Parameters.AddWithValue("@salario_empleado", salario_empleado);
            comando.Parameters.AddWithValue("@fecha_ingreso_empleado", fecha_ingreso_empleado);
            comando.Parameters.AddWithValue("@estatus_empleado", estatus);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EliminarEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
