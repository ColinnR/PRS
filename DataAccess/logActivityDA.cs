using DataAccess.DataHelper;
using DataEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LogActivityDA
    {
        private static string CadenaConn = Properties.Settings.Default.Valor;
        /// <summary>
        /// Método para agregar registro de actividad al Log.
        /// </summary>
        /// <param name="obj_log">Recibe un objeto de tipo log</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool AgregarLogActivity(LogActivityE obj_log, string nombre_nodo)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Agregar_LogActivity"
                DbCommand cmd = db.GetStoredProcCommand("Agregar_LogActivity");
                db.AddInParameter(cmd, "Usuario", DbType.String, obj_log.Usuario);
                db.AddInParameter(cmd, "Fecha", DbType.DateTime, obj_log.Fecha);
                db.AddInParameter(cmd, "Hora", DbType.String, obj_log.Hora);
                db.AddInParameter(cmd, "Modulo", DbType.String, obj_log.Modulo);
                db.AddInParameter(cmd, "FuncionRealizada", DbType.String, obj_log.FuncionRealizada);
                db.AddInParameter(cmd, "MensajeException", DbType.String, obj_log.MensajeException);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Método para agregar registro de actividad al Log con excepción.
        /// </summary>
        /// <param name="obj_log">Recibe un objeto de tipo log</param>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>True si este se guardo correctamente o un false si hubo un error</returns>
        public static bool AgregarLogActivityEX(LogActivityE obj_log, string nombre_nodo, Exception exception)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "Agregar_LogActivity"
                DbCommand cmd = db.GetStoredProcCommand("Agregar_LogActivity");
                db.AddInParameter(cmd, "Usuario", DbType.String, obj_log.Usuario);
                db.AddInParameter(cmd, "Fecha", DbType.DateTime, obj_log.Fecha);
                db.AddInParameter(cmd, "Hora", DbType.String, obj_log.Hora);
                db.AddInParameter(cmd, "Modulo", DbType.String, obj_log.Modulo);
                db.AddInParameter(cmd, "FuncionRealizada", DbType.String, obj_log.FuncionRealizada);
                db.AddInParameter(cmd, "MensajeException", DbType.String, obj_log.MensajeException);
                return (db.ExecuteNonQuery(cmd) >= 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para obtener los registros de LOG
        /// </summary>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>Retorna una lista de objetos del log</returns>
        public static List<LogActivityE> ActivityLog_obtener_todo(string nombre_nodo)
        {
            try
            {
                List<LogActivityE> lista_objeto = new List<LogActivityE>();//creación de lista de LogActivity.
                Database db = DatabaseFactory.CreateDatabase(nombre_nodo);
                //llamado al procedimiento "ActivityLog_obtener_todo"
                DbCommand cmd = db.GetStoredProcCommand("ActivityLog_obtener_todo");
                using (IDataReader dataReader = db.ExecuteReader(cmd))
                {
                    //Sentencia while que recorre y recopila los datos almacenados.
                    while (dataReader.Read())
                    {
                        LogActivityE obj = new LogActivityE();
                        if (dataReader["IdLog"] != DBNull.Value) { obj.IdLog = int.Parse(dataReader["IdLog"].ToString()); }
                        if (dataReader["Usuario"] != DBNull.Value) { obj.Usuario = (string)dataReader["Usuario"]; }
                        if (dataReader["Fecha"] != DBNull.Value) { obj.Fecha = (DateTime)dataReader["Fecha"]; }
                        if (dataReader["Hora"] != DBNull.Value) { obj.Hora = (string)dataReader["Hora"]; }
                        if (dataReader["Modulo"] != DBNull.Value) { obj.Modulo = (string)dataReader["Modulo"]; }
                        if (dataReader["FuncionRealizada"] != DBNull.Value) { obj.FuncionRealizada = (string)dataReader["FuncionRealizada"]; }
                        if (dataReader["MensajeException"] != DBNull.Value) { obj.MensajeException = (string)dataReader["MensajeException"]; }
                        lista_objeto.Add(obj);//Agregan los datos recopilados a la lista_objeto.
                    }
                }
                return lista_objeto;//retorna valores almacenados en lista_objeto.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para obtener los registros de LOG
        /// </summary>
        /// <param name="nombre_nodo">Recibe el nodo de la conexion a conectar</param>
        /// <returns>Retorna una lista de objetos del log</returns>
        public static List<LogActivityE> ActivityLog_obtener_fechas(string fechaDe, string fechaHasta)
        {
            try
            {
                List<LogActivityE> lista = new List<LogActivityE>();//creación de lista de LogActivity.

                SqlConnection cnn = new SqlConnection(CadenaConn);
                cnn.Open();

                string str = "select IdLog, Usuario, Fecha, Hora, Modulo, FuncionRealizada, MensajeException from ActivityLog where Fecha between '" + fechaDe + "' and '" + fechaHasta + "';";

                DbCommand command = cnn.CreateCommand();
                command.CommandText = str;
                command.CommandType = CommandType.Text;
                DbDataReader reader = command.ExecuteReader();
                //Sentencia while que recorre y recopila los datos almacenados.
                while (reader.Read())
                {
                    LogActivityE obj = new LogActivityE();
                    if (reader["IdLog"] != DBNull.Value) { obj.IdLog = int.Parse(reader["IdLog"].ToString()); }
                    if (reader["Usuario"] != DBNull.Value) { obj.Usuario = (string)reader["Usuario"]; }
                    if (reader["Fecha"] != DBNull.Value) { obj.Fecha = (DateTime)reader["Fecha"]; }
                    if (reader["Hora"] != DBNull.Value) { obj.Hora = (string)reader["Hora"]; }
                    if (reader["Modulo"] != DBNull.Value) { obj.Modulo = (string)reader["Modulo"]; }
                    if (reader["FuncionRealizada"] != DBNull.Value) { obj.FuncionRealizada = (string)reader["FuncionRealizada"]; }
                    if (reader["MensajeException"] != DBNull.Value) { obj.MensajeException = (string)reader["MensajeException"]; }
                    lista.Add(obj);//Agregan los datos recopilados a la lista.
                }
                reader.Close();
                cnn.Close();
                return lista;//retorna valores almacenados en lista.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
