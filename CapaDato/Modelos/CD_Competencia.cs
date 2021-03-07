using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    public class CD_Competencia : ConnectionToSql
    {

        SqlDataReader leer;
        DataTable table = new DataTable();

        public DataTable Mostrar()
        {
            using (var conn =  GetConnection()) 
            {
                conn.Open();
                using (var comando =  new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "MostrarCompetencia";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    table.Load(leer);
                    return table;
                }
            
            }
           
        }

        public void Insertar( string desc_competencia, int estatus_competencia)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "InsertarCompentencia";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@descripcion", desc_competencia);
                    comando.Parameters.AddWithValue("@estado", estatus_competencia);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            }
         


        }
        public void Editar(int id, string desc_competencia, int estatus_competencia)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "EditarCompetencia";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@desc_competencia", desc_competencia);
                    comando.Parameters.AddWithValue("estatus_competencia", estatus_competencia);
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
                    comando.CommandText = "EliminarCompetencia";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }

            }
         
        }
    }
}
