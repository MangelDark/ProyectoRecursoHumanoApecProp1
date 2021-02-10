using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    public class CD_Idioma
    {
        private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "MostrarIdioma";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar(string nombre, int estatus)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "InsertarIdioma";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@estatus", estatus);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id, string nombre, int estatus)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EditarIdioma";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@estatus", estatus);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EliminarIdioma";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
