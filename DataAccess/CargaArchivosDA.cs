using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CargaArchivosDA
    {
        //private static string cadenaConexion = "Data Source=localhost;Initial Catalog=PRS;Integrated Security=True";
        private static string CadenaConn = Properties.Settings.Default.Valor;
        /// <summary>
        /// Método para mandar a llamar el procedimiento "ImportarIPOModelos"
        /// </summary>
        /// 

        public static void IPO_Modelos(string ArchivoIPO)
        {

            try 
            {
                using (SqlConnection conexion = new SqlConnection(CadenaConn))
                {
                    using (SqlCommand comando = new SqlCommand("ImportarIPO", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetro para la ruta del archivo
                        comando.Parameters.Add(new SqlParameter("@RutaArchivo", SqlDbType.NVarChar, -1));
                        comando.Parameters["@RutaArchivo"].Value = ArchivoIPO;

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex) 
            {
                throw ex;            
            }
        }

        /// <summary>
        /// Método para mandar a llamar el procedimiento "ImportarPLUS"
        /// </summary>
        public static void PLUS(string ArchivoPLUS)
        {
            try 
            { 
                using (SqlConnection conexion = new SqlConnection(CadenaConn))
                {
                    using (SqlCommand comando = new SqlCommand("ImportarPLUS", conexion))
                    {
                        comando.CommandType= CommandType.StoredProcedure;

                        comando.Parameters.Add(new SqlParameter("@RutaArchivoPLUS", SqlDbType.NVarChar));
                        comando.Parameters["@RutaArchivoPLUS"].Value = ArchivoPLUS;
                        

                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
