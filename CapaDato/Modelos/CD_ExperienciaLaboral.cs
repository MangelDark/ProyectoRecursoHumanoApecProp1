using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    public class CD_ExperienciaLaboral : ConnectionToSql
    {

        SqlDataReader leer;
        DataTable table = new DataTable();
      

        public DataTable Mostrar()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "MostrarExperienciaLaboral";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    table.Load(leer);
                    return table;
                }

            }
      
        }

        public void Insertar(int IdCandidato,string puestoOcupado,DateTime fechaDesdeExp, DateTime fechaHastaExp)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
              
                    comando.CommandText = "InsertarExperienciaLaboral";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id_candidato", IdCandidato);
                    comando.Parameters.AddWithValue("@puesto_ocupado", puestoOcupado);
                    comando.Parameters.AddWithValue("@fecha_desde_experiencia", fechaDesdeExp);
                    comando.Parameters.AddWithValue("@fecha_hasta_experiencia", fechaHastaExp);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            }
     


        }
        public void Editar(int id, int IdCandidato, string puestoOcupado, DateTime fechaDesdeExp, DateTime fechaHastaExp)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                
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

            }
          

        }

        public void Eliminar(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "EliminarExperienciaLaboral";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            }
      
        }
    }
}
