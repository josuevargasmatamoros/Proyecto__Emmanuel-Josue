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
    public partial class FrmClases : Form
    {
        public DataTable DtListaDetalleClases { get; set; }



        private Logica.Models.Clases MiClaseLocal { get; set; }
        public FrmClases()
        {
            InitializeComponent();

            MiClaseLocal = new Logica.Models.Clases();
            DtListaDetalleClases = new DataTable();

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       


        private void FrmClases_Load(object sender, EventArgs e)
        {
            MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;
            CargarListaCLase();
           
        }

        private void CargarListaCLase()
        {
            Logica.Models.Clases miclase = new Logica.Models.Clases();

            DataTable lista = new DataTable();

            lista = miclase.ListarClase();

            DgvListaClases.DataSource = lista;


        }

        

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (MiClaseLocal.ConsultarPorID())
            {
                string msg = string.Format("Esta seguro de eliminar la clase {0}", MiClaseLocal.Nombre_Clase);

                DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    MiClaseLocal.Eliminar();
                    MessageBox.Show("clase eliminado correctamente!", "ok", MessageBoxButtons.OK);

                   
                    CargarListaCLase();
                    


                }


            }


        }

        


        private void DgvListaClases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaClases.SelectedRows.Count == 1)
            {
                

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna 
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaClases.SelectedRows[0];
                int ID_CLASE = Convert.ToInt32(MiDgvFila.Cells["ColID_Clase"].Value);

                MiClaseLocal = new Logica.Models.Clases();
                MiClaseLocal = MiClaseLocal.ConsultarPorID(ID_CLASE);

                if (MiClaseLocal != null && MiClaseLocal.IDClase > 0)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos 
                    //datos en los controles correspondientes del formulario 
                    
                     MiClaseLocal.IDClase.ToString();
                     MiClaseLocal.Nombre_Clase.ToString();
                     MiClaseLocal.Horario.ToString();
                     MiClaseLocal.Nivel.ToString(); ;
                     MiClaseLocal.MiInstructor.ID_Instructor.ToString(); ;
                     

                    //en este caso no quiere que se muestre la contraseña ya que está encriptada y no se 
                    //requiere actualizarla y se deja en blanco el campo de texto 

                    
                   

                    

                }
            }

        }

        private void DgvListaClases_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaClases.ClearSelection();
        }

        private void DgvListaClases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
