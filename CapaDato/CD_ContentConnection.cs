using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace CapaDato
{
   public class CD_ContentConnection
    {
        private SqlConnection Conexion = new SqlConnection("Server=(local);DataBase=HR_Management;Integrated Security=true");

        public SqlConnection AbriConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }


        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
