using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.ReportView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            GetReport();
        }

        private void GetReport()
        {
            ReportPuesto reportPuesto = new ReportPuesto();

            reportPuesto.createPuestoReport();

            PuestoDTOBindingSource.DataSource = reportPuesto;
            PuestoDTOBindingSource.DataSource = reportPuesto.puestoLista;

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            GetReport();
        }
    }
}
