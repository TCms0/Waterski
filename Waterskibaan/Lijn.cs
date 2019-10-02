using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Lijn
    {
        public int PositieOpDeKabel{ get; set; }
        public Sporter sp { get; set; }

        public void Addsporter(Sporter sport)
        {
            sp = sport;
        }
    }
}
