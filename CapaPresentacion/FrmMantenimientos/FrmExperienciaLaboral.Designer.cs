namespace CapaPresentacion.FrmMantenimientos
{
    partial class FrmExperienciaLaboral
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.ErrorMessageCandidato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.candidatoSelected = new System.Windows.Forms.ComboBox();
            this.lbPuestoError = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.groupBoxExperienciaLab = new System.Windows.Forms.GroupBox();
            this.lbHastaError = new System.Windows.Forms.Label();
            this.lbDesdeError = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtPuestoOcupado = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelCampos.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBoxExperienciaLab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelCampos.Controls.Add(this.btnEditar);
            this.panelCampos.Controls.Add(this.ErrorMessageCandidato);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.candidatoSelected);
            this.panelCampos.Controls.Add(this.lbPuestoError);
            this.panelCampos.Controls.Add(this.panelButtons);
            this.panelCampos.Controls.Add(this.lbNombre);
            this.panelCampos.Controls.Add(this.groupBoxExperienciaLab);
            this.panelCampos.Controls.Add(this.txtPuestoOcupado);
            this.panelCampos.Controls.Add(this.shapeContainer1);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.ForeColor = System.Drawing.Color.White;
            this.panelCampos.Location = new System.Drawing.Point(0, 0);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(900, 217);
            this.panelCampos.TabIndex = 14;
            this.panelCampos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCampos_Paint);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(12, 176);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditar.Size = new System.Drawing.Size(123, 38);
            this.btnEditar.TabIndex = 17;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // ErrorMessageCandidato
            // 
            this.ErrorMessageCandidato.AutoSize = true;
            this.ErrorMessageCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageCandidato.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageCandidato.Location = new System.Drawing.Point(93, 104);
            this.ErrorMessageCandidato.Name = "ErrorMessageCandidato";
            this.ErrorMessageCandidato.Size = new System.Drawing.Size(103, 18);
            this.ErrorMessageCandidato.TabIndex = 16;
            this.ErrorMessageCandidato.Text = "ErrorMessage";
            this.ErrorMessageCandidato.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Candidato:";
            // 
            // candidatoSelected
            // 
            this.candidatoSelected.FormattingEnabled = true;
            this.candidatoSelected.Location = new System.Drawing.Point(95, 80);
            this.candidatoSelected.Name = "candidatoSelected";
            this.candidatoSelected.Size = new System.Drawing.Size(160, 21);
            this.candidatoSelected.TabIndex = 14;
            // 
            // lbPuestoError
            // 
            this.lbPuestoError.AutoSize = true;
            this.lbPuestoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuestoError.ForeColor = System.Drawing.Color.Red;
            this.lbPuestoError.Location = new System.Drawing.Point(145, 44);
            this.lbPuestoError.Name = "lbPuestoError";
            this.lbPuestoError.Size = new System.Drawing.Size(103, 18);
            this.lbPuestoError.TabIndex = 13;
            this.lbPuestoError.Text = "ErrorMessage";
            this.lbPuestoError.Visible = false;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(642, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(258, 217);
            this.panelButtons.TabIndex = 12;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(10, 15);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(133, 18);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Puesto que ocupo:";
            // 
            // groupBoxExperienciaLab
            // 
            this.groupBoxExperienciaLab.Controls.Add(this.lbHastaError);
            this.groupBoxExperienciaLab.Controls.Add(this.lbDesdeError);
            this.groupBoxExperienciaLab.Controls.Add(this.dateTimeHasta);
            this.groupBoxExperienciaLab.Controls.Add(this.dateTimeDesde);
            this.groupBoxExperienciaLab.Controls.Add(this.label4);
            this.groupBoxExperienciaLab.Controls.Add(this.label3);
            this.groupBoxExperienciaLab.Controls.Add(this.textBox4);
            this.groupBoxExperienciaLab.Controls.Add(this.textBox3);
            this.groupBoxExperienciaLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExperienciaLab.ForeColor = System.Drawing.Color.White;
            this.groupBoxExperienciaLab.Location = new System.Drawing.Point(333, 10);
            this.groupBoxExperienciaLab.Name = "groupBoxExperienciaLab";
            this.groupBoxExperienciaLab.Size = new System.Drawing.Size(303, 175);
            this.groupBoxExperienciaLab.TabIndex = 10;
            this.groupBoxExperienciaLab.TabStop = false;
            this.groupBoxExperienciaLab.Text = "Experiencia Laboral";
            // 
            // lbHastaError
            // 
            this.lbHastaError.AutoSize = true;
            this.lbHastaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHastaError.ForeColor = System.Drawing.Color.Red;
            this.lbHastaError.Location = new System.Drawing.Point(66, 143);
            this.lbHastaError.Name = "lbHastaError";
            this.lbHastaError.Size = new System.Drawing.Size(103, 18);
            this.lbHastaError.TabIndex = 12;
            this.lbHastaError.Text = "ErrorMessage";
            this.lbHastaError.Visible = false;
            // 
            // lbDesdeError
            // 
            this.lbDesdeError.AutoSize = true;
            this.lbDesdeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesdeError.ForeColor = System.Drawing.Color.Red;
            this.lbDesdeError.Location = new System.Drawing.Point(66, 69);
            this.lbDesdeError.Name = "lbDesdeError";
            this.lbDesdeError.Size = new System.Drawing.Size(103, 18);
            this.lbDesdeError.TabIndex = 11;
            this.lbDesdeError.Text = "ErrorMessage";
            this.lbDesdeError.Visible = false;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeHasta.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimeHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dateTimeHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeHasta.Location = new System.Drawing.Point(66, 107);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 24);
            this.dateTimeHasta.TabIndex = 10;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.dateTimeDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDesde.Location = new System.Drawing.Point(66, 32);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 24);
            this.dateTimeDesde.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Desde:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(66, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 19);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(66, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 19);
            this.textBox3.TabIndex = 7;
            // 
            // txtPuestoOcupado
            // 
            this.txtPuestoOcupado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtPuestoOcupado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPuestoOcupado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuestoOcupado.ForeColor = System.Drawing.Color.White;
            this.txtPuestoOcupado.Location = new System.Drawing.Point(148, 18);
            this.txtPuestoOcupado.Name = "txtPuestoOcupado";
            this.txtPuestoOcupado.Size = new System.Drawing.Size(158, 19);
            this.txtPuestoOcupado.TabIndex = 5;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 217);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 146;
            this.lineShape1.X2 = 307;
            this.lineShape1.Y1 = 40;
            this.lineShape1.Y2 = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 338);
            this.panel1.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmExperienciaLaboral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExperienciaLaboral";
            this.Text = "Mantenimiento Experiencia Laboral";
            this.Load += new System.EventHandler(this.FrmExperienciaLaboral_Load);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.groupBoxExperienciaLab.ResumeLayout(false);
            this.groupBoxExperienciaLab.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtPuestoOcupado;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBoxExperienciaLab;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbPuestoError;
        private System.Windows.Forms.Label lbHastaError;
        private System.Windows.Forms.Label lbDesdeError;
        private System.Windows.Forms.Label ErrorMessageCandidato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox candidatoSelected;
        private System.Windows.Forms.Button btnEditar;
    }
}