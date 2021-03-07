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
    public partial class FrmCompetencia : Form
    {

        CN_Competencia objetoCN = new CN_Competencia();
        private string id = null;
        private bool Editar = false;
        int Estatus;


        public FrmCompetencia()
        {
            InitializeComponent();
        }
      
        private void panelCampos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioButton1.Checked)
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
                        objetoCN.Insertar(textBox1.Text, Convert.ToString(Estatus));
                        MessageBox.Show("se inserto correctamente");
                        MostraCompetencia();
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
                        objetoCN.Editar(id, textBox1.Text,Convert.ToString(Estatus));
                        MessageBox.Show("se edito correctamente");
                        MostraCompetencia();
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
                LbErrorMessageCompentencia.Text = "El campo es obligatorio.";
                LbErrorMessageCompentencia.Visible = true;
                    
            }
           
        }
        //Es un funcion que limpia los campos es reutilizables
        private void limpiarForm()
        {

            textBox1.Clear();          
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            btnSave.Text = "Guardar";
            Editar = false;
        }

        private void FrmCompetencia_Load(object sender, EventArgs e)
        {
            MostraCompetencia();
        }

        private void MostraCompetencia()
        {
            CN_Competencia objeto = new CN_Competencia();

            dataGridView1.DataSource = objeto.Mostrar();
        }
        private void HideLabelError()
        {
            LbErrorMessageCompentencia.Visible = false;
         }

        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["Identificador"].Value.ToString();
                objetoCN.Elimiar(id);
                MessageBox.Show("Eliminado correctamente");
                MostraCompetencia();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                HideLabelError();
                id = dataGridView1.CurrentRow.Cells["Identificador"].Value.ToString();
                textBox1.Text = dataGridView1.CurrentRow.Cells["Descripción"].Value.ToString();
              
                Estatus = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Estado"].Value.ToString());
                btnSave.Text = "Guardar cambios";

                if (Estatus == 1)
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
