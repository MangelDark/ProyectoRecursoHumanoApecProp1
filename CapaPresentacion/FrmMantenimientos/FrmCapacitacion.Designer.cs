namespace CapaPresentacion.FrmMantenimientos
{
    partial class FrmCapacitacion
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
            this.panelCampos = new System.Windows.Forms.Panel();
            this.groupBoxCapacitacion = new System.Windows.Forms.GroupBox();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cboxNivelCapacitacion = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnInactivo = new System.Windows.Forms.RadioButton();
            this.rdBtnActivo = new System.Windows.Forms.RadioButton();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbDescripcionError = new System.Windows.Forms.Label();
            this.lbNiveCapError = new System.Windows.Forms.Label();
            this.lbHastaError = new System.Windows.Forms.Label();
            this.lbDesdeError = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            this.groupBoxCapacitacion.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelCampos.Controls.Add(this.lbHastaError);
            this.panelCampos.Controls.Add(this.lbNiveCapError);
            this.panelCampos.Controls.Add(this.lbDescripcionError);
            this.panelCampos.Controls.Add(this.groupBoxCapacitacion);
            this.panelCampos.Controls.Add(this.cboxNivelCapacitacion);
            this.panelCampos.Controls.Add(this.panelButtons);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.lbNombre);
            this.panelCampos.Controls.Add(this.groupBox1);
            this.panelCampos.Controls.Add(this.txtDescripcion);
            this.panelCampos.Controls.Add(this.shapeContainer1);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.ForeColor = System.Drawing.Color.White;
            this.panelCampos.Location = new System.Drawing.Point(0, 0);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(900, 219);
            this.panelCampos.TabIndex = 15;
            // 
            // groupBoxCapacitacion
            // 
            this.groupBoxCapacitacion.Controls.Add(this.lbDesdeError);
            this.groupBoxCapacitacion.Controls.Add(this.dateTimeHasta);
            this.groupBoxCapacitacion.Controls.Add(this.dateTimeDesde);
            this.groupBoxCapacitacion.Controls.Add(this.label4);
            this.groupBoxCapacitacion.Controls.Add(this.label3);
            this.groupBoxCapacitacion.Controls.Add(this.textBox4);
            this.groupBoxCapacitacion.Controls.Add(this.textBox3);
            this.groupBoxCapacitacion.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCapacitacion.ForeColor = System.Drawing.Color.White;
            this.groupBoxCapacitacion.Location = new System.Drawing.Point(329, 7);
            this.groupBoxCapacitacion.Name = "groupBoxCapacitacion";
            this.groupBoxCapacitacion.Size = new System.Drawing.Size(282, 128);
            this.groupBoxCapacitacion.TabIndex = 15;
            this.groupBoxCapacitacion.TabStop = false;
            this.groupBoxCapacitacion.Text = "Rango de las fechas capacitaciones";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimeHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dateTimeHasta.Font = new System.Drawing.Font("Industry-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(66, 79);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 23);
            this.dateTimeHasta.TabIndex = 10;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dateTimeDesde.Font = new System.Drawing.Font("Industry-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(66, 32);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 23);
            this.dateTimeDesde.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Industry-Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Industry-Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(66, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 21);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(66, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 21);
            this.textBox3.TabIndex = 7;
            // 
            // cboxNivelCapacitacion
            // 
            this.cboxNivelCapacitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.cboxNivelCapacitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxNivelCapacitacion.ForeColor = System.Drawing.Color.White;
            this.cboxNivelCapacitacion.FormattingEnabled = true;
            this.cboxNivelCapacitacion.Location = new System.Drawing.Point(165, 150);
            this.cboxNivelCapacitacion.Name = "cboxNivelCapacitacion";
            this.cboxNivelCapacitacion.Size = new System.Drawing.Size(141, 21);
            this.cboxNivelCapacitacion.TabIndex = 14;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(642, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(258, 219);
            this.panelButtons.TabIndex = 12;
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
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
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
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
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
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel de capacitación:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(7, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(92, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Descripción:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnInactivo);
            this.groupBox1.Controls.Add(this.rdBtnActivo);
            this.groupBox1.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(329, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 66);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado puesto:";
            // 
            // rdBtnInactivo
            // 
            this.rdBtnInactivo.AutoSize = true;
            this.rdBtnInactivo.Location = new System.Drawing.Point(96, 27);
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
            this.rdBtnActivo.Location = new System.Drawing.Point(18, 27);
            this.rdBtnActivo.Name = "rdBtnActivo";
            this.rdBtnActivo.Size = new System.Drawing.Size(70, 24);
            this.rdBtnActivo.TabIndex = 0;
            this.rdBtnActivo.TabStop = true;
            this.rdBtnActivo.Text = "Activo";
            this.rdBtnActivo.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(100, 18);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(206, 70);
            this.txtDescripcion.TabIndex = 5;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 219);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 98;
            this.lineShape1.X2 = 307;
            this.lineShape1.Y1 = 90;
            this.lineShape1.Y2 = 90;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 336);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 336);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbDescripcionError
            // 
            this.lbDescripcionError.AutoSize = true;
            this.lbDescripcionError.Font = new System.Drawing.Font("Industry-Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescripcionError.ForeColor = System.Drawing.Color.Red;
            this.lbDescripcionError.Location = new System.Drawing.Point(96, 98);
            this.lbDescripcionError.Name = "lbDescripcionError";
            this.lbDescripcionError.Size = new System.Drawing.Size(109, 20);
            this.lbDescripcionError.TabIndex = 16;
            this.lbDescripcionError.Text = "ErrorMessage";
            this.lbDescripcionError.Visible = false;
            // 
            // lbNiveCapError
            // 
            this.lbNiveCapError.AutoSize = true;
            this.lbNiveCapError.Font = new System.Drawing.Font("Industry-Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNiveCapError.ForeColor = System.Drawing.Color.Red;
            this.lbNiveCapError.Location = new System.Drawing.Point(167, 174);
            this.lbNiveCapError.Name = "lbNiveCapError";
            this.lbNiveCapError.Size = new System.Drawing.Size(109, 20);
            this.lbNiveCapError.TabIndex = 17;
            this.lbNiveCapError.Text = "ErrorMessage";
            this.lbNiveCapError.Visible = false;
            // 
            // lbHastaError
            // 
            this.lbHastaError.AutoSize = true;
            this.lbHastaError.Font = new System.Drawing.Font("Industry-Black", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHastaError.ForeColor = System.Drawing.Color.Red;
            this.lbHastaError.Location = new System.Drawing.Point(396, 109);
            this.lbHastaError.Name = "lbHastaError";
            this.lbHastaError.Size = new System.Drawing.Size(94, 17);
            this.lbHastaError.TabIndex = 18;
            this.lbHastaError.Text = "ErrorMessage";
            this.lbHastaError.Visible = false;
            // 
            // lbDesdeError
            // 
            this.lbDesdeError.AutoSize = true;
            this.lbDesdeError.Font = new System.Drawing.Font("Industry-Black", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesdeError.ForeColor = System.Drawing.Color.Red;
            this.lbDesdeError.Location = new System.Drawing.Point(69, 56);
            this.lbDesdeError.Name = "lbDesdeError";
            this.lbDesdeError.Size = new System.Drawing.Size(94, 17);
            this.lbDesdeError.TabIndex = 19;
            this.lbDesdeError.Text = "ErrorMessage";
            this.lbDesdeError.Visible = false;
            // 
            // FrmCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCapacitacion";
            this.Text = "Mantenimiento Capacitación";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.groupBoxCapacitacion.ResumeLayout(false);
            this.groupBoxCapacitacion.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.ComboBox cboxNivelCapacitacion;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnInactivo;
        private System.Windows.Forms.RadioButton rdBtnActivo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBoxCapacitacion;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbHastaError;
        private System.Windows.Forms.Label lbNiveCapError;
        private System.Windows.Forms.Label lbDescripcionError;
        private System.Windows.Forms.Label lbDesdeError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}