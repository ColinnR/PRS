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
    public class CampoDA
    {
        public static bool Agregar (CampoE obj_campo, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Campo_insert");
            db.AddInParameter(cmd, "Nombre", DbType.String, obj_campo.Nombre);
            db.AddInParameter(cmd, "Estado", DbType.Boolean, obj_campo.Estado);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Eliminar(int CampoID, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Campo_delete");
            db.AddInParameter(cmd, "CampoID", DbType.Int32, CampoID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Desactivar(int CampoID, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Campo_desactivar");
            db.AddInParameter(cmd, "CampoID", DbType.Int32, CampoID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Activar(int obj_campo, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Campo_activar");
            db.AddInParameter(cmd, "CampoID", DbType.Int32, obj_campo);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Campo_update(CampoE obj_campo, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Campo_update");
            db.AddInParameter(cmd, "CampoID", DbType.Int32, obj_campo.CampoID);
            db.AddInParameter(cmd, "nombre", DbType.String, obj_campo.Nombre);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static List<CampoE> ObtenerTodo(string nombre_nodo)
        {
            List<CampoE> lista = new List<CampoE>();
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Campo_getall");
            using (IDataReader dataReader = db.ExecuteReader(cmd))
            {
                while (dataReader.Read())
                {
                    CampoE obj = new CampoE();
                    if (dataReader["CampoID"] != DBNull.Value) { obj.CampoID = int.Parse(dataReader["CampoID"].ToString()); }
                    if (dataReader["nombre"] != DBNull.Value) { obj.Nombre = (string)dataReader["nombre"]; }
                    if (dataReader["estado"] != DBNull.Value) { obj.Estado = (bool)dataReader["estado"]; }
                    lista.Add(obj);
                }
            }
            return lista;
        }
    }
}
