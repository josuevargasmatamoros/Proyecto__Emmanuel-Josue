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
    public partial class FrmAlumnosGestion : Form
    {
        public FrmAlumnosGestion()
        {
            InitializeComponent();
        }

        private void FrmAlumnosGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;
            CargarListaAlumnos();


        }

        private void CargarListaAlumnos()
        {
            Logica.Models.Alumno mialumno = new Logica.Models.Alumno();

            DataTable lista = new DataTable();

            lista = mialumno.ListarAlumnos();

            DgvListaAlumnos.DataSource = lista;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

        }











    }
}

