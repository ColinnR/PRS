using DataAccess;
using DataEntity;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class TramaCampoBL
    {
        public static bool TramaCampo_agregar(TramaCampoE obj_tramaCampo, string nombre_nodo)
        {
            bool operacion = false;

            try
            {
                //Si el método Usuario_agregar es correcto, el estado de la operación es válido
                if (TramaCampoDA.TramaCampoAgregar(obj_tramaCampo, nombre_nodo))
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

        public static bool TramaCampo_modificar(TramaCampoE obj_tramaCampo, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método Usuario_modificar es correcto, el estado de la operación es válido
                if (TramaCampoDA.TramaCampoModificar(obj_tramaCampo, nombre_nodo))
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


        public static bool TramaCampo_eliminar(int obj_tramaCampoid, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método Usuario_eliminar es correcto, el estado de la operación es válido
                if (TramaCampoDA.TramaCampoEliminar(obj_tramaCampoid, nombre_nodo))
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

        public static bool TramaCampo_eliminarporID(int obj_tramaCampoid, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método Usuario_eliminar es correcto, el estado de la operación es válido
                if (TramaCampoDA.TramaCampoEliminarporID(obj_tramaCampoid, nombre_nodo))
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
        public static List<TramaCampoE> TramaCampo_obtener_todo(string nombre_nodo)
        {
            try
            {
                //retorna el método Usuario_obtener_todo de UsuarioDA
                return TramaCampoDA.TramaCampoObtenerTodo(nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static List<TramaCampoE> TramaCampo_obtener_todo_ID(int Id, string nombre_nodo)
        {
            try
            {
                //retorna el método Usuario_obtener_todo de UsuarioDA
                return TramaCampoDA.TramaCampoObtenerID(Id, nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool TramaCampo_activar(int TramaCampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaCampoDA.TramaCampoActivar(TramaCampoID, nombre_nodo))
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

        public static bool TramaCampo_desactivar(int TramaCampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaCampoDA.TramaCampoDesactivar(TramaCampoID, nombre_nodo))
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

        public static bool TramaCampoActivarFiltro(int TramaCampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaCampoDA.TramaCampoActivarFiltro(TramaCampoID, nombre_nodo))
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

        public static bool TramaCampoDesactivarFiltro(int TramaCampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaCampoDA.TramaCampoDesactivarFiltro(TramaCampoID, nombre_nodo))
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
