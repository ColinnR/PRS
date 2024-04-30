using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    /// <summary>
    /// Clase publica para declarar las entidades que se utilizan dentro del CRUD usuario
    /// </summary>
    public class UsuarioE
    {

        //Almacena el id del usuario
        public int UsuarioID {  get; set; }

        //Almacena el nombre del usuario
        public string Nombre {  get; set; }

        //Almacena el apellido del usuario
        public string Apellido { get; set; }

        //Almacena el correo electrónico del usuario
        public string Correo { get; set; }

        //Almacena el nombre de usuario del usuario
        public string Usuario {  get; set; }

        //Almacena la contraseña del usuario
        public string Password { get; set; }

        //Almacena el estado del usuario (si está activo o no)
        public bool Estado { get; set; }

        //Almacena el id del tipo de usuario que tiene el usuario
        public int IDTipo { get; set; }

        //Almacena el nombre del tipo de usuario que tiene el usuario
        public string NombreTipo { get; set; }
    }
}
