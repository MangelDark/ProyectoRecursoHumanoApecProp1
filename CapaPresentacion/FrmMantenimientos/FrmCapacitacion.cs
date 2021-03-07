using CapaNegocio.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.FrmMantenimientos
{
    public partial class FrmCapacitacion : Form
    {


        CN_Capacitancion objetoCN = new CN_Capacitancion();
        private string id = null;
        private bool Editar = false;
        int Estatus;

        public FrmCapacitacion()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["Identificador"].Value.ToString();
                objetoCN.Elimiar(id);
                MessageBox.Show("Eliminado correctamente");
                MostrarCapacitacion();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        private void HideLabelError()
        {
            lbDescripcionError.Visible = false;
            lbDescripcionError.Text = "";
            lbDesdeError.Visible = false;
            lbDesdeError.Text = "";
            lbHastaError.Visible = false;
            lbHastaError.Text = "";
            lbNiveCapError.Visible = false;
        }
        private void limpiarForm()
        {

            txtDescripcion.Clear();       
            rdBtnActivo.Checked = true;
            rdBtnInactivo.Checked = false;
            btnSave.Text = "Guardar";
            Editar = false;
        }



        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmCapacitacion_Load(object sender, EventArgs e)
        {
            MostrarCapacitacion();
        }
        private void MostrarCapacitacion()
        {
            CN_Capacitancion objeto = new CN_Capacitancion();

            dataGridView1.DataSource = objeto.Mostrar();
            //cargarCheck(dgtPuesto,objeto.MostrarPuesto());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarForm();
            HideLabelError();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validamos que el nombre no este vacio
            if (txtDescripcion.Text != "")
            {
                //Validamos que el Salario minimo no este vacio
                if (dateTimeDesde.Text != "" && dateTimeDesde.Value.Date != dateTimeHasta.Value.Date && dateTimeDesde.Value.Date < dateTimeHasta.Value.Date)
                {
                    //Validamos que el Salario maximo no este vacio
                    if (dateTimeHasta.Text != "" && dateTimeHasta.Value.Date != dateTimeDesde.Value.Date && dateTimeHasta.Value.Date > dateTimeDesde.Value.Date)
                    {
                        //Obtenemos el valor de los radioButton
                        if (rdBtnActivo.Checked)
                        {
                            Estatus = 1;
                        }
                        else
                        {
                            Estatus = 0;
                        }
                        //INSERTAR
                        if (Editar == false)
                        {
                            try
                            {
                                objetoCN.Insertar(txtDescripcion.Text, cboxNivelCapacitacion.SelectedIndex.ToString(), dateTimeDesde.Text, dateTimeHasta.Text, Convert.ToString(Estatus)) ;
                                MessageBox.Show("se inserto correctamente");
                                MostrarCapacitacion();
                                limpiarForm();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("no se pudo insertar los datos por: " + ex);
                            }
                        }
                        ////EDITAR
                        if (Editar == true)
                        {

                            try
                            {
                                objetoCN.Editar(id, txtDescripcion.Text, cboxNivelCapacitacion.SelectedIndex.ToString(), dateTimeDesde.Text, dateTimeHasta.Text, Convert.ToString(Estatus));
                                MessageBox.Show("se edito correctamente");
                                MostrarCapacitacion();
                                limpiarForm();
                                Editar = false;
                                btnSave.Text = "Guardar";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("no se pudo editar los datos por: " + ex);
                            }
                        }
                    }
                    else
                    {
                        lbHastaError.Text = "El campo es requerido.";
                        lbHastaError.Visible = true;
                    }
                }
                else
                {
                    lbDesdeError.Text = "El campo es requerido.";
                    lbDesdeError.Visible = true;

                }
            }
            else
            {
                lbDescripcionError.Text = "El campo es requerido.";
                lbDescripcionError.Visible = true;
                txtDescripcion.Focus();
            }
        }
    }
}
