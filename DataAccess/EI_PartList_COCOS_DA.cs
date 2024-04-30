using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EI_PartList_COCOS_DA
    {
        private static string CadenaConn = Properties.Settings.Default.Cocos;

        #region End Item Part List
        /// <summary>
        /// Método para mandar a llamar el procedimiento "ObtenerEndItemPartList"
        /// </summary>
        /// 

        public List<EI_PartList_COCOS_E> EndItemPartList(string codigo)
        {
            List<EI_PartList_COCOS_E> EIPartList = new List<EI_PartList_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEndItemPartList", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_COCOS_E info = new EI_PartList_COCOS_E();
                            info.Plus = reader["MODEL"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["INT"].ToString();
                            info.Ext = reader["EXT"].ToString();
                            info.Tabla = reader["TABLA"].ToString();
                            info.Pzas = reader["PZAS"].ToString();
                            info.Diff = reader["DIFF"].ToString();

                            EIPartList.Add(info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EIPartList;
        }

        public List<EI_PartList_COCOS_E> EndItemPartListDesc(string codigo)
        {
            List<EI_PartList_COCOS_E> EIPartList = new List<EI_PartList_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEndItemPartListDesc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_COCOS_E info = new EI_PartList_COCOS_E();
                            info.Plus = reader["MODEL"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["INT"].ToString();
                            info.Ext = reader["EXT"].ToString();
                            info.Tabla = reader["TABLA"].ToString();
                            info.Pzas = reader["PZAS"].ToString();
                            info.Diff = reader["DIFF"].ToString();

                            EIPartList.Add(info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EIPartList;
        }

        public List<EI_PartList_COCOS_E> EndItemPartListWI(string codigo)
        {
            List<EI_PartList_COCOS_E> EIPartList = new List<EI_PartList_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEndItemPartListWI", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_COCOS_E info = new EI_PartList_COCOS_E();
                            info.Plus = reader["MODEL"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["INT"].ToString();
                            info.Ext = reader["EXT"].ToString();
                            info.Tabla = reader["TABLA"].ToString();
                            info.Pzas = reader["PZAS"].ToString();
                            info.Diff = reader["DIFF"].ToString();

                            EIPartList.Add(info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EIPartList;
        }

        public List<EI_PartList_COCOS_E> EndItemPartListWIP(string codigo)
        {
            List<EI_PartList_COCOS_E> EIPartList = new List<EI_PartList_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEndItemPartListWIP", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_COCOS_E info = new EI_PartList_COCOS_E();
                            info.Plus = reader["MODEL"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["INT"].ToString();
                            info.Ext = reader["EXT"].ToString();
                            info.Tabla = reader["TABLA"].ToString();
                            info.Pzas = reader["PZAS"].ToString();
                            info.Diff = reader["DIFF"].ToString();

                            EIPartList.Add(info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EIPartList;
        }
    }
    #endregion
}

