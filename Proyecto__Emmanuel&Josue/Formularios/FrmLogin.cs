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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;

        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim()) &&
   !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string usuario = TxtUsuario.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                int idUsuario = Globales.ObjetosGlobales.MiUsuarioGlobal.ValidarIngreso(usuario, contrasennia);

                if (idUsuario > 0)
                {
                    Globales.ObjetosGlobales.MiUsuarioGlobal = Globales.ObjetosGlobales.MiUsuarioGlobal.ConsultarPorID(idUsuario);

                    Globales.ObjetosGlobales.MiFormularioPrincipal.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Acceso deneegado", "ERROR de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUsuario.Focus();
                    TxtUsuario.SelectAll();

                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

