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
    public partial class FrmExperienciaLaboral : Form
    {

        CN_ExperienciaLaboral objetoCN = new CN_ExperienciaLaboral();
        private string id = null;
        private bool Editar = false;
        int Estatus;
        public FrmExperienciaLaboral()
        {
            InitializeComponent();
        }
        #region Funciones
        private void MostrarExperienciaLaboral()
        {
            CN_ExperienciaLaboral objetoCN = new CN_ExperienciaLaboral();
            dataGridView1.DataSource = objetoCN.Mostrar();
        }
        private void HideLabelError()
        {
            lbDesdeError.Visible = false;
            lbHastaError.Visible = false;
            lbPuestoError.Visible = false;
            lbNombre.Visible = false;
        }

        private void limpiarForm()
        {

            txtPuestoOcupado.Clear();
            dateTimeDesde.Value = new DateTime().Date;
            dateTimeHasta.Value = new DateTime().Date;

         
            btnSave.Text = "Guardar";
            Editar = false;
        }
        #endregion
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validamos que el nombre no este vacio
            if (txtPuestoOcupado.Text != "")
            {
                //Validamos que el Salario minimo no este vacio
                if (dateTimeDesde.Text != "")
                {

                    //Obtenemos el valor de los radioButton
                    if (dateTimeHasta.Checked)
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
                            objetoCN.Insertar(candidatoSelected.SelectedIndex.ToString(),txtPuestoOcupado.Text, dateTimeDesde.Text, dateTimeHasta.Text);
                            MessageBox.Show("se inserto correctamente");
                            MostrarExperienciaLaboral();
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
                            objetoCN.Editar(id, candidatoSelected.SelectedIndex.ToString(), txtPuestoOcupado.Text, dateTimeDesde.Text, dateTimeHasta.Text);
                            MessageBox.Show("se edito correctamente");
                            MostrarExperienciaLaboral();
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
                    lbDesdeError.Text = "El campo es requerido.";
                    lbDesdeError.Visible = true;
                    lbDesdeError.Focus();

                }
            }
            else
            {
                lbPuestoError.Text = "El campo es requerido.";
                lbPuestoError.Visible = true;
                lbPuestoError.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarForm();
            HideLabelError();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["Identificador"].Value.ToString();
                objetoCN.Elimiar(id);
                MessageBox.Show("Eliminado correctamente");
                MostrarExperienciaLaboral();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmExperienciaLaboral_Load(object sender, EventArgs e)
        {
            MostrarExperienciaLaboral();
        }
    }
}
