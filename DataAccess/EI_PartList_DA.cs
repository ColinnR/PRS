using DataAccess.DataHelper;
using Presentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class EI_PartList_DA
    {
        //private string cadenaConexion = "Data Source=localhost;Initial Catalog=PRS;Integrated Security=True";
        private static string CadenaConn = Properties.Settings.Default.Valor;

        #region End Item Part List
        /// <summary>
        /// Método para mandar a llamar el procedimiento "ObtenerEndItemPartList"
        /// </summary>
        /// 

        public List<EI_PartList_E> EndItemPartList(string codigo)
        {
            List<EI_PartList_E> EIPartList = new List<EI_PartList_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemPartList", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_E info = new EI_PartList_E();
                            info.Plus = reader["PLUS"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WIP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["ENTERO"].ToString();
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
        
        public List<EI_PartList_E> EndItemPartListDesc(string codigo)
        {
            List<EI_PartList_E> EIPartList = new List<EI_PartList_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemPartListDesc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_E info = new EI_PartList_E();
                            info.Plus = reader["PLUS"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WIP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["ENTERO"].ToString();
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

        public List<EI_PartList_E> EndItemPartListWI(string codigo)
        {
            List<EI_PartList_E> EIPartList = new List<EI_PartList_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemPartListWI", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_E info = new EI_PartList_E();
                            info.Plus = reader["PLUS"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WIP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["ENTERO"].ToString();
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

        public List<EI_PartList_E> EndItemPartListWIP(string codigo)
        {
            List<EI_PartList_E> EIPartList = new List<EI_PartList_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemPartListWIP", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EI_PartList_E info = new EI_PartList_E();
                            info.Plus = reader["PLUS"].ToString();
                            info.Numero = reader["NUMERO"].ToString();
                            info.Descrip = reader["DESCRIP"].ToString();
                            info.Adopt = reader["ADOPT"].ToString();
                            info.Cance = reader["CANCE"].ToString();
                            info.Wip = reader["WIP"].ToString();
                            info.Wi = reader["WI"].ToString();
                            info.Entero = reader["ENTERO"].ToString();
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
