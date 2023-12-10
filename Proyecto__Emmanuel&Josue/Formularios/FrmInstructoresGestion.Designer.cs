namespace Proyecto__Emmanuel_Josue.Formularios
{
    partial class FrmInstructoresGestion
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtContrasenniaInstructor = new System.Windows.Forms.TextBox();
            this.TxtIDInstructor = new System.Windows.Forms.TextBox();
            this.TxtInstructorTelefono = new System.Windows.Forms.TextBox();
            this.TxtInstructorEmail = new System.Windows.Forms.TextBox();
            this.TxtInstructorApellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtInstructorNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvListaInstructores = new System.Windows.Forms.DataGridView();
            this.ColID_Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColContrasennia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaInstructores)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Gold;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.Snow;
            this.BtnModificar.Location = new System.Drawing.Point(1212, 419);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(183, 57);
            this.BtnModificar.TabIndex = 15;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Snow;
            this.BtnEliminar.Location = new System.Drawing.Point(1007, 533);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(183, 57);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Snow;
            this.BtnCerrar.Location = new System.Drawing.Point(1244, 683);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(175, 57);
            this.BtnCerrar.TabIndex = 13;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.LightBlue;
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Snow;
            this.BtnLimpiar.Location = new System.Drawing.Point(1212, 533);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(183, 57);
            this.BtnLimpiar.TabIndex = 12;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Green;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.Snow;
            this.BtnAgregar.Location = new System.Drawing.Point(1007, 419);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(183, 57);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtContrasenniaInstructor);
            this.groupBox1.Controls.Add(this.TxtIDInstructor);
            this.groupBox1.Controls.Add(this.TxtInstructorTelefono);
            this.groupBox1.Controls.Add(this.TxtInstructorEmail);
            this.groupBox1.Controls.Add(this.TxtInstructorApellido);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtInstructorNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 404);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 348);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Requerida por instructor";
            // 
            // TxtContrasenniaInstructor
            // 
            this.TxtContrasenniaInstructor.Location = new System.Drawing.Point(135, 235);
            this.TxtContrasenniaInstructor.Name = "TxtContrasenniaInstructor";
            this.TxtContrasenniaInstructor.Size = new System.Drawing.Size(413, 31);
            this.TxtContrasenniaInstructor.TabIndex = 18;
            // 
            // TxtIDInstructor
            // 
            this.TxtIDInstructor.Location = new System.Drawing.Point(121, 41);
            this.TxtIDInstructor.Name = "TxtIDInstructor";
            this.TxtIDInstructor.Size = new System.Drawing.Size(427, 31);
            this.TxtIDInstructor.TabIndex = 15;
            // 
            // TxtInstructorTelefono
            // 
            this.TxtInstructorTelefono.Location = new System.Drawing.Point(121, 192);
            this.TxtInstructorTelefono.Name = "TxtInstructorTelefono";
            this.TxtInstructorTelefono.Size = new System.Drawing.Size(427, 31);
            this.TxtInstructorTelefono.TabIndex = 14;
            // 
            // TxtInstructorEmail
            // 
            this.TxtInstructorEmail.Location = new System.Drawing.Point(121, 155);
            this.TxtInstructorEmail.Name = "TxtInstructorEmail";
            this.TxtInstructorEmail.Size = new System.Drawing.Size(427, 31);
            this.TxtInstructorEmail.TabIndex = 13;
            // 
            // TxtInstructorApellido
            // 
            this.TxtInstructorApellido.Location = new System.Drawing.Point(121, 117);
            this.TxtInstructorApellido.Name = "TxtInstructorApellido";
            this.TxtInstructorApellido.Size = new System.Drawing.Size(427, 31);
            this.TxtInstructorApellido.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Contrasena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // TxtInstructorNombre
            // 
            this.TxtInstructorNombre.Location = new System.Drawing.Point(121, 80);
            this.TxtInstructorNombre.Name = "TxtInstructorNombre";
            this.TxtInstructorNombre.Size = new System.Drawing.Size(427, 31);
            this.TxtInstructorNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // DgvListaInstructores
            // 
            this.DgvListaInstructores.AllowUserToAddRows = false;
            this.DgvListaInstructores.AllowUserToDeleteRows = false;
            this.DgvListaInstructores.AllowUserToOrderColumns = true;
            this.DgvListaInstructores.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.DgvListaInstructores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaInstructores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID_Instructor,
            this.ColNombre,
            this.ColApellido,
            this.ColEmail,
            this.ColTelefono,
            this.ColContrasennia});
            this.DgvListaInstructores.GridColor = System.Drawing.Color.Linen;
            this.DgvListaInstructores.Location = new System.Drawing.Point(2, 4);
            this.DgvListaInstructores.MultiSelect = false;
            this.DgvListaInstructores.Name = "DgvListaInstructores";
            this.DgvListaInstructores.ReadOnly = true;
            this.DgvListaInstructores.RowHeadersVisible = false;
            this.DgvListaInstructores.RowHeadersWidth = 82;
            this.DgvListaInstructores.RowTemplate.Height = 33;
            this.DgvListaInstructores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaInstructores.Size = new System.Drawing.Size(1438, 379);
            this.DgvListaInstructores.TabIndex = 9;
            this.DgvListaInstructores.VirtualMode = true;
            this.DgvListaInstructores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaInstructores_CellClick);
            this.DgvListaInstructores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaInstructores_CellContentClick);
            this.DgvListaInstructores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaInstructores_DataBindingComplete);
            // 
            // ColID_Instructor
            // 
            this.ColID_Instructor.DataPropertyName = "ID_Instructor";
            this.ColID_Instructor.HeaderText = "ID";
            this.ColID_Instructor.MinimumWidth = 10;
            this.ColID_Instructor.Name = "ColID_Instructor";
            this.ColID_Instructor.ReadOnly = true;
            this.ColID_Instructor.Width = 200;
            // 
            // ColNombre
            // 
            this.ColNombre.DataPropertyName = "Nombre";
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.MinimumWidth = 10;
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            this.ColNombre.Width = 200;
            // 
            // ColApellido
            // 
            this.ColApellido.DataPropertyName = "Apellido";
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.MinimumWidth = 10;
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            this.ColApellido.Width = 200;
            // 
            // ColEmail
            // 
            this.ColEmail.DataPropertyName = "Email";
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.MinimumWidth = 10;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 200;
            // 
            // ColTelefono
            // 
            this.ColTelefono.DataPropertyName = "Telefono";
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.MinimumWidth = 10;
            this.ColTelefono.Name = "ColTelefono";
            this.ColTelefono.ReadOnly = true;
            this.ColTelefono.Width = 200;
            // 
            // ColContrasennia
            // 
            this.ColContrasennia.DataPropertyName = "Contrasennia";
            this.ColContrasennia.HeaderText = "Contrasennia";
            this.ColContrasennia.MinimumWidth = 10;
            this.ColContrasennia.Name = "ColContrasennia";
            this.ColContrasennia.ReadOnly = true;
            this.ColContrasennia.Width = 200;
            // 
            // FrmInstructoresGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 743);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvListaInstructores);
            this.Name = "FrmInstructoresGestion";
            this.Text = "Gestion de Instrucotres";
            this.Load += new System.EventHandler(this.FrmInstructoresGestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaInstructores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtIDInstructor;
        private System.Windows.Forms.TextBox TxtInstructorTelefono;
        private System.Windows.Forms.TextBox TxtInstructorEmail;
        private System.Windows.Forms.TextBox TxtInstructorApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtInstructorNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtContrasenniaInstructor;
        private System.Windows.Forms.DataGridView DgvListaInstructores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID_Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColContrasennia;
    }
}