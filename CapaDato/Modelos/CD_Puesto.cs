using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    class CD_Puesto
    {
        private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "MostrarPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar(string nombre,double sueldoMaximo, double sueldoMinimo,char nivelRiesgo, int estatus)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "InsertarPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@sueldoMaximo", sueldoMaximo);
            comando.Parameters.AddWithValue("@suedloMinimo", sueldoMinimo);
            comando.Parameters.AddWithValue("@NivelRiesgo", nivelRiesgo);
            comando.Parameters.AddWithValue("@estatus", estatus);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id, string nombre, double sueldoMaximo, double sueldoMinimo, char nivelRiesgo, int estatus)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EditarPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@sueldoMaximo", sueldoMaximo);
            comando.Parameters.AddWithValue("@suedloMinimo", sueldoMinimo);
            comando.Parameters.AddWithValue("@NivelRiesgo", nivelRiesgo);
            comando.Parameters.AddWithValue("@estatus", estatus);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EliminarPuesto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
