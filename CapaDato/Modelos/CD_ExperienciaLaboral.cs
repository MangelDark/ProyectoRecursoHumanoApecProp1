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
            comando.CommandText = "";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar(string cedula, string nombre, string puestoAspira)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@", cedula);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
