using DataAccess;
using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class EIM_BL
    {
        public static List<EIM_E> EndItemModels(string codigo)
        {
            try
            {
                EIM_DA dataAccess = new EIM_DA();

                return dataAccess.EndItemModels(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EIM_E> EndItemModelsDesc(string codigo)
        {
            try
            {
                EIM_DA dataAccess = new EIM_DA();

                return dataAccess.EndItemModels(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EIM_E> EndItemModelsWI(string codigo)
        {
            try
            {
                EIM_DA dataAccess = new EIM_DA();

                return dataAccess.EndItemModelsWI(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EIM_E> EndItemModelsWIP(string codigo)
        {
            try
            {
                EIM_DA dataAccess = new EIM_DA();

                return dataAccess.EndItemModelsWIP(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
