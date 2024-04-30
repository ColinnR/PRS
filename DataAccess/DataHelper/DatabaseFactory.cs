using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess.DataHelper
{
    public class DatabaseFactory
    {
        internal static Database CreateDatabase(string nombre_nodo)
        {
            string defaulCnnString = nombre_nodo;
            string cnnsettingapp = _CargarConexiones(nombre_nodo, "System.Data.SqlClient");
            //ConnectionStringSettings cnnSettings = ConfigurationManager.ConnectionStrings[defaulCnnString];

            DbConnection cnn;
            //if (cnnSettings.ProviderName == "System.Data.SqlClient")
            if (cnnsettingapp != "")
                cnn = new System.Data.SqlClient.SqlConnection(cnnsettingapp);
            else
                throw new NotImplementedException(string.Format("Proveedor de datos no implementado."));

            return new Database(cnn);
        }
        static string rutaXml = "";


        internal static string _CargarConexiones(string seleccion, string motorbase)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"" + Properties.Settings.Default.Direccion_Archivo);
            //document.Load(@"D:\conexionesnxauto.config");
            XmlNodeList listaconexiones = document.SelectNodes("CONEXIONES/CONEXION");
            XmlNode conexion;
            if (listaconexiones.Count > 0)
            {
                string VALOR = "";
                for (int i = 0; i < listaconexiones.Count; i++)
                {
                    conexion = listaconexiones.Item(i);
                    XmlAttributeCollection attColl = conexion.Attributes;
                    string nombre = GetAttCollNodeValue(conexion, attColl, "name");
                    string conexionsql = GetAttCollNodeValue(conexion, attColl, "providerName");
                    if (nombre == seleccion && motorbase == conexionsql)
                    {

                        VALOR = conexion.SelectSingleNode("VALUE").InnerText;
                        VALOR = VALOR.Replace("\"", "");
                        break;
                    }
                }
                return VALOR;
            }
            else
            {
                return "";
                //MessageBoxTemporal.Show("PCSR: Confirm", "No hay unidades en el archivo", 5, true);
            }
        }


        internal static string GetAttCollNodeValue(XmlNode node, XmlAttributeCollection attColl, string attName)
        {
            string InnerText = String.Empty;
            foreach (XmlAttribute att in attColl)
            {
                if (att.Name == attName)
                {
                    if (node.Attributes[att.Name] != null)
                    {
                        InnerText = node.Attributes[att.Name].InnerText;
                    }
                    break;
                }
            }
            return InnerText;
        }
    }
}
