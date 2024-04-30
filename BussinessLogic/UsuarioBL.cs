using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BussinesLogic
{
    public class UsuarioBL
    {
        UsuarioDA obj_logueo = new UsuarioDA();

        /// <summary>
        /// Método que recibe el método Usuario_agregar de UsuarioDA
        /// </summary>
        /// <param name="obj_usuario">Recibe un objeto de usuario</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool Usuario_agregar(UsuarioE obj_usuario, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método Usuario_agregar es correcto, el estado de la operación es válido
                if (UsuarioDA.Usuario_agregar(obj_usuario, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    MessageBox.Show("Usuario ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    operacion = false;
                }
            }
            catch (SqlException ex)
            {
                
                operacion = false;
            }
            return operacion;
        }

        /// <summary>
        /// Método que recibe el método Usuario_modificar de UsuarioDA
        /// </summary>
        /// <param name="obj_usuario">Recibe un objeto de usuario</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool Usuario_modificar(UsuarioE obj_usuario, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método Usuario_modificar es correcto, el estado de la operación es válido
                if (UsuarioDA.Usuario_modificar(obj_usuario, nombre_nodo))
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
        /// Método que recibe el método Usuario_eliminar de UsuarioDA
        /// </summary>
        /// <param name="obj_usuarioid">Recibe un objeto de usuario</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool Usuario_eliminar(int obj_usuarioid, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método Usuario_eliminar es correcto, el estado de la operación es válido
                if (UsuarioDA.Usuario_eliminar(obj_usuarioid, nombre_nodo))
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
        /// Método que recibe el método Usuario_obtener_todo de UsuarioDA
        /// </summary>
        public static List<UsuarioE> Usuario_obtener_todo(string nombre_nodo)
        {
            try
            {
                //retorna el método Usuario_obtener_todo de UsuarioDA
                return UsuarioDA.Usuario_obtener_todo(nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que recibe el método Usuario_logueo de UsuarioDA
        /// </summary>
        public DataTable Usuario_logueo(UsuarioE obj_usuario, string nombre_nodo)
        {
            try
            {
                //retorna el método Usuario_logueo de UsuarioDA
                return obj_logueo.Usuario_logueo(obj_usuario, nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Usuario_activar(int UsuarioID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (UsuarioDA.Activar(UsuarioID, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    operacion = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return operacion;
        }


        public static bool Usuario_desactivar(int UsuarioID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (UsuarioDA.Desactivar(UsuarioID, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    operacion = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return operacion;
        }
    }
}

