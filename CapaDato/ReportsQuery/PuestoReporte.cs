using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.ReportsQuery
{
    public class PuestoReporte: ConnectionToSql
    {


        public DataTable getPuesto()
        {


            using (var con = GetConnection())
            {
                con.Open();
                using (var comando =  new SqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = "MostrarPuesto";
                    comando.CommandType = CommandType.StoredProcedure;
                    var leer = comando.ExecuteReader();
                    var table = new DataTable();

                    table.Load(leer);
                    return table;
                }
            }
        }

    }
}
