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
    public class EIM_DA
    {
        //private string cadenaConexion = "Data Source=localhost;Initial Catalog=PRS;Integrated Security=True";
        private static string CadenaConn = Properties.Settings.Default.Valor;

        #region End Item Models
        /// <summary>
        /// Método para mandar a llamar el procedimiento "EndItemModels"
        /// </summary>
        /// 


        public List<EIM_E> EndItemModels(string codigo)
        {
            List<EIM_E> EndItemModel = new List<EIM_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemModels", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_E Info = new EIM_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["anio"].ToString();
                            Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["eim21"].ToString();
                            Info.Numero = reader["Numero"].ToString();
                            Info.DESCRIP = reader["DESCRIP"].ToString();

                            EndItemModel.Add(Info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EndItemModel;
        }

        public List<EIM_E> EndItemModelsDesc(string codigo)
        {
            List<EIM_E> EndItemModel = new List<EIM_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemModelsDesc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_E Info = new EIM_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["anio"].ToString();
                            Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["eim21"].ToString();
                            Info.Numero = reader["Numero"].ToString();
                            Info.DESCRIP = reader["DESCRIP"].ToString();

                            EndItemModel.Add(Info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EndItemModel;
        }

        public List<EIM_E> EndItemModelsWI(string codigo)
        {
            List<EIM_E> EndItemModel = new List<EIM_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemModelsWI", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_E Info = new EIM_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["anio"].ToString();
                            Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["eim21"].ToString();
                            Info.Numero = reader["Numero"].ToString();
                            Info.DESCRIP = reader["DESCRIP"].ToString();

                            EndItemModel.Add(Info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EndItemModel;
        }


        public List<EIM_E> EndItemModelsWIP(string codigo)
        {
            List<EIM_E> EndItemModel = new List<EIM_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ObtenerEndItemModelsWIP", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@Codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_E Info = new EIM_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["anio"].ToString();
                            Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["eim21"].ToString();
                            Info.Numero = reader["Numero"].ToString();
                            Info.DESCRIP = reader["DESCRIP"].ToString();

                            EndItemModel.Add(Info);
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return EndItemModel;
        }
        #endregion

    }
}
