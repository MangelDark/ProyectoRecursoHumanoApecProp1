namespace CapaPresentacion.FrmMantenimientos
{
    partial class FrmPuesto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNivelSalarioMaximo = new System.Windows.Forms.TextBox();
            this.txtNivelMinimoSalario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnInactivo = new System.Windows.Forms.RadioButton();
            this.rdBtnActivo = new System.Windows.Forms.RadioButton();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboxNivelRiesgoPuesto = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgtPuesto = new System.Windows.Forms.DataGridView();
            this.LbErrorNombre = new System.Windows.Forms.Label();
            this.lbSueldoMinimo = new System.Windows.Forms.Label();
            this.lbSueldoMaximoError = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtPuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(16, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel de riesgo puesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(316, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel maximo del salario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(312, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel minimo del salario:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(90, 13);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 21);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtNivelSalarioMaximo
            // 
            this.txtNivelSalarioMaximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtNivelSalarioMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNivelSalarioMaximo.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelSalarioMaximo.ForeColor = System.Drawing.Color.White;
            this.txtNivelSalarioMaximo.Location = new System.Drawing.Point(499, 86);
            this.txtNivelSalarioMaximo.Name = "txtNivelSalarioMaximo";
            this.txtNivelSalarioMaximo.Size = new System.Drawing.Size(120, 21);
            this.txtNivelSalarioMaximo.TabIndex = 7;
            this.txtNivelSalarioMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivelSalarioMaximo_KeyPress);
            this.txtNivelSalarioMaximo.Leave += new System.EventHandler(this.txtNivelSalarioMaximo_Leave);
            // 
            // txtNivelMinimoSalario
            // 
            this.txtNivelMinimoSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtNivelMinimoSalario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNivelMinimoSalario.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNivelMinimoSalario.ForeColor = System.Drawing.Color.White;
            this.txtNivelMinimoSalario.Location = new System.Drawing.Point(498, 15);
            this.txtNivelMinimoSalario.Name = "txtNivelMinimoSalario";
            this.txtNivelMinimoSalario.Size = new System.Drawing.Size(120, 21);
            this.txtNivelMinimoSalario.TabIndex = 8;
            this.txtNivelMinimoSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNivelMinimoSalario_KeyPress);
            this.txtNivelMinimoSalario.Leave += new System.EventHandler(this.txtNivelMinimoSalario_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnInactivo);
            this.groupBox1.Controls.Add(this.rdBtnActivo);
            this.groupBox1.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado puesto:";
            // 
            // rdBtnInactivo
            // 
            this.rdBtnInactivo.AutoSize = true;
            this.rdBtnInactivo.Location = new System.Drawing.Point(129, 33);
            this.rdBtnInactivo.Name = "rdBtnInactivo";
            this.rdBtnInactivo.Size = new System.Drawing.Size(80, 24);
            this.rdBtnInactivo.TabIndex = 1;
            this.rdBtnInactivo.Text = "Inactivo";
            this.rdBtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rdBtnActivo
            // 
            this.rdBtnActivo.AutoSize = true;
            this.rdBtnActivo.Checked = true;
            this.rdBtnActivo.Location = new System.Drawing.Point(21, 33);
            this.rdBtnActivo.Name = "rdBtnActivo";
            this.rdBtnActivo.Size = new System.Drawing.Size(70, 24);
            this.rdBtnActivo.TabIndex = 0;
            this.rdBtnActivo.TabStop = true;
            this.rdBtnActivo.Text = "Activo";
            this.rdBtnActivo.UseVisualStyleBackColor = true;
            // 
            // panelCampos
            // 
            this.panelCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelCampos.Controls.Add(this.lbSueldoMaximoError);
            this.panelCampos.Controls.Add(this.lbSueldoMinimo);
            this.panelCampos.Controls.Add(this.LbErrorNombre);
            this.panelCampos.Controls.Add(this.btnEditar);
            this.panelCampos.Controls.Add(this.panelButtons);
            this.panelCampos.Controls.Add(this.cboxNivelRiesgoPuesto);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.lbNombre);
            this.panelCampos.Controls.Add(this.groupBox1);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.txtNivelMinimoSalario);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.txtNivelSalarioMaximo);
            this.panelCampos.Controls.Add(this.txtNombre);
            this.panelCampos.Controls.Add(this.shapeContainer1);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.ForeColor = System.Drawing.Color.White;
            this.panelCampos.Location = new System.Drawing.Point(0, 0);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(883, 268);
            this.panelCampos.TabIndex = 12;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(20, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditar.Size = new System.Drawing.Size(123, 38);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(625, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(258, 268);
            this.panelButtons.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(19, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelete.Size = new System.Drawing.Size(227, 56);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(19, 79);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClear.Size = new System.Drawing.Size(227, 56);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Limpiar Campos";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(19, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSave.Size = new System.Drawing.Size(227, 56);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Guardar";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboxNivelRiesgoPuesto
            // 
            this.cboxNivelRiesgoPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.cboxNivelRiesgoPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxNivelRiesgoPuesto.ForeColor = System.Drawing.Color.White;
            this.cboxNivelRiesgoPuesto.FormattingEnabled = true;
            this.cboxNivelRiesgoPuesto.Items.AddRange(new object[] {
            "Alta",
            "Medio",
            "Bajo"});
            this.cboxNivelRiesgoPuesto.Location = new System.Drawing.Point(180, 84);
            this.cboxNivelRiesgoPuesto.Name = "cboxNivelRiesgoPuesto";
            this.cboxNivelRiesgoPuesto.Size = new System.Drawing.Size(121, 21);
            this.cboxNivelRiesgoPuesto.TabIndex = 14;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape4,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(883, 268);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 497;
            this.lineShape2.X2 = 618;
            this.lineShape2.Y1 = 111;
            this.lineShape2.Y2 = 111;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 496;
            this.lineShape4.X2 = 617;
            this.lineShape4.Y1 = 39;
            this.lineShape4.Y2 = 39;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 87;
            this.lineShape1.X2 = 307;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgtPuesto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 267);
            this.panel1.TabIndex = 13;
            // 
            // dgtPuesto
            // 
            this.dgtPuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtPuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgtPuesto.Location = new System.Drawing.Point(0, 0);
            this.dgtPuesto.Name = "dgtPuesto";
            this.dgtPuesto.Size = new System.Drawing.Size(883, 267);
            this.dgtPuesto.TabIndex = 0;
            this.dgtPuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtPuesto_CellContentClick);
            // 
            // LbErrorNombre
            // 
            this.LbErrorNombre.AutoSize = true;
            this.LbErrorNombre.Font = new System.Drawing.Font("Industry-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.LbErrorNombre.Location = new System.Drawing.Point(87, 40);
            this.LbErrorNombre.Name = "LbErrorNombre";
            this.LbErrorNombre.Size = new System.Drawing.Size(69, 17);
            this.LbErrorNombre.TabIndex = 16;
            this.LbErrorNombre.Text = "LbNombre";
            this.LbErrorNombre.Visible = false;
            this.LbErrorNombre.Click += new System.EventHandler(this.LbErrorNombre_Click);
            // 
            // lbSueldoMinimo
            // 
            this.lbSueldoMinimo.AutoSize = true;
            this.lbSueldoMinimo.Font = new System.Drawing.Font("Industry-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSueldoMinimo.ForeColor = System.Drawing.Color.Red;
            this.lbSueldoMinimo.Location = new System.Drawing.Point(496, 41);
            this.lbSueldoMinimo.Name = "lbSueldoMinimo";
            this.lbSueldoMinimo.Size = new System.Drawing.Size(105, 17);
            this.lbSueldoMinimo.TabIndex = 17;
            this.lbSueldoMinimo.Text = "LbSalarioMinimo";
            this.lbSueldoMinimo.Visible = false;
            // 
            // lbSueldoMaximoError
            // 
            this.lbSueldoMaximoError.AutoSize = true;
            this.lbSueldoMaximoError.Font = new System.Drawing.Font("Industry-Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSueldoMaximoError.ForeColor = System.Drawing.Color.Red;
            this.lbSueldoMaximoError.Location = new System.Drawing.Point(496, 114);
            this.lbSueldoMaximoError.Name = "lbSueldoMaximoError";
            this.lbSueldoMaximoError.Size = new System.Drawing.Size(109, 17);
            this.lbSueldoMaximoError.TabIndex = 18;
            this.lbSueldoMaximoError.Text = "LbSalarioMaximo";
            this.lbSueldoMaximoError.Visible = false;
            // 
            // FrmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPuesto";
            this.Text = "Mantenimiento Puesto";
            this.Load += new System.EventHandler(this.FrmPuesto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtPuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNivelSalarioMaximo;
        private System.Windows.Forms.TextBox txtNivelMinimoSalario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnInactivo;
        private System.Windows.Forms.RadioButton rdBtnActivo;
        private System.Windows.Forms.Panel panelCampos;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox cboxNivelRiesgoPuesto;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgtPuesto;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbSueldoMaximoError;
        private System.Windows.Forms.Label lbSueldoMinimo;
        private System.Windows.Forms.Label LbErrorNombre;
    }
}