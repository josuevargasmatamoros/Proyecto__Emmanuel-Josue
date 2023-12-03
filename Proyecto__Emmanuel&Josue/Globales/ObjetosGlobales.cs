using Proyecto__Emmanuel_Josue.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__Emmanuel_Josue.Globales
{
    public static class ObjetosGlobales
    {
        //definir un objeto goblal para el formulario principal

        public static Form MiFormularioPrincipal = new Formularios.FrmVentanaPrincipal();


        public static Formularios.FrmAlumnosGestion
            MiFormularioDeGestionDeAlumnos = new FrmAlumnosGestion();

        public static Formularios.FrmInstructoresGestion
            MiFormularioGestionDeInstroctores = new FrmInstructoresGestion();

        //public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        // public static Formularios.FrmMovimientosInventario
        // MiformularioMovimientos = new Formularios.FrmMovimientosInventario();

    }
}
