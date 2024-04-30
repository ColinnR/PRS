using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BussinessLogic
{
    public class RespaldoBL
    {
        public static void RespaldoBD (string nombrebackup)
        {
            try
            {
                RespaldoDB_DA.RespaldoBD(nombrebackup);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RecuperacionBD (string file)
        {
            try
            {
                RespaldoDB_DA.RecuperacionBD(file);

            }
            catch (Exception ex) 
            { 
                throw ex;
            }
        }





    }
}
