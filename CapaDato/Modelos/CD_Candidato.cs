using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
   public class CD_Candidato : ConnectionToSql
    {

        SqlDataReader leer;
        DataTable table = new DataTable();

        public DataTable Mostrar()
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando =  new SqlCommand())
                {

                    comando.Connection = conn;
                    comando.CommandText = "MostrarCandidato";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    table.Load(leer);
                    return table;
                }
            }

        }

        public void Insertar(string cedula,string nombre,string puestoAspira,int candidato,decimal salario)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {

                    comando.Connection = conn;
                    comando.CommandText = "InsertarCandidato";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@cedula",cedula);
                    comando.Parameters.AddWithValue("@nombre",nombre);
                    comando.Parameters.AddWithValue("@puestoAspira",puestoAspira);
                    comando.Parameters.AddWithValue("@Candidato", candidato);
                    comando.Parameters.AddWithValue("@Salario", salario);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
       

        }
        public void Editar(int id , string cedula, string nombre,string puestoAspira, int candidato, decimal salario)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {

                    comando.Connection = conn;
                    comando.CommandText = "EditarCandidato";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@cedula", cedula);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@puestoAspira", puestoAspira);
                    comando.Parameters.AddWithValue("@Candidato", candidato);
                    comando.Parameters.AddWithValue("@Salario", salario);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }

        }

        public void Eliminar (int id)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {

                    comando.Connection = conn;
                    comando.CommandText = "EliminarCandidato";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id",id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
        }
    }
}
