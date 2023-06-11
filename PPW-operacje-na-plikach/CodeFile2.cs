using PPW_operacje_na_plikach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PPW_operacje_na_plikach
{
    public class OP : Doc
    {
        public List<string> OPList { get; set; }

        public OP()
        {
            OPList = new List<string>();
        }


    }
}
