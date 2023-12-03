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
    public partial class FrmInstructoresGestion : Form
    {
        private Logica.Models.Instructor MiInstructorLocal { get; set; }
        public FrmInstructoresGestion()
        {
            InitializeComponent();
        }

        private void CargarListaInstructores()
        {
            Logica.Models.Instructor miinstructor = new Logica.Models.Instructor();

            DataTable lista = new DataTable();

            lista = miinstructor.ListarInstructores();

            DgvListaInstructores.DataSource = lista;
        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarBotonesModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void LimpiarForm()
        {
            TxtIDInstructor.Clear();
            TxtInstructorNombre.Clear();
            TxtInstructorApellido.Clear();
            TxtInstructorEmail.Clear();
            TxtInstructorTelefono.Clear();
            TxtContrasenniaInstructor.Clear();
           

        }

        private bool ValidarDatosRequeridos(bool OmitirContrasennia = false)
        {

            bool R = false;

            //validar que se hayan digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtInstructorNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtInstructorTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtInstructorEmail.Text.Trim()) 
                
                )
            {
                if (OmitirContrasennia)
                {
                    //Si se omite la contraseña entonces se pasa a true
                    R = true;
                }
                else
                {
                    //Si no se omite la contraseña debemos validar también ese campo
                    if (!string.IsNullOrEmpty(TxtContrasenniaInstructor.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //CONTRASEÑA
                        if (string.IsNullOrEmpty(TxtContrasenniaInstructor.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar la Contraseña", "Error de validación", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            else
            {
                //indicar al usuario qué validación está faltando

                //CEDULA
                if (string.IsNullOrEmpty(TxtInstructorNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el nombre", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //NOMBRE
                if (string.IsNullOrEmpty(TxtInstructorTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el telefono", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //CORREO
                if (string.IsNullOrEmpty(TxtInstructorEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el email", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                

            }

            return R;

        }












        private void FrmInstructoresGestion_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;
            CargarListaInstructores();
            ActivarBotonAgregar();
        }

        private void DgvListaInstructores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaInstructores.SelectedRows.Count == 1)
            {
                LimpiarForm();

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna 
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaInstructores.SelectedRows[0];
                int IDInstructor = Convert.ToInt32(MiDgvFila.Cells["ColID_Instructor"].Value);

                MiInstructorLocal = new Logica.Models.Instructor();
                MiInstructorLocal = MiInstructorLocal.ConsultarPorID(IDInstructor);

                if (MiInstructorLocal != null)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos 
                    //datos en los controles correspondientes del formulario 

                    TxtIDInstructor.Text = MiInstructorLocal.ID_Instructor.ToString(); ;
                    TxtInstructorNombre.Text = MiInstructorLocal.Nombre;
                    TxtInstructorApellido.Text = MiInstructorLocal.Apellido;
                    TxtInstructorEmail.Text = MiInstructorLocal.Email;
                    TxtInstructorTelefono.Text = MiInstructorLocal.Telefono;
                    
                   

                    //en este caso no quiere que se muestre la contraseña ya que está encriptada y no se 
                    //requiere actualizarla y se deja en blanco el campo de texto 



                    ActivarBotonesModificarYEliminar();

                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosRequeridos())
            {



                MiInstructorLocal = new Logica.Models.Instructor();

                MiInstructorLocal.Nombre = TxtInstructorNombre.Text.Trim();
                MiInstructorLocal.Apellido = TxtInstructorApellido.Text.Trim();
                MiInstructorLocal.Email = TxtInstructorEmail.Text.Trim();
                MiInstructorLocal.Telefono = TxtInstructorTelefono.Text.Trim();
                MiInstructorLocal.Contrasennia = TxtContrasenniaInstructor.Text.Trim();

               
                bool EmailOk = MiInstructorLocal.ConsultarPorEmailInstructor(MiInstructorLocal.Email);

                if ( EmailOk == false)
                {

                    //see solicita confirmacion por parte del usurio

                    string Pregunta = string.Format("Esta seguro de agregar al instructor {0}?", MiInstructorLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool ok = MiInstructorLocal.AgregarInstrucor();

                        if (ok)
                        {
                            MessageBox.Show("Instructor ingresado correctamente!", "ok", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaInstructores();

                        }
                        else
                        {
                            MessageBox.Show("El Instructor no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvListaInstructores_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaInstructores.ClearSelection();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiInstructorLocal.ConsultarPorID())
            {
                string msg = string.Format("Esta seguro de eliminar el instructor {0}", MiInstructorLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    MiInstructorLocal.Eliminar();
                    MessageBox.Show("instructor eliminado correctamente!", "ok", MessageBoxButtons.OK);

                    LimpiarForm();
                    CargarListaInstructores();
                    ActivarBotonAgregar();


                }


            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (MiInstructorLocal.ConsultarPorID())
            {

                
                MiInstructorLocal.Nombre = TxtInstructorNombre.Text.Trim();
                MiInstructorLocal.Apellido = TxtInstructorApellido.Text.Trim();
                MiInstructorLocal.Email = TxtInstructorEmail.Text.Trim();
                MiInstructorLocal.Telefono = TxtInstructorTelefono.Text.Trim();
                MiInstructorLocal.Email = TxtInstructorEmail.Text.Trim();
                MiInstructorLocal.Contrasennia = TxtContrasenniaInstructor.Text.Trim();

                DialogResult Resp = MessageBox.Show("¿Desea modificar el instructor?", "???",
                                                          MessageBoxButtons.YesNo);
                if (Resp == DialogResult.Yes)
                {
                    //procedemos a modificar el registro del usuario 
                    MiInstructorLocal.ActualizarInstructor();

                    MessageBox.Show("Instructor modificado correctamente!", "ok", MessageBoxButtons.OK);

                    LimpiarForm();
                    CargarListaInstructores();
                    ActivarBotonAgregar();

                }



            }
        }
    }
}

