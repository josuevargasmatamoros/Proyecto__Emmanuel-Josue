using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{

    public class Alumnoo
    {
        // ... (propiedades y otros métodos)

        // Método para obtener datos de alumnos desde la base de datos
        public DataTable ObtenerAlumnos()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Server=tcp:azurejosue.database.windows.net,1433;Initial Catalog=PR;Persist Security Info=False;User ID=CloudSA32c1bfb5;Password=Josuevm1701;Encrypt=True;"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT id, nombre FROM alumnos", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }

    public class Clase
    {
        // ... (propiedades y otros métodos)

        // Método para obtener datos de clases desde la base de datos
        public DataTable ObtenerClases()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection("Server=tcp:azurejosue.database.windows.net,1433;Initial Catalog=PR;Persist Security Info=False;User ID=CloudSA32c1bfb5;Password=Josuevm1701;Encrypt=True;"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT ID_Clase, Nombre_Clase FROM clases", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }
    }








    public class Matricula
    {

        public int ID_Matricula { get; set; }
        public int ID_Alumno { get; set; }
        public int ID_Clase { get; set; }
        public DateTime Fecha_Matricula { get; set; }

        public bool Agregar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Alumno", this.ID_Alumno));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.ID_Clase));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Fecha_Matricula", this.Fecha_Matricula));

            int resultado = MiCnn.EjecutarDML("SPMatriculaAgregar");

            if (resultado > 0)
                R = true;

            return R;
        }



        public bool Eliminar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();


            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Matricula", this.ID_Matricula));

            int resultado = MiCnn.EjecutarDML("SPMatriculaEliminar");

            if (resultado > 0)
                R = true;

            return R;
        }

        public bool Actualizar()
        {
            bool R = false;

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Matricula", this.ID_Matricula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Alumno", this.ID_Alumno));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Clase", this.ID_Clase));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Fecha_Matricula", this.Fecha_Matricula));

            int resultado = MiCnn.EjecutarDML("SPMatriculaActualizar");

            if (resultado > 0)
                R = true;

            return R;
        }


        public DataTable ListarMatriculas()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            // Limpiar cualquier parámetro anterior
            MiCnn.ListaDeParametros.Clear();

            // Imprimir la consulta SQL directamente
            Console.WriteLine("Consulta SQL: SELECT * FROM matriculas");

            R = MiCnn.EjecutarSELECT("SPMatriculaListar");
            return R;
        }







        public Matricula ConsultarPorID(int IDMatricula)
        {
            Matricula R = new Matricula();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@ID_Matricula", IDMatricula));

            DataTable DatosMatricula = MiCnn.EjecutarSELECT("SPMatriculaConsultarPorID");

            if (DatosMatricula != null && DatosMatricula.Rows.Count > 0)
            {
                DataRow MiFila = DatosMatricula.Rows[0];

                R.ID_Matricula = Convert.ToInt32(MiFila["ID_Matricula"]);
                R.ID_Alumno = Convert.ToInt32(MiFila["ID_Alumno"]);
                R.ID_Clase = Convert.ToInt32(MiFila["ID_Clase"]);
                R.Fecha_Matricula = Convert.ToDateTime(MiFila["Fecha_Matricula"]);
            }

            return R;
        }

        // Evento Load del formulario


    }







}

