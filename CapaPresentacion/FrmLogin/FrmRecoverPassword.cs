using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio.DTOUser;

namespace CapaPresentacion.FrmLogin
{
    public partial class FrmRecoverPassword : Form
    {
        public FrmRecoverPassword()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtxUserNameOrEmail.Text != "")
            {
                var user = new UserModel();
                var result = user.recoverPassword(txtxUserNameOrEmail.Text);
                lbMessage.Text = result;
                lbMessage.Visible = true;
            }
            else
            {
                txtxUserNameOrEmail.Focus();
                txtxUserNameOrEmail.Clear();
                lbError.Text = "El campo es obligatorio.";
                lbError.Visible = true;
            }
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRecoverPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
