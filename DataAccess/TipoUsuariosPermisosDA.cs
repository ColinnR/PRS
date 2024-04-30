using DataAccess.DataHelper;
using System;
using DataEntity;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class TipoUsuariosPermisosDA
    {
        /// <summary>
        /// Método para obtener los permisos disponibles en el sistema
        /// </summary>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static DataTable TipoUsuarioPermisos_obtener_todo(TipoUsuarioE obj_usuariopermisos, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "TipoUsuarioPermisos_obtener_todo"
                DbCommand cmd = db.GetStoredProcCommand("TipoUsuarioPermisos_obtener_todo");
                cmd.CommandType = CommandType.StoredProcedure;
                db.AddInParameter(cmd, "TipoUsuarioID", DbType.Int32, obj_usuariopermisos.IDTipo);
                SqlDataAdapter da = new SqlDataAdapter((SqlCommand)cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método para agregar permisos a los tipos de usuario
        /// </summary>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool TipoUsuarioPermisos_Set(string sPermisosID, int TipoUsuarioID, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "TipoUsuarioPermisos_Set"
                DbCommand cmd = db.GetStoredProcCommand("TipoUsuarioPermisos_Set");
                db.AddInParameter(cmd, "PermisosID", DbType.String, sPermisosID);
                db.AddInParameter(cmd, "TipoUsuarioID", DbType.Int32, TipoUsuarioID);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
