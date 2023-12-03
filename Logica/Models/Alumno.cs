using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Logica.Models
{
    public class Alumno
    {
        
        public string ID { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string FechaDeNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        
        public string Direccion { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCcn = new Conexion();

            MiCcn.ListaDeParametros.Add(new SqlParameter("@id", this.ID));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@nombre", this.Nombre));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@apellido", this.Apellidos));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@FechaNacimiento", this.FechaDeNacimiento));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@telefono", this.Telefono));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@direccion", this.Direccion));
            MiCcn.ListaDeParametros.Add(new SqlParameter("@email", this.Email));

           

            int resultado = MiCcn.EjecutarDML("SPAlumnosAgregar");

            if (resultado > 0) R = true;



            return R;
        }

        public Alumno ConsultarPorID(int IDAlumno)
        {
            Alumno R = new Alumno();

            //esta funcion retorna un objeto de tipo usuario con datos en los atributos. 
            //es una variedad de ConsultarPorID que me permite manipular el objeto y no
            //solo saber si el usuario existe o no a traves de un bool

            Conexion MyCnn = new Conexion();

            MyCnn.ListaDeParametros.Add(new SqlParameter("@id", IDAlumno));

            DataTable DatosAlumno = new DataTable();

            DatosAlumno = MyCnn.EjecutarSELECT("SAlumnosConsultarPorID");

            if (DatosAlumno != null && DatosAlumno.Rows.Count > 0)
            {
                //como tenemos que llenar un objeto compuesto (por el rol de usuario) 
                //debemos extraer los datos de la consulta y llenar los atributos 
                //correspondientes del objeto de tipo Usuario R. 

                //acá capturamos los datos de la fila 0 del resultado 
                DataRow MiFila = DatosAlumno.Rows[0];

                R.ID = Convert.ToString(MiFila["id"]);
                R.Nombre = Convert.ToString(MiFila["nombre"]);
                R.Apellidos = Convert.ToString(MiFila["apellido"]);
                R.FechaDeNacimiento = Convert.ToString(MiFila["fecha_de_nacimiento"]);
                R.Telefono = Convert.ToString(MiFila["telefono"]);
                R.Email = Convert.ToString(MiFila["email"]);
                R.Direccion = Convert.ToString(MiFila["direccion"]);
                
            }

            return R;
        }











        public DataTable ListarAlumnos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerAlumnos", true));
            


            R = MiCnn.EjecutarSELECT("SPAlumnosListar");
            return R;
        }

        public bool ConsultarPorEmail(string pEmail)
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@email", pEmail));

            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPUsuariosConsultarPorEmail");

            if (dt != null && dt.Rows.Count > 0) R = true;

            return R;
        }

    }
}
