using DataAccess;
using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class EI_PartList_COCOS_BL
    {
        public static List<EI_PartList_COCOS_E> EndItemPartList(string codigo)
        {
            try
            {
                EI_PartList_COCOS_DA dataAccess = new EI_PartList_COCOS_DA();

                return dataAccess.EndItemPartList(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EI_PartList_COCOS_E> EndItemPartListDesc(string codigo)
        {
            try
            {
                EI_PartList_COCOS_DA dataAccess = new EI_PartList_COCOS_DA();

                return dataAccess.EndItemPartListDesc(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EI_PartList_COCOS_E> EndItemPartListWI(string codigo)
        {
            try
            {
                EI_PartList_COCOS_DA dataAccess = new EI_PartList_COCOS_DA();

                return dataAccess.EndItemPartListWI(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<EI_PartList_COCOS_E> EndItemPartListWIP(string codigo)
        {
            try
            {
                EI_PartList_COCOS_DA dataAccess = new EI_PartList_COCOS_DA();

                return dataAccess.EndItemPartListWIP(codigo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
