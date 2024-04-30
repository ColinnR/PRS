using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class TipoUsuariosPermisosBL
    {
        /// <summary>
        /// Método que recibe el método TipoUsuarioPermisos_obtener_todo de TipoUsuariosPermisosDA
        /// </summary>
        public static DataTable TipoUsuarioPermisos_obtener_todo(TipoUsuarioE obj_usuariopermisos, string nombre_nodo)
        {
            try
            {
                //retorna el método TipoUsuarioPermisos_obtener_todo de TipoUsuariosPermisosDA
                return TipoUsuariosPermisosDA.TipoUsuarioPermisos_obtener_todo(obj_usuariopermisos, nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que recibe el método TipoUsuarioPermisos_Set de TipoUsuariosPermisosDA
        /// </summary>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool TipoUsuarioPermisos_Set(string sPermisosID, int TipoUsuarioID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método TipoUsuarioPermisos_Set es correcto, el estado de la operación es válido
                if (TipoUsuariosPermisosDA.TipoUsuarioPermisos_Set(sPermisosID, TipoUsuarioID, nombre_nodo))
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
    }
}
