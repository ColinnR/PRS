using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinesLogic
{
    public class TipoUsuarioBL
    {
        /// <summary>
        /// Método que recibe el método UsuarioTipo_agregar de TipoUsuarioDA
        /// </summary>
        /// <param name="obj_tipousuario">Recibe un objeto de tipo Usuario</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool UsuarioTipo_agregar(TipoUsuarioE obj_tipousuario, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método UsuarioTipo_agregar es correcto, el estado de la operación es válido
                if (TipoUsuarioDA.UsuarioTipo_agregar(obj_tipousuario, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    MessageBox.Show("Tipo de usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    operacion = false;
                }
            }
            catch (Exception ex)
            {
                operacion = false;
            }
            return operacion;
        }

        /// <summary>
        /// Método que recibe el método UsuarioTipo_modificar de TipoUsuarioDA
        /// </summary>
        /// <param name="obj_tipousuario">Recibe un objeto de tipo Usuario</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool UsuarioTipo_modificar(TipoUsuarioE obj_tipousuario, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método UsuarioTipo_modificar es correcto, el estado de la operación es válido
                if (TipoUsuarioDA.UsuarioTipo_modificar(obj_tipousuario, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    operacion = false;
                }
            }
            catch (Exception ex)
            {
                operacion = false;
            }
            return operacion;
        }

        /// <summary>
        /// Método que recibe el método UsuarioTipo_eliminar de TipoUsuarioDA
        /// </summary>
        /// <param name="obj_idtipo">Recibe un objeto de tipo Usuario</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool UsuarioTipo_eliminar(int obj_idtipo, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método UsuarioTipo_eliminar es correcto, el estado de la operación es válido
                if (TipoUsuarioDA.UsuarioTipo_eliminar(obj_idtipo, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    operacion = false;
                }
            }
            catch (Exception ex)
            {
                operacion = false;
            }
            return operacion;
        }

        /// <summary>
        /// Método que recibe el método UsuarioTipo_obtener_todo de TipoUsuarioDA
        /// </summary>
        public static List<TipoUsuarioE> UsuarioTipo_obtener_todo(string nombre_nodo)
        {
            try
            {
                //retorna el método UsuarioTipo_obtener_todo de TipoUsuarioDA
                return TipoUsuarioDA.UsuarioTipo_obtener_todo(nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
