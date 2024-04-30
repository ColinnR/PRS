using DataAccess.DataHelper;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TipoUsuarioDA
    {
        /// <summary>
        /// Método para agregar TipoUsuario
        /// </summary>
        /// <param name="obj_tipousuario">Recibe un objeto de tipo Usuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool UsuarioTipo_agregar(TipoUsuarioE obj_tipousuario, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "UsuarioTipo_agregar"
                DbCommand cmd = db.GetStoredProcCommand("UsuarioTipo_agregar");
                db.AddInParameter(cmd, "TipoUsuario", DbType.String, obj_tipousuario.TipoUsuario);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para Modificar Usuario
        /// </summary>
        /// <param name="obj_tipousuario">Recibe un objeto de tipo TipoUsuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool UsuarioTipo_modificar(TipoUsuarioE obj_tipousuario, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "UsuarioTipo_modificar"
                DbCommand cmd = db.GetStoredProcCommand("UsuarioTipo_modificar");
                db.AddInParameter(cmd, "IDTipo", DbType.Int32, obj_tipousuario.IDTipo);
                db.AddInParameter(cmd, "TipoUsuario", DbType.String, obj_tipousuario.TipoUsuario);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para eliminar Usuario
        /// </summary>
        /// <param name="obj_idtipo">Recibe un el identificador unico del tipo de usuario</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool UsuarioTipo_eliminar(int obj_idtipo, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "UsuarioTipo_eliminar"
                DbCommand cmd = db.GetStoredProcCommand("UsuarioTipo_eliminar");
                db.AddInParameter(cmd, "IDTipo", DbType.Int32, obj_idtipo);
                int eliminados = db.ExecuteNonQueryForStoreProcedure(cmd);
                return (eliminados >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para obtener todos los usuario
        /// </summary>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>Retorna una lista de objetos de usuario</returns>
        public static List<TipoUsuarioE> UsuarioTipo_obtener_todo(string nombre_nodo)
        {
            try
            {
                List<TipoUsuarioE> lista_objeto = new List<TipoUsuarioE>();//creación de lista de tipo de usuarios
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "UsuarioTipo_obtener_todo"
                DbCommand cmd = db.GetStoredProcCommand("UsuarioTipo_obtener_todo");
                using (IDataReader dataReader = db.ExecuteReader(cmd))
                {
                    //Sentencia while que recorre y recopila los datos almacenados
                    while (dataReader.Read())
                    {
                        TipoUsuarioE obj = new TipoUsuarioE();
                        if (dataReader["IDTipo"] != DBNull.Value) { obj.IDTipo = int.Parse(dataReader["IDTipo"].ToString()); }
                        if (dataReader["TipoUsuario"] != DBNull.Value) { obj.TipoUsuario = (string)dataReader["TipoUsuario"]; }
                        lista_objeto.Add(obj);//Agregan los datos recopilados a la lista_objeto
                    }
                }
                return lista_objeto;//retorna valores almacenados en lista_objeto
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
