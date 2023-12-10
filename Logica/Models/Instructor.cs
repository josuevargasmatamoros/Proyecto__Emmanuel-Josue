using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica.Tools;

namespace Logica.Models
{
    public class Instructor
    {
        public Instructor()
        {

        }
        public string ID_Instructor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasennia { get; set; }
        public string Telefono { get; set; }
        
        


        //   public UsuarioRol MiUsuarioRol { get; set; }


        // comportamiento,  funciones, operaciones, métodos

        public bool AgregarInstrucor()
        {
            bool R = false;

            Conexion MiCcn = new Conexion();

            MiCcn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", this.ID_Instructor));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));


            Tools.Crypto MiEncriptador = new Tools.Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Contrassenia", ContrasenniaEncriptada));



            MiCcn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

            

            int resultado = MiCcn.EjecutarDML("SPInstructorAgregar");

            if (resultado > 0) R = true;



            return R;
        }
        public bool ActualizarInstructor()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", this.ID_Instructor));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.Nombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Apellido", this.Apellido));


            Tools.Crypto MiEncriptador = new Tools.Crypto();
            string ContrasenniaEncriptada = MiEncriptador.EncriptarEnUnSentido(this.Contrasennia);
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", ContrasenniaEncriptada));



            MiCnn.ListaDeParametros.Add(new SqlParameter("@Telefono", this.Telefono));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", this.Email));

            int resultado = MiCnn.EjecutarDML("SPInstructorActualizar");

            if (resultado > 0) R = true;

            return R;
        }

        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", this.ID_Instructor));

            int resultado = MiCnn.EjecutarDML("SPInstructorEliminar");

            if (resultado > 0) R = true;

            return R;
        }


    



        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", this.ID_Instructor));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MyCnn.EjecutarSELECT("SPInstructorConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count > 0)
            {
                //el usuario existe
                R = true;
            }

            return R;
        }


        public Instructor ConsultarPorID(int IdInstructor)
        {
            Instructor R = new Instructor();

            //esta funcion retorna un objeto de tipo usuario con datos en los atributos. 
            //es una variedad de ConsultarPorID que me permite manipular el objeto y no
            //solo saber si el usuario existe o no a traves de un bool

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", IdInstructor));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MyCnn.EjecutarSELECT("SPInstructorConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count > 0)
            {
                //como tenemos que llenar un objeto compuesto (por el rol de usuario) 
                //debemos extraer los datos de la consulta y llenar los atributos 
                //correspondientes del objeto de tipo Usuario R. 

                //acá capturamos los datos de la fila 0 del resultado 
                DataRow MiFila = DatosUsuario.Rows[0];

                R.ID_Instructor = Convert.ToString(MiFila["ID_Instructor"]);
                R.Nombre = Convert.ToString(MiFila["Nombre"]);
                R.Apellido = Convert.ToString(MiFila["Apellido"]);
                R.Email = Convert.ToString(MiFila["Email"]);
                R.Telefono = Convert.ToString(MiFila["Telefono"]);
                R.Contrasennia = Convert.ToString(MiFila["Contrasennia"]);
                
            }

            return R;
        }


        public bool ConsultarPorEmailInstructor(string pEmail)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Email", pEmail));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPInstructorConsultarPorEmail");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }





        public DataTable ListarInstructores()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerInstructores", true));



            R = MiCnn.EjecutarSELECT("SPInstructorListar");
            return R;
        }
        public int ValidarIngreso(string pInstructor, string pContrasennia)
        {
            int R = 0;

            Conexion myCnn = new Conexion();

            Crypto myEncriptador = new Crypto();

            string PasswordEncriptado = myEncriptador.EncriptarEnUnSentido(pContrasennia);

            myCnn.ListaDeParametros.Add(new SqlParameter("@Usuario", pInstructor));
            myCnn.ListaDeParametros.Add(new SqlParameter("@Contrasennia", PasswordEncriptado));

            DataTable resultado = myCnn.EjecutarSELECT("SPInstructorValidarIngreso");

            if (resultado != null && resultado.Rows.Count > 0)
            {
                DataRow Mifila = resultado.Rows[0];

                R = Convert.ToInt32(Mifila["ID_Instructor"]);
            }



            return R;
        }













    }
}
