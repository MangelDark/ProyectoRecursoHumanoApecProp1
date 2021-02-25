using CapaPresentacion.FrmMantenimientos;
using Common;
using FontAwesome.Sharp;
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


namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        //Fields
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public MenuPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);

            //Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(24, 161, 255);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 68);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.Image = currentBtn.Image;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(childForm);
            panelPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.Image = pictureBox2.Image;
            lblTitleChildForm.Text = "Inicio";
        }
        private void LoadUserData()
        {
            lbName.Text = UserCache.FirstName;
            lbLastName.Text = UserCache.LastName;
            lbPosition.Text = UserCache.Position;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //End Methods
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            if (MessageBox.Show("¿Estás seguro de cerrar sesión?", "Advertencia",
          MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            if(UserCache.Position == Positions.Accounting)
            {
                btnCapacitacion.Enabled = false;
                btnCompetencia.Enabled= false;
            }
            if (UserCache.Position == Positions.Receptionist)
            {
                btnExperienciaLaboral.Enabled = false;
                btnIdioma.Enabled = false;
            }
            if (UserCache.Position == Positions.Administrator)
            {

            }
        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {

            FrmCapacitacion frmCapacitacion = new FrmCapacitacion();
            OpenChildForm(frmCapacitacion);
            ActivateButton(sender, RGBColors.color1);
            SubMenuConfig.Visible = false;
            panelSubMenuNavBar.Visible = false;


        }
        private void btnCompetencia_Click(object sender, EventArgs e)
        {
            FrmCompetencia frmCompetencia = new FrmCompetencia();
            OpenChildForm(frmCompetencia);
            ActivateButton(sender, RGBColors.color2);
            SubMenuConfig.Visible = false;
            panelSubMenuNavBar.Visible = false;


        }
        private void btnExperienciaLaboral_Click(object sender, EventArgs e)
        {
            FrmExperienciaLaboral frmExperienciaLaboral = new FrmExperienciaLaboral();
            OpenChildForm(frmExperienciaLaboral);
            ActivateButton(sender, RGBColors.color3);
            SubMenuConfig.Visible = false;
            panelSubMenuNavBar.Visible = false;



        }
        private void btnIdioma_Click(object sender, EventArgs e)
        {

            FrmIdioma frmIdioma = new FrmIdioma();
            OpenChildForm(frmIdioma);
            ActivateButton(sender, RGBColors.color4);
            SubMenuConfig.Visible = false;
            panelSubMenuNavBar.Visible = false;


        }
        private void btnPuesto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            FrmPuesto frmPuesto = new FrmPuesto();
            OpenChildForm(frmPuesto);
            SubMenuConfig.Visible = false;
            panelSubMenuNavBar.Visible = false;



        }
        private void iconbtnPuesto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
           
            }
            else
            {
                WindowState = FormWindowState.Normal;
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCandidato_Click(object sender, EventArgs e)
        {
            FrmCandidato frmCandidato = new FrmCandidato();
            OpenChildForm(frmCandidato);
            ActivateButton(sender, RGBColors.color2);
            SubMenuConfig.Visible = false;
            panelSubMenuNavBar.Visible = false;


        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {                  
                SubMenuConfig.Visible = true;
                SubMenuConfig.BringToFront();
                panelSubMenuNavBar.Visible = false;

        }

        private void pictureBox4_DoubleClick(object sender, EventArgs e)
        {
            SubMenuConfig.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSubMenuNavBar.Visible = true;
            ActivateButton(sender, RGBColors.color2);
            panelSubMenuNavBar.BringToFront();

        }
    }
}
