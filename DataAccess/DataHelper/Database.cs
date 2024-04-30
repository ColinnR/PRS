using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DataHelper
{
    public class Database
    {
        public DbConnection Connection { get; private set; }
        private DbCommand currentCmd;

        public Database(DbConnection cnn)
        {
            Connection = cnn;
        }

        internal IDataReader ExecuteReader(DbCommand dbCommand)
        {
            try
            {

                dbCommand.Connection.Open();
                return dbCommand.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                dbCommand.Connection.Close();
                return null;
            }
        }

        internal int ExecuteNonQuery(DbCommand dbCommand)
        {
            try
            {
                dbCommand.Connection.Open();
                int res = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                return res;
            }
            catch (SqlException ex)
            {
                dbCommand.Connection.Close();
                return -1;
            }

        }
        //Consulta tipo select del procedure
        internal int ExecuteNonQueryForStoreProcedure(DbCommand dbCommand)
        {
            try
            {

                dbCommand.Connection.Open();
                DbDataReader rd = dbCommand.ExecuteReader();
                //
                if (rd != null)
                {
                    if (rd.Read())
                    {

                        return rd.GetInt32(0);
                    }
                }
                int res = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();
                return res;
            }
            catch (Exception ex)
            {
                dbCommand.Connection.Close();
                return -1;
            }

        }

        internal int ExecuteScalar(DbCommand dbCommand)
        {
            dbCommand.Connection.Open();
            int res = (int)dbCommand.ExecuteScalar();
            dbCommand.Connection.Close();
            return res;
        }

        internal DbCommand GetSqlStringCommand(string query)
        {
            currentCmd = Connection.CreateCommand();
            currentCmd.CommandType = CommandType.Text;
            currentCmd.CommandText = query;
            return currentCmd;
        }

        internal DbCommand GetStoredProcCommand(string storeProcedureName)
        {
            currentCmd = Connection.CreateCommand();
            currentCmd.CommandType = CommandType.StoredProcedure;
            currentCmd.CommandText = storeProcedureName;
            return currentCmd;
        }

        /// <summary>
        /// Con este metodo podemos aumentar el timeoud de la ejecucion de la consulta
        /// </summary>
        /// <param name="storeProcedureName"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        internal DbCommand GetStoredProcCommand(string storeProcedureName, int timeout)
        {
            currentCmd = Connection.CreateCommand();
            currentCmd.CommandTimeout = timeout;
            currentCmd.CommandType = CommandType.StoredProcedure;
            currentCmd.CommandText = storeProcedureName;
            return currentCmd;
        }

        internal void AddInParameter(DbCommand dbCommand, string parameterName, DbType dbType, object value)
        {
            //String Query = dbCommand.CommandText.ToUpper();

            //if (Query.Contains('@'+ parameterName.ToUpper()) == true)
            //{
            DbParameter newPar = dbCommand.CreateParameter();
            newPar.ParameterName = parameterName;
            newPar.DbType = dbType;
            if (value == null)
                value = System.DBNull.Value;
            newPar.Value = value;

            dbCommand.Parameters.Add(newPar);
            //}
        }

        internal void AddInParameterTypeDateTable(DbCommand dbCommand, string parameterName, SqlDbType dbTypeDataTable, object value)
        {
            SqlParameter parameter = new SqlParameter();
            //The parameter for the SP must be of SqlDbType.Structured 
            parameter.ParameterName = parameterName;
            parameter.SqlDbType = dbTypeDataTable;
            parameter.Value = value;
            dbCommand.Parameters.Add(parameter);
        }

        internal void AddOutputParameter(DbCommand dbCommand, string parameterName, DbType dbType)
        {
            object value = null;

            DbParameter newPar = dbCommand.CreateParameter();
            newPar.ParameterName = parameterName;
            newPar.Direction = ParameterDirection.Output;
            newPar.DbType = dbType;
            if (value == null)
                value = System.DBNull.Value;
            newPar.Value = value;

            dbCommand.Parameters.Add(newPar);

        }

    }
}
