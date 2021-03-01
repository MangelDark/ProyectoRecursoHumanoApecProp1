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
    public partial class FrmIdioma : Form
    {
        CN_Idioma objetoCN = new CN_Idioma();
        private string id = null;
        private bool Editar = false;
        int Estatus;

        public FrmIdioma()
        {
            InitializeComponent();
        }


        #region Funciones
        private void MostrarIdiomas()
        {
            CN_Idioma objetoCN = new CN_Idioma();
            dataGridView1.DataSource = objetoCN.MostrarIdioma();
        }
        private void HideLabelError()
        {
            lbNombreError.Visible = false;
            lbPaisError.Visible = false;
        }
        private void limpiarForm()
        {

            txtNombreIdioma.Clear();
            txtPais.Clear();

            rdbtnActivo.Checked = true;
            rdbtnInactivo.Checked = false;
            btnSave.Text = "Guardar";
            Editar = false;
        }
        #endregion

        private void FrmIdioma_Load(object sender, EventArgs e)
        {
            MostrarIdiomas();
        }
        //El boton editar llenas los campos con la fila selecionado de datagridview
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validamos que el nombre no este vacio
            if (txtNombreIdioma.Text != "")
            {
                //Validamos que el Salario minimo no este vacio
                if (txtPais.Text != "")
                {

                    //Obtenemos el valor de los radioButton
                    if (rdbtnActivo.Checked)
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
                            objetoCN.InsertarIdioma(txtNombreIdioma.Text, txtPais.Text,Convert.ToString(Estatus)); 
                            MessageBox.Show("se inserto correctamente");
                            MostrarIdiomas();
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
                            objetoCN.EditarIdioma(id, txtNombreIdioma.Text, txtPais.Text,  Convert.ToString(Estatus));
                            MessageBox.Show("se edito correctamente");
                            MostrarIdiomas();
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
                    lbPaisError.Text = "El campo es requerido.";
                    lbPaisError.Visible = true;
                    txtPais.Focus();

                }
            }
            else
            {
                lbNombreError.Text = "El campo es requerido.";
                lbNombreError.Visible = true;
                txtNombreIdioma.Focus();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                HideLabelError();
                id = dataGridView1.CurrentRow.Cells["Identificador"].Value.ToString();
                txtNombreIdioma.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPais.Text = dataGridView1.CurrentRow.Cells["Pais del idioma"].Value.ToString();
                Estatus = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Estado del idioma"].Value.ToString());
                btnSave.Text = "Guardar cambios";

                if (Estatus == 1)
                {
                    rdbtnActivo.Checked = true;
                }
                else
                {
                    rdbtnInactivo.Checked = true;
                }

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["Identificador"].Value.ToString();
                objetoCN.ElimarIdioma(id);
                MessageBox.Show("Eliminado correctamente");
                MostrarIdiomas();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarForm();
            HideLabelError();
        }

        private void txtNombreIdioma_Leave(object sender, EventArgs e)
        {
            if (txtNombreIdioma.Text != "")
            {
                lbNombreError.Text = "";
                lbNombreError.Visible = false;
            }
        }

        private void txtPais_Leave(object sender, EventArgs e)
        {
            if (txtPais.Text != "")
            {
                lbPaisError.Text = "";
                lbPaisError.Visible = false;
            }
        }
    }
}
