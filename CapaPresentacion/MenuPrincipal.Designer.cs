namespace CapaPresentacion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCandidato = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCapacitacion = new System.Windows.Forms.Button();
            this.btnCompetencia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btnPuesto = new System.Windows.Forms.Button();
            this.btnExperienciaLaboral = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.lbPosition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.panelUserInformacion = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new System.Windows.Forms.PictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SubMenuConfig = new System.Windows.Forms.Panel();
            this.panelSubMenuNavBar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBarra.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelUserInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SubMenuConfig.SuspendLayout();
            this.panelSubMenuNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.panelBarra.Controls.Add(this.panel2);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1100, 32);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.Click += new System.EventHandler(this.panelBarra_Click);
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnminimizar);
            this.panel2.Controls.Add(this.btnMaximized);
            this.panel2.Controls.Add(this.btncerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(920, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 32);
            this.panel2.TabIndex = 8;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnminimizar.Image")));
            this.btnminimizar.Location = new System.Drawing.Point(100, 5);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(20, 23);
            this.btnminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnminimizar.TabIndex = 12;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximized.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximized.Image")));
            this.btnMaximized.Location = new System.Drawing.Point(128, 5);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(20, 23);
            this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximized.TabIndex = 13;
            this.btnMaximized.TabStop = false;
            this.btnMaximized.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(154, 5);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(20, 23);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 11;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnCandidato);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(207, 627);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Click += new System.EventHandler(this.panelMenu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 137);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(207, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "Empleados";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnCandidato
            // 
            this.btnCandidato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCandidato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCandidato.FlatAppearance.BorderSize = 0;
            this.btnCandidato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCandidato.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidato.ForeColor = System.Drawing.Color.Silver;
            this.btnCandidato.Image = ((System.Drawing.Image)(resources.GetObject("btnCandidato.Image")));
            this.btnCandidato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCandidato.Location = new System.Drawing.Point(0, 74);
            this.btnCandidato.Name = "btnCandidato";
            this.btnCandidato.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCandidato.Size = new System.Drawing.Size(207, 63);
            this.btnCandidato.TabIndex = 6;
            this.btnCandidato.Text = "Candidatos";
            this.btnCandidato.UseVisualStyleBackColor = false;
            this.btnCandidato.Click += new System.EventHandler(this.btnCandidato_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Silver;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 67);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCerrarSesion.Size = new System.Drawing.Size(232, 49);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnCapacitacion
            // 
            this.btnCapacitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCapacitacion.FlatAppearance.BorderSize = 0;
            this.btnCapacitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacitacion.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacitacion.ForeColor = System.Drawing.Color.Silver;
            this.btnCapacitacion.Image = ((System.Drawing.Image)(resources.GetObject("btnCapacitacion.Image")));
            this.btnCapacitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapacitacion.Location = new System.Drawing.Point(3, 271);
            this.btnCapacitacion.Name = "btnCapacitacion";
            this.btnCapacitacion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCapacitacion.Size = new System.Drawing.Size(198, 63);
            this.btnCapacitacion.TabIndex = 0;
            this.btnCapacitacion.Text = "Capacitaciones";
            this.btnCapacitacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapacitacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapacitacion.UseVisualStyleBackColor = false;
            this.btnCapacitacion.Click += new System.EventHandler(this.btnCapacitacion_Click);
            // 
            // btnCompetencia
            // 
            this.btnCompetencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnCompetencia.FlatAppearance.BorderSize = 0;
            this.btnCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetencia.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetencia.ForeColor = System.Drawing.Color.Silver;
            this.btnCompetencia.Image = ((System.Drawing.Image)(resources.GetObject("btnCompetencia.Image")));
            this.btnCompetencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetencia.Location = new System.Drawing.Point(0, 3);
            this.btnCompetencia.Name = "btnCompetencia";
            this.btnCompetencia.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCompetencia.Size = new System.Drawing.Size(200, 63);
            this.btnCompetencia.TabIndex = 1;
            this.btnCompetencia.Text = "Competencias";
            this.btnCompetencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompetencia.UseVisualStyleBackColor = false;
            this.btnCompetencia.Click += new System.EventHandler(this.btnCompetencia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lbtitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Industry-Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Industry-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(72, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recursos Humanos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Industry-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(117, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "De";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 56);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbtitulo.Font = new System.Drawing.Font("Industry-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitulo.ForeColor = System.Drawing.Color.Silver;
            this.lbtitulo.Location = new System.Drawing.Point(101, 8);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(57, 17);
            this.lbtitulo.TabIndex = 6;
            this.lbtitulo.Text = "Sistema";
            // 
            // btnPuesto
            // 
            this.btnPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnPuesto.FlatAppearance.BorderSize = 0;
            this.btnPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPuesto.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPuesto.ForeColor = System.Drawing.Color.Silver;
            this.btnPuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnPuesto.Image")));
            this.btnPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPuesto.Location = new System.Drawing.Point(1, 203);
            this.btnPuesto.Name = "btnPuesto";
            this.btnPuesto.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPuesto.Size = new System.Drawing.Size(200, 63);
            this.btnPuesto.TabIndex = 4;
            this.btnPuesto.Text = "Puestos";
            this.btnPuesto.UseVisualStyleBackColor = false;
            this.btnPuesto.Click += new System.EventHandler(this.btnPuesto_Click);
            // 
            // btnExperienciaLaboral
            // 
            this.btnExperienciaLaboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnExperienciaLaboral.FlatAppearance.BorderSize = 0;
            this.btnExperienciaLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExperienciaLaboral.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExperienciaLaboral.ForeColor = System.Drawing.Color.Silver;
            this.btnExperienciaLaboral.Image = ((System.Drawing.Image)(resources.GetObject("btnExperienciaLaboral.Image")));
            this.btnExperienciaLaboral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExperienciaLaboral.Location = new System.Drawing.Point(0, 135);
            this.btnExperienciaLaboral.Name = "btnExperienciaLaboral";
            this.btnExperienciaLaboral.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExperienciaLaboral.Size = new System.Drawing.Size(200, 63);
            this.btnExperienciaLaboral.TabIndex = 2;
            this.btnExperienciaLaboral.Text = "Experiencia Lab.";
            this.btnExperienciaLaboral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExperienciaLaboral.UseVisualStyleBackColor = false;
            this.btnExperienciaLaboral.Click += new System.EventHandler(this.btnExperienciaLaboral_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnIdioma.FlatAppearance.BorderSize = 0;
            this.btnIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdioma.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdioma.ForeColor = System.Drawing.Color.Silver;
            this.btnIdioma.Image = ((System.Drawing.Image)(resources.GetObject("btnIdioma.Image")));
            this.btnIdioma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdioma.Location = new System.Drawing.Point(0, 67);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnIdioma.Size = new System.Drawing.Size(200, 63);
            this.btnIdioma.TabIndex = 3;
            this.btnIdioma.Text = "Idiomas";
            this.btnIdioma.UseVisualStyleBackColor = false;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Industry-Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.ForeColor = System.Drawing.Color.Silver;
            this.lbPosition.Location = new System.Drawing.Point(65, 8);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(87, 21);
            this.lbPosition.TabIndex = 3;
            this.lbPosition.Text = "TypeUsers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(3, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Industry-Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.Color.Silver;
            this.lbLastName.Location = new System.Drawing.Point(66, 46);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(68, 16);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "LastName";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Industry-Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Silver;
            this.lbName.Location = new System.Drawing.Point(66, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(42, 16);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelPrincipal.Controls.Add(this.panelSubMenuNavBar);
            this.panelPrincipal.Controls.Add(this.SubMenuConfig);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(207, 104);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(893, 555);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Click += new System.EventHandler(this.panelPrincipal_Click);
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitulo.Controls.Add(this.panelUserInformacion);
            this.panelTitulo.Controls.Add(this.iconCurrentChildForm);
            this.panelTitulo.Controls.Add(this.lblTitleChildForm);
            this.panelTitulo.Controls.Add(this.pictureBox2);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(207, 32);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(893, 72);
            this.panelTitulo.TabIndex = 8;
            this.panelTitulo.Click += new System.EventHandler(this.panelTitulo_Click);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // panelUserInformacion
            // 
            this.panelUserInformacion.Controls.Add(this.pictureBox4);
            this.panelUserInformacion.Controls.Add(this.lbLastName);
            this.panelUserInformacion.Controls.Add(this.pictureBox1);
            this.panelUserInformacion.Controls.Add(this.lbPosition);
            this.panelUserInformacion.Controls.Add(this.lbName);
            this.panelUserInformacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelUserInformacion.Location = new System.Drawing.Point(658, 0);
            this.panelUserInformacion.Name = "panelUserInformacion";
            this.panelUserInformacion.Size = new System.Drawing.Size(235, 72);
            this.panelUserInformacion.TabIndex = 4;
            this.panelUserInformacion.Click += new System.EventHandler(this.panelUserInformacion_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(192, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            this.pictureBox4.DoubleClick += new System.EventHandler(this.pictureBox4_DoubleClick);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.Image = ((System.Drawing.Image)(resources.GetObject("iconCurrentChildForm.Image")));
            this.iconCurrentChildForm.Location = new System.Drawing.Point(13, 21);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(37, 34);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCurrentChildForm.TabIndex = 6;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Silver;
            this.lblTitleChildForm.Location = new System.Drawing.Point(54, 30);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(48, 21);
            this.lblTitleChildForm.TabIndex = 5;
            this.lblTitleChildForm.Text = "Inicio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // SubMenuConfig
            // 
            this.SubMenuConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubMenuConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(100)))));
            this.SubMenuConfig.Controls.Add(this.btnCerrarSesion);
            this.SubMenuConfig.Location = new System.Drawing.Point(661, 0);
            this.SubMenuConfig.Name = "SubMenuConfig";
            this.SubMenuConfig.Size = new System.Drawing.Size(232, 116);
            this.SubMenuConfig.TabIndex = 0;
            this.SubMenuConfig.Visible = false;
            // 
            // panelSubMenuNavBar
            // 
            this.panelSubMenuNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelSubMenuNavBar.Controls.Add(this.btnCompetencia);
            this.panelSubMenuNavBar.Controls.Add(this.btnIdioma);
            this.panelSubMenuNavBar.Controls.Add(this.btnCapacitacion);
            this.panelSubMenuNavBar.Controls.Add(this.btnExperienciaLaboral);
            this.panelSubMenuNavBar.Controls.Add(this.btnPuesto);
            this.panelSubMenuNavBar.Location = new System.Drawing.Point(0, 127);
            this.panelSubMenuNavBar.Name = "panelSubMenuNavBar";
            this.panelSubMenuNavBar.Size = new System.Drawing.Size(204, 338);
            this.panelSubMenuNavBar.TabIndex = 1;
            this.panelSubMenuNavBar.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.button2.Size = new System.Drawing.Size(207, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "Mantenimientos";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 659);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelBarra.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelUserInformacion.ResumeLayout(false);
            this.panelUserInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SubMenuConfig.ResumeLayout(false);
            this.panelSubMenuNavBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnPuesto;
        private System.Windows.Forms.Button btnIdioma;
        private System.Windows.Forms.Button btnExperienciaLaboral;
        private System.Windows.Forms.Button btnCompetencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnCapacitacion;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.PictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.Panel panelUserInformacion;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCandidato;
        private System.Windows.Forms.Panel SubMenuConfig;
        private System.Windows.Forms.Panel panelSubMenuNavBar;
        private System.Windows.Forms.Button button2;
    }
}

