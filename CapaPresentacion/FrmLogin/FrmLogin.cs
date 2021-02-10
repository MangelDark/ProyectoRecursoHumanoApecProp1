using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaNegocio.DTOUser;
using Common;

namespace CapaPresentacion.FrmLogin
{
    public partial class FrmLoginUI : Form
    {
        public FrmLoginUI()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuario" && txtUser.TextLength > 2)
            {
                    if(txtPass.Text != "Contraseña")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtUser.Text, txtPass.Text);
                    if (validLogin == true)
                    {
                        MenuPrincipal mainMenu = new MenuPrincipal();
                        MessageBox.Show("Bienvenido " + UserCache.FirstName + " " + UserCache.LoginName);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        MessageError("Usuario o Contraseña son incorrecta. \n Por favor vuelva a intentarlo");
                        txtPass.Clear();
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageError("El campo contraseña es obligatorio.");
                }
            }
            else
            {
                MessageError("El campo usuarios es obligatorio.");
            }
        }
        public void MessageError(string msg)
        {
            lbError.Text = msg;
            lbError.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Text = "Password";
            txtPass.UseSystemPasswordChar = false;
            txtUser.Text = "Username";
            lbError.Visible = false;
            this.Show();
        }
    }
}
