using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class LogActivityBL
    {
        /// <summary>
        /// Método que recibe el método AgregarLogActivity de LogActivityDA
        /// </summary>
        /// <param name="obj_log">Recibe un objeto de log activity</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool AgregarLogActivity(LogActivityE obj_log, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                //Si el método AgregarLogActivity es correcto, el estado de la operación es válido
                if (LogActivityDA.AgregarLogActivity(obj_log, nombre_nodo))
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
        /// Método que recibe el método AgregarLogActivityEX de LogActivityDA
        /// </summary>
        /// <param name="obj_log">Recibe un objeto de log activity</param>
        /// <returns>Retorna el estado de la operación</returns>
        public static bool AgregarLogActivityEX(LogActivityE obj_log, string nombre_nodo, Exception exception)
        {
            bool operacion = false;
            try
            {
                //Si el método AgregarLogActivityEX es correcto, el estado de la operación es válido
                if (LogActivityDA.AgregarLogActivityEX(obj_log, nombre_nodo, exception))
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
        /// Método que recibe el método ActivityLog_obtener_todo de LogActivityDA
        /// </summary>
        public static List<LogActivityE> ActivityLog_obtener_todo(string nombre_nodo)
        {
            try
            {
                //retorna el método ActivityLog_obtener_todo de LogActivityDA
                return LogActivityDA.ActivityLog_obtener_todo(nombre_nodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método que recibe el método ActivityLog_obtener_fechas de LogActivityDA
        /// </summary>
        public static List<LogActivityE> ActivityLog_obtener_fechas(string fechaDe, string fechaHasta)
        {
            try
            {
                //retorna el método ActivityLog_obtener_fechas de LogActivityDA
                return LogActivityDA.ActivityLog_obtener_fechas(fechaDe, fechaHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
