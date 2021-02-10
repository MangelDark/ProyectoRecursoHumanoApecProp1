using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
   public class CD_Capacitacion
    {
        private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "MostrarCapacitacione";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar(string descripcion, char nivelCapacitacion, DateTime fechaDesde,DateTime fechaHasta,string institucionCapacitacion)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "InsertarCapacitacione";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@desc_capacitacion", descripcion);
            comando.Parameters.AddWithValue("@nivel_capacitacion", nivelCapacitacion);
            comando.Parameters.AddWithValue("@fecha_desde", fechaDesde);
            comando.Parameters.AddWithValue("@fecha_hasta", fechaHasta);
            comando.Parameters.AddWithValue("@institucion_capacitacion", institucionCapacitacion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id, string descripcion, char nivelCapacitacion, DateTime fechaDesde, DateTime fechaHasta, string institucionCapacitacion)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EditarCapacitacione";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@", id);
            comando.Parameters.AddWithValue("@desc_capacitacion", descripcion);
            comando.Parameters.AddWithValue("@nivel_capacitacion", nivelCapacitacion);
            comando.Parameters.AddWithValue("@fecha_desde", fechaDesde);
            comando.Parameters.AddWithValue("@fecha_hasta", fechaHasta);
            comando.Parameters.AddWithValue("@institucion_capacitacion", institucionCapacitacion);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EliminarCapacitacione";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
