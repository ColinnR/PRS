using DataAccess.DataHelper;
using DataEntity;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class TramaCampoDA
    {
        public static bool TramaCampoAgregar(TramaCampoE obj_tramaCampo, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_insert");
            db.AddInParameter(cmd, "Estado", DbType.Boolean, obj_tramaCampo.Estado);
            db.AddInParameter(cmd, "filtro", DbType.Boolean, obj_tramaCampo.filtro);
            db.AddInParameter(cmd, "TramaID", DbType.Int32, obj_tramaCampo.TramaID);
            db.AddInParameter(cmd, "CampoID", DbType.Int32, obj_tramaCampo.CampoID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
        public static bool TramaCampoEliminar(int id, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_delete");
            db.AddInParameter(cmd, "TramaCampoID", DbType.Int32, id);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
        public static bool TramaCampoEliminarporID(int id, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("EliminarCamposPorTramaID");
            db.AddInParameter(cmd, "TramaID", DbType.Int32, id);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
        public static bool TramaCampoDesactivar(int id, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_desactivar");
            db.AddInParameter(cmd, "TramaCampoID", DbType.Int32, id);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
        public static bool TramaCampoActivar(int id, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_activar");
            db.AddInParameter(cmd, "TramaCampoID", DbType.Int32, id);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
        public static bool TramaCampoModificar(TramaCampoE obj_tramaCampo, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_update");
            db.AddInParameter(cmd, "TramaCampoID", DbType.Int32, obj_tramaCampo.TramaCampoID);
            db.AddInParameter(cmd, "filtro", DbType.Boolean, obj_tramaCampo.filtro);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool TramaCampoActivarFiltro(int id, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampoFiltro_activar");
            db.AddInParameter(cmd, "TramaCampoID", DbType.Int32, id);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }
        public static bool TramaCampoDesactivarFiltro(int id, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampoFiltro_desactivar");
            db.AddInParameter(cmd, "TramaCampoID", DbType.Int32, id);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static int TramaCampo_existe_secuencia(string nombreconexion, string filtro, string nombre_nodo)
        {
            int result = 0;
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_existe_secuencia");
            db.AddInParameter(cmd, "sqlfiltro", DbType.String, filtro);
            db.AddInParameter(cmd, "nombreconexion", DbType.String, nombreconexion);
            using (IDataReader dataReader = db.ExecuteReader(cmd))
            {
                if (dataReader.Read())
                {
                    if (dataReader["id"] != DBNull.Value) { result = int.Parse(dataReader["id"].ToString()); }
                }
            }
            return result;
        }

        public static List<TramaCampoE> TramaCampoObtenerTodo(string nombre_nodo)
        {
            List<TramaCampoE> lista = new List<TramaCampoE>();
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_getall");
            using (IDataReader dataReader = db.ExecuteReader(cmd))
            {
                while (dataReader.Read())
                {
                    TramaCampoE obj = new TramaCampoE();
                    if (dataReader["TramaCampoID"] != DBNull.Value) { obj.TramaCampoID = int.Parse(dataReader["TramaCampoID"].ToString()); }
                    if (dataReader["nombrecampo"] != DBNull.Value) { obj.nombrecampo = (string)dataReader["nombrecampo"].ToString(); }
                    if (dataReader["Estado"] != DBNull.Value) { obj.Estado = (bool)dataReader["Estado"]; }
                    if (dataReader["filtro"] != DBNull.Value) { obj.filtro = (bool)dataReader["filtro"]; }
                    if (dataReader["TramaID"] != DBNull.Value) { obj.TramaID = int.Parse(dataReader["TramaID"].ToString()); }
                    if (dataReader["CampoID"] != DBNull.Value) { obj.CampoID = int.Parse(dataReader["CampoID"].ToString()); }
                    lista.Add(obj);
                }
            }
            return lista;
        }

        public static List<TramaCampoE> TramaCampoObtenerID(int Id, string nombre_nodo)
        {
            List<TramaCampoE> lista = new List<TramaCampoE>();
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("TramaCampo_getall_tramaID");
            db.AddInParameter(cmd, "TramaID", DbType.Int32, Id);
            using (IDataReader dataReader = db.ExecuteReader(cmd))
            {
                while (dataReader.Read())
                {
                    TramaCampoE obj = new TramaCampoE();
                    if (dataReader["TramaCampoID"] != DBNull.Value) { obj.TramaCampoID = int.Parse(dataReader["TramaCampoID"].ToString()); }
                    if (dataReader["nombrecampo"] != DBNull.Value) { obj.nombrecampo = (string)dataReader["nombrecampo"].ToString(); }
                    if (dataReader["Estado"] != DBNull.Value) { obj.Estado = (bool)dataReader["Estado"]; }
                    if (dataReader["filtro"] != DBNull.Value) { obj.filtro = (bool)dataReader["filtro"]; }
                    if (dataReader["TramaID"] != DBNull.Value) { obj.TramaID = int.Parse(dataReader["TramaID"].ToString()); }
                    if (dataReader["CampoID"] != DBNull.Value) { obj.CampoID = int.Parse(dataReader["CampoID"].ToString()); }
                    lista.Add(obj);
                }
            }
            return lista;
        }
    }
}
