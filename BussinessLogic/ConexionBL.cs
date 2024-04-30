using DataAccess;
using DataEntity;
using Microsoft.SqlServer.Management.Smo.RegSvrEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BussinessLogic
{
    public class ConexionBL
    {
        public static bool Conexion_agregar(ConexionE obj_conexion, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (ConexionDA.Agregar(obj_conexion, nombre_nodo))
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

        public static bool Conexion_eliminar(int ConexionID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (ConexionDA.Eliminar(ConexionID, nombre_nodo))
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

        public static bool Conexion_desactivar(int ConexionID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (ConexionDA.Desactivar(ConexionID, nombre_nodo))
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

        public static bool Conexion_activar(int CampoID, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (ConexionDA.Activar(CampoID, nombre_nodo))
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

        public static bool Conexion_update(ConexionE obj_conexion, string nombre_nodo)
        {
            bool operacion = false;
            try
            {
                if (ConexionDA.Campo_update(obj_conexion, nombre_nodo))
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


        //ACtivar,Agregar_Campos,

        public static bool Agregar_Campos(TramaCampoE entity, ConexionE entity_, string BD)
        {
            bool operacion = false;
            try
            {
                if(ConexionDA.Agregar_Campos(entity, entity_, BD))
                {
                    operacion = true;
                }
                else
                {
                    operacion = true;
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
            return operacion;
        }

        public static List<ConexionE> Conexion_obtenertodo(string nombre_nodo)
        {
            try
            {
                return ConexionDA.ObtenerTodo(nombre_nodo);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intentar obtener todos los campos", ex);
            }
        }
    }



}
