using DataAccess;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogic
{
    public class CampoBL
    {
        public static bool Campo_agregar(CampoE obj_campo, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (CampoDA.Agregar(obj_campo, nombre_nodo))
                {
                    operacion = true;
                }
                else
                {
                    MessageBox.Show("Campo ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    operacion = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return operacion;
        }

        public static bool Campo_eliminar(int CampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (CampoDA.Eliminar(CampoID, nombre_nodo))
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


        public static bool Campo_desactivar(int CampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (CampoDA.Desactivar(CampoID, nombre_nodo))
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

        public static bool Campo_activar(int CampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (CampoDA.Activar(CampoID, nombre_nodo))
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


        public static bool Campo_update(CampoE obj_campo, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (CampoDA.Campo_update(obj_campo, nombre_nodo))
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

        public static List<CampoE> Campo_obtenertodo(string nombre_nodo)
        {
            try
            {
                return CampoDA.ObtenerTodo(nombre_nodo);
            }
            catch (Exception ex)
            {
                
                throw new Exception ("Error al intentar obtener todos los campos",ex);
            }
        }
    }
}
