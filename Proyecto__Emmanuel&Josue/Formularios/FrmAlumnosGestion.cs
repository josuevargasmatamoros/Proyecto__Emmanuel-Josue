using System;
using System.Collections;
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

        private Logica.Models.Alumno MiAlumnoLocal { get; set; }

        public FrmAlumnosGestion()
        {
            InitializeComponent();

            MiAlumnoLocal = new Logica.Models.Alumno();
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


            MiAlumnoLocal = new Logica.Models.Alumno();

            MiAlumnoLocal.ID = TxtID.Text.Trim();
            MiAlumnoLocal.Nombre = TxtAlumnoNombre.Text.Trim();
            MiAlumnoLocal.Apellidos = TxtApellidosAlumno.Text.Trim();
            MiAlumnoLocal.FechaDeNacimiento = TxtFechaNacimientoAlumno.Text.Trim();
            MiAlumnoLocal.Telefono = TxtTelefonoAlumno.Text.Trim();
            MiAlumnoLocal.Email = TxtEmailAlumno.Text.Trim();
            MiAlumnoLocal.Direccion = TxtDireccionAlumno.Text.Trim();

            bool EmailOK = MiAlumnoLocal.ConsultarPorEmail(MiAlumnoLocal.Email);

            if (EmailOK == false)
            {

                //see solicita confirmacion por parte del usurio

                string Pregunta = string.Format("Esta seguro de agregar al Alumno {0}?", MiAlumnoLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    bool ok = MiAlumnoLocal.Agregar();

                    if (ok)
                    {
                        MessageBox.Show("Alumno ingresado correctamente!", "ok", MessageBoxButtons.OK);

                         LimpiarForm();
                        

                    }
                    else
                    {
                        MessageBox.Show("El Alumno no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
                    }
                }
            }


            


        }

        private void LimpiarForm() 
        { 
        TxtID.Clear();
        TxtAlumnoNombre.Clear();
        TxtApellidosAlumno.Clear();
        TxtFechaNacimientoAlumno.Clear();
        TxtTelefonoAlumno.Clear();
        TxtEmailAlumno.Clear();
        TxtDireccionAlumno.Clear();

        }

        
    }
}

