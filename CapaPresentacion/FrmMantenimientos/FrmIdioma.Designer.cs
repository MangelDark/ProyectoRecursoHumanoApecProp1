namespace CapaPresentacion.FrmMantenimientos
{
    partial class FrmIdioma
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNombreIdioma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.groupBoxEstatus = new System.Windows.Forms.GroupBox();
            this.rdbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rdbtnActivo = new System.Windows.Forms.RadioButton();
            this.lbNombre = new System.Windows.Forms.Label();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lbNombreError = new System.Windows.Forms.Label();
            this.lbPaisError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxEstatus.SuspendLayout();
            this.panelCampos.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(900, 339);
            this.dataGridView1.TabIndex = 14;
            // 
            // txtNombreIdioma
            // 
            this.txtNombreIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtNombreIdioma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreIdioma.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreIdioma.ForeColor = System.Drawing.Color.White;
            this.txtNombreIdioma.Location = new System.Drawing.Point(134, 13);
            this.txtNombreIdioma.Name = "txtNombreIdioma";
            this.txtNombreIdioma.Size = new System.Drawing.Size(216, 21);
            this.txtNombreIdioma.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(381, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = " País de origen:";
            // 
            // txtPais
            // 
            this.txtPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPais.Font = new System.Drawing.Font("Industry-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.ForeColor = System.Drawing.Color.White;
            this.txtPais.Location = new System.Drawing.Point(498, 15);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(120, 21);
            this.txtPais.TabIndex = 8;
            // 
            // groupBoxEstatus
            // 
            this.groupBoxEstatus.Controls.Add(this.rdbtnInactivo);
            this.groupBoxEstatus.Controls.Add(this.rdbtnActivo);
            this.groupBoxEstatus.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEstatus.ForeColor = System.Drawing.Color.White;
            this.groupBoxEstatus.Location = new System.Drawing.Point(20, 77);
            this.groupBoxEstatus.Name = "groupBoxEstatus";
            this.groupBoxEstatus.Size = new System.Drawing.Size(246, 76);
            this.groupBoxEstatus.TabIndex = 10;
            this.groupBoxEstatus.TabStop = false;
            this.groupBoxEstatus.Text = "Estado idioma:";
            // 
            // rdbtnInactivo
            // 
            this.rdbtnInactivo.AutoSize = true;
            this.rdbtnInactivo.Location = new System.Drawing.Point(129, 33);
            this.rdbtnInactivo.Name = "rdbtnInactivo";
            this.rdbtnInactivo.Size = new System.Drawing.Size(80, 24);
            this.rdbtnInactivo.TabIndex = 1;
            this.rdbtnInactivo.TabStop = true;
            this.rdbtnInactivo.Text = "Inactivo";
            this.rdbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rdbtnActivo
            // 
            this.rdbtnActivo.AutoSize = true;
            this.rdbtnActivo.Location = new System.Drawing.Point(21, 33);
            this.rdbtnActivo.Name = "rdbtnActivo";
            this.rdbtnActivo.Size = new System.Drawing.Size(70, 24);
            this.rdbtnActivo.TabIndex = 0;
            this.rdbtnActivo.TabStop = true;
            this.rdbtnActivo.Text = "Activo";
            this.rdbtnActivo.UseVisualStyleBackColor = true;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Industry-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.White;
            this.lbNombre.Location = new System.Drawing.Point(16, 18);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(115, 20);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre idioma:";
            // 
            // panelCampos
            // 
            this.panelCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panelCampos.Controls.Add(this.lbPaisError);
            this.panelCampos.Controls.Add(this.lbNombreError);
            this.panelCampos.Controls.Add(this.panelButtons);
            this.panelCampos.Controls.Add(this.lbNombre);
            this.panelCampos.Controls.Add(this.groupBoxEstatus);
            this.panelCampos.Controls.Add(this.txtPais);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.txtNombreIdioma);
            this.panelCampos.Controls.Add(this.shapeContainer1);
            this.panelCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCampos.ForeColor = System.Drawing.Color.White;
            this.panelCampos.Location = new System.Drawing.Point(0, 0);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(900, 216);
            this.panelCampos.TabIndex = 13;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(642, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(258, 216);
            this.panelButtons.TabIndex = 16;
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
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 216);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 496;
            this.lineShape4.X2 = 617;
            this.lineShape4.Y1 = 37;
            this.lineShape4.Y2 = 37;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 130;
            this.lineShape1.X2 = 350;
            this.lineShape1.Y1 = 38;
            this.lineShape1.Y2 = 38;
            // 
            // lbNombreError
            // 
            this.lbNombreError.AutoSize = true;
            this.lbNombreError.Font = new System.Drawing.Font("Industry-Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreError.ForeColor = System.Drawing.Color.Red;
            this.lbNombreError.Location = new System.Drawing.Point(131, 43);
            this.lbNombreError.Name = "lbNombreError";
            this.lbNombreError.Size = new System.Drawing.Size(109, 20);
            this.lbNombreError.TabIndex = 17;
            this.lbNombreError.Text = "ErrorMessage";
            this.lbNombreError.Visible = false;
            // 
            // lbPaisError
            // 
            this.lbPaisError.AutoSize = true;
            this.lbPaisError.Font = new System.Drawing.Font("Industry-Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaisError.ForeColor = System.Drawing.Color.Red;
            this.lbPaisError.Location = new System.Drawing.Point(494, 43);
            this.lbPaisError.Name = "lbPaisError";
            this.lbPaisError.Size = new System.Drawing.Size(109, 20);
            this.lbPaisError.TabIndex = 18;
            this.lbPaisError.Text = "ErrorMessage";
            this.lbPaisError.Visible = false;
            // 
            // FrmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 555);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelCampos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmIdioma";
            this.Text = "Mantenimiento Idiomas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxEstatus.ResumeLayout(false);
            this.groupBoxEstatus.PerformLayout();
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreIdioma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.GroupBox groupBoxEstatus;
        private System.Windows.Forms.RadioButton rdbtnInactivo;
        private System.Windows.Forms.RadioButton rdbtnActivo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Panel panelCampos;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbPaisError;
        private System.Windows.Forms.Label lbNombreError;
    }
}