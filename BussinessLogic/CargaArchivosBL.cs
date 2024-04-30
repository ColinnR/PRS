using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class CargaArchivosBL
    {
        public async Task IPO_Modelos(string ArchivoIPO)
        {
            try
            {
                CargaArchivosDA.IPO_Modelos(ArchivoIPO);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void PLUS(string ArchivoPLUS)
        {
			try
			{
				CargaArchivosDA.PLUS(ArchivoPLUS);
            }
			catch (Exception)
			{
				throw;
			}
        }
    }


}
