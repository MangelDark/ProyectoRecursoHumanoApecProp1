using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    class CD_ExperienciaLaboral
    {
        private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "MostrarExperienciaLaboral";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar(int IdCandidato,string puestoOcupado,DateTime fechaDesdeExp, DateTime fechaHastaExp)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "InsertarExperienciaLaboral";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_candidato", IdCandidato);
            comando.Parameters.AddWithValue("@puesto_ocupado", puestoOcupado);
            comando.Parameters.AddWithValue("@fecha_desde_experiencia", fechaDesdeExp);
            comando.Parameters.AddWithValue("@fecha_hasta_experiencia", fechaHastaExp);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id, int IdCandidato, string puestoOcupado, DateTime fechaDesdeExp, DateTime fechaHastaExp)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EditarExperienciaLaboral";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@id_candidato", IdCandidato);
            comando.Parameters.AddWithValue("@puesto_ocupado", puestoOcupado);
            comando.Parameters.AddWithValue("@fecha_desde_experiencia", fechaDesdeExp);
            comando.Parameters.AddWithValue("@fecha_hasta_experiencia", fechaHastaExp);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EliminarExperienciaLaboral";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
