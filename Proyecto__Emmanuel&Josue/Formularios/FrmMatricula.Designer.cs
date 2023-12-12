namespace Proyecto__Emmanuel_Josue.Formularios
{
    partial class FrmMatricula
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgMatriculas = new System.Windows.Forms.DataGridView();
            this.ID_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.cmbIDClase = new System.Windows.Forms.ComboBox();
            this.cmbIDAlumno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 680);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Clase";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 578);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Alumnos ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(528, 629);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(206, 126);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Green;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(528, 446);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(206, 126);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgMatriculas
            // 
            this.dgMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Matricula,
            this.ID_Alumno,
            this.ID_Clase,
            this.Fecha_Matricula});
            this.dgMatriculas.Location = new System.Drawing.Point(-54, 63);
            this.dgMatriculas.Margin = new System.Windows.Forms.Padding(6);
            this.dgMatriculas.Name = "dgMatriculas";
            this.dgMatriculas.ReadOnly = true;
            this.dgMatriculas.RowHeadersWidth = 82;
            this.dgMatriculas.Size = new System.Drawing.Size(1486, 372);
            this.dgMatriculas.TabIndex = 14;
            // 
            // ID_Matricula
            // 
            this.ID_Matricula.HeaderText = "ID";
            this.ID_Matricula.MinimumWidth = 10;
            this.ID_Matricula.Name = "ID_Matricula";
            this.ID_Matricula.ReadOnly = true;
            this.ID_Matricula.Width = 133;
            // 
            // ID_Alumno
            // 
            this.ID_Alumno.HeaderText = "ID_Alumno";
            this.ID_Alumno.MinimumWidth = 10;
            this.ID_Alumno.Name = "ID_Alumno";
            this.ID_Alumno.ReadOnly = true;
            this.ID_Alumno.Width = 133;
            // 
            // ID_Clase
            // 
            this.ID_Clase.HeaderText = "ID Clase";
            this.ID_Clase.MinimumWidth = 10;
            this.ID_Clase.Name = "ID_Clase";
            this.ID_Clase.ReadOnly = true;
            this.ID_Clase.Width = 133;
            // 
            // Fecha_Matricula
            // 
            this.Fecha_Matricula.HeaderText = "Fecha de la Matricula";
            this.Fecha_Matricula.MinimumWidth = 10;
            this.Fecha_Matricula.Name = "Fecha_Matricula";
            this.Fecha_Matricula.ReadOnly = true;
            this.Fecha_Matricula.Width = 300;
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Location = new System.Drawing.Point(15, 502);
            this.dtpFechaMatricula.Margin = new System.Windows.Forms.Padding(6);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(396, 31);
            this.dtpFechaMatricula.TabIndex = 13;
            // 
            // cmbIDClase
            // 
            this.cmbIDClase.FormattingEnabled = true;
            this.cmbIDClase.Location = new System.Drawing.Point(13, 716);
            this.cmbIDClase.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIDClase.Name = "cmbIDClase";
            this.cmbIDClase.Size = new System.Drawing.Size(396, 33);
            this.cmbIDClase.TabIndex = 12;
            // 
            // cmbIDAlumno
            // 
            this.cmbIDAlumno.FormattingEnabled = true;
            this.cmbIDAlumno.Location = new System.Drawing.Point(13, 614);
            this.cmbIDAlumno.Margin = new System.Windows.Forms.Padding(6);
            this.cmbIDAlumno.Name = "cmbIDAlumno";
            this.cmbIDAlumno.Size = new System.Drawing.Size(396, 33);
            this.cmbIDAlumno.TabIndex = 11;
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 999);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgMatriculas);
            this.Controls.Add(this.dtpFechaMatricula);
            this.Controls.Add(this.cmbIDClase);
            this.Controls.Add(this.cmbIDAlumno);
            this.Name = "FrmMatricula";
            this.Text = "FrmMatriculas";
            this.Load += new System.EventHandler(this.FrmMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgMatriculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Matricula;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.ComboBox cmbIDClase;
        private System.Windows.Forms.ComboBox cmbIDAlumno;
    }
}