using CapaDato.Modelos;
using CapaNegocio.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class ReportPuesto
    {
        public List<PuestoDTO> puestoLista { get;  set; }
        public void createPuestoReport()
        {
            

            var puestoData = new CD_Puesto();
            var result = puestoData.Mostar();

            puestoLista = new List<PuestoDTO>();
            foreach (System.Data.DataRow row in result.Rows)
            {
                var re = new PuestoDTO()
                {
                    Id = Convert.ToInt32((row[0])),
                    Nombre = Convert.ToString(row[1]),
                    MinimoSalario = Convert.ToDouble(row[2]),
                    MaximoSalario = Convert.ToDouble(row[3]),
                    Estatus = Convert.ToInt32(row[4])


                };
                puestoLista.Add(re);
            }
            

        }
    }
}
