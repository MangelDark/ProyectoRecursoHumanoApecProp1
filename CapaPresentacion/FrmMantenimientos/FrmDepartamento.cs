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
    public partial class FrmDepartamento : Form
    {
        CN_Departamento objetoCN = new CN_Departamento();
        private string id = null;
        private bool Editar = false;
 
        public FrmDepartamento()
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
        }

        private void MostrarPuesto()
        {
            CN_Departamento objeto = new CN_Departamento();

            dgDepartamento.DataSource = objeto.Mostrar();
            //cargarCheck(dgtPuesto,objeto.MostrarPuesto());
        }
   
        //Boton Guardar
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validamos que el nombre no este vacio
            if (txtNombre.Text != "")
            {
               //Obtenemos el valor de los radioButton
                     
                        //INSERTAR
                        if (Editar == false)
                        {
                            try
                            {
                                objetoCN.Insertar(txtNombre.Text);
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
                                objetoCN.Editar(id,txtNombre.Text);
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
                
            
            else
            {
                LbErrorNombre.Text = "El campo es requerido.";
                LbErrorNombre.Visible = true;
                txtNombre.Focus();
            }
          
        }

        //Es un funcion que limpia los campos es reutilizables
        private void limpiarForm()
        {

            txtNombre.Clear();
         
            btnSave.Text = "Guardar";
            Editar = false;
        }
        //El boton editar llenas los campos con la fila selecionado de datagridview
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgDepartamento.SelectedRows.Count > 0)
            {
                Editar = true;
                HideLabelError();
                id = dgDepartamento.CurrentRow.Cells["Identificador"].Value.ToString();
                txtNombre.Text = dgDepartamento.CurrentRow.Cells["Departamento"].Value.ToString();
                btnSave.Text = "Guardar cambios";

             

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void HideLabelError()
        {
            LbErrorNombre.Visible = false;
            LbErrorNombre.Text = "";
       
        }
        //Elimina un registro de puesto
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgDepartamento.SelectedRows.Count > 0)
            {
                id = dgDepartamento.CurrentRow.Cells["Identificador"].Value.ToString();
                objetoCN.Eliminar(id);
                MessageBox.Show("Eliminado correctamente");
                MostrarPuesto();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
        //Limpiar los campos 
        private void btnClear_Click(object sender, EventArgs e)
        {
            limpiarForm();
            HideLabelError();



        }
        private void LbErrorNombre_Click(object sender, EventArgs e)
        {

        }
        //Esta funcion verifica cuando sales el campos si tiene datos si es asi el LbErro se podra invisible
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text !="" )
            {
                LbErrorNombre.Visible = false;
                LbErrorNombre.Text = "";
            }
        }
     
    
    
        //Cargarmos los datos al grid con un check
        public void cargarCheck(DataGridView grid,DataTable data)
        {
            grid.Columns.Clear();
            DataGridViewCheckBoxColumn check = new DataGridViewCheckBoxColumn();

            check.HeaderText = "Seleccionar";
            check.Name = "Seleccionar";
            check.Width = 60;
            grid.Columns.Add(check);
            grid.Columns[grid.Columns.Count - 1].DisplayIndex = 0;
            grid.DataSource = data;
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0;i<= dgDepartamento.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(dgDepartamento.Rows[i].Cells[0].Value))
                {
                    dgDepartamento.Rows[i].Cells[0].Value = true;
                }
            }
        }

        private void btnQuitarAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgDepartamento.Rows.Count - 1; i++)
            {
                if (Convert.ToBoolean(dgDepartamento.Rows[i].Cells[0].Value))
                {
                    dgDepartamento.Rows[i].Cells[0].Value = false;
                }
            }
        }
    }
}
