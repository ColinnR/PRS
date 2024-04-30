using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    /// <summary>
    //Clase publica para declarar las entidades que se ocupan para el LOG de actividades.
    /// </summary>
    public class LogActivityE
    {
        //Almacena el id del LOG.
        public int IdLog { get; set; }

        //Almacena el usuario que realizó esa actividad.
        public string Usuario { get; set; }

        //Almacena la fecha en la que el usuario realizó esa actividad.
        public DateTime Fecha { get; set; }

        //Almacena la hora en la que el usuario realizó esa actividad.
        public string Hora { get; set; }

        //Almacena el módulo en la que el usuario realizó esa actividad.
        public string Modulo { get; set; }

        //Almacena la función que el usuario realizó.
        public string FuncionRealizada { get; set; }

        //Almacena los mensaje de exception
        public string MensajeException { get; set; }
    }
}
