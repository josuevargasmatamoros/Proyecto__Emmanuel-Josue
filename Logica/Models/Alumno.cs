using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Alumno
    {

        public DataTable ListarAlumnos()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerAlumnos", true));
            


            R = MiCnn.EjecutarSELECT("SPAlumnosListar");
            return R;
        }


    }
}
