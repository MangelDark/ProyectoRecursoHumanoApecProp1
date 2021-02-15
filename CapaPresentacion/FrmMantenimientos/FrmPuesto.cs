using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.DTO;

namespace CapaPresentacion.FrmMantenimientos
{
    public partial class FrmPuesto : Form
    {
        CN_Puesto objetoCN = new CN_Puesto();
        private string idPuesto = null;
        private bool Editar = false;
        int Estatus;
        public FrmPuesto()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgtPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPuesto_Load(object sender, EventArgs e)
        {
            MostrarPuesto();
            cboxNivelRiesgoPuesto.SelectedIndex = 0;
        }

        private void MostrarPuesto()
        {
            CN_Puesto objeto = new CN_Puesto();
            dgtPuesto.DataSource = objeto.MostrarPuesto();
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    objetoCN.InsertarPuesto(txtNombre.Text, txtNivelSalarioMaximo.Text, txtNivelMinimoSalario.Text, cboxNivelRiesgoPuesto.SelectedIndex.ToString(), Convert.ToString(Estatus)); ;
                    MessageBox.Show("se inserto correctamente");
                    MostrarPuesto();
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
                    objetoCN.EditarPuesto(idPuesto, txtNombre.Text, txtNivelSalarioMaximo.Text, txtNivelMinimoSalario.Text, cboxNivelRiesgoPuesto.SelectedIndex.ToString(), Convert.ToString(Estatus));
                    MessageBox.Show("se edito correctamente");
                    MostrarPuesto();
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


        private void limpiarForm()
        {

            txtNombre.Clear();
            txtNivelMinimoSalario.Clear();
            txtNivelSalarioMaximo.Clear();
            rdBtnActivo.Checked = true;
            rdBtnInactivo.Checked = false;
            btnSave.Text = "Guardar";
            Editar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgtPuesto.SelectedRows.Count > 0)
            {
                Editar = true;
                idPuesto = dgtPuesto.CurrentRow.Cells["Identificador"].Value.ToString();
                txtNombre.Text = dgtPuesto.CurrentRow.Cells["Nombre"].Value.ToString();
                txtNivelSalarioMaximo.Text = dgtPuesto.CurrentRow.Cells["Nivel Del Sueldo Maximo"].Value.ToString();
                txtNivelMinimoSalario.Text = dgtPuesto.CurrentRow.Cells["Nivel Del Sueldo Minimo"].Value.ToString();
                cboxNivelRiesgoPuesto.SelectedIndex = Convert.ToInt32(dgtPuesto.CurrentRow.Cells["Nivel De Riesgo al Puesto"].Value.ToString());
                Estatus = Convert.ToInt32( dgtPuesto.CurrentRow.Cells["Estado Del Puesto"].Value.ToString());
                btnSave.Text = "Guardar cambios";

                if (Estatus == 1)
                {
                    rdBtnActivo.Checked = true;
                }
                else
                {
                    rdBtnInactivo.Checked = true;
                }

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgtPuesto.SelectedRows.Count > 0)
            {
                idPuesto = dgtPuesto.CurrentRow.Cells["Identificador"].Value.ToString();
                objetoCN.ElimiarPuesto(idPuesto);
                MessageBox.Show("Eliminado correctamente");
                MostrarPuesto();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarForm();
           
        }
    }
}
