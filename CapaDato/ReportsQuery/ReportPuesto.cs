using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDato.ReportsQuery
{
    public class ReportPuesto: ConnectionToSql
    {


        public DataTable getPuesto()
        {


            using (var con = GetConnection())
            {
                con.Open();
                using (var command  =  new SqlCommand())
                {
                    command.Connection = con;
                    command.CommandText = @"
                                        select  nombre_puesto,
		                                        estatus_puesto,
		                                        nivel_maximo_salario,
		                                        nivel_minimo_salario,
		                                        nivel_riesgo_puesto 
                                        from puestos";
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);

                    return table;
                }
            }
        }

    }
}
