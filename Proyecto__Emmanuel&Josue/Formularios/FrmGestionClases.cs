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
    public partial class FrmGestionClases : Form
    {

        private Logica.Models.Clases MiClaseLocal { get; set; }

        public FrmGestionClases()
        {
            InitializeComponent();



            MiClaseLocal = new Logica.Models.Clases();
        }

        private void FrmGestionClases_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;
            //CargarListaAlumnos();
            ActivarBotonAgregar();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            if (ValidarDatosRequeridos())
            {

                MiClaseLocal = new Logica.Models.Clases();
                MiClaseLocal.IDClase = Convert.ToInt32(TxtID_Clase.Text.Trim());
                MiClaseLocal.Nombre_Clase = TxtNombre_Clase.Text.Trim();
                MiClaseLocal.Horario = TxtHorario.Text.Trim();
                MiClaseLocal.Nivel = TxtNivel.Text.Trim();
                MiClaseLocal.MiInstructor.ID_Instructor = txtCodigoinstructor.Text.Trim();



                bool nombreok = MiClaseLocal.ConsultarPorNombreClase(MiClaseLocal.Nombre_Clase);










                if (nombreok == false)
                {

                    //see solicita confirmacion por parte del usurio

                    string Pregunta = string.Format("Esta seguro de agregar la clase {0}?", MiClaseLocal.Nombre_Clase);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiClaseLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Clase ingresada correctamente!", "ok", MessageBoxButtons.OK);

                            LimpiarForm();
                            

                        }
                        else
                        {
                            MessageBox.Show("La clase no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
                        }
                    }
                }
            }


        }

        private bool ValidarDatosRequeridos(bool nombre = false)
        {

            bool R = false;

            //validar que se hayan digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(txtCodigoinstructor.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtNombre_Clase.Text.Trim()) 

                
                )
            {
                if (nombre)
                {
                    //Si se omite la contraseña entonces se pasa a true
                    R = true;
                }
                else
                {
                    //Si no se omite la contraseña debemos validar también ese campo
                    if (!string.IsNullOrEmpty(TxtNombre_Clase.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //CONTRASEÑA
                        if (string.IsNullOrEmpty(TxtNombre_Clase.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar el nombre de la clase", "Error de validación", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            else
            {
                //indicar al usuario qué validación está faltando

                //CEDULA
                if (string.IsNullOrEmpty(txtCodigoinstructor.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el id del instructor", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //NOMBRE
                if (string.IsNullOrEmpty(TxtNombre_Clase.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //CORREO
                if (string.IsNullOrEmpty(TxtHorario.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el horario", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //ROL DE USUARIO
                

            }

            return R;



        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ActivarBotonAgregar();
            LimpiarForm();
        }
        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
           // BtnModificar.Enabled = false;
            
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        


        private void LimpiarForm()
        {
            txtCodigoinstructor.Clear();
            TxtID_Clase.Clear();
            TxtNombre_Clase.Clear();
            TxtHorario.Clear();
            TxtNivel.Clear();


        }
    }
}   

