using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{

    

    public class Clases
    {

        public Clases()
        {
            MiInstructor = new Instructor();


        }



        public int IDClase
        { get; set; }

        public string Nombre_Clase
        { get; set; }

        public string Horario
        { get; set; }

        public string Nivel
        { get; set; }

        


        

        public Instructor MiInstructor { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCcn = new Conexion();

            MiCcn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.IDClase));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Nombre_Clase", this.Nombre_Clase));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@Horario", this.Horario));


            



            MiCcn.ListaDeParametros.Add(new SqlParameter("@Nivel", this.Nivel));
            

            MiCcn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", this.MiInstructor.ID_Instructor));

            int resultado = MiCcn.EjecutarDML("SPClasesAgregar");

            if (resultado > 0) R = true;



            return R;
        }



        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.IDClase));

            int resultado = MiCnn.EjecutarDML("SPClaseEliminar");

            if (resultado > 0) R = true;

            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            //ahora agregamos todos los parámetros que solicita el SP de agregar
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.IDClase));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre_Clase", this.Nombre_Clase));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Horario", this.Horario));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nivel", this.Nivel));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Instructor", this.MiInstructor.ID_Instructor));



            int resultado = MiCnn.EjecutarDML("SPClasesActualizar");

            if (resultado > 0) R = true;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.IDClase));

            DataTable DatosUsuario = new DataTable();

            DatosUsuario = MyCnn.EjecutarSELECT("SPClaseConsultarPorID");

            if (DatosUsuario != null && DatosUsuario.Rows.Count > 0)
            {
                //el usuario existe
                R = true;
            }

            return R;
        }

        public Clases ConsultarPorID(int IDClase)
        {
            Clases R = new Clases();

            //esta funcion retorna un objeto de tipo usuario con datos en los atributos. 
            //es una variedad de ConsultarPorID que me permite manipular el objeto y no
            //solo saber si el usuario existe o no a traves de un bool

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.IDClase));

            DataTable DatosAlumno = new DataTable();

            DatosAlumno = MyCnn.EjecutarSELECT("SPClaseConsultarPorID");

            if (DatosAlumno != null && DatosAlumno.Rows.Count > 0)
            {
                //como tenemos que llenar un objeto compuesto (por el rol de usuario) 
                //debemos extraer los datos de la consulta y llenar los atributos 
                //correspondientes del objeto de tipo Usuario R. 

                //acá capturamos los datos de la fila 0 del resultado 
                DataRow MiFila = DatosAlumno.Rows[0];

                R.IDClase = Convert.ToInt32(MiFila["ID_Clase"]);
                R.Nombre_Clase = Convert.ToString(MiFila["Nombre_Clase"]);
                R.Horario = Convert.ToString(MiFila["Horario"]);
                R.Nivel = Convert.ToString(MiFila["Nivel"]);
                R.MiInstructor.ID_Instructor = Convert.ToString(MiFila["ID_Instructor"]);
               

            }

            return R;
        }

        public bool Activar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.IDClase));

            int resultado = MiCnn.EjecutarDML("SPClaseActivar");

            if (resultado > 0) R = true;

            return R;
        }

        public bool ConsultarPorNombreClase(string pNombreClase)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre_Clase", pNombreClase));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPClaseConsultarNombre");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

        public DataTable ListarClase()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerClase", true));



            R = MiCnn.EjecutarSELECT("SPClaseListar");
            return R;
        }

        














    }









}

