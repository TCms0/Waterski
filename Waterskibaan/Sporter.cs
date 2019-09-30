using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterskibaan
{
    class Sporter
    {
        public int _aantalPT;
        public int AantalRondenNogTeGaan { get;set;}
        public Zwemvest Zwemvest{ get; set;}
        public Skies skies { get; set; }
        public Color KledingKleur { get; set; }
        public List<IMoves> Moves { get; set; }

        public Sporter(List<IMoves> moves)
        {
            foreach (IMoves m in moves)
            {
                _aantalPT +=  m.moves();
            }
            Moves = moves;
        }


    }
}
