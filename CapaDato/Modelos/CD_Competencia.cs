using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.Modelos
{
    public class CD_Competencia
    {
        private CD_ContentConnection Con = new CD_ContentConnection();

        SqlDataReader leer;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "MostrarCompetencia";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            Con.CerrarConexion();
            return table;
        }

        public void Insertar( string desc_competencia, int estatus_competencia)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "InsertarCompentencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@desc_competencia", desc_competencia);
            comando.Parameters.AddWithValue("estatus_competencia", estatus_competencia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();


        }
        public void Editar(int id, string desc_competencia, int estatus_competencia)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EditarCompetencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@desc_competencia", desc_competencia);
            comando.Parameters.AddWithValue("estatus_competencia", estatus_competencia);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

        public void Eliminar(int id)
        {
            comando.Connection = Con.AbriConexion();
            comando.CommandText = "EliminarCompetencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
