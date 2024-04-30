using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntity
{
    public class TramaCampoE
    {
        public int TramaCampoID {  get; set; }
        public string nombrecampo {  get; set; }
        public bool Estado { get; set; }
        public bool filtro { get; set; }
        public int TramaID { get; set; }
        public int CampoID { get; set; }
    }
}
