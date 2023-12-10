namespace Proyecto__Emmanuel_Josue.Formularios
{
    partial class FrmClases
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.DgvListaClases = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.ColID_Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre_Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClases)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Crimson;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.ForeColor = System.Drawing.Color.Snow;
            this.BtnCerrar.Location = new System.Drawing.Point(25, 481);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(256, 116);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // DgvListaClases
            // 
            this.DgvListaClases.AllowUserToAddRows = false;
            this.DgvListaClases.AllowUserToDeleteRows = false;
            this.DgvListaClases.AllowUserToOrderColumns = true;
            this.DgvListaClases.BackgroundColor = System.Drawing.Color.SaddleBrown;
            this.DgvListaClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID_Clase,
            this.ColNombre_Clase,
            this.ColHorario,
            this.ColNivel});
            this.DgvListaClases.GridColor = System.Drawing.Color.Linen;
            this.DgvListaClases.Location = new System.Drawing.Point(305, 12);
            this.DgvListaClases.MultiSelect = false;
            this.DgvListaClases.Name = "DgvListaClases";
            this.DgvListaClases.ReadOnly = true;
            this.DgvListaClases.RowHeadersVisible = false;
            this.DgvListaClases.RowHeadersWidth = 82;
            this.DgvListaClases.RowTemplate.Height = 33;
            this.DgvListaClases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaClases.Size = new System.Drawing.Size(1131, 942);
            this.DgvListaClases.TabIndex = 12;
            this.DgvListaClases.VirtualMode = true;
            this.DgvListaClases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClases_CellClick);
            this.DgvListaClases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClases_CellContentClick);
            this.DgvListaClases.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaClases_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 103);
            this.label1.TabIndex = 13;
            this.label1.Text = "Listas de las Clases";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Snow;
            this.BtnEliminar.Location = new System.Drawing.Point(25, 240);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(256, 116);
            this.BtnEliminar.TabIndex = 15;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // ColID_Clase
            // 
            this.ColID_Clase.DataPropertyName = "ID_Clase";
            this.ColID_Clase.HeaderText = "ID_Clase";
            this.ColID_Clase.MinimumWidth = 10;
            this.ColID_Clase.Name = "ColID_Clase";
            this.ColID_Clase.ReadOnly = true;
            this.ColID_Clase.Width = 200;
            // 
            // ColNombre_Clase
            // 
            this.ColNombre_Clase.DataPropertyName = "Nombre_Clase";
            this.ColNombre_Clase.HeaderText = "Nombre_Clase";
            this.ColNombre_Clase.MinimumWidth = 10;
            this.ColNombre_Clase.Name = "ColNombre_Clase";
            this.ColNombre_Clase.ReadOnly = true;
            this.ColNombre_Clase.Width = 200;
            // 
            // ColHorario
            // 
            this.ColHorario.DataPropertyName = "Horario";
            this.ColHorario.HeaderText = "Horario";
            this.ColHorario.MinimumWidth = 10;
            this.ColHorario.Name = "ColHorario";
            this.ColHorario.ReadOnly = true;
            this.ColHorario.Width = 200;
            // 
            // ColNivel
            // 
            this.ColNivel.DataPropertyName = "Nivel";
            this.ColNivel.HeaderText = "Nivel";
            this.ColNivel.MinimumWidth = 10;
            this.ColNivel.Name = "ColNivel";
            this.ColNivel.ReadOnly = true;
            this.ColNivel.Width = 200;
            // 
            // FrmClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1448, 966);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.DgvListaClases);
            this.Name = "FrmClases";
            this.Text = "FrmClases";
            this.Load += new System.EventHandler(this.FrmClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.DataGridView DgvListaClases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID_Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre_Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNivel;
    }
}