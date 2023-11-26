namespace Proyecto__Emmanuel_Josue.Formularios
{
    partial class FrmAlumnosGestion
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
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListaAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAlumnoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtApellidosAlumno = new System.Windows.Forms.TextBox();
            this.TxtFechaNacimientoAlumno = new System.Windows.Forms.TextBox();
            this.TxtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.TxtTelefonoAlumno = new System.Windows.Forms.TextBox();
            this.TxtEmailAlumno = new System.Windows.Forms.TextBox();
            this.TxtDataTimeAlumno = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaAlumnos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(99, 12);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(471, 31);
            this.TxtBuscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // DgvListaAlumnos
            // 
            this.DgvListaAlumnos.AllowUserToAddRows = false;
            this.DgvListaAlumnos.AllowUserToDeleteRows = false;
            this.DgvListaAlumnos.AllowUserToOrderColumns = true;
            this.DgvListaAlumnos.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.DgvListaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaAlumnos.GridColor = System.Drawing.Color.Linen;
            this.DgvListaAlumnos.Location = new System.Drawing.Point(12, 69);
            this.DgvListaAlumnos.MultiSelect = false;
            this.DgvListaAlumnos.Name = "DgvListaAlumnos";
            this.DgvListaAlumnos.ReadOnly = true;
            this.DgvListaAlumnos.RowHeadersVisible = false;
            this.DgvListaAlumnos.RowHeadersWidth = 82;
            this.DgvListaAlumnos.RowTemplate.Height = 33;
            this.DgvListaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaAlumnos.Size = new System.Drawing.Size(1459, 322);
            this.DgvListaAlumnos.TabIndex = 2;
            this.DgvListaAlumnos.VirtualMode = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDataTimeAlumno);
            this.groupBox1.Controls.Add(this.TxtEmailAlumno);
            this.groupBox1.Controls.Add(this.TxtTelefonoAlumno);
            this.groupBox1.Controls.Add(this.TxtDireccionAlumno);
            this.groupBox1.Controls.Add(this.TxtFechaNacimientoAlumno);
            this.groupBox1.Controls.Add(this.TxtApellidosAlumno);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtAlumnoNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 398);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1454, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Necesaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(58, 41);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(92, 31);
            this.TxtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // TxtAlumnoNombre
            // 
            this.TxtAlumnoNombre.Location = new System.Drawing.Point(123, 138);
            this.TxtAlumnoNombre.Name = "TxtAlumnoNombre";
            this.TxtAlumnoNombre.Size = new System.Drawing.Size(427, 31);
            this.TxtAlumnoNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(806, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(812, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(812, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "DataTime";
            // 
            // TxtApellidosAlumno
            // 
            this.TxtApellidosAlumno.Location = new System.Drawing.Point(123, 188);
            this.TxtApellidosAlumno.Name = "TxtApellidosAlumno";
            this.TxtApellidosAlumno.Size = new System.Drawing.Size(427, 31);
            this.TxtApellidosAlumno.TabIndex = 10;
            // 
            // TxtFechaNacimientoAlumno
            // 
            this.TxtFechaNacimientoAlumno.Location = new System.Drawing.Point(238, 239);
            this.TxtFechaNacimientoAlumno.Name = "TxtFechaNacimientoAlumno";
            this.TxtFechaNacimientoAlumno.Size = new System.Drawing.Size(312, 31);
            this.TxtFechaNacimientoAlumno.TabIndex = 11;
            // 
            // TxtDireccionAlumno
            // 
            this.TxtDireccionAlumno.Location = new System.Drawing.Point(914, 235);
            this.TxtDireccionAlumno.Multiline = true;
            this.TxtDireccionAlumno.Name = "TxtDireccionAlumno";
            this.TxtDireccionAlumno.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDireccionAlumno.Size = new System.Drawing.Size(369, 109);
            this.TxtDireccionAlumno.TabIndex = 12;
            // 
            // TxtTelefonoAlumno
            // 
            this.TxtTelefonoAlumno.Location = new System.Drawing.Point(914, 132);
            this.TxtTelefonoAlumno.Name = "TxtTelefonoAlumno";
            this.TxtTelefonoAlumno.Size = new System.Drawing.Size(369, 31);
            this.TxtTelefonoAlumno.TabIndex = 13;
            // 
            // TxtEmailAlumno
            // 
            this.TxtEmailAlumno.Location = new System.Drawing.Point(914, 191);
            this.TxtEmailAlumno.Name = "TxtEmailAlumno";
            this.TxtEmailAlumno.Size = new System.Drawing.Size(369, 31);
            this.TxtEmailAlumno.TabIndex = 14;
            // 
            // TxtDataTimeAlumno
            // 
            this.TxtDataTimeAlumno.Location = new System.Drawing.Point(137, 293);
            this.TxtDataTimeAlumno.Name = "TxtDataTimeAlumno";
            this.TxtDataTimeAlumno.Size = new System.Drawing.Size(416, 31);
            this.TxtDataTimeAlumno.TabIndex = 15;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Snow;
            this.BtnAgregar.Location = new System.Drawing.Point(17, 770);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(270, 82);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Snow;
            this.BtnLimpiar.Location = new System.Drawing.Point(953, 770);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(256, 82);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Snow;
            this.BtnCerrar.Location = new System.Drawing.Point(1215, 770);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(256, 82);
            this.BtnCerrar.TabIndex = 6;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Snow;
            this.BtnEliminar.Location = new System.Drawing.Point(586, 770);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(268, 82);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Gold;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Snow;
            this.BtnModificar.Location = new System.Drawing.Point(311, 770);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(259, 82);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // FrmAlumnosGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 926);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaAlumnos);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAlumnosGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaAlumnos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DgvListaAlumnos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAlumnoNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtDataTimeAlumno;
        private System.Windows.Forms.TextBox TxtEmailAlumno;
        private System.Windows.Forms.TextBox TxtTelefonoAlumno;
        private System.Windows.Forms.TextBox TxtDireccionAlumno;
        private System.Windows.Forms.TextBox TxtFechaNacimientoAlumno;
        private System.Windows.Forms.TextBox TxtApellidosAlumno;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
    }
}