using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    public class CD_Departamento : ConnectionToSql
    {
        //private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        //SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            using (var conn = GetConnection() )
            {
                conn.Open();
                using (var comando =  new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "MostrarDepartamento";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    table.Load(leer);
                    return table;
                }

            }
                
        }

        public void Insertar(string nombre)
        {
            using (var conn  = GetConnection())
            {
                conn.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "InsertarDepartamento";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
                


        }
        public void Editar(int id, string nombre)
        {
            using (var conn =  GetConnection())
            { conn.Open();
                using (var comando =  new SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "EditarDepartamento";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            }
   

        }

        public void Eliminar(int id)
        {
            using (var conn =  GetConnection()) 
            {
                conn.Open();
                using (var comando = new  SqlCommand())
                {
                    comando.Connection = conn;
                    comando.CommandText = "EliminarDepartamento";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                    comando.Parameters.Clear();
                }
            
            }

         
        }
    }
}
