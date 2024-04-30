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
    public class EIM_COCOS_DA
    {
        //private string cadenaConexion = "Data Source=localhost;Initial Catalog=PRS;Integrated Security=True";
        private static string CadenaConn = Properties.Settings.Default.Cocos;

        #region End Item Models
        /// <summary>
        /// Método para mandar a llamar el procedimiento "EndItemModels"
        /// </summary>
        /// 


        public List<EIM_COCOS_E> EndItemModels(string codigo)
        {
            List<EIM_COCOS_E> EndItemModel = new List<EIM_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEIMporNumParte", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@codigo", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_COCOS_E Info = new EIM_COCOS_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["year"].ToString();
                            //Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["EIM21"].ToString();
                            Info.Numero = reader["Número"].ToString();
                            Info.DESCRIP = reader["Descripción"].ToString();

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

        public List<EIM_COCOS_E> EndItemModelsDesc(string codigo)
        {
            List<EIM_COCOS_E> EndItemModel = new List<EIM_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEIMporDescripcion", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@descripcion", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_COCOS_E Info = new EIM_COCOS_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["year"].ToString();
                            //Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["EIM21"].ToString();
                            Info.Numero = reader["Número"].ToString();
                            Info.DESCRIP = reader["Descripción"].ToString();

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

        public List<EIM_COCOS_E> EndItemModelsWI(string codigo)
        {
            List<EIM_COCOS_E> EndItemModel = new List<EIM_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEIMporWI", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@descripcion", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_COCOS_E Info = new EIM_COCOS_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["year"].ToString();
                            //Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["EIM21"].ToString();
                            Info.Numero = reader["Número"].ToString();
                            Info.DESCRIP = reader["Descripción"].ToString();

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


        public List<EIM_COCOS_E> EndItemModelsWIP(string codigo)
        {
            List<EIM_COCOS_E> EndItemModel = new List<EIM_COCOS_E>();
            try
            {
                using (SqlConnection connection = new SqlConnection(CadenaConn))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("ConsultarEIMporWIP", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandTimeout = 120;

                    command.Parameters.AddWithValue("@descripcion", codigo);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EIM_COCOS_E Info = new EIM_COCOS_E();
                            Info.Planta = reader["planta"].ToString();
                            Info.Modelo = reader["modelo"].ToString();
                            Info.Usage = reader["USAGE"].ToString();
                            Info.EImodel = reader["eimodel"].ToString();
                            Info.Dest = reader["Dest"].ToString();
                            Info.Anio = reader["year"].ToString();
                            //Info.Applie = reader["APPLIE"].ToString();
                            Info.Model = reader["model"].ToString();
                            Info.EIM21 = reader["EIM21"].ToString();
                            Info.Numero = reader["Número"].ToString();
                            Info.DESCRIP = reader["Descripción"].ToString();

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
