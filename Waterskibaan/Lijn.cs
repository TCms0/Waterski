using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    public class Lijn
    {
        public int PositieOpDeKabel{ get; set; }
        public Sporter Sp { get; set; }

        public void Addsporter(Sporter sport)
        {
            Sp = sport;
        }
    }
}
