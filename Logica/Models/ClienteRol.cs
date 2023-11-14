using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class ClienteRol
    {


        public int ClienteID { get; set;}

        public string Nombre { get; set; }

        public DataTable Listar()
        {
            DataTable R = new DataTable();

            return R;
        }


    }
}
