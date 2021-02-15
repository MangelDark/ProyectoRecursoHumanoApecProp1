using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
  public  class CD_Puesto : ConnectionToSql
    {
        //private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
   
        public DataTable Mostar()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "MostrarPuesto";
                    comando.CommandType = CommandType.StoredProcedure;
                    leer = comando.ExecuteReader();
                    table.Load(leer);
                    return table;
                }
            }
        }


        public void Insertar(string nombre, double sueldoMaximo, double sueldoMinimo, int nivel ,int estatus)
        {
            using (var connection =  GetConnection())
            {
                connection.Open();
                using (var comando = new  SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "insert into puestos(nombre_puesto,nivel_maximo_salario, nivel_minimo_salario,nivel_riesgo_puesto,estatus_puesto) values(@nombre,@sueldoMaximo,@suedloMinimo,@NivelRiesgo, @estatus)";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@sueldoMaximo", sueldoMaximo);
                    comando.Parameters.AddWithValue("@suedloMinimo", sueldoMinimo);
                    comando.Parameters.AddWithValue("@NivelRiesgo", nivel);
                    comando.Parameters.AddWithValue("@estatus", estatus);
                    comando.ExecuteNonQuery();
                }
            }
         
        }
        public void Editar(int id, string nombre, double sueldoMaximo, double sueldoMinimo, int nivelRiesgo, int estatus)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "update puestos set " +
                        "nombre_puesto=@nombre," +
                        "nivel_maximo_salario = @sueldoMaximo," +
                        "nivel_minimo_salario=@suedloMinimo," +
                        "nivel_riesgo_puesto = @NivelRiesgo," +
                        "estatus_puesto = @estatus " +
                        "where id_puesto = @id";
                    comando.CommandType = CommandType.Text;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@sueldoMaximo", sueldoMaximo);
                    comando.Parameters.AddWithValue("@suedloMinimo", sueldoMinimo);
                    comando.Parameters.AddWithValue("@NivelRiesgo", nivelRiesgo);
                    comando.Parameters.AddWithValue("@estatus", estatus);
                    comando.ExecuteNonQuery();

                }
            }

      

        }
        public void Eliminar(int id)
        {
            using (var connection  = GetConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = "EliminarPuesto";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
               
                }
            }
            
        }
    }
}
