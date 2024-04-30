using DataAccess.DataHelper;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace DataAccess
{
    public class TramaDA
    {
        public static bool Agregar(TramaE obj_trama, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Trama_insert");
            db.AddInParameter(cmd, "Nombre", DbType.String, obj_trama.Nombre);
            db.AddInParameter(cmd, "Estado", DbType.Boolean, obj_trama.Estado);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Eliminar(int tramaID, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Trama_delete");
            db.AddInParameter(cmd, "TramaID", DbType.Int32, tramaID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Desactivar(int tramaID, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Trama_desactivar");
            db.AddInParameter(cmd, "TramaID", DbType.Int32, tramaID);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Activar(int obj_trama, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Trama_activar");
            db.AddInParameter(cmd, "TramaID", DbType.Int32, obj_trama);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static bool Modificar(TramaE obj_trama, string nombre_nodo)
        {
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Trama_update");
            db.AddInParameter(cmd, "TramaID", DbType.Int32, obj_trama.TramaID);
            db.AddInParameter(cmd, "nombre", DbType.String, obj_trama.Nombre);
            return (db.ExecuteNonQuery(cmd) >= 1);
        }

        public static List<TramaE> ObtenerTodo(string nombre_nodo)
        {
            List<TramaE> lista = new List<TramaE>();
            Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
            DbCommand cmd = db.GetStoredProcCommand("Trama_getall");
            using (IDataReader dataReader = db.ExecuteReader(cmd))
            {
                while (dataReader.Read())
                {
                    TramaE obj = new TramaE();
                    if (dataReader["TramaID"] != DBNull.Value) { obj.TramaID = int.Parse(dataReader["TramaID"].ToString()); }
                    if (dataReader["nombre"] != DBNull.Value) { obj.Nombre = (string)dataReader["nombre"]; }
                    if (dataReader["estado"] != DBNull.Value) { obj.Estado = (bool)dataReader["estado"]; }
                    lista.Add(obj);
                }
            }
            return lista;
        }
    }
}
