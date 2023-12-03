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
            ActivarBotonAgregar();


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
                        CargarListaAlumnos();

                    }
                    else
                    {
                        MessageBox.Show("El Alumno no se pudo ingresar....", "N'ok", MessageBoxButtons.OK);
                    }

                }
            }


            


        }


        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
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
        TxtID.Clear();
        TxtAlumnoNombre.Clear();
        TxtApellidosAlumno.Clear();
        TxtFechaNacimientoAlumno.Clear();
        TxtTelefonoAlumno.Clear();
        TxtEmailAlumno.Clear();
        TxtDireccionAlumno.Clear();

        }



        private void DgvListaAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgvListaAlumnos.SelectedRows.Count == 1)
            {
                LimpiarForm();

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna 
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaAlumnos.SelectedRows[0];
                int IDAlumno = Convert.ToInt32(MiDgvFila.Cells["Colid"].Value);

                MiAlumnoLocal = new Logica.Models.Alumno();
                MiAlumnoLocal = MiAlumnoLocal.ConsultarPorID(IDAlumno);

                if (MiAlumnoLocal != null)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos 
                    //datos en los controles correspondientes del formulario 

                    TxtID.Text = MiAlumnoLocal.ID;
                    TxtAlumnoNombre.Text = MiAlumnoLocal.Nombre;
                    TxtApellidosAlumno.Text = MiAlumnoLocal.Apellidos;
                    TxtFechaNacimientoAlumno.Text = MiAlumnoLocal.FechaDeNacimiento;
                    TxtTelefonoAlumno.Text = MiAlumnoLocal.Telefono;
                    TxtEmailAlumno.Text = MiAlumnoLocal.Email;
                    TxtDireccionAlumno.Text = MiAlumnoLocal.Direccion;

                    //en este caso no quiere que se muestre la contraseña ya que está encriptada y no se 
                    //requiere actualizarla y se deja en blanco el campo de texto 



                    ActivarBotonesModificarYEliminar();

                }
            }


        }

        private void DgvListaAlumnos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaAlumnos.ClearSelection();
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (MiAlumnoLocal.ConsultarPorID())
            {

                MiAlumnoLocal.ID = TxtID.Text.Trim();
                MiAlumnoLocal.Nombre = TxtAlumnoNombre.Text.Trim();
                MiAlumnoLocal.Apellidos = TxtApellidosAlumno.Text.Trim();
                MiAlumnoLocal.FechaDeNacimiento = TxtFechaNacimientoAlumno.Text.Trim();
                MiAlumnoLocal.Telefono = TxtTelefonoAlumno.Text.Trim();
                MiAlumnoLocal.Email = TxtEmailAlumno.Text.Trim();
                MiAlumnoLocal.Direccion = TxtDireccionAlumno.Text.Trim();

                DialogResult Resp = MessageBox.Show("¿Desea modificar el alumno?", "???",
                                                          MessageBoxButtons.YesNo);
                if (Resp == DialogResult.Yes)
                {
                    //procedemos a modificar el registro del usuario 
                    MiAlumnoLocal.Actualizar();
                    
                        MessageBox.Show("Alumno modificado correctamente!", "ok", MessageBoxButtons.OK);

                        LimpiarForm();
                        CargarListaAlumnos();
                        ActivarBotonAgregar();
                    
                }


                //en el diagrama expandido de casos de uso para el tema Usuario, se indica 
                // que para modificar o eliminar primero se debe consultar por el ID
                }


            }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiAlumnoLocal.ConsultarPorID())
            {
                string msg = string.Format("Esta seguro de eliminar el alumno {0}", MiAlumnoLocal.Nombre);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    MiAlumnoLocal.Eliminar();
                    MessageBox.Show("Alumno eliminado correctamente!", "ok", MessageBoxButtons.OK);

                    LimpiarForm();
                    CargarListaAlumnos();
                    ActivarBotonAgregar();


                }


            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
           
                this.Close();
           
        }

       
    }
}


