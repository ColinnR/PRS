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
    public class ConexionDA
    {
        public static bool Agregar(ConexionE obj_conexion, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_insert");
            db.AddInParameter(cmd, "Nombre", DbType.String, obj_conexion.Nombre);
            db.AddInParameter(cmd, "TramaID", DbType.Int32, obj_conexion.TramaID);
            db.AddInParameter(cmd, "Estado", DbType.Boolean, obj_conexion.Estado);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Eliminar(int ConexionID, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_delete");
            db.AddInParameter(cmd, "ConexionID", DbType.Int32, ConexionID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Desactivar(int ConexionID, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_desactivar");
            db.AddInParameter(cmd, "ConexionID", DbType.Int32, ConexionID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Activar(int obj_conexion, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_activar");
            db.AddInParameter(cmd, "ConexionID", DbType.Int32, obj_conexion);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Campo_update(ConexionE obj_conexion, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_update");
            db.AddInParameter(cmd, "ConexionID", DbType.Int32, obj_conexion.ConexionID);
            db.AddInParameter(cmd, "nombre", DbType.String, obj_conexion.Nombre);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Agregar_Campos(TramaCampoE entity, ConexionE entity_, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_insert_campo");
            db.AddInParameter(cmd, "nombrecampo", DbType.String, entity.nombrecampo);
            db.AddInParameter(cmd, "nombreconexion", DbType.String, entity_.Nombre);
            return (db.ExecuteNonQuery(cmd) == -1);
        }

        public static List<ConexionE> ObtenerTodo(string nombre_nodo)
        {
            List<ConexionE> lista = new List<ConexionE>();
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Conexion_getall");
            using (IDataReader dataReader = db.ExecuteReader(cmd))
            {
                while (dataReader.Read())
                {
                    ConexionE obj = new ConexionE();
                    if (dataReader["ConexionID"] != DBNull.Value) { obj.ConexionID = int.Parse(dataReader["ConexionID"].ToString()); }
                    if (dataReader["nombre"] != DBNull.Value) { obj.Nombre = (string)dataReader["nombre"]; }
                    if (dataReader["estado"] != DBNull.Value) { obj.Estado = (bool)dataReader["estado"]; }
                    lista.Add(obj);
                }
            }
            return lista;
        }
    }
}
