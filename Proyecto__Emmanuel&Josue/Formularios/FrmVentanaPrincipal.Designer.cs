namespace Proyecto__Emmanuel_Josue.Formularios
{
    partial class FrmVentanaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aLUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNSTRUCTORESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLASESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATRICULASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaMatriculasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUMNOSToolStripMenuItem,
            this.iNSTRUCTORESToolStripMenuItem,
            this.cLASESToolStripMenuItem,
            this.mATRICULASToolStripMenuItem,
            this.pAGOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1472, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aLUMNOSToolStripMenuItem
            // 
            this.aLUMNOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeAlumnosToolStripMenuItem});
            this.aLUMNOSToolStripMenuItem.Name = "aLUMNOSToolStripMenuItem";
            this.aLUMNOSToolStripMenuItem.Size = new System.Drawing.Size(147, 36);
            this.aLUMNOSToolStripMenuItem.Text = "ALUMNOS";
            // 
            // gestionDeAlumnosToolStripMenuItem
            // 
            this.gestionDeAlumnosToolStripMenuItem.Name = "gestionDeAlumnosToolStripMenuItem";
            this.gestionDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.gestionDeAlumnosToolStripMenuItem.Text = "Gestion de Alumnos";
            this.gestionDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeAlumnosToolStripMenuItem_Click);
            // 
            // iNSTRUCTORESToolStripMenuItem
            // 
            this.iNSTRUCTORESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientesToolStripMenuItem});
            this.iNSTRUCTORESToolStripMenuItem.Name = "iNSTRUCTORESToolStripMenuItem";
            this.iNSTRUCTORESToolStripMenuItem.Size = new System.Drawing.Size(198, 36);
            this.iNSTRUCTORESToolStripMenuItem.Text = "INSTRUCTORES";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(393, 44);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Instructores";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // cLASESToolStripMenuItem
            // 
            this.cLASESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClasesToolStripMenuItem,
            this.gestionDeClaseToolStripMenuItem});
            this.cLASESToolStripMenuItem.Name = "cLASESToolStripMenuItem";
            this.cLASESToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.cLASESToolStripMenuItem.Text = "CLASES";
            // 
            // listaDeClasesToolStripMenuItem
            // 
            this.listaDeClasesToolStripMenuItem.Name = "listaDeClasesToolStripMenuItem";
            this.listaDeClasesToolStripMenuItem.Size = new System.Drawing.Size(325, 44);
            this.listaDeClasesToolStripMenuItem.Text = "Lista de Clases";
            this.listaDeClasesToolStripMenuItem.Click += new System.EventHandler(this.listaDeClasesToolStripMenuItem_Click);
            // 
            // gestionDeClaseToolStripMenuItem
            // 
            this.gestionDeClaseToolStripMenuItem.Name = "gestionDeClaseToolStripMenuItem";
            this.gestionDeClaseToolStripMenuItem.Size = new System.Drawing.Size(325, 44);
            this.gestionDeClaseToolStripMenuItem.Text = "Gestion de Clase";
            this.gestionDeClaseToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClaseToolStripMenuItem_Click);
            // 
            // mATRICULASToolStripMenuItem
            // 
            this.mATRICULASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaMatriculasToolStripMenuItem});
            this.mATRICULASToolStripMenuItem.Name = "mATRICULASToolStripMenuItem";
            this.mATRICULASToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.mATRICULASToolStripMenuItem.Text = "MATRICULAS";
            // 
            // listaMatriculasToolStripMenuItem
            // 
            this.listaMatriculasToolStripMenuItem.Name = "listaMatriculasToolStripMenuItem";
            this.listaMatriculasToolStripMenuItem.Size = new System.Drawing.Size(310, 44);
            this.listaMatriculasToolStripMenuItem.Text = "Lista Matriculas";
            this.listaMatriculasToolStripMenuItem.Click += new System.EventHandler(this.listaMatriculasToolStripMenuItem_Click);
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDePagosToolStripMenuItem});
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(107, 36);
            this.pAGOSToolStripMenuItem.Text = "PAGOS";
            // 
            // gestionDePagosToolStripMenuItem
            // 
            this.gestionDePagosToolStripMenuItem.Name = "gestionDePagosToolStripMenuItem";
            this.gestionDePagosToolStripMenuItem.Size = new System.Drawing.Size(331, 44);
            this.gestionDePagosToolStripMenuItem.Text = "Gestion de Pagos";
            // 
            // FrmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1472, 943);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmVentanaPrincipal";
            this.Text = "CENTRO DE CONTROL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmVentanaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmVentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNSTRUCTORESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLASESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATRICULASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaMatriculasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClaseToolStripMenuItem;
    }
}