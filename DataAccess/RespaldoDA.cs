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
    public class RespaldoDB_DA
    {
        private static string CadenaConn = Properties.Settings.Default.Valor;

        /// <summary>
        /// Método para construir el query del backup de la base de datos
        /// </summary>
        public static void RespaldoBD(string nombrebackup)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(CadenaConn);
                //variable comando_consulta que almacena cadena de conexion construida.
                string comando_consulta = "BACKUP DATABASE [PRS] TO  DISK = N'" + nombrebackup + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'PRS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                DbCommand command = cnn.CreateCommand();
                command.CommandText = comando_consulta;// llamado a la variable 
                command.CommandType = CommandType.Text;
                cnn.Open();
                DbDataReader reader = command.ExecuteReader();
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Método para construir el query del restore de la base de datos
        /// </summary>
        public static void RecuperacionBD(string file)
        {
            try
            {
                SqlConnection cnn = new SqlConnection(CadenaConn);
                //variable comando_consulta que almacena cadena de conexion construida.
                string comando_consulta = "USE [master] ALTER DATABASE PRS SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [PRS] FROM  DISK = N'" + file + "' WITH REPLACE; ";

                DbCommand command = cnn.CreateCommand();
                command.CommandText = comando_consulta;// llamado a la variable 
                command.CommandType = CommandType.Text;
                cnn.Open();
                DbDataReader reader = command.ExecuteReader();
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}   
