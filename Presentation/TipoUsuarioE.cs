using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    /// <summary>
    /// Clase pública para declarar las entidades que se ocupan para el CRUD TipoUsuario
    /// </summary>
    public class TipoUsuarioE
    {
        //Almacena el id del tipo de usuario.
        public int IDTipo { get; set; }
        //Almacena el nombre del tipo de usuario.
        public string TipoUsuario { get; set; }
    }
}
