using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogic
{
    public class TramaBL
    {
        public static bool Trama_agregar(TramaE obj_trama, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaDA.Agregar(obj_trama, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    MessageBox.Show("Trama ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    operacion = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return operacion;
        }

        public static bool Trama_eliminar(int tramaID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaDA.Eliminar(tramaID, nombre_nodo))
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

        public static bool Trama_desactivar(int tramaID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaDA.Desactivar(tramaID, nombre_nodo))
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

        public static bool Trama_activar(int tramaID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaDA.Activar(tramaID, nombre_nodo))
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

        public static bool Trama_Modificar(TramaE obj_trama, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (TramaDA.Modificar(obj_trama, nombre_nodo))
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

        public static List<TramaE> Trama_obtenertodo(string nombre_nodo)
        {
            try
            {
                return TramaDA.ObtenerTodo(nombre_nodo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //public static bool Trama_obtenerid(int tramaID, string nombre_nodo)
        //{
        //    bool operacion = false;
        //    try
        //    {
        //        if (TramaDA.ObtenerID(tramaID, nombre_nodo))
        //        {
        //            operacion = true;
        //        }
        //        else
        //        {
        //            operacion = false;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return operacion;
        //}
    }
}
