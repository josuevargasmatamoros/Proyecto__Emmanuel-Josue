using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__Emmanuel_Josue.Formularios
{
    public partial class FrmVentanaPrincipal : Form
    {
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void gestionDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globales.ObjetosGlobales.MiFormularioDeGestionDeAlumnos.Visible)
            {
                Globales.ObjetosGlobales.MiFormularioDeGestionDeAlumnos = new FrmAlumnosGestion();

                Globales.ObjetosGlobales.MiFormularioDeGestionDeAlumnos.Show();
            }
        }

        private void FrmVentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
