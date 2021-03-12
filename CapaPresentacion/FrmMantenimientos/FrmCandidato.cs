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
    public partial class FrmCandidato : Form
    {

        CN_Candidato objetoCN = new CN_Candidato();
        private string id = null;
        private bool Editar = false;

        public FrmCandidato()
        {
            InitializeComponent();
        }
        //Es un funcion que limpia los campos es reutilizables
        private void limpiarForm()
        {

            txtNombre.Clear();
            txtCedula.Clear();
            txtSalario.Clear();
           
        
            btnSave.Text = "Guardar";
            Editar = false;
        }
        private void Mostrar()
        {
            CN_Candidato objetoCN = new CN_Candidato();

            dataGridView1.DataSource = objetoCN.Mostrar();
            //cargarCheck(dgtPuesto,objeto.MostrarPuesto());
        }
        private void HideLabelError()
        {
            lbErrorCedula.Visible = false;
            lbErrorDepartamento.Visible = false;
            lbErrorNombre.Visible = false;
            lbErrorPuesto.Visible = false;
            lbErrorSalario.Visible = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            //Validamos que el nombre no este vacio
            if (txtNombre.Text != "")
            {
                //Validamos que el Salario minimo no este vacio
                if (txtCedula.Text != "")
                {
                    //Validamos que el Salario maximo no este vacio
                    if (txtSalario.Text != "")
                    {
                        //INSERTAR
                        if (Editar == false)
                        {
                            try
                            {
                                objetoCN.Insertar(txtCedula.Text,txtNombre.Text, txtSalario.Text, cboxPuesto.SelectedIndex.ToString(),txtSalario.Text); ;
                                MessageBox.Show("se inserto correctamente");
                                Mostrar();
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
                                objetoCN.Editar(id, txtCedula.Text, txtNombre.Text, cboxPuesto.SelectedIndex.ToString(),comboBoxDepartamento.SelectedText, txtSalario.Text);
                                MessageBox.Show("se edito correctamente");
                                Mostrar();
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
                        lbErrorSalario.Text = "El campo es requerido.";
                        lbErrorSalario.Visible = true;
                        txtSalario.Focus();
                    }
                }
                else
                {
                    lbErrorCedula.Text = "El campo es requerido.";
                    lbErrorCedula.Visible = true;
                    txtCedula.Focus();

                }
            }
            else
            {
                lbErrorNombre.Text = "El campo es requerido.";
                lbErrorNombre.Visible = true;
                txtNombre.Focus();
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
                Mostrar();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
   
    }
}
